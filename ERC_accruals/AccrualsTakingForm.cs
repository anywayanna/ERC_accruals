using System;

using System.Windows.Forms;

namespace ERC_accruals
{
    public partial class AccrualsTakingForm : Form
    {
        private Calculate _calculate;
        private Volumes _volumes;

        public AccrualsTakingForm(Calculate calculate, Volumes volumes)
        {
            _calculate = calculate;
            _volumes = volumes;
            InitializeComponent();

            CleanBox(CVS);
            CleanBox(HVS);
            CleanBox(EEDay);
            CleanBox(EENight);
           
            InitialForm initial = (InitialForm)Application.OpenForms["InitialForm"]; //для доступа к открытой форме

            //для проверки приборов учета
            Conditions(initial.checkBoxCVS, CVS);
            Conditions(initial.checkBoxHVS, HVS);
            Conditions(initial.checkBoxEE, EEDay);
            Conditions(initial.checkBoxEE, EENight);

            previousCVS.Text = _volumes.VolumeCVSPrevious.ToString();
            previousHVS.Text = _volumes.VolumeHVSPrevious.ToString();
            previousEEDay.Text = _volumes.VolumeEEDayPrevious.ToString();
            previousEENight.Text = _volumes.VolumeEENightPrevious.ToString();
        }

        private void Conditions(CheckBox apparatus, TextBox values)
        {
            if (!apparatus.Checked)
            {
                values.Enabled = false;
                values.Text = "0";
            }
            else
                values.Enabled = true;
        }
        private void CleanBox(TextBox textBox)
        {
            textBox.Text = "";
        }
        private void ConfirmSecondForm_Click(object sender, EventArgs e)
        {
            if (!(CVS.Text == "" || HVS.Text == "" || EEDay.Text == "" || EENight.Text == ""))
            {
                _volumes.Save(CVS.Text, HVS.Text, EEDay.Text, EENight.Text);
                var sunnaryForm = new SumForm(_calculate, _volumes);
                sunnaryForm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Заполните поля показателей!");
        }
        
    }
}

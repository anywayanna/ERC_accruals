using System;
using System.Windows.Forms;

namespace ERC_accruals
{
    public partial class AccrualsTakingForm : Form
    {
        private Calculate _calculate;
        private Volumes _volumes;
        private InitialForm _initialForm;
        
        public AccrualsTakingForm(Calculate calculate, Volumes volumes)
        {
            _initialForm = (InitialForm)Application.OpenForms["InitialForm"]; ;
            _calculate = calculate;
            _volumes = volumes;
            InitializeComponent();

            CVS.Clear();
            HVS.Clear();
            EEDay.Clear();
            EENight.Clear();

            previousCVS.Text = _volumes.VolumeCVSPrevious.ToString();
            previousHVS.Text = _volumes.VolumeHVSPrevious.ToString();
            previousEEDay.Text = _volumes.VolumeEEDayPrevious.ToString();
            previousEENight.Text = _volumes.VolumeEENightPrevious.ToString();

            //для проверки приборов учета
            OnAndOffInput(_initialForm.checkBoxCVS, CVS);
            OnAndOffInput(_initialForm.checkBoxHVS, HVS);
            OnAndOffInput(_initialForm.checkBoxEE, EEDay);
            OnAndOffInput(_initialForm.checkBoxEE, EENight);
        }

        private bool CheckAccruals(string current, string previous)
        {
            return double.Parse(current) > double.Parse(previous);
        }

        private void OnAndOffInput(CheckBox apparatus, TextBox values)
        {
            if (!apparatus.Checked)
            {
                values.Enabled = false;
                values.Text = "0";
            }
            else
                values.Enabled = true;
        }
        
        private void ConfirmSecondForm_Click(object sender, EventArgs e)
        {
            if (_initialForm.checkBoxCVS.Checked)
            
                if (!CheckAccruals(CVS.Text, previousCVS.Text))
                {
                    MessageBox.Show("Текущие показатели должны быть больше прошлого месяца!");
                    return;
                }
            if (_initialForm.checkBoxHVS.Checked)

                if (!CheckAccruals(HVS.Text, previousHVS.Text))
                {
                    MessageBox.Show("Текущие показатели должны быть больше прошлого месяца!");
                    return;
                }
            if (_initialForm.checkBoxEE.Checked)

                if (!CheckAccruals(EEDay.Text, previousEEDay.Text) || !CheckAccruals(EENight.Text, previousEENight.Text))
                {
                    MessageBox.Show("Текущие показатели должны быть больше прошлого месяца!");
                    return;
                }
            if (CVS.Text == "" || HVS.Text == "" || EEDay.Text == "" || EENight.Text == "")
                MessageBox.Show("Заполните поля показателей!");
            else
            {
                _volumes.Save(CVS.Text, HVS.Text, EEDay.Text, EENight.Text);
                var sunnaryForm = new SumForm(_calculate, _volumes, this);
                sunnaryForm.Show();
                this.Hide();
            }
        }

        private void CVS_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(CVS, e);
        }
        private void HVS_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(HVS, e);
        }
        private void EEDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(EEDay, e);
        }
        private void EENight_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(EENight, e);
        }

        private void CheckInput(TextBox textBox, KeyPressEventArgs e)
        {
            char KeyAsciiNumber = e.KeyChar;
            if (!(Char.IsDigit(KeyAsciiNumber)))
            {
                e.Handled = true;
                var selectionStart = textBox.SelectionStart;
                var textLenght = textBox.Text.Length;
                switch ((int)KeyAsciiNumber)
                {
                    case 08:
                        if (textBox.SelectionLength > 0)
                        {
                            textBox.Text = textBox.Text.Substring(0, selectionStart) + textBox.Text.Substring(selectionStart + textBox.SelectionLength);
                            textBox.SelectionStart = selectionStart;
                        }
                        else if (selectionStart > 0)
                        {
                            textBox.Text = textBox.Text.Substring(0, selectionStart - 1) + textBox.Text.Substring(selectionStart);
                            textBox.SelectionStart = selectionStart - 1;
                        }

                        break;
                    case 46:
                        if (textLenght == 0 || (textBox.Text.IndexOf(',') > -1))
                        {
                            e.Handled = true;
                            break;
                        }
                        textBox.Text += ",";
                        textBox.SelectionStart = selectionStart + 1;
                        break;
                }
            }
        }
    }
}

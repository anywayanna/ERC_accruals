using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            InitialForm initial = (InitialForm)Application.OpenForms["InitialForm"]; //для доступа к открытой форме

            //для проверки приборов учета
            Conditions(initial.checkBoxCVS, CVS);
            Conditions(initial.checkBoxHVS, HVS);
            Conditions(initial.checkBoxEE, EEDay);
            Conditions(initial.checkBoxEE, EENight);
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

        private void ConfirmSecondForm_Click(object sender, EventArgs e)
        {
            _volumes.Save(CVS.Text, HVS.Text, EEDay.Text, EENight.Text);
            var sunnaryForm = new SumForm(_calculate);
            sunnaryForm.Show();
            this.Hide();
        }
        

       
    }
}

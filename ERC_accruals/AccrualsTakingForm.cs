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
        public bool EECondition = false;
        
        public AccrualsTakingForm()
        {
            InitializeComponent();
            InitialForm initial = (InitialForm)Application.OpenForms["InitialForm"]; //для доступа к открытой форме

            //для проверки приборов учета
            Conditions(initial.checkBoxCVS, CVS);
            Conditions(initial.checkBoxHVS, HVS);
            Conditions(initial.checkBoxEE, EEDay);
            Conditions(initial.checkBoxEE, EENight);

            //запихала в метод ниже:
            //if (initial.checkBoxCVS.Checked)
            //    CVS.Enabled = true;
            //if (initial.checkBoxHVS.Checked)
            //    HVS.Enabled = true;
            //if (initial.checkBoxEE.Checked)
            //{
            //    EEDay.Enabled = true;
            //    EENight.Enabled = true;
            //    EECondition = true;
            //}


        }
        public void Conditions(CheckBox apparatus, TextBox values)
        {
            if (!apparatus.Checked)
            {
                values.Enabled = false;
               // values.Text = "Без прибора учета передача показаний невозможна!";
            }
            else
                values.Enabled = true;
        }

        private void ConfirmSecondForm_Click(object sender, EventArgs e)
        {
            var sunnaryForm = new SumForm(CVS.Text, HVS.Text, EEDay.Text, EENight.Text, EECondition);
            sunnaryForm.Show();
            this.Hide();
        }
        

       
    }
}

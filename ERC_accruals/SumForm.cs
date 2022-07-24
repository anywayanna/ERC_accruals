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


    public partial class SumForm : Form
    {
        public SumForm(string CVSenter, string HVSenter, string EEDayenter, string EENightenter, bool EECondition)
        {
            InitializeComponent();
            
            CVSResult.Text = Math.Round(Calculate.GetCVSSum(CVSenter),2).ToString();
            HVSResult.Text = Math.Round(Calculate.GetHVSSum(HVSenter),2).ToString();
            double EESum;

            if (EECondition)
            {
                EEDayResult.Text = Math.Round(Calculate.GetEEDaySum(EEDayenter),2).ToString();
                EENightResult.Text = Math.Round(Calculate.GetEENightSum(EENightenter),2).ToString();
                EESum = Calculate.GetEENightSum(EENightenter) + Calculate.GetEEDaySum(EEDayenter);
            }
            else
            {
                EEResult.Text = Math.Round(Calculate.GetEESum(),2).ToString();
                EEResult.Visible = true;
                EELable.Visible = true;
                EESum = Calculate.GetEESum();
            }


            CommonResult.Text = Math.Round(Calculate.GetERCSum(EESum),2).ToString();

        }

        private void TurnAgainButton_Click(object sender, EventArgs e)
        {
           
            AccrualsTakingForm accrualsTaking = (AccrualsTakingForm)Application.OpenForms["AccrualsTakingForm"]; //для доступа к открытой форме
            accrualsTaking.Show();
        }
    }
}

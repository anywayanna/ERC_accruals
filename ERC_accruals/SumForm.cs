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
        private Calculate _calculate;
        public SumForm(Calculate calculate)
        {
            _calculate = calculate;
            InitializeComponent();
            
            CVSResult.Text = Math.Round(_calculate.GetCVSSum(),2).ToString();

            HVSResult.Text = Math.Round(_calculate.GetHVSSum(),2).ToString();
            HVSResultEnergy.Text = Math.Round(_calculate.GetHVSEnergySum(), 2).ToString();

            EEResult.Text = Math.Round(_calculate.GetEESum(), 2).ToString();

            CommonResult.Text = Math.Round(calculate.GetERCSum(),2).ToString();
            
        }

        private void TurnAgainButton_Click(object sender, EventArgs e)
        {
            AccrualsTakingForm accrualsTaking = (AccrualsTakingForm)Application.OpenForms["AccrualsTakingForm"]; //для доступа к открытой форме
            accrualsTaking.Update();
            accrualsTaking.Show();
        }
    }
}

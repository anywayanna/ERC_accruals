using System;
using System.Windows.Forms;

namespace ERC_accruals
{
    public partial class SumForm : Form
    {
        private Calculate _calculate;
        private Volumes _volumes;
        private AccrualsTakingForm _accrualsTaking;
        public SumForm(Calculate calculate, Volumes volumes, AccrualsTakingForm accrualsTaking)
        {
            _accrualsTaking = accrualsTaking;
            _calculate = calculate;
            _volumes = volumes;
            InitializeComponent();
            
            CVSResult.Text = Math.Round(_calculate.GetCVSSum(),2).ToString();

            HVSResult.Text = Math.Round(_calculate.GetHVSSum(),2).ToString();
            HVSResultEnergy.Text = Math.Round(_calculate.GetHVSEnergySum(), 2).ToString();

            EEResult.Text = Math.Round(_calculate.GetEESum(), 2).ToString();

            CommonResult.Text = Math.Round(calculate.GetERCSum(),2).ToString();
        }

        private void TurnAgainButton_Click(object sender, EventArgs e)
        {
            _volumes.Save();
            _accrualsTaking = new AccrualsTakingForm(_calculate, _volumes); //запуск новой формы
            _accrualsTaking.Show();
            this.Hide();

        }

        private void ChangeAccurals_Click(object sender, EventArgs e)
        {
            _accrualsTaking.Show();
            _volumes.Reset();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

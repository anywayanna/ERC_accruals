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
    
    public partial class InitialForm : Form
    {
        private Calculate _calculate;
        private Volumes _volumes;
        private Ratebase _ratebase;

        public InitialForm()
        {
            
            _calculate = new Calculate();
            _volumes = new Volumes();
            _ratebase = new Ratebase();
            _calculate.Init(_volumes, _ratebase);
            InitializeComponent();
        }

        private void ConfirmFirstForm_Click(object sender, EventArgs e)
        {
            _calculate.SetPeopleNumber((int)peopleCount.Value);
            
            var accuralsForm = new AccrualsTakingForm(_calculate, _volumes);
            accuralsForm.Show();
            this.Hide();
        }

    
        
    }
}

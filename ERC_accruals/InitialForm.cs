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
        public int nPeople;
        public InitialForm()
        {
            InitializeComponent();
            
        }

        private void ConfirmFirstForm_Click(object sender, EventArgs e)
        {
            Calculate.nPeople = (int)peopleCount.Value;
            var accuralsForm = new AccrualsTakingForm();
            accuralsForm.Show();
            this.Hide();
        }

    
        
    }
}

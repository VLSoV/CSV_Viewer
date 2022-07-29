using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_IBA_AG
{
    public partial class FormProgress : Form
    {
        public event Action _dCancel;
        public FormProgress(Action action)
        {
            InitializeComponent();
            progressBar1.Maximum = 100;
            _dCancel += action;
        }

        public void SetDescription(string stringDescription)
        {
            description.Text = stringDescription;
        }

        public void SetPercents(int number)
        {
            percents.Text = number.ToString() + "%";
            progressBar1.Value = number;
        }

        public void Cancel()
        {
            description.Text = "Cancelling";
            button_cancel.Enabled = false; 
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Cancel();
            _dCancel();
        }

    }
}

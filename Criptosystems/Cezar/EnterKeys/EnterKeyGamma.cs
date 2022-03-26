using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cezar.EnterKeys
{
    public partial class EnterKeyGamma : Form
    {
        public EnterKeyGamma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
        }
        public bool ReturnData()
        {
            return comboBox1.SelectedIndex == 0 ? false : true;
        }
    }
}

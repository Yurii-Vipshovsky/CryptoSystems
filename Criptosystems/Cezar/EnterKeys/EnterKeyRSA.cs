using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cezar.EnterKeys
{
    public partial class EnterKeyRSA : Form
    {
        public EnterKeyRSA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(checkBox1.Checked == false && numericUpDown1.Value % 2 == 0)
            //{
            //    MessageBox.Show("Парне число не можна вибрати відкритим ключем");
            //    return;
            //}
            this.DialogResult = DialogResult.OK;
        }
        public int ReturnData()
        {
            return (int)numericUpDown1.Value;
        }
    }
}

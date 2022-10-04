using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Cezar.CriptoSystems;

namespace Cezar.EnterKeys
{
    public partial class EnterKeyUitstone : Form
    {
        public EnterKeyUitstone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        public UitstoneInitData ReturnData()
        {
            return new UitstoneInitData()
            {
                firstWord = FirstWordTextBox.Text,
                secondWord = SecondWordTextBox.Text,
                isEng = comboBox1.SelectedIndex == 0 ? false : true
            };
        }

        
    }
}

using Cezar.CriptoSystems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cezar.EnterKeys
{
    public partial class EnterKeyCezar : Form
    {
        public EnterKeyCezar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        public CezarInitData ReturnData()
        {
            return new CezarInitData() { key = (int)numericUpDown1.Value,
                                         isEng = comboBox1.SelectedIndex==0 ? false : true, 
                                         isText = checkBox1.Checked};
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            { 
                case 0:
                    numericUpDown1.Maximum = ICriptoSystem.UKR_ALF_COUNT-1;
                    break;
                case 1:
                    numericUpDown1.Maximum = ICriptoSystem.ENG_ALF_COUNT-1;
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                comboBox1.Enabled = false;
                numericUpDown1.Maximum = ICriptoSystem.MAX_BYTE_SIZE - 1;
            }
            else
            {
                comboBox1.Enabled = true;
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        numericUpDown1.Maximum = ICriptoSystem.UKR_ALF_COUNT - 1;
                        break;
                    case 1:
                        numericUpDown1.Maximum = ICriptoSystem.ENG_ALF_COUNT - 1;
                        break;
                }
            }
        }
    }
}

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
    public partial class EnterKeyVigener : Form
    {
        public EnterKeyVigener()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        public VigenerInitData ReturnData()
        {
            string MottoText = textBox1.Text;
            for (int i = 0; i < MottoText.Length; ++i)
            {
                if (!Char.IsLetter(MottoText[i])) { MottoText.Remove(i); }
            }
            int[] Motto = new int[MottoText.Length];
            for (int i = 0; i < MottoText.Length; ++i)
            {
                try
                {
                    Motto[i] = (int)Enum.Parse(typeof(UkrainianABC), MottoText[i].ToString().ToLower());
                }
                catch
                {
                    Motto[i] = (int)Enum.Parse(typeof(EnglishABC), MottoText[i].ToString().ToLower());
                }
            }
            return new VigenerInitData()
            {
                isEng = comboBox1.SelectedIndex == 0 ? false : true,
                key = Motto,
            };
        }
    }
}

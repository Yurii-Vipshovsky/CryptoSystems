using Cezar.CriptoSystems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cezar
{
    public partial class CriptoNotepad : Form
    {
        private Gamma gamma;
        public CriptoNotepad(Gamma g)
        {
            InitializeComponent();
            gamma = g;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gammaTextBox.Text = "";
            Random generator = new Random();
            while (gamma.gamma.Count < textTextBox.Text.Length)
            {
                if (gamma.isEng)
                {
                    gamma.gamma.Add(generator.Next(0, ICriptoSystem.ENG_ALF_COUNT));
                }
                else
                {
                    gamma.gamma.Add(generator.Next(0, ICriptoSystem.UKR_ALF_COUNT));
                }
            }
            foreach(int elem in gamma.gamma)
            {
                if (gamma.isEng)
                {
                    gammaTextBox.Text += (EnglishABC)elem;
                }
                else
                {
                    gammaTextBox.Text += (UkrainianABC)elem;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = gammaTextBox.Text.Replace(' ', '_');
            gamma.gamma.Clear();
            if(gamma.isEng)
            {
                try
                {
                    for(int j = 0; j < text.Length; ++j)
                    {
                        gamma.gamma.Add((int)Enum.Parse(typeof(EnglishABC), text[j].ToString().ToLower()));
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid Gamma");
                    return;
                }
            }
            else
            {
                try
                {
                    for (int j = 0; j < text.Length; ++j)
                    {
                        gamma.gamma.Add((int)Enum.Parse(typeof(UkrainianABC), text[j].ToString().ToLower()));
                    }
                }
                catch
                {
                    MessageBox.Show("Некоректна Гамма!");
                    return;
                }
            }
            int i = 0;
            while (gamma.gamma.Count < textTextBox.Text.Length)
            {
                gamma.gamma.Add(gamma.gamma[i]);
                i++;
            }
            resultTextBox.Text = gamma.encrypt(textTextBox.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = gammaTextBox.Text.Replace(' ', '_');
            gamma.gamma.Clear();
            if (gamma.isEng)
            {
                try
                {
                    for (int j = 0; j < text.Length; ++j)
                    {
                        gamma.gamma.Add((int)Enum.Parse(typeof(EnglishABC), text[j].ToString().ToLower()));
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid Gamma");
                    return;
                }
            }
            else
            {
                try
                {
                    for (int j = 0; j < text.Length; ++j)
                    {
                        gamma.gamma.Add((int)Enum.Parse(typeof(UkrainianABC), text[j].ToString().ToLower()));
                    }
                }
                catch
                {
                    MessageBox.Show("Некоректна Гамма!");
                    return;
                }
            }
            int i = 0;
            while (gamma.gamma.Count < textTextBox.Text.Length)
            {
                gamma.gamma.Add(gamma.gamma[i]);
                i++;
            }
            resultTextBox.Text = gamma.decrypt(textTextBox.Text);
        }

        private void textTextBox_TextChanged(object sender, EventArgs e)
        {
            textTextBox.Text = textTextBox.Text.ToLower();
        }

        private void gammaTextBox_TextChanged(object sender, EventArgs e)
        {
            gammaTextBox.Text = gammaTextBox.Text.ToLower();
        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text.ToLower();
        }
    }
}

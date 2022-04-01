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
            gamma.gamma.Clear();
            Random generator = new Random();
            while (gamma.gamma.Count < textTextBox.Text.Length)
            {
                gamma.gamma.Add(generator.Next(0, ICriptoSystem.MAX_BYTE_SIZE));
            }
            foreach(int elem in gamma.gamma)
            {
                gammaTextBox.Text += (char)elem;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
            resultTextBox.Text = gamma.decrypt(textTextBox.Text);
        }
    }
}

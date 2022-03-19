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
    public partial class EnterKeyTrtemius : Form
    {
        public EnterKeyTrtemius()
        {
            InitializeComponent();
            FormulaLable.Visible = false;
            FormulaLable.Enabled = false;
            ALabel.Visible = false;
            ALabel.Enabled = false;
            ANumericUpDown.Visible = false;
            ANumericUpDown.Enabled = false;
            BLable.Visible = false;
            BLable.Enabled = false;
            BNumericUpDown.Visible = false;
            BNumericUpDown.Enabled = false;
            CLable.Visible = false;
            CLable.Enabled = false;
            CNumericUpDown.Visible = false;
            CNumericUpDown.Enabled = false;
            MottoLable.Visible = false;
            MottoLable.Enabled = false;
            MottoTextBox.Visible = false;
            MottoTextBox.Enabled = false;
        }
        public TrtemiusInitData ReturnData()
        {
            switch (KeyTypeComboBox.SelectedIndex)
            {
                case 0:
                    return new TrtemiusInitData()
                    {
                        isEng = comboBox2.SelectedIndex == 0 ? false : true,
                        isMotto = false,
                        isLinear = true,
                        linear = new int[] {(int)ANumericUpDown.Value, (int)BNumericUpDown.Value}
                    };
                case 1:
                    return new TrtemiusInitData()
                    {
                        isEng = comboBox2.SelectedIndex == 0 ? false : true,
                        isMotto = false,
                        isLinear = false,
                        square = new int[] { (int)ANumericUpDown.Value, (int)BNumericUpDown.Value, (int)CNumericUpDown.Value }
                    };
                case 2:
                        string MottoText = MottoTextBox.Text;
                        for (int i = 0; i < MottoText.Length; ++i)
                        {
                            if (!Char.IsLetter(MottoText[i])) { MottoText.Remove(i); }
                        }
                        int[] Motto = new int[MottoText.Length];
                        for(int i=0;i<MottoText.Length;++i)
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
                        return new TrtemiusInitData()
                        {
                            isEng = comboBox2.SelectedIndex == 0 ? false : true,
                            isMotto = true,
                            isLinear = false,
                            motto = Motto,
                        };
                    
                default: return new TrtemiusInitData();
            }            
        }
        private void KeyTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (KeyTypeComboBox.SelectedIndex)
            {
                case 0:
                    FormulaLable.Text = "k=A*p+B";
                    FormulaLable.Visible = true;
                    FormulaLable.Enabled = true;
                    ALabel.Visible = true;
                    ALabel.Enabled = true;
                    ANumericUpDown.Visible = true;
                    ANumericUpDown.Enabled = true;
                    BLable.Visible = true;
                    BLable.Enabled = true;
                    BNumericUpDown.Visible = true;
                    BNumericUpDown.Enabled = true;
                    CLable.Visible = false;
                    CLable.Enabled = false;
                    CNumericUpDown.Visible = false;
                    CNumericUpDown.Enabled = false;
                    MottoLable.Visible = false;
                    MottoLable.Enabled = false;
                    MottoTextBox.Visible = false;
                    MottoTextBox.Enabled = false;
                    break;
                case 1:
                    FormulaLable.Text = "k=A*p*p+B*p+C";
                    FormulaLable.Visible = true;
                    FormulaLable.Enabled = true;
                    ALabel.Visible = true;
                    ALabel.Enabled = true;
                    ANumericUpDown.Visible = true;
                    ANumericUpDown.Enabled = true;
                    BLable.Visible = true;
                    BLable.Enabled = true;
                    BNumericUpDown.Visible = true;
                    BNumericUpDown.Enabled = true;
                    CLable.Visible = true;
                    CLable.Enabled = true;
                    CNumericUpDown.Visible = true;
                    CNumericUpDown.Enabled = true;
                    MottoLable.Visible = false;
                    MottoLable.Enabled = false;
                    MottoTextBox.Visible = false;
                    MottoTextBox.Enabled = false;
                    break;
                case 2:
                    FormulaLable.Text = "k=A*p+B";
                    FormulaLable.Visible = false;
                    FormulaLable.Enabled = false;
                    ALabel.Visible = false;
                    ALabel.Enabled = false;
                    ANumericUpDown.Visible = false;
                    ANumericUpDown.Enabled = false;
                    BLable.Visible = false;
                    BLable.Enabled = false;
                    BNumericUpDown.Visible = false;
                    BNumericUpDown.Enabled = false;
                    CLable.Visible = false;
                    CLable.Enabled = false;
                    CNumericUpDown.Visible = false;
                    CNumericUpDown.Enabled = false;
                    MottoLable.Visible = true;
                    MottoLable.Enabled = true;
                    MottoTextBox.Visible = true;
                    MottoTextBox.Enabled = true;
                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

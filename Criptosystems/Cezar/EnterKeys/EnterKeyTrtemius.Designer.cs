
namespace Cezar.EnterKeys
{
    partial class EnterKeyTrtemius
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.KeyTypeLable = new System.Windows.Forms.Label();
            this.KeyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ALabel = new System.Windows.Forms.Label();
            this.ANumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BLable = new System.Windows.Forms.Label();
            this.BNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CLable = new System.Windows.Forms.Label();
            this.CNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MottoLable = new System.Windows.Forms.Label();
            this.MottoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FormulaLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ANumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // KeyTypeLable
            // 
            this.KeyTypeLable.AutoSize = true;
            this.KeyTypeLable.Location = new System.Drawing.Point(13, 16);
            this.KeyTypeLable.Name = "KeyTypeLable";
            this.KeyTypeLable.Size = new System.Drawing.Size(82, 20);
            this.KeyTypeLable.TabIndex = 0;
            this.KeyTypeLable.Text = "Вид ключа";
            // 
            // KeyTypeComboBox
            // 
            this.KeyTypeComboBox.FormattingEnabled = true;
            this.KeyTypeComboBox.Items.AddRange(new object[] {
            "Лінійний",
            "Квадратичний",
            "Гасло"});
            this.KeyTypeComboBox.Location = new System.Drawing.Point(101, 13);
            this.KeyTypeComboBox.Name = "KeyTypeComboBox";
            this.KeyTypeComboBox.Size = new System.Drawing.Size(151, 28);
            this.KeyTypeComboBox.TabIndex = 1;
            this.KeyTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.KeyTypeComboBox_SelectedIndexChanged);
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Location = new System.Drawing.Point(13, 58);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(19, 20);
            this.ALabel.TabIndex = 2;
            this.ALabel.Text = "A";
            // 
            // ANumericUpDown
            // 
            this.ANumericUpDown.Location = new System.Drawing.Point(38, 56);
            this.ANumericUpDown.Name = "ANumericUpDown";
            this.ANumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.ANumericUpDown.TabIndex = 3;
            // 
            // BLable
            // 
            this.BLable.AutoSize = true;
            this.BLable.Location = new System.Drawing.Point(215, 58);
            this.BLable.Name = "BLable";
            this.BLable.Size = new System.Drawing.Size(18, 20);
            this.BLable.TabIndex = 4;
            this.BLable.Text = "B";
            // 
            // BNumericUpDown
            // 
            this.BNumericUpDown.Location = new System.Drawing.Point(239, 56);
            this.BNumericUpDown.Name = "BNumericUpDown";
            this.BNumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.BNumericUpDown.TabIndex = 5;
            this.BNumericUpDown.Visible = false;
            // 
            // CLable
            // 
            this.CLable.AutoSize = true;
            this.CLable.Location = new System.Drawing.Point(406, 56);
            this.CLable.Name = "CLable";
            this.CLable.Size = new System.Drawing.Size(18, 20);
            this.CLable.TabIndex = 6;
            this.CLable.Text = "C";
            // 
            // CNumericUpDown
            // 
            this.CNumericUpDown.Location = new System.Drawing.Point(430, 56);
            this.CNumericUpDown.Name = "CNumericUpDown";
            this.CNumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.CNumericUpDown.TabIndex = 7;
            // 
            // MottoLable
            // 
            this.MottoLable.AutoSize = true;
            this.MottoLable.Location = new System.Drawing.Point(12, 58);
            this.MottoLable.Name = "MottoLable";
            this.MottoLable.Size = new System.Drawing.Size(103, 20);
            this.MottoLable.TabIndex = 8;
            this.MottoLable.Text = "Введіть Гасло";
            this.MottoLable.Visible = false;
            // 
            // MottoTextBox
            // 
            this.MottoTextBox.Location = new System.Drawing.Point(121, 55);
            this.MottoTextBox.Name = "MottoTextBox";
            this.MottoTextBox.Size = new System.Drawing.Size(125, 27);
            this.MottoTextBox.TabIndex = 9;
            this.MottoTextBox.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Мова";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Українська",
            "English"});
            this.comboBox2.Location = new System.Drawing.Point(65, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormulaLable
            // 
            this.FormulaLable.AutoSize = true;
            this.FormulaLable.Location = new System.Drawing.Point(266, 16);
            this.FormulaLable.Name = "FormulaLable";
            this.FormulaLable.Size = new System.Drawing.Size(50, 20);
            this.FormulaLable.TabIndex = 13;
            this.FormulaLable.Text = "label1";
            // 
            // EnterKeyTrtemius
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 168);
            this.Controls.Add(this.FormulaLable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MottoTextBox);
            this.Controls.Add(this.MottoLable);
            this.Controls.Add(this.CNumericUpDown);
            this.Controls.Add(this.CLable);
            this.Controls.Add(this.BNumericUpDown);
            this.Controls.Add(this.BLable);
            this.Controls.Add(this.ANumericUpDown);
            this.Controls.Add(this.ALabel);
            this.Controls.Add(this.KeyTypeComboBox);
            this.Controls.Add(this.KeyTypeLable);
            this.Name = "EnterKeyTrtemius";
            this.Text = "Введіть ключ Шифр Тритеміуса";
            ((System.ComponentModel.ISupportInitialize)(this.ANumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KeyTypeLable;
        private System.Windows.Forms.ComboBox KeyTypeComboBox;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.NumericUpDown ANumericUpDown;
        private System.Windows.Forms.Label BLable;
        private System.Windows.Forms.NumericUpDown BNumericUpDown;
        private System.Windows.Forms.Label CLable;
        private System.Windows.Forms.NumericUpDown CNumericUpDown;
        private System.Windows.Forms.Label MottoLable;
        private System.Windows.Forms.TextBox MottoTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label FormulaLable;
    }
}
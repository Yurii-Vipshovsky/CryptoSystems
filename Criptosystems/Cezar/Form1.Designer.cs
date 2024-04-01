
namespace Cezar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            File = new System.Windows.Forms.ToolStripMenuItem();
            create = new System.Windows.Forms.ToolStripMenuItem();
            RSA = new System.Windows.Forms.ToolStripMenuItem();
            RSAParalelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            open = new System.Windows.Forms.ToolStripMenuItem();
            encriptedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            decpritedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            save = new System.Windows.Forms.ToolStripMenuItem();
            decriptedSave = new System.Windows.Forms.ToolStripMenuItem();
            encriptedSave = new System.Windows.Forms.ToolStripMenuItem();
            print = new System.Windows.Forms.ToolStripMenuItem();
            encriptedPrint = new System.Windows.Forms.ToolStripMenuItem();
            decriptedPrint = new System.Windows.Forms.ToolStripMenuItem();
            створитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cript = new System.Windows.Forms.ToolStripMenuItem();
            encript = new System.Windows.Forms.ToolStripMenuItem();
            decript = new System.Windows.Forms.ToolStripMenuItem();
            Criptonotepad = new System.Windows.Forms.ToolStripMenuItem();
            atack = new System.Windows.Forms.ToolStripMenuItem();
            cezarAtack = new System.Windows.Forms.ToolStripMenuItem();
            cezarAtackEng = new System.Windows.Forms.ToolStripMenuItem();
            cezarAtackUkr = new System.Windows.Forms.ToolStripMenuItem();
            trtemiusAtack = new System.Windows.Forms.ToolStripMenuItem();
            FrecTab = new System.Windows.Forms.ToolStripMenuItem();
            info = new System.Windows.Forms.ToolStripMenuItem();
            exit = new System.Windows.Forms.ToolStripMenuItem();
            label1 = new System.Windows.Forms.Label();
            decriptedText = new System.Windows.Forms.RichTextBox();
            label2 = new System.Windows.Forms.Label();
            encriptedText = new System.Windows.Forms.RichTextBox();
            printDialog1 = new System.Windows.Forms.PrintDialog();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            printDocumentEncripted = new System.Drawing.Printing.PrintDocument();
            RSASecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { File, cript, atack, FrecTab, info, exit });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(1143, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { create, open, save, print, створитиToolStripMenuItem });
            File.Name = "File";
            File.Size = new System.Drawing.Size(69, 29);
            File.Text = "Файл";
            // 
            // create
            // 
            create.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { RSA, RSAParalelToolStripMenuItem, RSASecToolStripMenuItem });
            create.Name = "create";
            create.Size = new System.Drawing.Size(270, 34);
            create.Text = "Створити";
            // 
            // RSA
            // 
            RSA.Name = "RSA";
            RSA.Size = new System.Drawing.Size(315, 34);
            RSA.Text = "Шифр RSA";
            RSA.Visible = false;
            RSA.Click += RSA_Click;
            // 
            // RSAParalelToolStripMenuItem
            // 
            RSAParalelToolStripMenuItem.Name = "RSAParalelToolStripMenuItem";
            RSAParalelToolStripMenuItem.Size = new System.Drawing.Size(315, 34);
            RSAParalelToolStripMenuItem.Text = "Шифр RSA Паралельний";
            RSAParalelToolStripMenuItem.Click += RSAParalelToolStripMenuItem_Click;
            // 
            // open
            // 
            open.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { encriptedToolStripMenuItem, decpritedToolStripMenuItem });
            open.Name = "open";
            open.Size = new System.Drawing.Size(270, 34);
            open.Text = "Відкрити";
            // 
            // encriptedToolStripMenuItem
            // 
            encriptedToolStripMenuItem.Name = "encriptedToolStripMenuItem";
            encriptedToolStripMenuItem.Size = new System.Drawing.Size(250, 34);
            encriptedToolStripMenuItem.Text = "Розшифрований";
            encriptedToolStripMenuItem.Click += encriptedToolStripMenuItem_Click;
            // 
            // decpritedToolStripMenuItem
            // 
            decpritedToolStripMenuItem.Name = "decpritedToolStripMenuItem";
            decpritedToolStripMenuItem.Size = new System.Drawing.Size(250, 34);
            decpritedToolStripMenuItem.Text = "Зашифрований";
            decpritedToolStripMenuItem.Click += decpritedToolStripMenuItem_Click;
            // 
            // save
            // 
            save.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { decriptedSave, encriptedSave });
            save.Name = "save";
            save.Size = new System.Drawing.Size(270, 34);
            save.Text = "Зберегти";
            // 
            // decriptedSave
            // 
            decriptedSave.Name = "decriptedSave";
            decriptedSave.Size = new System.Drawing.Size(250, 34);
            decriptedSave.Text = "Розшифрований";
            decriptedSave.Click += decriptedSave_Click;
            // 
            // encriptedSave
            // 
            encriptedSave.Name = "encriptedSave";
            encriptedSave.Size = new System.Drawing.Size(250, 34);
            encriptedSave.Text = "Зашифрований";
            encriptedSave.Click += encriptedSave_Click;
            // 
            // print
            // 
            print.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { encriptedPrint, decriptedPrint });
            print.Name = "print";
            print.Size = new System.Drawing.Size(270, 34);
            print.Text = "Друк";
            // 
            // encriptedPrint
            // 
            encriptedPrint.Name = "encriptedPrint";
            encriptedPrint.Size = new System.Drawing.Size(250, 34);
            encriptedPrint.Text = "Розшифрований";
            encriptedPrint.Click += encriptedPrint_Click;
            // 
            // decriptedPrint
            // 
            decriptedPrint.Name = "decriptedPrint";
            decriptedPrint.Size = new System.Drawing.Size(250, 34);
            decriptedPrint.Text = "Зашифрований";
            // 
            // створитиToolStripMenuItem
            // 
            створитиToolStripMenuItem.Name = "створитиToolStripMenuItem";
            створитиToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            створитиToolStripMenuItem.Text = "Створити";
            // 
            // cript
            // 
            cript.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { encript, decript, Criptonotepad });
            cript.Name = "cript";
            cript.Size = new System.Drawing.Size(135, 29);
            cript.Text = "Шифрування";
            // 
            // encript
            // 
            encript.Name = "encript";
            encript.Size = new System.Drawing.Size(242, 34);
            encript.Text = "Шифрувати";
            encript.Click += encript_Click;
            // 
            // decript
            // 
            decript.Name = "decript";
            decript.Size = new System.Drawing.Size(242, 34);
            decript.Text = "Розшифрувати";
            decript.Click += decript_Click;
            // 
            // Criptonotepad
            // 
            Criptonotepad.Enabled = false;
            Criptonotepad.Name = "Criptonotepad";
            Criptonotepad.Size = new System.Drawing.Size(242, 34);
            Criptonotepad.Text = "Шифроблокнот";
            Criptonotepad.Visible = false;
            Criptonotepad.Click += Criptonotepad_Click;
            // 
            // atack
            // 
            atack.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { cezarAtack, trtemiusAtack });
            atack.Name = "atack";
            atack.Size = new System.Drawing.Size(74, 29);
            atack.Text = "Атака";
            atack.Visible = false;
            // 
            // cezarAtack
            // 
            cezarAtack.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { cezarAtackEng, cezarAtackUkr });
            cezarAtack.Name = "cezarAtack";
            cezarAtack.Size = new System.Drawing.Size(380, 34);
            cezarAtack.Text = "Груба Сила - Шифр Цезаря";
            // 
            // cezarAtackEng
            // 
            cezarAtackEng.Name = "cezarAtackEng";
            cezarAtackEng.Size = new System.Drawing.Size(202, 34);
            cezarAtackEng.Text = "Анлгійська";
            cezarAtackEng.Click += cezarAtackEng_Click;
            // 
            // cezarAtackUkr
            // 
            cezarAtackUkr.Name = "cezarAtackUkr";
            cezarAtackUkr.Size = new System.Drawing.Size(202, 34);
            cezarAtackUkr.Text = "Українська";
            cezarAtackUkr.Click += cezarAtackUkr_Click;
            // 
            // trtemiusAtack
            // 
            trtemiusAtack.Name = "trtemiusAtack";
            trtemiusAtack.Size = new System.Drawing.Size(380, 34);
            trtemiusAtack.Text = "Інтерполяція - Шифр Тритеміуса";
            trtemiusAtack.Click += trtemiusAtack_Click;
            // 
            // FrecTab
            // 
            FrecTab.Name = "FrecTab";
            FrecTab.Size = new System.Drawing.Size(171, 29);
            FrecTab.Text = "Частотна таблиця";
            FrecTab.Visible = false;
            FrecTab.Click += FrecTab_Click;
            // 
            // info
            // 
            info.Name = "info";
            info.Size = new System.Drawing.Size(66, 29);
            info.Text = "Інфо";
            info.Click += info_Click;
            // 
            // exit
            // 
            exit.Name = "exit";
            exit.Size = new System.Drawing.Size(70, 29);
            exit.Text = "Вихід";
            exit.Click += exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(16, 43);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(193, 25);
            label1.TabIndex = 1;
            label1.Text = "Розшифрований текст";
            // 
            // decriptedText
            // 
            decriptedText.Location = new System.Drawing.Point(16, 73);
            decriptedText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            decriptedText.Name = "decriptedText";
            decriptedText.Size = new System.Drawing.Size(1110, 299);
            decriptedText.TabIndex = 2;
            decriptedText.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 407);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(183, 25);
            label2.TabIndex = 3;
            label2.Text = "Зашифрований текст";
            // 
            // encriptedText
            // 
            encriptedText.Location = new System.Drawing.Point(16, 435);
            encriptedText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            encriptedText.Name = "encriptedText";
            encriptedText.Size = new System.Drawing.Size(1110, 299);
            encriptedText.TabIndex = 4;
            encriptedText.Text = "";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "*.txt|";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "\"txt files (*.txt)|*.txt|Photo|*.jpg;*.jpeg;*.png;\"";
            // 
            // printDocumentEncripted
            // 
            printDocumentEncripted.BeginPrint += printDocumentEncripted_BeginPrint;
            printDocumentEncripted.PrintPage += printDocumentEncripted_PrintPage;
            // 
            // RSASecToolStripMenuItem
            // 
            RSASecToolStripMenuItem.Name = "RSASecToolStripMenuItem";
            RSASecToolStripMenuItem.Size = new System.Drawing.Size(315, 34);
            RSASecToolStripMenuItem.Text = "RSA Послідовний";
            RSASecToolStripMenuItem.Click += RSASecToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1143, 750);
            Controls.Add(encriptedText);
            Controls.Add(label2);
            Controls.Add(decriptedText);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Universal Encryptor";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem create;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem print;
        private System.Windows.Forms.ToolStripMenuItem cript;
        private System.Windows.Forms.ToolStripMenuItem encript;
        private System.Windows.Forms.ToolStripMenuItem decript;
        private System.Windows.Forms.ToolStripMenuItem info;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox decriptedText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox encriptedText;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem encriptedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decpritedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decriptedSave;
        private System.Windows.Forms.ToolStripMenuItem encriptedSave;
        private System.Windows.Forms.ToolStripMenuItem encriptedPrint;
        private System.Windows.Forms.ToolStripMenuItem decriptedPrint;
        private System.Drawing.Printing.PrintDocument printDocumentEncripted;
        private System.Windows.Forms.ToolStripMenuItem створитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atack;
        private System.Windows.Forms.ToolStripMenuItem cezarAtack;
        private System.Windows.Forms.ToolStripMenuItem cezarAtackEng;
        private System.Windows.Forms.ToolStripMenuItem cezarAtackUkr;
        private System.Windows.Forms.ToolStripMenuItem FrecTab;
        private System.Windows.Forms.ToolStripMenuItem trtemiusAtack;
        private System.Windows.Forms.ToolStripMenuItem Criptonotepad;
        private System.Windows.Forms.ToolStripMenuItem RSA;
        private System.Windows.Forms.ToolStripMenuItem RSAParalelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RSASecToolStripMenuItem;
    }
}



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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.create = new System.Windows.Forms.ToolStripMenuItem();
            this.Cezar = new System.Windows.Forms.ToolStripMenuItem();
            this.Trtemius = new System.Windows.Forms.ToolStripMenuItem();
            this.Gamma = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.encriptedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decpritedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.decriptedSave = new System.Windows.Forms.ToolStripMenuItem();
            this.encriptedSave = new System.Windows.Forms.ToolStripMenuItem();
            this.print = new System.Windows.Forms.ToolStripMenuItem();
            this.encriptedPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.decriptedPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.створитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cript = new System.Windows.Forms.ToolStripMenuItem();
            this.encript = new System.Windows.Forms.ToolStripMenuItem();
            this.decript = new System.Windows.Forms.ToolStripMenuItem();
            this.atack = new System.Windows.Forms.ToolStripMenuItem();
            this.cezarAtack = new System.Windows.Forms.ToolStripMenuItem();
            this.cezarAtackEng = new System.Windows.Forms.ToolStripMenuItem();
            this.cezarAtackUkr = new System.Windows.Forms.ToolStripMenuItem();
            this.trtemiusAtack = new System.Windows.Forms.ToolStripMenuItem();
            this.FrecTab = new System.Windows.Forms.ToolStripMenuItem();
            this.info = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.decriptedText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.encriptedText = new System.Windows.Forms.RichTextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDocumentEncripted = new System.Drawing.Printing.PrintDocument();
            this.Criptonotepad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.cript,
            this.atack,
            this.FrecTab,
            this.info,
            this.exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.create,
            this.open,
            this.save,
            this.print,
            this.створитиToolStripMenuItem});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(59, 24);
            this.File.Text = "Файл";
            // 
            // create
            // 
            this.create.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cezar,
            this.Trtemius,
            this.Gamma});
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(157, 26);
            this.create.Text = "Створити";
            // 
            // Cezar
            // 
            this.Cezar.Name = "Cezar";
            this.Cezar.Size = new System.Drawing.Size(215, 26);
            this.Cezar.Text = "Шифр Цезаря";
            this.Cezar.Click += new System.EventHandler(this.Cezar_Click);
            // 
            // Trtemius
            // 
            this.Trtemius.Name = "Trtemius";
            this.Trtemius.Size = new System.Drawing.Size(215, 26);
            this.Trtemius.Text = "Шифр Тритеміуса";
            this.Trtemius.Click += new System.EventHandler(this.trtemius_Click);
            // 
            // Gamma
            // 
            this.Gamma.Name = "Gamma";
            this.Gamma.Size = new System.Drawing.Size(215, 26);
            this.Gamma.Text = "Шифр Гамування";
            this.Gamma.Click += new System.EventHandler(this.Gamma_Click);
            // 
            // open
            // 
            this.open.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encriptedToolStripMenuItem,
            this.decpritedToolStripMenuItem});
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(157, 26);
            this.open.Text = "Відкрити";
            // 
            // encriptedToolStripMenuItem
            // 
            this.encriptedToolStripMenuItem.Name = "encriptedToolStripMenuItem";
            this.encriptedToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.encriptedToolStripMenuItem.Text = "Розшифрований";
            this.encriptedToolStripMenuItem.Click += new System.EventHandler(this.encriptedToolStripMenuItem_Click);
            // 
            // decpritedToolStripMenuItem
            // 
            this.decpritedToolStripMenuItem.Name = "decpritedToolStripMenuItem";
            this.decpritedToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.decpritedToolStripMenuItem.Text = "Зашифрований";
            this.decpritedToolStripMenuItem.Click += new System.EventHandler(this.decpritedToolStripMenuItem_Click);
            // 
            // save
            // 
            this.save.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decriptedSave,
            this.encriptedSave});
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(157, 26);
            this.save.Text = "Зберегти";
            // 
            // decriptedSave
            // 
            this.decriptedSave.Name = "decriptedSave";
            this.decriptedSave.Size = new System.Drawing.Size(208, 26);
            this.decriptedSave.Text = "Розшифрований";
            this.decriptedSave.Click += new System.EventHandler(this.decriptedSave_Click);
            // 
            // encriptedSave
            // 
            this.encriptedSave.Name = "encriptedSave";
            this.encriptedSave.Size = new System.Drawing.Size(208, 26);
            this.encriptedSave.Text = "Зашифрований";
            this.encriptedSave.Click += new System.EventHandler(this.encriptedSave_Click);
            // 
            // print
            // 
            this.print.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encriptedPrint,
            this.decriptedPrint});
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(157, 26);
            this.print.Text = "Друк";
            // 
            // encriptedPrint
            // 
            this.encriptedPrint.Name = "encriptedPrint";
            this.encriptedPrint.Size = new System.Drawing.Size(208, 26);
            this.encriptedPrint.Text = "Розшифрований";
            this.encriptedPrint.Click += new System.EventHandler(this.encriptedPrint_Click);
            // 
            // decriptedPrint
            // 
            this.decriptedPrint.Name = "decriptedPrint";
            this.decriptedPrint.Size = new System.Drawing.Size(208, 26);
            this.decriptedPrint.Text = "Зашифрований";
            // 
            // створитиToolStripMenuItem
            // 
            this.створитиToolStripMenuItem.Name = "створитиToolStripMenuItem";
            this.створитиToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.створитиToolStripMenuItem.Text = "Створити";
            // 
            // cript
            // 
            this.cript.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encript,
            this.decript,
            this.Criptonotepad});
            this.cript.Name = "cript";
            this.cript.Size = new System.Drawing.Size(114, 24);
            this.cript.Text = "Шифрування";
            // 
            // encript
            // 
            this.encript.Name = "encript";
            this.encript.Size = new System.Drawing.Size(224, 26);
            this.encript.Text = "Шифрувати";
            this.encript.Click += new System.EventHandler(this.encript_Click);
            // 
            // decript
            // 
            this.decript.Name = "decript";
            this.decript.Size = new System.Drawing.Size(224, 26);
            this.decript.Text = "Розшифрувати";
            this.decript.Click += new System.EventHandler(this.decript_Click);
            // 
            // atack
            // 
            this.atack.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cezarAtack,
            this.trtemiusAtack});
            this.atack.Name = "atack";
            this.atack.Size = new System.Drawing.Size(62, 24);
            this.atack.Text = "Атака";
            // 
            // cezarAtack
            // 
            this.cezarAtack.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cezarAtackEng,
            this.cezarAtackUkr});
            this.cezarAtack.Name = "cezarAtack";
            this.cezarAtack.Size = new System.Drawing.Size(320, 26);
            this.cezarAtack.Text = "Груба Сила - Шифр Цезаря";
            // 
            // cezarAtackEng
            // 
            this.cezarAtackEng.Name = "cezarAtackEng";
            this.cezarAtackEng.Size = new System.Drawing.Size(168, 26);
            this.cezarAtackEng.Text = "Анлгійська";
            this.cezarAtackEng.Click += new System.EventHandler(this.cezarAtackEng_Click);
            // 
            // cezarAtackUkr
            // 
            this.cezarAtackUkr.Name = "cezarAtackUkr";
            this.cezarAtackUkr.Size = new System.Drawing.Size(168, 26);
            this.cezarAtackUkr.Text = "Українська";
            this.cezarAtackUkr.Click += new System.EventHandler(this.cezarAtackUkr_Click);
            // 
            // trtemiusAtack
            // 
            this.trtemiusAtack.Name = "trtemiusAtack";
            this.trtemiusAtack.Size = new System.Drawing.Size(320, 26);
            this.trtemiusAtack.Text = "Інтерполяція - Шифр Тритеміуса";
            this.trtemiusAtack.Click += new System.EventHandler(this.trtemiusAtack_Click);
            // 
            // FrecTab
            // 
            this.FrecTab.Name = "FrecTab";
            this.FrecTab.Size = new System.Drawing.Size(147, 24);
            this.FrecTab.Text = "Частотна таблиця";
            this.FrecTab.Click += new System.EventHandler(this.FrecTab_Click);
            // 
            // info
            // 
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(55, 24);
            this.info.Text = "Інфо";
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(60, 24);
            this.exit.Text = "Вихід";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Розшифрований текст";
            // 
            // decriptedText
            // 
            this.decriptedText.Location = new System.Drawing.Point(13, 59);
            this.decriptedText.Name = "decriptedText";
            this.decriptedText.Size = new System.Drawing.Size(889, 240);
            this.decriptedText.TabIndex = 2;
            this.decriptedText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Зашифрований текст";
            // 
            // encriptedText
            // 
            this.encriptedText.Location = new System.Drawing.Point(13, 348);
            this.encriptedText.Name = "encriptedText";
            this.encriptedText.Size = new System.Drawing.Size(889, 240);
            this.encriptedText.TabIndex = 4;
            this.encriptedText.Text = "";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "*.txt|";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"txt files (*.txt)|*.txt|Photo|*.jpg;*.jpeg;*.png;\"";
            // 
            // printDocumentEncripted
            // 
            this.printDocumentEncripted.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocumentEncripted_BeginPrint);
            this.printDocumentEncripted.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentEncripted_PrintPage);
            // 
            // Criptonotepad
            // 
            this.Criptonotepad.Enabled = false;
            this.Criptonotepad.Name = "Criptonotepad";
            this.Criptonotepad.Size = new System.Drawing.Size(224, 26);
            this.Criptonotepad.Text = "Шифроблокнот";
            this.Criptonotepad.Visible = false;
            this.Criptonotepad.Click += new System.EventHandler(this.Criptonotepad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.encriptedText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.decriptedText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Universal Encryptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ToolStripMenuItem Cezar;
        private System.Windows.Forms.ToolStripMenuItem створитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atack;
        private System.Windows.Forms.ToolStripMenuItem cezarAtack;
        private System.Windows.Forms.ToolStripMenuItem cezarAtackEng;
        private System.Windows.Forms.ToolStripMenuItem cezarAtackUkr;
        private System.Windows.Forms.ToolStripMenuItem FrecTab;
        private System.Windows.Forms.ToolStripMenuItem Trtemius;
        private System.Windows.Forms.ToolStripMenuItem trtemiusAtack;
        private System.Windows.Forms.ToolStripMenuItem Gamma;
        private System.Windows.Forms.ToolStripMenuItem Criptonotepad;
    }
}


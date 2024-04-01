using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using Cezar.EnterKeys;
using Cezar.CriptoSystems;

namespace Cezar
{
    public partial class Form1 : Form
    {
        ICriptoSystem CurentSystem;
        string FileName;
        Cezar cezar;
        Trtemius trtemius;
        Gamma gamma;
        Vigener vigener;
        RSA rsa;
        Uitstone uitstone;
        byte[] byteInfoDec;
        byte[] byteInfoEnc;
        public Form1()
        {
            InitializeComponent();
        }
        //empty
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void info_Click(object sender, EventArgs e)
        {
            new AboutInfo().Show();
        }

        private void encriptedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                if (openFileDialog1.FilterIndex == 1)
                {
                    decriptedText.Text = System.IO.File.ReadAllText(FileName);
                }
                else
                {
                    byteInfoDec = System.IO.File.ReadAllBytes(FileName);
                    decriptedText.Text = "Відрито не текстовий файл!";
                }
            }
        }

        private void decpritedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                if (openFileDialog1.FilterIndex == 1)
                {
                    encriptedText.Text = System.IO.File.ReadAllText(FileName);
                }
                else
                {
                    byteInfoEnc = System.IO.File.ReadAllBytes(FileName);
                    encriptedText.Text = "Відрито не текстовий файл!";
                }
            }
        }

        private void decriptedSave_Click(object sender, EventArgs e)
        {
            if (CurentSystem.isTextInfo())
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, decriptedText.Text);
                }
            }
            else
            {
                if (byteInfoDec != null)
                {
                    FileInfo fi = new FileInfo(FileName);
                    saveFileDialog1.DefaultExt = fi.Extension;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.WriteAllBytes(saveFileDialog1.FileName, byteInfoDec);
                    }
                    decriptedText.Text = "Дані збережено";
                }
                else
                {
                    MessageBox.Show("Розшифрованих даних немає!");
                }
            }
        }

        private void encriptedSave_Click(object sender, EventArgs e)
        {
            if (CurentSystem.isTextInfo())
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, encriptedText.Text);
                }
            }

            else
            {
                if (byteInfoEnc != null)
                {
                    FileInfo fi = new FileInfo(FileName);
                    saveFileDialog1.DefaultExt = fi.Extension;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.WriteAllBytes(saveFileDialog1.FileName, byteInfoEnc);
                    }
                    decriptedText.Text = "Дані збережено";
                }
                else
                {
                    MessageBox.Show("Зашифрованих даних немає!");
                }
            }
        }

        private void encriptedPrint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocumentEncripted.Print();
            }


            //PrintDocument p = new PrintDocument();
            //p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            //{
            //    e1.Graphics.DrawString(decriptedText.Text, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));

            //};
            //try
            //{
            //    printDialog1.AllowSomePages = true;

            //    // Show the help button.
            //    printDialog1.ShowHelp = true;

            //    // Set the Document property to the PrintDocument for 
            //    // which the PrintPage Event has been handled. To display the
            //    // dialog, either this property or the PrinterSettings property 
            //    // must be set 
            //    printDialog1.Document = p;

            //    DialogResult result = printDialog1.ShowDialog();

            //    // If the result is OK then print the document.
            //    if (result == DialogResult.OK)
            //    {
            //        p.Print();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("Exception Occured While Printing", ex);
            //}
        }

        private int linesPrinted;
        private string[] lines;

        private void printDocumentEncripted_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            Brush brush = new SolidBrush(encriptedText.ForeColor);

            while (linesPrinted < lines.Length)
            {
                e.Graphics.DrawString(lines[linesPrinted++],
                    encriptedText.Font, brush, x, y);
                y += 15;
                if (y >= e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            linesPrinted = 0;
            e.HasMorePages = false;
        }

        private void printDocumentEncripted_BeginPrint(object sender, PrintEventArgs e)
        {
            char[] param = { '\n' };

            if (printDialog1.PrinterSettings.PrintRange == PrintRange.Selection)
            {
                lines = encriptedText.SelectedText.Split(param);
            }
            else
            {
                lines = encriptedText.Text.Split(param);
            }

            int i = 0;
            char[] trimParam = { '\r' };
            foreach (string s in lines)
            {
                lines[i++] = s.TrimEnd(trimParam);
            }
        }

        private void Cezar_Click(object sender, EventArgs e)
        {
            EnterKeyCezar key = new EnterKeyCezar();
            key.ShowDialog();
            if (key.DialogResult == DialogResult.OK)
            {
                cezar = new Cezar(key.ReturnData());
            }
            CurentSystem = cezar;
            Criptonotepad.Enabled = false;
            Criptonotepad.Visible = false;
        }

        private void encript_Click(object sender, EventArgs e)
        {
            if (CurentSystem != null)
            {
                if (CurentSystem.isTextInfo())
                {
                    encriptedText.Text = CurentSystem.encrypt(decriptedText.Text);
                }
                else
                {
                    byteInfoEnc = CurentSystem.encrypt(byteInfoDec);
                    encriptedText.Text = "Дані зашифровано";
                }
            }
            else
            {
                MessageBox.Show("Створіть шифрувальну систему!");
            }
        }

        private void decript_Click(object sender, EventArgs e)
        {
            if (CurentSystem != null)
            {
                if (CurentSystem.isTextInfo())
                {
                    decriptedText.Text = CurentSystem.decrypt(encriptedText.Text);
                }
                else
                {
                    byteInfoDec = CurentSystem.decrypt(byteInfoEnc);
                    decriptedText.Text = "Дані розшифровано";
                }
            }
            else
            {
                MessageBox.Show("Створіть шифрувальну систему!");
            }
        }

        private void cezarAtackEng_Click(object sender, EventArgs e)
        {
            //Cezar atackingCezarEng = new Cezar(new CezarInitData() { key = 1, isEng = true }); 
            //for(int i = 1; i < ICriptoSystem.ENG_ALF_COUNT; ++i)
            //{
            //    decriptedText.Text = atackingCezarEng.decrypt(encriptedText.Text);
            //    DialogResult dialogResult = MessageBox.Show("Information decripted?", "Decription", MessageBoxButtons.YesNo);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        MessageBox.Show("Cipher hacked, key: "+atackingCezarEng.key, "Done");
            //        return;
            //    }
            //    else if (dialogResult == DialogResult.No)
            //    {
            //        atackingCezarEng.nextKey();
            //    }
            //}
            //MessageBox.Show("We can't decript this text!", "Error");
        }

        private void cezarAtackUkr_Click(object sender, EventArgs e)
        {
            //Cezar atackingCezarUkr = new Cezar(new CezarInitData() { key = 1, isEng = false });
            //for (int i = 1; i < ICriptoSystem.UKR_ALF_COUNT; ++i)
            //{
            //    decriptedText.Text = atackingCezarUkr.decrypt(encriptedText.Text);
            //    DialogResult dialogResult = MessageBox.Show("Інформація розшифрована?", "Розшифрування", MessageBoxButtons.YesNo);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        MessageBox.Show("Шифр взломаний, ключ: "+ atackingCezarUkr.key, "Готово");
            //        return;
            //    }
            //    else if (dialogResult == DialogResult.No)
            //    {
            //        atackingCezarUkr.nextKey();
            //    }
            //}
            //MessageBox.Show("Ми не можемо зламати цей шифр!", "Помилка");
        }

        private void FrecTab_Click(object sender, EventArgs e)
        {
            if (CurentSystem == null)
            {
                MessageBox.Show("Створіть криптосистему!");
                return;
            }
            if (CurentSystem.isEnglish() && CurentSystem.isTextInfo())
            {
                Dictionary<string, int> frecData = new Dictionary<string, int>();
                foreach (var letter in Enum.GetNames(typeof(EnglishABC)))
                {
                    foreach (var elem in encriptedText.Text)
                    {
                        if (letter == Char.ToLower(elem).ToString())
                        {
                            if (frecData.ContainsKey(letter))
                            {
                                frecData[letter] += 1;
                            }
                            else
                            {
                                frecData.Add(letter, 1);
                            }
                        }
                    }
                    if (!frecData.ContainsKey(letter))
                    {
                        frecData.Add(letter, 0);
                    }
                }
                FrecTable fr = new FrecTable(frecData.ToArray());
                fr.Show();
            }
            else if (!CurentSystem.isEnglish() && CurentSystem.isTextInfo())
            {
                Dictionary<string, int> frecData = new Dictionary<string, int>();
                foreach (var letter in Enum.GetNames(typeof(UkrainianABC)))
                {
                    foreach (var elem in encriptedText.Text)
                    {
                        if (letter == Char.ToLower(elem).ToString())
                        {
                            if (frecData.ContainsKey(letter))
                            {
                                frecData[letter] += 1;
                            }
                            else
                            {
                                frecData.Add(letter, 1);
                            }
                        }
                    }
                    if (!frecData.ContainsKey(letter))
                    {
                        frecData.Add(letter, 0);
                    }
                }
                FrecTable fr = new FrecTable(frecData.ToArray());
                fr.Show();
            }
        }

        private void trtemius_Click(object sender, EventArgs e)
        {
            EnterKeyTrtemius key = new EnterKeyTrtemius();
            key.ShowDialog();
            if (key.DialogResult == DialogResult.OK)
            {
                trtemius = new Trtemius(key.ReturnData());
            }
            CurentSystem = trtemius;
            Criptonotepad.Enabled = false;
            Criptonotepad.Visible = false;
        }

        private void trtemiusAtack_Click(object sender, EventArgs e)
        {
            //1 буква зашифровується вільним членом з 2 підбираєм коеф для х і перевіряєм чи 3 розшифровується
            //якщо ні то розвязуєм систему і ерівряєм цю систему на 4
            //якщо ні то треба шукати гасло - шукаєм букви поки не повторяться, якщо перша повторилась перівряємо решту в додатковому циклі і так поки не найдем слово
            if (encriptedText.Text.Length != decriptedText.Text.Length)
            {
                MessageBox.Show("Розмір розшифрованого тексту не збігається з зашированим!");
                return;
            }
            for (int i = 0; i < 3; ++i)
            {
                if (!Char.IsLetter(encriptedText.Text[i]))
                {
                    MessageBox.Show("Для розшифрування ключів необхідно щоб перші 3 елемента були буквами!");
                    return;
                }
            }
            //Мінімально 3 букви підряд для розвязання систем перевірка для них вором по всіх
            //в гаслі в пробілах немає букви і їх треба буде шукати
            bool IsEnglish;
            try
            {
                int temp = (int)Enum.Parse(typeof(EnglishABC), decriptedText.Text[0].ToString().ToLower());
                IsEnglish = true;
            }
            catch { IsEnglish = false; }
            int C;
            int A;
            int B;
            bool IsLinear = true;
            bool IsSquare = false;
            bool IsMotto = false;
            if (IsEnglish)
            {
                C = ((int)Enum.Parse(typeof(EnglishABC), encriptedText.Text[0].ToString().ToLower()) - (int)Enum.Parse(typeof(EnglishABC), decriptedText.Text[0].ToString().ToLower()) + ICriptoSystem.ENG_ALF_COUNT) % ICriptoSystem.ENG_ALF_COUNT;
                B = ((((int)Enum.Parse(typeof(EnglishABC), encriptedText.Text[1].ToString().ToLower()) - (int)Enum.Parse(typeof(EnglishABC), decriptedText.Text[1].ToString().ToLower()) + ICriptoSystem.ENG_ALF_COUNT) % ICriptoSystem.ENG_ALF_COUNT - C) + ICriptoSystem.ENG_ALF_COUNT) % ICriptoSystem.ENG_ALF_COUNT;
                for (int i = 2; i < encriptedText.Text.Length; ++i)
                {
                    if (!Char.IsLetter(encriptedText.Text[i]))
                    {
                        continue;
                    }
                    int k = B * i + C;
                    int newElem = ((int)Enum.Parse(typeof(EnglishABC), decriptedText.Text[i].ToString().ToLower()) + k) % ICriptoSystem.ENG_ALF_COUNT;
                    if (newElem != (int)Enum.Parse(typeof(EnglishABC), encriptedText.Text[i].ToString().ToLower()))
                    {
                        IsSquare = true;
                        IsLinear = false;
                        break;
                    }
                }
                if (IsLinear)
                {
                    MessageBox.Show("Систему Взломано ключ - лінійний: " + B + "*p+" + C);
                    return;
                }
                int AB = B;
                A = (((((((((int)Enum.Parse(typeof(EnglishABC), encriptedText.Text[2].ToString().ToLower()) - (int)Enum.Parse(typeof(EnglishABC), decriptedText.Text[2].ToString().ToLower()) + ICriptoSystem.ENG_ALF_COUNT) % ICriptoSystem.ENG_ALF_COUNT - C) + ICriptoSystem.ENG_ALF_COUNT) % ICriptoSystem.ENG_ALF_COUNT) - 2 * AB + ICriptoSystem.ENG_ALF_COUNT) % ICriptoSystem.ENG_ALF_COUNT) + ICriptoSystem.ENG_ALF_COUNT) / 2) % ICriptoSystem.ENG_ALF_COUNT;
                B = ((AB + ICriptoSystem.ENG_ALF_COUNT) - A) % ICriptoSystem.ENG_ALF_COUNT;
                for (int i = 3; i < encriptedText.Text.Length; ++i)
                {
                    if (!Char.IsLetter(encriptedText.Text[i]))
                    {
                        continue;
                    }
                    int k = A * i * i + B * i + C;
                    int newElem = ((int)Enum.Parse(typeof(EnglishABC), decriptedText.Text[i].ToString().ToLower()) + k) % ICriptoSystem.ENG_ALF_COUNT;
                    if (newElem != (int)Enum.Parse(typeof(EnglishABC), encriptedText.Text[i].ToString().ToLower()))
                    {
                        IsSquare = false;
                        IsMotto = true;
                        break;
                    }
                }
                if (IsSquare)
                {
                    MessageBox.Show("Систему Взломано ключ - нелінійний: " + A + "*p^2+" + B + "*p+" + C);
                    return;
                }
                else
                {
                    string possibleMotto = "";
                    int posibleMottoLength;
                    for (int i = 0; i < decriptedText.Text.Length; ++i)
                    {
                        if (!Char.IsLetter(encriptedText.Text[i]))
                        {
                            possibleMotto += "_";
                        }
                        else
                        {
                            possibleMotto += (EnglishABC)((((int)Enum.Parse(typeof(EnglishABC), encriptedText.Text[i].ToString().ToLower()) - (int)Enum.Parse(typeof(EnglishABC), decriptedText.Text[i].ToString().ToLower())) + ICriptoSystem.ENG_ALF_COUNT) % ICriptoSystem.ENG_ALF_COUNT);
                        }
                    }
                    string findFirstTwo = "";
                    if (findFirstTwo.Contains("_"))
                    {
                        MessageBox.Show("Гасло: " + possibleMotto);
                        return;
                    }
                    findFirstTwo += possibleMotto[0];
                    findFirstTwo += possibleMotto[1];
                    int possiblePosition = String.Concat(possibleMotto.Skip(2)).IndexOf(findFirstTwo) + 2;
                    string tryMotto = possibleMotto.Substring(0, possiblePosition);
                    bool hasLetters = true;
                    while (tryMotto.Contains("_") && hasLetters)
                    {
                        int index = tryMotto.IndexOf("_");
                        if (possibleMotto.Length > possiblePosition + index)
                        {
                            tryMotto = tryMotto.Remove(index, 1).Insert(index, possibleMotto[possiblePosition + index].ToString());
                        }
                        else
                        {
                            hasLetters = false;
                        }
                    }

                    if (hasLetters)
                    {
                        int[] Motto = new int[tryMotto.Length];
                        for (int i = 0; i < tryMotto.Length; ++i)
                        {
                            Motto[i] = (int)Enum.Parse(typeof(EnglishABC), tryMotto[i].ToString().ToLower());
                        }
                        Trtemius tryM = new Trtemius(new TrtemiusInitData() { isEng = true, isLinear = false, isMotto = true, motto = Motto });
                        string result = tryM.decrypt(encriptedText.Text);
                        if (result == decriptedText.Text)
                        {
                            MessageBox.Show("Гасло взломане: " + tryMotto);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Гасло: " + possibleMotto);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Гасло: " + possibleMotto);
                    }

                }

            }
            //same for ukr
            else
            {
                C = ((int)Enum.Parse(typeof(UkrainianABC), encriptedText.Text[0].ToString().ToLower()) - (int)Enum.Parse(typeof(UkrainianABC), decriptedText.Text[0].ToString().ToLower()) + ICriptoSystem.UKR_ALF_COUNT) % ICriptoSystem.UKR_ALF_COUNT;
                B = ((((int)Enum.Parse(typeof(UkrainianABC), encriptedText.Text[1].ToString().ToLower()) - (int)Enum.Parse(typeof(UkrainianABC), decriptedText.Text[1].ToString().ToLower()) + ICriptoSystem.UKR_ALF_COUNT) % ICriptoSystem.UKR_ALF_COUNT - C) + ICriptoSystem.UKR_ALF_COUNT) % ICriptoSystem.UKR_ALF_COUNT;
                for (int i = 2; i < encriptedText.Text.Length; ++i)
                {
                    if (!Char.IsLetter(encriptedText.Text[i]))
                    {
                        continue;
                    }
                    int k = B * i + C;
                    int newElem = ((int)Enum.Parse(typeof(UkrainianABC), decriptedText.Text[i].ToString().ToLower()) + k) % ICriptoSystem.UKR_ALF_COUNT;
                    if (newElem != (int)Enum.Parse(typeof(UkrainianABC), encriptedText.Text[i].ToString().ToLower()))
                    {
                        IsSquare = true;
                        IsLinear = false;
                        break;
                    }
                }
                if (IsLinear)
                {
                    MessageBox.Show("Систему Взломано ключ - лінійний: " + B + "*p+" + C);
                    return;
                }
                int AB = B;
                A = (((((((((int)Enum.Parse(typeof(UkrainianABC), encriptedText.Text[2].ToString().ToLower()) - (int)Enum.Parse(typeof(UkrainianABC), decriptedText.Text[2].ToString().ToLower()) + ICriptoSystem.UKR_ALF_COUNT) % ICriptoSystem.UKR_ALF_COUNT - C) + ICriptoSystem.UKR_ALF_COUNT) % ICriptoSystem.UKR_ALF_COUNT) - 2 * AB + ICriptoSystem.UKR_ALF_COUNT) % ICriptoSystem.UKR_ALF_COUNT) + ICriptoSystem.UKR_ALF_COUNT) / 2) % ICriptoSystem.UKR_ALF_COUNT;
                B = ((AB + ICriptoSystem.UKR_ALF_COUNT) - A) % ICriptoSystem.UKR_ALF_COUNT;
                for (int i = 3; i < encriptedText.Text.Length; ++i)
                {
                    if (!Char.IsLetter(encriptedText.Text[i]))
                    {
                        continue;
                    }
                    int k = A * i * i + B * i + C;
                    int newElem = ((int)Enum.Parse(typeof(UkrainianABC), decriptedText.Text[i].ToString().ToLower()) + k) % ICriptoSystem.UKR_ALF_COUNT;
                    if (newElem != (int)Enum.Parse(typeof(UkrainianABC), encriptedText.Text[i].ToString().ToLower()))
                    {
                        IsSquare = false;
                        IsMotto = true;
                        break;
                    }
                }
                if (IsSquare)
                {
                    MessageBox.Show("Систему Взломано ключ - нелінійний: " + A + "*p^2+" + B + "*p+" + C);
                    return;
                }
                else
                {
                    string possibleMotto = "";
                    int posibleMottoLength;
                    for (int i = 0; i < decriptedText.Text.Length; ++i)
                    {
                        if (!Char.IsLetter(encriptedText.Text[i]))
                        {
                            possibleMotto += "_";
                        }
                        else
                        {
                            possibleMotto += (UkrainianABC)((((int)Enum.Parse(typeof(UkrainianABC), encriptedText.Text[i].ToString().ToLower()) - (int)Enum.Parse(typeof(UkrainianABC), decriptedText.Text[i].ToString().ToLower())) + ICriptoSystem.UKR_ALF_COUNT) % ICriptoSystem.UKR_ALF_COUNT);
                        }
                    }
                    string findFirstTwo = "";
                    if (findFirstTwo.Contains("_"))
                    {
                        MessageBox.Show("Гасло: " + possibleMotto);
                        return;
                    }
                    findFirstTwo += possibleMotto[0];
                    findFirstTwo += possibleMotto[1];
                    int possiblePosition = String.Concat(possibleMotto.Skip(2)).IndexOf(findFirstTwo) + 2;
                    string tryMotto = possibleMotto.Substring(0, possiblePosition);
                    bool hasLetters = true;
                    while (tryMotto.Contains("_") && hasLetters)
                    {
                        int index = tryMotto.IndexOf("_");
                        if (possibleMotto.Length > possiblePosition + index && possibleMotto[possiblePosition + index] != '_')
                        {
                            tryMotto = tryMotto.Remove(index, 1).Insert(index, possibleMotto[possiblePosition + index].ToString());
                        }
                        else
                        {
                            hasLetters = false;
                        }
                    }

                    if (hasLetters)
                    {
                        int[] Motto = new int[tryMotto.Length];
                        for (int i = 0; i < tryMotto.Length; ++i)
                        {
                            Motto[i] = (int)Enum.Parse(typeof(UkrainianABC), tryMotto[i].ToString().ToLower());
                        }
                        Trtemius tryM = new Trtemius(new TrtemiusInitData() { isEng = false, isLinear = false, isMotto = true, motto = Motto });
                        string result = tryM.decrypt(encriptedText.Text);
                        if (result == decriptedText.Text)
                        {
                            MessageBox.Show("Гасло взломане: " + tryMotto);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Гасло: " + possibleMotto);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Гасло: " + possibleMotto);
                    }

                }

            }
        }

        private void Gamma_Click(object sender, EventArgs e)
        {
            gamma = new Gamma();
            CurentSystem = gamma;
            Criptonotepad.Enabled = true;
            Criptonotepad.Visible = true;
            MessageBox.Show("Гамма шифр готовий");
        }

        private void Criptonotepad_Click(object sender, EventArgs e)
        {
            CriptoNotepad notepad = new CriptoNotepad(gamma);
            notepad.Show();
        }

        private void Vigener_Click(object sender, EventArgs e)
        {
            EnterKeyVigener key = new EnterKeyVigener();
            key.ShowDialog();
            if (key.DialogResult == DialogResult.OK)
            {
                vigener = new Vigener(key.ReturnData());
                CurentSystem = vigener;
                Criptonotepad.Enabled = false;
                Criptonotepad.Visible = false;
            }

        }
        private void RSA_Click(object sender, EventArgs e)
        {
            EnterKeyRSA key = new EnterKeyRSA();
            key.ShowDialog();
            if (key.DialogResult == DialogResult.OK)
            {
                if (key.ReturnData() == -1)
                {
                    rsa = new RSA(false, 1);
                }
                else
                {
                    rsa = new RSA(key.ReturnData());
                }
                MessageBox.Show("RSA шифр створений відкритий ключ - " + rsa.openKey);
                CurentSystem = rsa;
                Criptonotepad.Enabled = false;
                Criptonotepad.Visible = false;
            }
        }
        private void Uitsrone_Click(object sender, EventArgs e)
        {
            EnterKeyUitstone key = new EnterKeyUitstone();
            key.ShowDialog();
            if (key.DialogResult == DialogResult.OK)
            {
                uitstone = new Uitstone(key.ReturnData());
                MessageBox.Show("Uitstone шифр створений");
                CurentSystem = uitstone;
                Criptonotepad.Enabled = false;
                Criptonotepad.Visible = false;
            }
        }

        private void RSAParalelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterKeyRSA key = new EnterKeyRSA();
            key.ShowDialog();
            if (key.DialogResult == DialogResult.OK)
            {
                rsa = new RSA(true, key.ReturnData());
                MessageBox.Show("RSA шифр створений відкритий ключ - " + rsa.openKey);
                CurentSystem = rsa;
                Criptonotepad.Enabled = false;
                Criptonotepad.Visible = false;
            }
        }

        private void RSASecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rsa = new RSA(false, 1);
            MessageBox.Show("RSA шифр створений відкритий ключ - " + rsa.openKey);
            CurentSystem = rsa;
            Criptonotepad.Enabled = false;
            Criptonotepad.Visible = false;
        }
    }
}

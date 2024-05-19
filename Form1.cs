using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TextEditor
{
    public partial class Form1 : Form
    {
        FindForm finder = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1Load(object sender, EventArgs e)
        {
            fontSizeComboBox.SelectedIndex = 3;
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();

            // Get the array of FontFamily objects.
            FontFamily[] fontFamilies = installedFontCollection.Families;
            foreach (FontFamily fontFamily in fontFamilies)
            {
                fontNameComboBox.Items.Add(fontFamily.Name);
            }
            fontNameComboBox.SelectedIndex = 18;
        }

        private void newClick(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void saveClick(object sender, EventArgs e)
        {
            string filename;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                richTextBox.SaveFile(filename);
            }
        }

        private void openClick(object sender, EventArgs e)
        {
            string filename;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                richTextBox.LoadFile(filename);
            }
        }

        private void quitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutClick(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void fontSizeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int start = richTextBox.SelectionStart;
            int length = richTextBox.SelectionLength;
            if (length != 0)
            {
                for (int i = 0; i < length; i++)
                {
                    richTextBox.Select(start + i, 1);
                    Font oldfont = richTextBox.SelectionFont;
                    richTextBox.SelectionFont = new Font(oldfont.FontFamily, Convert.ToInt32(fontSizeComboBox.SelectedItem), oldfont.Style);
                }
                richTextBox.Select(start, length);
            }
            else
            {
                Font oldfont = richTextBox.SelectionFont;
                richTextBox.SelectionFont = new Font(oldfont.FontFamily, Convert.ToInt32(fontSizeComboBox.SelectedItem), oldfont.Style);
            }
        }
        private void fontSizeCombo_Click(object sender, EventArgs e)
        {

        }


        private void fontClick(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox.SelectionFont = fontDialog1.Font;
        }

        private void copyClick(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void pasteClick(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void otmenClick(object sender, EventArgs e)
        {
            richTextBox.Undo();
        }

        private void radomClick(object sender, EventArgs e)
        {
            richTextBox.Redo();
        }

        private void messageClick(object sender, EventArgs e)
        {
            MessageBox.Show("Этот замечательный текстовый редактор разработали ПИ-122");
        }

        private void boldClick(object sender, EventArgs e)
        {
            ChangeStyle(FontStyle.Bold);
        }

        private void italicClick(object sender, EventArgs e)
        {
            ChangeStyle(FontStyle.Italic);
        }

        private void underlineClick(object sender, EventArgs e)
        {
            ChangeStyle(FontStyle.Underline);
        }

        private void strikeoutClick(object sender, EventArgs e)
        {
            ChangeStyle(FontStyle.Strikeout);
        }

        private void ChangeStyle(FontStyle style)
        {
            int start = richTextBox.SelectionStart;
            int length = richTextBox.SelectionLength;
            if (length != 0)
            {
                for (int i = 0; i < length; i++)
                {
                    richTextBox.Select(start + i, 1);
                    Font oldfont = richTextBox.SelectionFont;
                    richTextBox.SelectionFont = new Font(oldfont.FontFamily, oldfont.Size, oldfont.Style ^ style);
                }
                richTextBox.Select(start, length);
            }
            else
            {
                Font oldfont = richTextBox.SelectionFont;
                richTextBox.SelectionFont = new Font(oldfont.FontFamily, oldfont.Size, oldfont.Style ^ style);
            }
        }

        private void growFontSizeClick(object sender, EventArgs e)
        {
            float currentSize = richTextBox.SelectionFont.Size;
            if (fontSizeComboBox.SelectedIndex < fontSizeComboBox.Items.Count - 1)
            {
                fontSizeComboBox.SelectedIndex++;
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, currentSize + 1);
            }
        }

        private void shrinkFontSizeClick(object sender, EventArgs e)
        {
            float currentSize = richTextBox.SelectionFont.Size;
            if (fontSizeComboBox.SelectedIndex > 0)
            {
                fontSizeComboBox.SelectedIndex--;
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, currentSize - 1);
            }
        }

        private void subscriptClick(object sender, EventArgs e)
        {
            if (richTextBox.SelectionCharOffset == 0 || richTextBox.SelectionCharOffset == 10)
                richTextBox.SelectionCharOffset = -10;
            else
                richTextBox.SelectionCharOffset = 0;
        }

        private void superscriptClick(object sender, EventArgs e)
        {
            if (richTextBox.SelectionCharOffset == 0 || richTextBox.SelectionCharOffset == -10)
                richTextBox.SelectionCharOffset = 10;
            else
                richTextBox.SelectionCharOffset = 0;
        }

        private void selectTextColorClick(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                richTextBox.SelectionColor = colorDialog.Color;
        }

        private void highlightTextColorClick(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                richTextBox.SelectionBackColor = colorDialog.Color;
        }

        private void decreaseIndentClick(object sender, EventArgs e)
        {
            if (richTextBox.SelectionIndent > 0)
            {
                richTextBox.SelectionIndent -= 10;
            }
        }

        private void increaseIndentClick(object sender, EventArgs e)
        {
            if (richTextBox.SelectionIndent + 10 < richTextBox.Width)
                richTextBox.SelectionIndent += 10;
        }

        private void startListClick(object sender, EventArgs e)
        {
            if (richTextBox.SelectionBullet == false)
            {
                richTextBox.SelectionBullet = true;
            }
            else
                richTextBox.SelectionBullet = false;
        }

        private void leftAlignmentClick(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centerAlignmentClick(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rightAlignmentClick(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void pasteImageClick(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png";
                dialog.Title = "Выберите изображение";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(dialog.FileName);
                    Clipboard.SetImage(img);
                    richTextBox.Paste();
                }
            }
        }

        private void pasteDateTimeClick(object sender, EventArgs e)
        {
            string dateTime = DateTime.Now.ToString();
            richTextBox.AppendText(dateTime);
        }

        private void insertObjectClick(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "All Files|*.*";
                dialog.Title = "Выбирите файл";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    IDataObject dataObject = new DataObject();
                    dataObject.SetData(DataFormats.FileDrop, new string[] { dialog.FileName });
                    Clipboard.SetDataObject(dataObject);
                    richTextBox.Paste();
                }
            }
        }

        private void findClick(object sender, EventArgs e)
        {
            if (finder == null)
            {
                finder = new FindForm();
                finder.Find += FindEventHandler;
                finder.FormClosed += (s, args) => finder = null;
                finder.Show();
            }
            else
                finder.BringToFront();
        }

        private bool FindEventHandler(object obj, FindEventArgs args)
        {
            int posCurrent = richTextBox.SelectionStart + richTextBox.SelectionLength;

            RichTextBoxFinds argFind = RichTextBoxFinds.None;
            if (args.IsOnlyFullWord && args.IsWithRegister)
                argFind = RichTextBoxFinds.WholeWord | RichTextBoxFinds.MatchCase;
            else if (args.IsOnlyFullWord)
                argFind = RichTextBoxFinds.WholeWord;
            else if (args.IsWithRegister)
                argFind = RichTextBoxFinds.MatchCase;

            int posFind = richTextBox.Find(
                args.FindValue,
                posCurrent,
                argFind
                );

            if (posFind == -1)
            {
                richTextBox.SelectionStart = 0;
                richTextBox.SelectionLength = 0;
                MessageBox.Show("Достигнут конец документа.");
                return false;
            }

            richTextBox.Select(posFind, args.FindValue.Length);
            richTextBox.SelectionColor = Color.Red;
            return true;
        }

        private void fontNameComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            int start = richTextBox.SelectionStart;
            int length = richTextBox.SelectionLength;
            if (length != 0)
            {
                for (int i = 0; i < length; i++)
                {
                    richTextBox.Select(start + i, 1);
                    Font oldfont = richTextBox.SelectionFont;
                    richTextBox.SelectionFont = new Font(fontNameComboBox.SelectedItem.ToString(), Convert.ToInt32(fontSizeComboBox.SelectedItem), oldfont.Style);
                }
                richTextBox.Select(start, length);
            }
            else
            {
                Font oldfont = richTextBox.SelectionFont;
                richTextBox.SelectionFont = new Font(fontNameComboBox.SelectedItem.ToString(), Convert.ToInt32(fontSizeComboBox.SelectedItem), oldfont.Style);
            }
        }

        private void fontNameComboBoxClick(object sender, EventArgs e) { }
    }
}

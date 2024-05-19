using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class FindForm : Form
    {
        public event FindEvent Find;

        public FindForm()
        {
            InitializeComponent();
            ChekStateFindText();
        }

        private void FindForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void FindNextClick(object sender, EventArgs e)
        {
            Find(this, new FindEventArgs
            {
                IsOnlyFullWord = onlyFullWordCheckBox.Checked,
                IsWithRegister = withRegisterCheckBox.Checked,
                FindValue = textBox.Text
            });
        }

        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            ChekStateFindText();
        }

        private void ChekStateFindText()
        {
            if (textBox.TextLength == 0)
                findNextButton.Enabled = false;
            else 
                findNextButton.Enabled = true;
        }
    }
}

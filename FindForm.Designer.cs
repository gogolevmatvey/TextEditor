namespace TextEditor
{
    partial class FindForm
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.findNextButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.onlyFullWordCheckBox = new System.Windows.Forms.CheckBox();
            this.withRegisterCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(57, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(189, 20);
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Найти:";
            // 
            // findNextButton
            // 
            this.findNextButton.Location = new System.Drawing.Point(280, 10);
            this.findNextButton.Name = "findNextButton";
            this.findNextButton.Size = new System.Drawing.Size(95, 23);
            this.findNextButton.TabIndex = 2;
            this.findNextButton.Text = "Найти далее";
            this.findNextButton.UseVisualStyleBackColor = true;
            this.findNextButton.Click += new System.EventHandler(this.FindNextClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(280, 39);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelClick);
            // 
            // onlyFullWordCheckBox
            // 
            this.onlyFullWordCheckBox.AutoSize = true;
            this.onlyFullWordCheckBox.Location = new System.Drawing.Point(13, 45);
            this.onlyFullWordCheckBox.Name = "onlyFullWordCheckBox";
            this.onlyFullWordCheckBox.Size = new System.Drawing.Size(143, 17);
            this.onlyFullWordCheckBox.TabIndex = 4;
            this.onlyFullWordCheckBox.Text = "Только слово целиком";
            this.onlyFullWordCheckBox.UseVisualStyleBackColor = true;
            // 
            // withRegisterCheckBox
            // 
            this.withRegisterCheckBox.AutoSize = true;
            this.withRegisterCheckBox.Location = new System.Drawing.Point(13, 68);
            this.withRegisterCheckBox.Name = "withRegisterCheckBox";
            this.withRegisterCheckBox.Size = new System.Drawing.Size(120, 17);
            this.withRegisterCheckBox.TabIndex = 5;
            this.withRegisterCheckBox.Text = "С учетом регистра";
            this.withRegisterCheckBox.UseVisualStyleBackColor = true;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 93);
            this.Controls.Add(this.withRegisterCheckBox);
            this.Controls.Add(this.onlyFullWordCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.findNextButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Name = "FindForm";
            this.Text = "Найти";
            this.Load += new System.EventHandler(this.FindForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findNextButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox onlyFullWordCheckBox;
        private System.Windows.Forms.CheckBox withRegisterCheckBox;
    }
}
namespace TextEditor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fontNameComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.fontSizeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.growFontSizeButton = new System.Windows.Forms.ToolStripButton();
            this.shrinkFontSizeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.strikeoutButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.subscriptButton = new System.Windows.Forms.ToolStripButton();
            this.superScriptButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectColorClick = new System.Windows.Forms.ToolStripButton();
            this.selectTextHighlightButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.decreaseIndentButton = new System.Windows.Forms.ToolStripButton();
            this.increaseIndentButton = new System.Windows.Forms.ToolStripButton();
            this.startListButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.leftAlignmentButton = new System.Windows.Forms.ToolStripButton();
            this.centerAlignmentButton = new System.Windows.Forms.ToolStripButton();
            this.rightAlignmentButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.pasteImageButton = new System.Windows.Forms.ToolStripButton();
            this.pasteDateTimeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.findButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.вырезатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.новыйToolStripMenuItem.Text = "Новый";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.newClick);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.openClick);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.saveClick);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.quitClick);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.отменитьToolStripMenuItem,
            this.вернутьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.cutClick);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.copyClick);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.pasteClick);
            // 
            // отменитьToolStripMenuItem
            // 
            this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.отменитьToolStripMenuItem.Text = "Отменить";
            this.отменитьToolStripMenuItem.Click += new System.EventHandler(this.otmenClick);
            // 
            // вернутьToolStripMenuItem
            // 
            this.вернутьToolStripMenuItem.Name = "вернутьToolStripMenuItem";
            this.вернутьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.вернутьToolStripMenuItem.Text = "Вернуть";
            this.вернутьToolStripMenuItem.Click += new System.EventHandler(this.radomClick);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шрифтToolStripMenuItem,
            this.цветToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.шрифтToolStripMenuItem.Text = "Шрифт...";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.fontClick);
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.цветToolStripMenuItem.Text = "Цвет...";
            this.цветToolStripMenuItem.Click += new System.EventHandler(this.selectTextColorClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе...";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.messageClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.fontNameComboBox,
            this.fontSizeComboBox,
            this.growFontSizeButton,
            this.shrinkFontSizeButton,
            this.toolStripSeparator2,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.strikeoutButton,
            this.toolStripSeparator3,
            this.subscriptButton,
            this.superScriptButton,
            this.toolStripSeparator4,
            this.selectColorClick,
            this.selectTextHighlightButton,
            this.toolStripSeparator5,
            this.decreaseIndentButton,
            this.increaseIndentButton,
            this.startListButton,
            this.toolStripSeparator6,
            this.leftAlignmentButton,
            this.centerAlignmentButton,
            this.rightAlignmentButton,
            this.toolStripSeparator7,
            this.pasteImageButton,
            this.pasteDateTimeButton,
            this.toolStripSeparator8,
            this.findButton});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(600, 108);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Новый";
            this.toolStripButton1.Click += new System.EventHandler(this.newClick);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Открыть";
            this.toolStripButton2.Click += new System.EventHandler(this.openClick);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "Сохранить как";
            this.toolStripButton3.Click += new System.EventHandler(this.saveClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // fontNameComboBox
            // 
            this.fontNameComboBox.Name = "fontNameComboBox";
            this.fontNameComboBox.Size = new System.Drawing.Size(121, 23);
            this.fontNameComboBox.SelectedIndexChanged += new System.EventHandler(this.fontNameComboBoxSelectedIndexChanged);
            this.fontNameComboBox.Click += new System.EventHandler(this.fontNameComboBoxClick);
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.Size = new System.Drawing.Size(75, 23);
            this.fontSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.fontSizeCombo_SelectedIndexChanged);
            this.fontSizeComboBox.Click += new System.EventHandler(this.fontSizeCombo_Click);
            // 
            // growFontSizeButton
            // 
            this.growFontSizeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.growFontSizeButton.Image = global::TextEditor.Properties.Resources.icons8_увеличить_шрифт_50;
            this.growFontSizeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.growFontSizeButton.Name = "growFontSizeButton";
            this.growFontSizeButton.Size = new System.Drawing.Size(24, 24);
            this.growFontSizeButton.Text = "toolStripButton7";
            this.growFontSizeButton.Click += new System.EventHandler(this.growFontSizeClick);
            // 
            // shrinkFontSizeButton
            // 
            this.shrinkFontSizeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shrinkFontSizeButton.Image = global::TextEditor.Properties.Resources.icons8_уменьшить_шрифт_50;
            this.shrinkFontSizeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.shrinkFontSizeButton.Name = "shrinkFontSizeButton";
            this.shrinkFontSizeButton.Size = new System.Drawing.Size(24, 24);
            this.shrinkFontSizeButton.Text = "toolStripButton7";
            this.shrinkFontSizeButton.Click += new System.EventHandler(this.shrinkFontSizeClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.boldClick);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.Click += new System.EventHandler(this.italicClick);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton6.Text = "toolStripButton6";
            this.toolStripButton6.Click += new System.EventHandler(this.underlineClick);
            // 
            // strikeoutButton
            // 
            this.strikeoutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.strikeoutButton.Image = global::TextEditor.Properties.Resources.icons8_зачеркивание_50;
            this.strikeoutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strikeoutButton.Name = "strikeoutButton";
            this.strikeoutButton.Size = new System.Drawing.Size(24, 24);
            this.strikeoutButton.Text = "toolStripButton7";
            this.strikeoutButton.Click += new System.EventHandler(this.strikeoutClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // subscriptButton
            // 
            this.subscriptButton.CheckOnClick = true;
            this.subscriptButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.subscriptButton.Image = global::TextEditor.Properties.Resources.icons8_нижний_индекс_50;
            this.subscriptButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.subscriptButton.Name = "subscriptButton";
            this.subscriptButton.Size = new System.Drawing.Size(24, 24);
            this.subscriptButton.Text = "toolStripButton7";
            this.subscriptButton.Click += new System.EventHandler(this.subscriptClick);
            // 
            // superScriptButton
            // 
            this.superScriptButton.CheckOnClick = true;
            this.superScriptButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.superScriptButton.Image = global::TextEditor.Properties.Resources.icons8_верхний_индекс_50;
            this.superScriptButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.superScriptButton.Name = "superScriptButton";
            this.superScriptButton.Size = new System.Drawing.Size(24, 24);
            this.superScriptButton.Text = "toolStripButton8";
            this.superScriptButton.Click += new System.EventHandler(this.superscriptClick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // selectColorClick
            // 
            this.selectColorClick.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectColorClick.Image = global::TextEditor.Properties.Resources.icons8_цвет_текста_50;
            this.selectColorClick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectColorClick.Name = "selectColorClick";
            this.selectColorClick.Size = new System.Drawing.Size(24, 24);
            this.selectColorClick.Text = "toolStripButton7";
            this.selectColorClick.Click += new System.EventHandler(this.selectTextColorClick);
            // 
            // selectTextHighlightButton
            // 
            this.selectTextHighlightButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectTextHighlightButton.Image = global::TextEditor.Properties.Resources.icons8_место_выделение_64;
            this.selectTextHighlightButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectTextHighlightButton.Name = "selectTextHighlightButton";
            this.selectTextHighlightButton.Size = new System.Drawing.Size(24, 24);
            this.selectTextHighlightButton.Text = "toolStripButton7";
            this.selectTextHighlightButton.Click += new System.EventHandler(this.highlightTextColorClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
            // 
            // decreaseIndentButton
            // 
            this.decreaseIndentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.decreaseIndentButton.Image = global::TextEditor.Properties.Resources.icons8_отступ_50;
            this.decreaseIndentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decreaseIndentButton.Name = "decreaseIndentButton";
            this.decreaseIndentButton.Size = new System.Drawing.Size(24, 24);
            this.decreaseIndentButton.Text = "toolStripButton7";
            this.decreaseIndentButton.Click += new System.EventHandler(this.decreaseIndentClick);
            // 
            // increaseIndentButton
            // 
            this.increaseIndentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.increaseIndentButton.Image = global::TextEditor.Properties.Resources.icons8_отступ_501;
            this.increaseIndentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.increaseIndentButton.Name = "increaseIndentButton";
            this.increaseIndentButton.Size = new System.Drawing.Size(24, 24);
            this.increaseIndentButton.Text = "toolStripButton7";
            this.increaseIndentButton.Click += new System.EventHandler(this.increaseIndentClick);
            // 
            // startListButton
            // 
            this.startListButton.CheckOnClick = true;
            this.startListButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startListButton.Image = global::TextEditor.Properties.Resources.icons8_список_50;
            this.startListButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startListButton.Name = "startListButton";
            this.startListButton.Size = new System.Drawing.Size(24, 24);
            this.startListButton.Text = "toolStripButton7";
            this.startListButton.Click += new System.EventHandler(this.startListClick);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 23);
            // 
            // leftAlignmentButton
            // 
            this.leftAlignmentButton.CheckOnClick = true;
            this.leftAlignmentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftAlignmentButton.Image = global::TextEditor.Properties.Resources.icons8_выровнять_по_левому_краю_50__1_;
            this.leftAlignmentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftAlignmentButton.Name = "leftAlignmentButton";
            this.leftAlignmentButton.Size = new System.Drawing.Size(24, 24);
            this.leftAlignmentButton.Text = "toolStripButton7";
            this.leftAlignmentButton.Click += new System.EventHandler(this.leftAlignmentClick);
            // 
            // centerAlignmentButton
            // 
            this.centerAlignmentButton.CheckOnClick = true;
            this.centerAlignmentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.centerAlignmentButton.Image = global::TextEditor.Properties.Resources.icons8_выровнять_по_центру_50__1_;
            this.centerAlignmentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.centerAlignmentButton.Name = "centerAlignmentButton";
            this.centerAlignmentButton.Size = new System.Drawing.Size(24, 24);
            this.centerAlignmentButton.Text = "toolStripButton8";
            this.centerAlignmentButton.Click += new System.EventHandler(this.centerAlignmentClick);
            // 
            // rightAlignmentButton
            // 
            this.rightAlignmentButton.CheckOnClick = true;
            this.rightAlignmentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rightAlignmentButton.Image = global::TextEditor.Properties.Resources.icons8_выровнять_по_левому_краю_50__1_1;
            this.rightAlignmentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rightAlignmentButton.Name = "rightAlignmentButton";
            this.rightAlignmentButton.Size = new System.Drawing.Size(24, 24);
            this.rightAlignmentButton.Text = "toolStripButton9";
            this.rightAlignmentButton.Click += new System.EventHandler(this.rightAlignmentClick);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 23);
            // 
            // pasteImageButton
            // 
            this.pasteImageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteImageButton.Image = global::TextEditor.Properties.Resources.icons8_вставить_растровое_изображение_96;
            this.pasteImageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteImageButton.Name = "pasteImageButton";
            this.pasteImageButton.Size = new System.Drawing.Size(24, 24);
            this.pasteImageButton.Text = "toolStripButton7";
            this.pasteImageButton.Click += new System.EventHandler(this.pasteImageClick);
            // 
            // pasteDateTimeButton
            // 
            this.pasteDateTimeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteDateTimeButton.Image = global::TextEditor.Properties.Resources.icons8_дата_50;
            this.pasteDateTimeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteDateTimeButton.Name = "pasteDateTimeButton";
            this.pasteDateTimeButton.Size = new System.Drawing.Size(24, 24);
            this.pasteDateTimeButton.Text = "toolStripButton7";
            this.pasteDateTimeButton.Click += new System.EventHandler(this.pasteDateTimeClick);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 23);
            // 
            // findButton
            // 
            this.findButton.Image = global::TextEditor.Properties.Resources.icons8_поиск_50;
            this.findButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(66, 24);
            this.findButton.Text = "Поиск";
            this.findButton.Click += new System.EventHandler(this.findClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 597);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(600, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // richTextBox
            // 
            this.richTextBox.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 132);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox.Size = new System.Drawing.Size(600, 465);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вырезатьToolStripMenuItem1,
            this.копироватьToolStripMenuItem1,
            this.вставитьToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 70);
            // 
            // вырезатьToolStripMenuItem1
            // 
            this.вырезатьToolStripMenuItem1.Name = "вырезатьToolStripMenuItem1";
            this.вырезатьToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.вырезатьToolStripMenuItem1.Text = "Вырезать";
            this.вырезатьToolStripMenuItem1.Click += new System.EventHandler(this.cutClick);
            // 
            // копироватьToolStripMenuItem1
            // 
            this.копироватьToolStripMenuItem1.Name = "копироватьToolStripMenuItem1";
            this.копироватьToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.копироватьToolStripMenuItem1.Text = "Копировать";
            this.копироватьToolStripMenuItem1.Click += new System.EventHandler(this.copyClick);
            // 
            // вставитьToolStripMenuItem1
            // 
            this.вставитьToolStripMenuItem1.Name = "вставитьToolStripMenuItem1";
            this.вставитьToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.вставитьToolStripMenuItem1.Text = "Вставить";
            this.вставитьToolStripMenuItem1.Click += new System.EventHandler(this.pasteClick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Текстовые документы|*.rtf|Все файлы|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 619);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Текстовый редактор";
            this.Load += new System.EventHandler(this.Form1Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripComboBox fontSizeComboBox;
        private System.Windows.Forms.ToolStripComboBox fontNameComboBox;
        private System.Windows.Forms.ToolStripButton strikeoutButton;
        private System.Windows.Forms.ToolStripButton growFontSizeButton;
        private System.Windows.Forms.ToolStripButton shrinkFontSizeButton;
        private System.Windows.Forms.ToolStripButton subscriptButton;
        private System.Windows.Forms.ToolStripButton superScriptButton;
        private System.Windows.Forms.ToolStripButton selectColorClick;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton selectTextHighlightButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton decreaseIndentButton;
        private System.Windows.Forms.ToolStripButton increaseIndentButton;
        private System.Windows.Forms.ToolStripButton startListButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton leftAlignmentButton;
        private System.Windows.Forms.ToolStripButton centerAlignmentButton;
        private System.Windows.Forms.ToolStripButton rightAlignmentButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton pasteImageButton;
        private System.Windows.Forms.ToolStripButton pasteDateTimeButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton findButton;
    }
}


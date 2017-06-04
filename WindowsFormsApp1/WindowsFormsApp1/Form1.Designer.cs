namespace LazyButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GroupButtonsIn = new System.Windows.Forms.GroupBox();
            this.ListGroupButtonsIn = new MetroFramework.Controls.MetroTabControl();
            this.LazyButton = new MetroFramework.Controls.MetroTabPage();
            this.LazyButtonLabel = new MetroFramework.Controls.MetroLabel();
            this.LazyButtonButtonCancel = new MetroFramework.Controls.MetroButton();
            this.LazyButtonButtonОК = new MetroFramework.Controls.MetroButton();
            this.NumMultiply = new MetroFramework.Controls.MetroTabPage();
            this.NumEnterLabel = new MetroFramework.Controls.MetroLabel();
            this.NumMultiplyButtonCancel = new MetroFramework.Controls.MetroButton();
            this.NumMultiplyButtonOK = new MetroFramework.Controls.MetroButton();
            this.NumPlus = new MetroFramework.Controls.MetroTabPage();
            this.NumPlusLabel = new MetroFramework.Controls.MetroLabel();
            this.NumPlusButtonCancel = new MetroFramework.Controls.MetroButton();
            this.NumPlusButtonOK = new MetroFramework.Controls.MetroButton();
            this.NumMinus = new MetroFramework.Controls.MetroTabPage();
            this.NumMinusLabel = new MetroFramework.Controls.MetroLabel();
            this.NumMinusButtonCancel = new MetroFramework.Controls.MetroButton();
            this.NumMinusButtonOK = new MetroFramework.Controls.MetroButton();
            this.UserButton = new MetroFramework.Controls.MetroTabPage();
            this.UserButtonTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UserButtonLabel = new MetroFramework.Controls.MetroLabel();
            this.UserButtonButtonCancel = new MetroFramework.Controls.MetroButton();
            this.UserButtonButtonOK = new MetroFramework.Controls.MetroButton();
            this.FAQ = new MetroFramework.Controls.MetroButton();
            this.GroupButtonsOut = new System.Windows.Forms.GroupBox();
            this.ListGroupButtonsOut = new MetroFramework.Controls.MetroTabControl();
            this.Default = new MetroFramework.Controls.MetroTabPage();
            this.DefaultTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.DefaultLabel = new MetroFramework.Controls.MetroLabel();
            this.DefaultButtonSave = new MetroFramework.Controls.MetroButton();
            this.KeyboardFunction = new MetroFramework.Controls.MetroTabPage();
            this.KeyboardFunctionLabel = new MetroFramework.Controls.MetroLabel();
            this.KeyboardFunctionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.KeyboardFunctionButtonSave = new MetroFramework.Controls.MetroButton();
            this.MouseFunction = new MetroFramework.Controls.MetroTabPage();
            this.MouseFunctionComboBox = new MetroFramework.Controls.MetroComboBox();
            this.MouseFunctionLabel = new MetroFramework.Controls.MetroLabel();
            this.MouseFunctionButtonSave = new MetroFramework.Controls.MetroButton();
            this.WINDOWSKeyCombination = new MetroFramework.Controls.MetroTabPage();
            this.WINDOWSKeyCombinationComboBox = new MetroFramework.Controls.MetroComboBox();
            this.WINDOWSKeyCombinationLabel = new MetroFramework.Controls.MetroLabel();
            this.WINDOWSKeyCombinationButtonSave = new MetroFramework.Controls.MetroButton();
            this.LaunchingTheProgram = new MetroFramework.Controls.MetroTabPage();
            this.LaunchingTheProgramFileWayLabel = new MetroFramework.Controls.MetroLabel();
            this.LaunchingTheProgramFileWayTextBox = new MetroFramework.Controls.MetroTextBox();
            this.LaunchingTheProgramButtonOpen = new MetroFramework.Controls.MetroButton();
            this.LaunchingTheProgramTextBox = new MetroFramework.Controls.MetroTextBox();
            this.LaunchingTheProgramLabel = new MetroFramework.Controls.MetroLabel();
            this.LaunchingTheProgramButtonSave = new MetroFramework.Controls.MetroButton();
            this.TestButton = new MetroFramework.Controls.MetroButton();
            this.GroupButtonsIn.SuspendLayout();
            this.ListGroupButtonsIn.SuspendLayout();
            this.LazyButton.SuspendLayout();
            this.NumMultiply.SuspendLayout();
            this.NumPlus.SuspendLayout();
            this.NumMinus.SuspendLayout();
            this.UserButton.SuspendLayout();
            this.GroupButtonsOut.SuspendLayout();
            this.ListGroupButtonsOut.SuspendLayout();
            this.Default.SuspendLayout();
            this.KeyboardFunction.SuspendLayout();
            this.MouseFunction.SuspendLayout();
            this.WINDOWSKeyCombination.SuspendLayout();
            this.LaunchingTheProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupButtonsIn
            // 
            this.GroupButtonsIn.Controls.Add(this.ListGroupButtonsIn);
            this.GroupButtonsIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupButtonsIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.GroupButtonsIn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.GroupButtonsIn.Location = new System.Drawing.Point(20, 60);
            this.GroupButtonsIn.Name = "GroupButtonsIn";
            this.GroupButtonsIn.Size = new System.Drawing.Size(880, 207);
            this.GroupButtonsIn.TabIndex = 2;
            this.GroupButtonsIn.TabStop = false;
            this.GroupButtonsIn.Text = "Вы назначаете на клавишу ...";
            this.GroupButtonsIn.Enter += new System.EventHandler(this.GroupButtonsIn_Enter);
            // 
            // ListGroupButtonsIn
            // 
            this.ListGroupButtonsIn.Controls.Add(this.LazyButton);
            this.ListGroupButtonsIn.Controls.Add(this.NumMultiply);
            this.ListGroupButtonsIn.Controls.Add(this.NumPlus);
            this.ListGroupButtonsIn.Controls.Add(this.NumMinus);
            this.ListGroupButtonsIn.Controls.Add(this.UserButton);
            this.ListGroupButtonsIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListGroupButtonsIn.Location = new System.Drawing.Point(3, 25);
            this.ListGroupButtonsIn.Name = "ListGroupButtonsIn";
            this.ListGroupButtonsIn.SelectedIndex = 1;
            this.ListGroupButtonsIn.Size = new System.Drawing.Size(874, 179);
            this.ListGroupButtonsIn.TabIndex = 0;
            this.ListGroupButtonsIn.TabStop = false;
            this.ListGroupButtonsIn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ListGroupButtonsIn.UseSelectable = true;
            // 
            // LazyButton
            // 
            this.LazyButton.Controls.Add(this.LazyButtonLabel);
            this.LazyButton.Controls.Add(this.LazyButtonButtonCancel);
            this.LazyButton.Controls.Add(this.LazyButtonButtonОК);
            this.LazyButton.HorizontalScrollbarBarColor = true;
            this.LazyButton.HorizontalScrollbarHighlightOnWheel = false;
            this.LazyButton.HorizontalScrollbarSize = 10;
            this.LazyButton.Location = new System.Drawing.Point(4, 38);
            this.LazyButton.Name = "LazyButton";
            this.LazyButton.Size = new System.Drawing.Size(866, 137);
            this.LazyButton.TabIndex = 0;
            this.LazyButton.Text = "LazyButton";
            this.LazyButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LazyButton.VerticalScrollbarBarColor = true;
            this.LazyButton.VerticalScrollbarHighlightOnWheel = false;
            this.LazyButton.VerticalScrollbarSize = 10;
            // 
            // LazyButtonLabel
            // 
            this.LazyButtonLabel.AutoSize = true;
            this.LazyButtonLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LazyButtonLabel.Location = new System.Drawing.Point(270, 45);
            this.LazyButtonLabel.Name = "LazyButtonLabel";
            this.LazyButtonLabel.Size = new System.Drawing.Size(340, 19);
            this.LazyButtonLabel.TabIndex = 4;
            this.LazyButtonLabel.Text = "Дистанционная кнопка, прилагающаяся в комплекте.";
            this.LazyButtonLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LazyButtonLabel.UseStyleColors = true;
            // 
            // LazyButtonButtonCancel
            // 
            this.LazyButtonButtonCancel.Enabled = false;
            this.LazyButtonButtonCancel.Location = new System.Drawing.Point(699, 105);
            this.LazyButtonButtonCancel.Name = "LazyButtonButtonCancel";
            this.LazyButtonButtonCancel.Size = new System.Drawing.Size(127, 29);
            this.LazyButtonButtonCancel.TabIndex = 3;
            this.LazyButtonButtonCancel.TabStop = false;
            this.LazyButtonButtonCancel.Text = "Отменить";
            this.LazyButtonButtonCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LazyButtonButtonCancel.UseSelectable = true;
            this.LazyButtonButtonCancel.Click += new System.EventHandler(this.LazyButtonButtonCancel_Click);
            // 
            // LazyButtonButtonОК
            // 
            this.LazyButtonButtonОК.Location = new System.Drawing.Point(551, 105);
            this.LazyButtonButtonОК.Name = "LazyButtonButtonОК";
            this.LazyButtonButtonОК.Size = new System.Drawing.Size(127, 29);
            this.LazyButtonButtonОК.TabIndex = 2;
            this.LazyButtonButtonОК.TabStop = false;
            this.LazyButtonButtonОК.Text = "Подтвердить";
            this.LazyButtonButtonОК.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LazyButtonButtonОК.UseSelectable = true;
            this.LazyButtonButtonОК.UseStyleColors = true;
            this.LazyButtonButtonОК.Click += new System.EventHandler(this.LazyButtonButtonОК_Click);
            // 
            // NumMultiply
            // 
            this.NumMultiply.Controls.Add(this.NumEnterLabel);
            this.NumMultiply.Controls.Add(this.NumMultiplyButtonCancel);
            this.NumMultiply.Controls.Add(this.NumMultiplyButtonOK);
            this.NumMultiply.HorizontalScrollbarBarColor = true;
            this.NumMultiply.HorizontalScrollbarHighlightOnWheel = false;
            this.NumMultiply.HorizontalScrollbarSize = 10;
            this.NumMultiply.Location = new System.Drawing.Point(4, 38);
            this.NumMultiply.Name = "NumMultiply";
            this.NumMultiply.Size = new System.Drawing.Size(866, 137);
            this.NumMultiply.TabIndex = 1;
            this.NumMultiply.Text = "Num Multiply";
            this.NumMultiply.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NumMultiply.VerticalScrollbarBarColor = true;
            this.NumMultiply.VerticalScrollbarHighlightOnWheel = false;
            this.NumMultiply.VerticalScrollbarSize = 10;
            // 
            // NumEnterLabel
            // 
            this.NumEnterLabel.AutoSize = true;
            this.NumEnterLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.NumEnterLabel.Location = new System.Drawing.Point(350, 45);
            this.NumEnterLabel.Name = "NumEnterLabel";
            this.NumEnterLabel.Size = new System.Drawing.Size(170, 19);
            this.NumEnterLabel.TabIndex = 6;
            this.NumEnterLabel.Text = "Нажатие \" * \" на NumLock.";
            this.NumEnterLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NumEnterLabel.UseStyleColors = true;
            // 
            // NumMultiplyButtonCancel
            // 
            this.NumMultiplyButtonCancel.Enabled = false;
            this.NumMultiplyButtonCancel.Location = new System.Drawing.Point(699, 105);
            this.NumMultiplyButtonCancel.Name = "NumMultiplyButtonCancel";
            this.NumMultiplyButtonCancel.Size = new System.Drawing.Size(127, 29);
            this.NumMultiplyButtonCancel.TabIndex = 5;
            this.NumMultiplyButtonCancel.TabStop = false;
            this.NumMultiplyButtonCancel.Text = "Отменить";
            this.NumMultiplyButtonCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NumMultiplyButtonCancel.UseSelectable = true;
            this.NumMultiplyButtonCancel.Click += new System.EventHandler(this.NumMultiplyButtonCancel_Click);
            // 
            // NumMultiplyButtonOK
            // 
            this.NumMultiplyButtonOK.Location = new System.Drawing.Point(551, 105);
            this.NumMultiplyButtonOK.Name = "NumMultiplyButtonOK";
            this.NumMultiplyButtonOK.Size = new System.Drawing.Size(127, 29);
            this.NumMultiplyButtonOK.TabIndex = 4;
            this.NumMultiplyButtonOK.TabStop = false;
            this.NumMultiplyButtonOK.Text = "Подтвердить";
            this.NumMultiplyButtonOK.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NumMultiplyButtonOK.UseSelectable = true;
            this.NumMultiplyButtonOK.UseStyleColors = true;
            this.NumMultiplyButtonOK.Click += new System.EventHandler(this.NumMultiplyButtonOK_Click);
            // 
            // NumPlus
            // 
            this.NumPlus.Controls.Add(this.NumPlusLabel);
            this.NumPlus.Controls.Add(this.NumPlusButtonCancel);
            this.NumPlus.Controls.Add(this.NumPlusButtonOK);
            this.NumPlus.HorizontalScrollbarBarColor = true;
            this.NumPlus.HorizontalScrollbarHighlightOnWheel = false;
            this.NumPlus.HorizontalScrollbarSize = 10;
            this.NumPlus.Location = new System.Drawing.Point(4, 38);
            this.NumPlus.Name = "NumPlus";
            this.NumPlus.Size = new System.Drawing.Size(866, 137);
            this.NumPlus.TabIndex = 2;
            this.NumPlus.Text = "Num +";
            this.NumPlus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NumPlus.VerticalScrollbarBarColor = true;
            this.NumPlus.VerticalScrollbarHighlightOnWheel = false;
            this.NumPlus.VerticalScrollbarSize = 10;
            // 
            // NumPlusLabel
            // 
            this.NumPlusLabel.AutoSize = true;
            this.NumPlusLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.NumPlusLabel.Location = new System.Drawing.Point(350, 45);
            this.NumPlusLabel.Name = "NumPlusLabel";
            this.NumPlusLabel.Size = new System.Drawing.Size(165, 19);
            this.NumPlusLabel.TabIndex = 7;
            this.NumPlusLabel.Text = "Нажатие \"+\" на NumLock.";
            this.NumPlusLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NumPlusLabel.UseStyleColors = true;
            // 
            // NumPlusButtonCancel
            // 
            this.NumPlusButtonCancel.Enabled = false;
            this.NumPlusButtonCancel.Location = new System.Drawing.Point(699, 105);
            this.NumPlusButtonCancel.Name = "NumPlusButtonCancel";
            this.NumPlusButtonCancel.Size = new System.Drawing.Size(127, 29);
            this.NumPlusButtonCancel.TabIndex = 5;
            this.NumPlusButtonCancel.TabStop = false;
            this.NumPlusButtonCancel.Text = "Отменить";
            this.NumPlusButtonCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NumPlusButtonCancel.UseSelectable = true;
            this.NumPlusButtonCancel.Click += new System.EventHandler(this.NumPlusButtonCancel_Click);
            // 
            // NumPlusButtonOK
            // 
            this.NumPlusButtonOK.Location = new System.Drawing.Point(551, 105);
            this.NumPlusButtonOK.Name = "NumPlusButtonOK";
            this.NumPlusButtonOK.Size = new System.Drawing.Size(127, 29);
            this.NumPlusButtonOK.TabIndex = 4;
            this.NumPlusButtonOK.TabStop = false;
            this.NumPlusButtonOK.Text = "Подтвердить";
            this.NumPlusButtonOK.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NumPlusButtonOK.UseSelectable = true;
            this.NumPlusButtonOK.UseStyleColors = true;
            this.NumPlusButtonOK.Click += new System.EventHandler(this.NumPlusButtonOK_Click);
            // 
            // NumMinus
            // 
            this.NumMinus.Controls.Add(this.NumMinusLabel);
            this.NumMinus.Controls.Add(this.NumMinusButtonCancel);
            this.NumMinus.Controls.Add(this.NumMinusButtonOK);
            this.NumMinus.HorizontalScrollbarBarColor = true;
            this.NumMinus.HorizontalScrollbarHighlightOnWheel = false;
            this.NumMinus.HorizontalScrollbarSize = 10;
            this.NumMinus.Location = new System.Drawing.Point(4, 38);
            this.NumMinus.Name = "NumMinus";
            this.NumMinus.Size = new System.Drawing.Size(866, 137);
            this.NumMinus.TabIndex = 3;
            this.NumMinus.Text = "Num -";
            this.NumMinus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NumMinus.VerticalScrollbarBarColor = true;
            this.NumMinus.VerticalScrollbarHighlightOnWheel = false;
            this.NumMinus.VerticalScrollbarSize = 10;
            // 
            // NumMinusLabel
            // 
            this.NumMinusLabel.AutoSize = true;
            this.NumMinusLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.NumMinusLabel.Location = new System.Drawing.Point(350, 45);
            this.NumMinusLabel.Name = "NumMinusLabel";
            this.NumMinusLabel.Size = new System.Drawing.Size(162, 19);
            this.NumMinusLabel.TabIndex = 8;
            this.NumMinusLabel.Text = "Нажатие \"-\" на NumLock.";
            this.NumMinusLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NumMinusLabel.UseStyleColors = true;
            // 
            // NumMinusButtonCancel
            // 
            this.NumMinusButtonCancel.Enabled = false;
            this.NumMinusButtonCancel.Location = new System.Drawing.Point(699, 105);
            this.NumMinusButtonCancel.Name = "NumMinusButtonCancel";
            this.NumMinusButtonCancel.Size = new System.Drawing.Size(127, 29);
            this.NumMinusButtonCancel.TabIndex = 5;
            this.NumMinusButtonCancel.TabStop = false;
            this.NumMinusButtonCancel.Text = "Отменить";
            this.NumMinusButtonCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NumMinusButtonCancel.UseSelectable = true;
            this.NumMinusButtonCancel.Click += new System.EventHandler(this.NumMinusButtonCancel_Click);
            // 
            // NumMinusButtonOK
            // 
            this.NumMinusButtonOK.Location = new System.Drawing.Point(551, 105);
            this.NumMinusButtonOK.Name = "NumMinusButtonOK";
            this.NumMinusButtonOK.Size = new System.Drawing.Size(127, 29);
            this.NumMinusButtonOK.TabIndex = 4;
            this.NumMinusButtonOK.TabStop = false;
            this.NumMinusButtonOK.Text = "Подтвердить";
            this.NumMinusButtonOK.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NumMinusButtonOK.UseSelectable = true;
            this.NumMinusButtonOK.UseStyleColors = true;
            this.NumMinusButtonOK.Click += new System.EventHandler(this.NumMinusButtonOK_Click);
            // 
            // UserButton
            // 
            this.UserButton.Controls.Add(this.UserButtonTextBox);
            this.UserButton.Controls.Add(this.UserButtonLabel);
            this.UserButton.Controls.Add(this.UserButtonButtonCancel);
            this.UserButton.Controls.Add(this.UserButtonButtonOK);
            this.UserButton.HorizontalScrollbarBarColor = true;
            this.UserButton.HorizontalScrollbarHighlightOnWheel = false;
            this.UserButton.HorizontalScrollbarSize = 10;
            this.UserButton.Location = new System.Drawing.Point(4, 38);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(866, 137);
            this.UserButton.TabIndex = 4;
            this.UserButton.Text = "Назначить свою";
            this.UserButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UserButton.VerticalScrollbarBarColor = true;
            this.UserButton.VerticalScrollbarHighlightOnWheel = false;
            this.UserButton.VerticalScrollbarSize = 10;
            // 
            // UserButtonTextBox
            // 
            // 
            // 
            // 
            this.UserButtonTextBox.CustomButton.Image = null;
            this.UserButtonTextBox.CustomButton.Location = new System.Drawing.Point(253, 1);
            this.UserButtonTextBox.CustomButton.Name = "";
            this.UserButtonTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UserButtonTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserButtonTextBox.CustomButton.TabIndex = 1;
            this.UserButtonTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserButtonTextBox.CustomButton.UseSelectable = true;
            this.UserButtonTextBox.CustomButton.Visible = false;
            this.UserButtonTextBox.Lines = new string[0];
            this.UserButtonTextBox.Location = new System.Drawing.Point(304, 55);
            this.UserButtonTextBox.MaxLength = 32767;
            this.UserButtonTextBox.Name = "UserButtonTextBox";
            this.UserButtonTextBox.PasswordChar = '\0';
            this.UserButtonTextBox.ReadOnly = true;
            this.UserButtonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserButtonTextBox.SelectedText = "";
            this.UserButtonTextBox.SelectionLength = 0;
            this.UserButtonTextBox.SelectionStart = 0;
            this.UserButtonTextBox.ShortcutsEnabled = true;
            this.UserButtonTextBox.Size = new System.Drawing.Size(275, 23);
            this.UserButtonTextBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.UserButtonTextBox.TabIndex = 10;
            this.UserButtonTextBox.TabStop = false;
            this.UserButtonTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UserButtonTextBox.UseSelectable = true;
            this.UserButtonTextBox.UseStyleColors = true;
            this.UserButtonTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserButtonTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.UserButtonTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserButtonTextBox_KeyDown);
            // 
            // UserButtonLabel
            // 
            this.UserButtonLabel.AutoSize = true;
            this.UserButtonLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.UserButtonLabel.Location = new System.Drawing.Point(304, 33);
            this.UserButtonLabel.Name = "UserButtonLabel";
            this.UserButtonLabel.Size = new System.Drawing.Size(234, 19);
            this.UserButtonLabel.TabIndex = 9;
            this.UserButtonLabel.Text = "Нажмите клавишу или их сочетание:";
            this.UserButtonLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UserButtonLabel.UseStyleColors = true;
            // 
            // UserButtonButtonCancel
            // 
            this.UserButtonButtonCancel.Enabled = false;
            this.UserButtonButtonCancel.Location = new System.Drawing.Point(699, 105);
            this.UserButtonButtonCancel.Name = "UserButtonButtonCancel";
            this.UserButtonButtonCancel.Size = new System.Drawing.Size(127, 29);
            this.UserButtonButtonCancel.TabIndex = 5;
            this.UserButtonButtonCancel.TabStop = false;
            this.UserButtonButtonCancel.Text = "Отменить";
            this.UserButtonButtonCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UserButtonButtonCancel.UseSelectable = true;
            this.UserButtonButtonCancel.Click += new System.EventHandler(this.UserButtonButtonCancel_Click);
            // 
            // UserButtonButtonOK
            // 
            this.UserButtonButtonOK.Location = new System.Drawing.Point(551, 105);
            this.UserButtonButtonOK.Name = "UserButtonButtonOK";
            this.UserButtonButtonOK.Size = new System.Drawing.Size(127, 29);
            this.UserButtonButtonOK.TabIndex = 4;
            this.UserButtonButtonOK.TabStop = false;
            this.UserButtonButtonOK.Text = "Подтвердить";
            this.UserButtonButtonOK.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UserButtonButtonOK.UseSelectable = true;
            this.UserButtonButtonOK.UseStyleColors = true;
            this.UserButtonButtonOK.Click += new System.EventHandler(this.UserButtonButtonOK_Click);
            // 
            // FAQ
            // 
            this.FAQ.Location = new System.Drawing.Point(774, 23);
            this.FAQ.Name = "FAQ";
            this.FAQ.Size = new System.Drawing.Size(79, 31);
            this.FAQ.TabIndex = 3;
            this.FAQ.TabStop = false;
            this.FAQ.Text = "F.A.Q.";
            this.FAQ.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FAQ.UseSelectable = true;
            this.FAQ.Click += new System.EventHandler(this.FAQ_Click);
            // 
            // GroupButtonsOut
            // 
            this.GroupButtonsOut.Controls.Add(this.ListGroupButtonsOut);
            this.GroupButtonsOut.Enabled = false;
            this.GroupButtonsOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.GroupButtonsOut.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.GroupButtonsOut.Location = new System.Drawing.Point(20, 286);
            this.GroupButtonsOut.Name = "GroupButtonsOut";
            this.GroupButtonsOut.Size = new System.Drawing.Size(880, 331);
            this.GroupButtonsOut.TabIndex = 4;
            this.GroupButtonsOut.TabStop = false;
            this.GroupButtonsOut.Text = "Назначение клавиши ...";
            this.GroupButtonsOut.Enter += new System.EventHandler(this.GroupButtonsOut_Enter);
            // 
            // ListGroupButtonsOut
            // 
            this.ListGroupButtonsOut.Controls.Add(this.Default);
            this.ListGroupButtonsOut.Controls.Add(this.KeyboardFunction);
            this.ListGroupButtonsOut.Controls.Add(this.MouseFunction);
            this.ListGroupButtonsOut.Controls.Add(this.WINDOWSKeyCombination);
            this.ListGroupButtonsOut.Controls.Add(this.LaunchingTheProgram);
            this.ListGroupButtonsOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListGroupButtonsOut.Location = new System.Drawing.Point(3, 25);
            this.ListGroupButtonsOut.Name = "ListGroupButtonsOut";
            this.ListGroupButtonsOut.SelectedIndex = 4;
            this.ListGroupButtonsOut.Size = new System.Drawing.Size(874, 303);
            this.ListGroupButtonsOut.Style = MetroFramework.MetroColorStyle.Green;
            this.ListGroupButtonsOut.TabIndex = 0;
            this.ListGroupButtonsOut.TabStop = false;
            this.ListGroupButtonsOut.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ListGroupButtonsOut.UseSelectable = true;
            // 
            // Default
            // 
            this.Default.Controls.Add(this.DefaultTextBox1);
            this.Default.Controls.Add(this.DefaultLabel);
            this.Default.Controls.Add(this.DefaultButtonSave);
            this.Default.HorizontalScrollbarBarColor = true;
            this.Default.HorizontalScrollbarHighlightOnWheel = false;
            this.Default.HorizontalScrollbarSize = 10;
            this.Default.Location = new System.Drawing.Point(4, 38);
            this.Default.Name = "Default";
            this.Default.Size = new System.Drawing.Size(866, 261);
            this.Default.TabIndex = 0;
            this.Default.Text = "По умолчанию";
            this.Default.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Default.VerticalScrollbarBarColor = true;
            this.Default.VerticalScrollbarHighlightOnWheel = false;
            this.Default.VerticalScrollbarSize = 10;
            // 
            // DefaultTextBox1
            // 
            // 
            // 
            // 
            this.DefaultTextBox1.CustomButton.Image = null;
            this.DefaultTextBox1.CustomButton.Location = new System.Drawing.Point(253, 1);
            this.DefaultTextBox1.CustomButton.Name = "";
            this.DefaultTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DefaultTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DefaultTextBox1.CustomButton.TabIndex = 1;
            this.DefaultTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DefaultTextBox1.CustomButton.UseSelectable = true;
            this.DefaultTextBox1.CustomButton.Visible = false;
            this.DefaultTextBox1.Lines = new string[0];
            this.DefaultTextBox1.Location = new System.Drawing.Point(304, 67);
            this.DefaultTextBox1.MaxLength = 32767;
            this.DefaultTextBox1.Name = "DefaultTextBox1";
            this.DefaultTextBox1.PasswordChar = '\0';
            this.DefaultTextBox1.ReadOnly = true;
            this.DefaultTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DefaultTextBox1.SelectedText = "";
            this.DefaultTextBox1.SelectionLength = 0;
            this.DefaultTextBox1.SelectionStart = 0;
            this.DefaultTextBox1.ShortcutsEnabled = true;
            this.DefaultTextBox1.Size = new System.Drawing.Size(275, 23);
            this.DefaultTextBox1.Style = MetroFramework.MetroColorStyle.Orange;
            this.DefaultTextBox1.TabIndex = 7;
            this.DefaultTextBox1.TabStop = false;
            this.DefaultTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DefaultTextBox1.UseSelectable = true;
            this.DefaultTextBox1.UseStyleColors = true;
            this.DefaultTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DefaultTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DefaultLabel
            // 
            this.DefaultLabel.AutoSize = true;
            this.DefaultLabel.Location = new System.Drawing.Point(304, 45);
            this.DefaultLabel.Name = "DefaultLabel";
            this.DefaultLabel.Size = new System.Drawing.Size(161, 19);
            this.DefaultLabel.Style = MetroFramework.MetroColorStyle.Green;
            this.DefaultLabel.TabIndex = 6;
            this.DefaultLabel.Text = "Клавиша по умолчанию:";
            this.DefaultLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DefaultLabel.UseStyleColors = true;
            // 
            // DefaultButtonSave
            // 
            this.DefaultButtonSave.Location = new System.Drawing.Point(699, 229);
            this.DefaultButtonSave.Name = "DefaultButtonSave";
            this.DefaultButtonSave.Size = new System.Drawing.Size(127, 29);
            this.DefaultButtonSave.Style = MetroFramework.MetroColorStyle.Green;
            this.DefaultButtonSave.TabIndex = 5;
            this.DefaultButtonSave.TabStop = false;
            this.DefaultButtonSave.Text = "Сохранить";
            this.DefaultButtonSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DefaultButtonSave.UseSelectable = true;
            this.DefaultButtonSave.UseStyleColors = true;
            this.DefaultButtonSave.Click += new System.EventHandler(this.DefaultButtonSave_Click);
            // 
            // KeyboardFunction
            // 
            this.KeyboardFunction.Controls.Add(this.KeyboardFunctionLabel);
            this.KeyboardFunction.Controls.Add(this.KeyboardFunctionTextBox);
            this.KeyboardFunction.Controls.Add(this.KeyboardFunctionButtonSave);
            this.KeyboardFunction.HorizontalScrollbarBarColor = true;
            this.KeyboardFunction.HorizontalScrollbarHighlightOnWheel = false;
            this.KeyboardFunction.HorizontalScrollbarSize = 10;
            this.KeyboardFunction.Location = new System.Drawing.Point(4, 38);
            this.KeyboardFunction.Name = "KeyboardFunction";
            this.KeyboardFunction.Size = new System.Drawing.Size(866, 261);
            this.KeyboardFunction.TabIndex = 1;
            this.KeyboardFunction.Text = "Функция клавиатуры";
            this.KeyboardFunction.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.KeyboardFunction.VerticalScrollbarBarColor = true;
            this.KeyboardFunction.VerticalScrollbarHighlightOnWheel = false;
            this.KeyboardFunction.VerticalScrollbarSize = 10;
            // 
            // KeyboardFunctionLabel
            // 
            this.KeyboardFunctionLabel.AutoSize = true;
            this.KeyboardFunctionLabel.Location = new System.Drawing.Point(304, 45);
            this.KeyboardFunctionLabel.Name = "KeyboardFunctionLabel";
            this.KeyboardFunctionLabel.Size = new System.Drawing.Size(242, 19);
            this.KeyboardFunctionLabel.Style = MetroFramework.MetroColorStyle.Green;
            this.KeyboardFunctionLabel.TabIndex = 9;
            this.KeyboardFunctionLabel.Text = "Назначьте клавишу или их сочетание:";
            this.KeyboardFunctionLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.KeyboardFunctionLabel.UseStyleColors = true;
            // 
            // KeyboardFunctionTextBox
            // 
            // 
            // 
            // 
            this.KeyboardFunctionTextBox.CustomButton.Image = null;
            this.KeyboardFunctionTextBox.CustomButton.Location = new System.Drawing.Point(253, 1);
            this.KeyboardFunctionTextBox.CustomButton.Name = "";
            this.KeyboardFunctionTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.KeyboardFunctionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.KeyboardFunctionTextBox.CustomButton.TabIndex = 1;
            this.KeyboardFunctionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.KeyboardFunctionTextBox.CustomButton.UseSelectable = true;
            this.KeyboardFunctionTextBox.CustomButton.Visible = false;
            this.KeyboardFunctionTextBox.Lines = new string[0];
            this.KeyboardFunctionTextBox.Location = new System.Drawing.Point(304, 67);
            this.KeyboardFunctionTextBox.MaxLength = 32767;
            this.KeyboardFunctionTextBox.Name = "KeyboardFunctionTextBox";
            this.KeyboardFunctionTextBox.PasswordChar = '\0';
            this.KeyboardFunctionTextBox.ReadOnly = true;
            this.KeyboardFunctionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.KeyboardFunctionTextBox.SelectedText = "";
            this.KeyboardFunctionTextBox.SelectionLength = 0;
            this.KeyboardFunctionTextBox.SelectionStart = 0;
            this.KeyboardFunctionTextBox.ShortcutsEnabled = true;
            this.KeyboardFunctionTextBox.Size = new System.Drawing.Size(275, 23);
            this.KeyboardFunctionTextBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.KeyboardFunctionTextBox.TabIndex = 8;
            this.KeyboardFunctionTextBox.TabStop = false;
            this.KeyboardFunctionTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.KeyboardFunctionTextBox.UseSelectable = true;
            this.KeyboardFunctionTextBox.UseStyleColors = true;
            this.KeyboardFunctionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.KeyboardFunctionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.KeyboardFunctionTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyboardFunctionTextBox_KeyDown);
            // 
            // KeyboardFunctionButtonSave
            // 
            this.KeyboardFunctionButtonSave.Location = new System.Drawing.Point(699, 229);
            this.KeyboardFunctionButtonSave.Name = "KeyboardFunctionButtonSave";
            this.KeyboardFunctionButtonSave.Size = new System.Drawing.Size(127, 29);
            this.KeyboardFunctionButtonSave.Style = MetroFramework.MetroColorStyle.Green;
            this.KeyboardFunctionButtonSave.TabIndex = 6;
            this.KeyboardFunctionButtonSave.TabStop = false;
            this.KeyboardFunctionButtonSave.Text = "Сохранить";
            this.KeyboardFunctionButtonSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.KeyboardFunctionButtonSave.UseSelectable = true;
            this.KeyboardFunctionButtonSave.UseStyleColors = true;
            this.KeyboardFunctionButtonSave.Click += new System.EventHandler(this.KeyboardFunctionButtonSave_Click);
            // 
            // MouseFunction
            // 
            this.MouseFunction.Controls.Add(this.MouseFunctionComboBox);
            this.MouseFunction.Controls.Add(this.MouseFunctionLabel);
            this.MouseFunction.Controls.Add(this.MouseFunctionButtonSave);
            this.MouseFunction.HorizontalScrollbarBarColor = true;
            this.MouseFunction.HorizontalScrollbarHighlightOnWheel = false;
            this.MouseFunction.HorizontalScrollbarSize = 10;
            this.MouseFunction.Location = new System.Drawing.Point(4, 38);
            this.MouseFunction.Name = "MouseFunction";
            this.MouseFunction.Size = new System.Drawing.Size(866, 261);
            this.MouseFunction.TabIndex = 2;
            this.MouseFunction.Text = "Функция Мыши";
            this.MouseFunction.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MouseFunction.VerticalScrollbarBarColor = true;
            this.MouseFunction.VerticalScrollbarHighlightOnWheel = false;
            this.MouseFunction.VerticalScrollbarSize = 10;
            // 
            // MouseFunctionComboBox
            // 
            this.MouseFunctionComboBox.FormattingEnabled = true;
            this.MouseFunctionComboBox.ItemHeight = 23;
            this.MouseFunctionComboBox.Items.AddRange(new object[] {
            "---",
            "Щелчок",
            "Двойной щелчок",
            "Меню"});
            this.MouseFunctionComboBox.Location = new System.Drawing.Point(304, 67);
            this.MouseFunctionComboBox.Name = "MouseFunctionComboBox";
            this.MouseFunctionComboBox.Size = new System.Drawing.Size(275, 29);
            this.MouseFunctionComboBox.Style = MetroFramework.MetroColorStyle.Green;
            this.MouseFunctionComboBox.TabIndex = 11;
            this.MouseFunctionComboBox.TabStop = false;
            this.MouseFunctionComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MouseFunctionComboBox.UseSelectable = true;
            this.MouseFunctionComboBox.UseStyleColors = true;
            this.MouseFunctionComboBox.SelectedIndexChanged += new System.EventHandler(this.MouseFunctionComboBox_SelectedIndexChanged);
            // 
            // MouseFunctionLabel
            // 
            this.MouseFunctionLabel.AutoSize = true;
            this.MouseFunctionLabel.Location = new System.Drawing.Point(304, 45);
            this.MouseFunctionLabel.Name = "MouseFunctionLabel";
            this.MouseFunctionLabel.Size = new System.Drawing.Size(242, 19);
            this.MouseFunctionLabel.Style = MetroFramework.MetroColorStyle.Green;
            this.MouseFunctionLabel.TabIndex = 10;
            this.MouseFunctionLabel.Text = "Назначьте клавишу или их сочетание:";
            this.MouseFunctionLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MouseFunctionLabel.UseStyleColors = true;
            // 
            // MouseFunctionButtonSave
            // 
            this.MouseFunctionButtonSave.Location = new System.Drawing.Point(699, 229);
            this.MouseFunctionButtonSave.Name = "MouseFunctionButtonSave";
            this.MouseFunctionButtonSave.Size = new System.Drawing.Size(127, 29);
            this.MouseFunctionButtonSave.Style = MetroFramework.MetroColorStyle.Green;
            this.MouseFunctionButtonSave.TabIndex = 7;
            this.MouseFunctionButtonSave.TabStop = false;
            this.MouseFunctionButtonSave.Text = "Сохранить";
            this.MouseFunctionButtonSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MouseFunctionButtonSave.UseSelectable = true;
            this.MouseFunctionButtonSave.UseStyleColors = true;
            this.MouseFunctionButtonSave.Click += new System.EventHandler(this.MouseFunctionButtonSave_Click);
            // 
            // WINDOWSKeyCombination
            // 
            this.WINDOWSKeyCombination.Controls.Add(this.WINDOWSKeyCombinationComboBox);
            this.WINDOWSKeyCombination.Controls.Add(this.WINDOWSKeyCombinationLabel);
            this.WINDOWSKeyCombination.Controls.Add(this.WINDOWSKeyCombinationButtonSave);
            this.WINDOWSKeyCombination.Cursor = System.Windows.Forms.Cursors.Default;
            this.WINDOWSKeyCombination.HorizontalScrollbarBarColor = true;
            this.WINDOWSKeyCombination.HorizontalScrollbarHighlightOnWheel = false;
            this.WINDOWSKeyCombination.HorizontalScrollbarSize = 10;
            this.WINDOWSKeyCombination.Location = new System.Drawing.Point(4, 38);
            this.WINDOWSKeyCombination.Name = "WINDOWSKeyCombination";
            this.WINDOWSKeyCombination.Size = new System.Drawing.Size(866, 261);
            this.WINDOWSKeyCombination.TabIndex = 3;
            this.WINDOWSKeyCombination.Text = "Сочетание клавиш WINDOWS";
            this.WINDOWSKeyCombination.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WINDOWSKeyCombination.VerticalScrollbarBarColor = true;
            this.WINDOWSKeyCombination.VerticalScrollbarHighlightOnWheel = false;
            this.WINDOWSKeyCombination.VerticalScrollbarSize = 10;
            // 
            // WINDOWSKeyCombinationComboBox
            // 
            this.WINDOWSKeyCombinationComboBox.FormattingEnabled = true;
            this.WINDOWSKeyCombinationComboBox.ItemHeight = 23;
            this.WINDOWSKeyCombinationComboBox.Items.AddRange(new object[] {
            "---",
            "Запустить диспетчера задач",
            "Свернуть все окна",
            "Alt + TAB",
            "Закрыть приложение",
            "Вырезать",
            "Копировать",
            "Вставить"});
            this.WINDOWSKeyCombinationComboBox.Location = new System.Drawing.Point(304, 67);
            this.WINDOWSKeyCombinationComboBox.Name = "WINDOWSKeyCombinationComboBox";
            this.WINDOWSKeyCombinationComboBox.Size = new System.Drawing.Size(275, 29);
            this.WINDOWSKeyCombinationComboBox.Style = MetroFramework.MetroColorStyle.Green;
            this.WINDOWSKeyCombinationComboBox.TabIndex = 12;
            this.WINDOWSKeyCombinationComboBox.TabStop = false;
            this.WINDOWSKeyCombinationComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WINDOWSKeyCombinationComboBox.UseSelectable = true;
            this.WINDOWSKeyCombinationComboBox.UseStyleColors = true;
            // 
            // WINDOWSKeyCombinationLabel
            // 
            this.WINDOWSKeyCombinationLabel.AutoSize = true;
            this.WINDOWSKeyCombinationLabel.Location = new System.Drawing.Point(304, 45);
            this.WINDOWSKeyCombinationLabel.Name = "WINDOWSKeyCombinationLabel";
            this.WINDOWSKeyCombinationLabel.Size = new System.Drawing.Size(242, 19);
            this.WINDOWSKeyCombinationLabel.Style = MetroFramework.MetroColorStyle.Green;
            this.WINDOWSKeyCombinationLabel.TabIndex = 11;
            this.WINDOWSKeyCombinationLabel.Text = "Назначьте клавишу или их сочетание:";
            this.WINDOWSKeyCombinationLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WINDOWSKeyCombinationLabel.UseStyleColors = true;
            // 
            // WINDOWSKeyCombinationButtonSave
            // 
            this.WINDOWSKeyCombinationButtonSave.Location = new System.Drawing.Point(699, 229);
            this.WINDOWSKeyCombinationButtonSave.Name = "WINDOWSKeyCombinationButtonSave";
            this.WINDOWSKeyCombinationButtonSave.Size = new System.Drawing.Size(127, 29);
            this.WINDOWSKeyCombinationButtonSave.Style = MetroFramework.MetroColorStyle.Green;
            this.WINDOWSKeyCombinationButtonSave.TabIndex = 8;
            this.WINDOWSKeyCombinationButtonSave.TabStop = false;
            this.WINDOWSKeyCombinationButtonSave.Text = "Сохранить";
            this.WINDOWSKeyCombinationButtonSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WINDOWSKeyCombinationButtonSave.UseSelectable = true;
            this.WINDOWSKeyCombinationButtonSave.UseStyleColors = true;
            this.WINDOWSKeyCombinationButtonSave.Click += new System.EventHandler(this.WINDOWSKeyCombinationButtonSave_Click);
            // 
            // LaunchingTheProgram
            // 
            this.LaunchingTheProgram.Controls.Add(this.LaunchingTheProgramFileWayLabel);
            this.LaunchingTheProgram.Controls.Add(this.LaunchingTheProgramFileWayTextBox);
            this.LaunchingTheProgram.Controls.Add(this.LaunchingTheProgramButtonOpen);
            this.LaunchingTheProgram.Controls.Add(this.LaunchingTheProgramTextBox);
            this.LaunchingTheProgram.Controls.Add(this.LaunchingTheProgramLabel);
            this.LaunchingTheProgram.Controls.Add(this.LaunchingTheProgramButtonSave);
            this.LaunchingTheProgram.HorizontalScrollbarBarColor = true;
            this.LaunchingTheProgram.HorizontalScrollbarHighlightOnWheel = false;
            this.LaunchingTheProgram.HorizontalScrollbarSize = 10;
            this.LaunchingTheProgram.Location = new System.Drawing.Point(4, 38);
            this.LaunchingTheProgram.Name = "LaunchingTheProgram";
            this.LaunchingTheProgram.Size = new System.Drawing.Size(866, 261);
            this.LaunchingTheProgram.TabIndex = 4;
            this.LaunchingTheProgram.Text = "Запуск программы";
            this.LaunchingTheProgram.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LaunchingTheProgram.VerticalScrollbarBarColor = true;
            this.LaunchingTheProgram.VerticalScrollbarHighlightOnWheel = false;
            this.LaunchingTheProgram.VerticalScrollbarSize = 10;
            // 
            // LaunchingTheProgramFileWayLabel
            // 
            this.LaunchingTheProgramFileWayLabel.AutoSize = true;
            this.LaunchingTheProgramFileWayLabel.Location = new System.Drawing.Point(304, 107);
            this.LaunchingTheProgramFileWayLabel.Name = "LaunchingTheProgramFileWayLabel";
            this.LaunchingTheProgramFileWayLabel.Size = new System.Drawing.Size(90, 19);
            this.LaunchingTheProgramFileWayLabel.Style = MetroFramework.MetroColorStyle.Green;
            this.LaunchingTheProgramFileWayLabel.TabIndex = 16;
            this.LaunchingTheProgramFileWayLabel.Text = "Полный путь:";
            this.LaunchingTheProgramFileWayLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LaunchingTheProgramFileWayLabel.UseStyleColors = true;
            // 
            // LaunchingTheProgramFileWayTextBox
            // 
            // 
            // 
            // 
            this.LaunchingTheProgramFileWayTextBox.CustomButton.Image = null;
            this.LaunchingTheProgramFileWayTextBox.CustomButton.Location = new System.Drawing.Point(352, 1);
            this.LaunchingTheProgramFileWayTextBox.CustomButton.Name = "";
            this.LaunchingTheProgramFileWayTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LaunchingTheProgramFileWayTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LaunchingTheProgramFileWayTextBox.CustomButton.TabIndex = 1;
            this.LaunchingTheProgramFileWayTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LaunchingTheProgramFileWayTextBox.CustomButton.UseSelectable = true;
            this.LaunchingTheProgramFileWayTextBox.CustomButton.Visible = false;
            this.LaunchingTheProgramFileWayTextBox.Lines = new string[0];
            this.LaunchingTheProgramFileWayTextBox.Location = new System.Drawing.Point(304, 129);
            this.LaunchingTheProgramFileWayTextBox.MaxLength = 32767;
            this.LaunchingTheProgramFileWayTextBox.Name = "LaunchingTheProgramFileWayTextBox";
            this.LaunchingTheProgramFileWayTextBox.PasswordChar = '\0';
            this.LaunchingTheProgramFileWayTextBox.ReadOnly = true;
            this.LaunchingTheProgramFileWayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LaunchingTheProgramFileWayTextBox.SelectedText = "";
            this.LaunchingTheProgramFileWayTextBox.SelectionLength = 0;
            this.LaunchingTheProgramFileWayTextBox.SelectionStart = 0;
            this.LaunchingTheProgramFileWayTextBox.ShortcutsEnabled = true;
            this.LaunchingTheProgramFileWayTextBox.Size = new System.Drawing.Size(374, 23);
            this.LaunchingTheProgramFileWayTextBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.LaunchingTheProgramFileWayTextBox.TabIndex = 15;
            this.LaunchingTheProgramFileWayTextBox.TabStop = false;
            this.LaunchingTheProgramFileWayTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LaunchingTheProgramFileWayTextBox.UseSelectable = true;
            this.LaunchingTheProgramFileWayTextBox.UseStyleColors = true;
            this.LaunchingTheProgramFileWayTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LaunchingTheProgramFileWayTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LaunchingTheProgramButtonOpen
            // 
            this.LaunchingTheProgramButtonOpen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LaunchingTheProgramButtonOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LaunchingTheProgramButtonOpen.BackgroundImage")));
            this.LaunchingTheProgramButtonOpen.Location = new System.Drawing.Point(585, 67);
            this.LaunchingTheProgramButtonOpen.Name = "LaunchingTheProgramButtonOpen";
            this.LaunchingTheProgramButtonOpen.Size = new System.Drawing.Size(25, 25);
            this.LaunchingTheProgramButtonOpen.Style = MetroFramework.MetroColorStyle.Green;
            this.LaunchingTheProgramButtonOpen.TabIndex = 14;
            this.LaunchingTheProgramButtonOpen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LaunchingTheProgramButtonOpen.UseSelectable = true;
            this.LaunchingTheProgramButtonOpen.UseStyleColors = true;
            this.LaunchingTheProgramButtonOpen.Click += new System.EventHandler(this.LaunchingTheProgramButtonOpen_Click);
            // 
            // LaunchingTheProgramTextBox
            // 
            // 
            // 
            // 
            this.LaunchingTheProgramTextBox.CustomButton.Image = null;
            this.LaunchingTheProgramTextBox.CustomButton.Location = new System.Drawing.Point(253, 1);
            this.LaunchingTheProgramTextBox.CustomButton.Name = "";
            this.LaunchingTheProgramTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LaunchingTheProgramTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LaunchingTheProgramTextBox.CustomButton.TabIndex = 1;
            this.LaunchingTheProgramTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LaunchingTheProgramTextBox.CustomButton.UseSelectable = true;
            this.LaunchingTheProgramTextBox.CustomButton.Visible = false;
            this.LaunchingTheProgramTextBox.Lines = new string[0];
            this.LaunchingTheProgramTextBox.Location = new System.Drawing.Point(304, 67);
            this.LaunchingTheProgramTextBox.MaxLength = 32767;
            this.LaunchingTheProgramTextBox.Name = "LaunchingTheProgramTextBox";
            this.LaunchingTheProgramTextBox.PasswordChar = '\0';
            this.LaunchingTheProgramTextBox.ReadOnly = true;
            this.LaunchingTheProgramTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LaunchingTheProgramTextBox.SelectedText = "";
            this.LaunchingTheProgramTextBox.SelectionLength = 0;
            this.LaunchingTheProgramTextBox.SelectionStart = 0;
            this.LaunchingTheProgramTextBox.ShortcutsEnabled = true;
            this.LaunchingTheProgramTextBox.Size = new System.Drawing.Size(275, 23);
            this.LaunchingTheProgramTextBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.LaunchingTheProgramTextBox.TabIndex = 13;
            this.LaunchingTheProgramTextBox.TabStop = false;
            this.LaunchingTheProgramTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LaunchingTheProgramTextBox.UseSelectable = true;
            this.LaunchingTheProgramTextBox.UseStyleColors = true;
            this.LaunchingTheProgramTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LaunchingTheProgramTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LaunchingTheProgramLabel
            // 
            this.LaunchingTheProgramLabel.AutoSize = true;
            this.LaunchingTheProgramLabel.Location = new System.Drawing.Point(304, 45);
            this.LaunchingTheProgramLabel.Name = "LaunchingTheProgramLabel";
            this.LaunchingTheProgramLabel.Size = new System.Drawing.Size(143, 19);
            this.LaunchingTheProgramLabel.Style = MetroFramework.MetroColorStyle.Green;
            this.LaunchingTheProgramLabel.TabIndex = 12;
            this.LaunchingTheProgramLabel.Text = "Запустить программу:";
            this.LaunchingTheProgramLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LaunchingTheProgramLabel.UseStyleColors = true;
            // 
            // LaunchingTheProgramButtonSave
            // 
            this.LaunchingTheProgramButtonSave.Location = new System.Drawing.Point(699, 229);
            this.LaunchingTheProgramButtonSave.Name = "LaunchingTheProgramButtonSave";
            this.LaunchingTheProgramButtonSave.Size = new System.Drawing.Size(127, 29);
            this.LaunchingTheProgramButtonSave.Style = MetroFramework.MetroColorStyle.Green;
            this.LaunchingTheProgramButtonSave.TabIndex = 6;
            this.LaunchingTheProgramButtonSave.TabStop = false;
            this.LaunchingTheProgramButtonSave.Text = "Сохранить";
            this.LaunchingTheProgramButtonSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LaunchingTheProgramButtonSave.UseSelectable = true;
            this.LaunchingTheProgramButtonSave.UseStyleColors = true;
            this.LaunchingTheProgramButtonSave.Click += new System.EventHandler(this.LaunchingTheProgramButtonSave_Click);
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(495, 23);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(184, 23);
            this.TestButton.TabIndex = 5;
            this.TestButton.Text = "TestButtonLazyButton";
            this.TestButton.UseSelectable = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 640);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.GroupButtonsOut);
            this.Controls.Add(this.FAQ);
            this.Controls.Add(this.GroupButtonsIn);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(920, 640);
            this.MinimumSize = new System.Drawing.Size(920, 640);
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Переназначить? ну давай..";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeybordToMouse_KeyPress);
            this.GroupButtonsIn.ResumeLayout(false);
            this.ListGroupButtonsIn.ResumeLayout(false);
            this.LazyButton.ResumeLayout(false);
            this.LazyButton.PerformLayout();
            this.NumMultiply.ResumeLayout(false);
            this.NumMultiply.PerformLayout();
            this.NumPlus.ResumeLayout(false);
            this.NumPlus.PerformLayout();
            this.NumMinus.ResumeLayout(false);
            this.NumMinus.PerformLayout();
            this.UserButton.ResumeLayout(false);
            this.UserButton.PerformLayout();
            this.GroupButtonsOut.ResumeLayout(false);
            this.ListGroupButtonsOut.ResumeLayout(false);
            this.Default.ResumeLayout(false);
            this.Default.PerformLayout();
            this.KeyboardFunction.ResumeLayout(false);
            this.KeyboardFunction.PerformLayout();
            this.MouseFunction.ResumeLayout(false);
            this.MouseFunction.PerformLayout();
            this.WINDOWSKeyCombination.ResumeLayout(false);
            this.WINDOWSKeyCombination.PerformLayout();
            this.LaunchingTheProgram.ResumeLayout(false);
            this.LaunchingTheProgram.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GroupButtonsIn;
        private MetroFramework.Controls.MetroTabControl ListGroupButtonsIn;
        private MetroFramework.Controls.MetroTabPage LazyButton;
        private MetroFramework.Controls.MetroTabPage NumMultiply;
        private MetroFramework.Controls.MetroTabPage NumPlus;
        private MetroFramework.Controls.MetroTabPage NumMinus;
        private MetroFramework.Controls.MetroTabPage UserButton;
        private MetroFramework.Controls.MetroButton FAQ;
        private System.Windows.Forms.GroupBox GroupButtonsOut;
        private MetroFramework.Controls.MetroTabControl ListGroupButtonsOut;
        private MetroFramework.Controls.MetroTabPage Default;
        private MetroFramework.Controls.MetroTabPage KeyboardFunction;
        private MetroFramework.Controls.MetroTabPage MouseFunction;
        private MetroFramework.Controls.MetroTabPage WINDOWSKeyCombination;
        private MetroFramework.Controls.MetroTabPage LaunchingTheProgram;
        private MetroFramework.Controls.MetroButton LazyButtonButtonCancel;
        private MetroFramework.Controls.MetroButton LazyButtonButtonОК;
        private MetroFramework.Controls.MetroButton NumMultiplyButtonCancel;
        private MetroFramework.Controls.MetroButton NumMultiplyButtonOK;
        private MetroFramework.Controls.MetroButton NumPlusButtonCancel;
        private MetroFramework.Controls.MetroButton NumPlusButtonOK;
        private MetroFramework.Controls.MetroButton NumMinusButtonCancel;
        private MetroFramework.Controls.MetroButton NumMinusButtonOK;
        private MetroFramework.Controls.MetroButton UserButtonButtonCancel;
        private MetroFramework.Controls.MetroButton UserButtonButtonOK;
        private MetroFramework.Controls.MetroLabel LazyButtonLabel;
        private MetroFramework.Controls.MetroLabel NumEnterLabel;
        private MetroFramework.Controls.MetroLabel NumPlusLabel;
        private MetroFramework.Controls.MetroLabel NumMinusLabel;
        private MetroFramework.Controls.MetroLabel UserButtonLabel;
        private MetroFramework.Controls.MetroButton DefaultButtonSave;
        private MetroFramework.Controls.MetroButton KeyboardFunctionButtonSave;
        private MetroFramework.Controls.MetroButton MouseFunctionButtonSave;
        private MetroFramework.Controls.MetroButton WINDOWSKeyCombinationButtonSave;
        private MetroFramework.Controls.MetroButton LaunchingTheProgramButtonSave;
        private MetroFramework.Controls.MetroTextBox DefaultTextBox1;
        private MetroFramework.Controls.MetroLabel DefaultLabel;
        private MetroFramework.Controls.MetroLabel KeyboardFunctionLabel;
        private MetroFramework.Controls.MetroTextBox KeyboardFunctionTextBox;
        private MetroFramework.Controls.MetroComboBox MouseFunctionComboBox;
        private MetroFramework.Controls.MetroLabel MouseFunctionLabel;
        private MetroFramework.Controls.MetroComboBox WINDOWSKeyCombinationComboBox;
        private MetroFramework.Controls.MetroLabel WINDOWSKeyCombinationLabel;
        private MetroFramework.Controls.MetroLabel LaunchingTheProgramLabel;
        private MetroFramework.Controls.MetroButton LaunchingTheProgramButtonOpen;
        private MetroFramework.Controls.MetroTextBox LaunchingTheProgramTextBox;
        private MetroFramework.Controls.MetroLabel LaunchingTheProgramFileWayLabel;
        private MetroFramework.Controls.MetroTextBox LaunchingTheProgramFileWayTextBox;
        private MetroFramework.Controls.MetroTextBox UserButtonTextBox;
        private MetroFramework.Controls.MetroButton TestButton;
    }
}


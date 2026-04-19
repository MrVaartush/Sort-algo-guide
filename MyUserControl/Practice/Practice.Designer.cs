namespace SortAlgoGuide.MyUserControl.Practice
{
    partial class Practice
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer_functions = new System.Windows.Forms.Timer(this.components);
            this.Sort_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Func_panel = new System.Windows.Forms.Panel();
            this.Random_btn = new System.Windows.Forms.Button();
            this.Compare_btn = new System.Windows.Forms.Button();
            this.Import_btn = new System.Windows.Forms.Button();
            this.Temp_btn = new System.Windows.Forms.Button();
            this.Func_btn = new System.Windows.Forms.Button();
            this.mixElem_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Temp_comboBox = new System.Windows.Forms.ComboBox();
            this.Random_panel = new System.Windows.Forms.Panel();
            this.Random_count = new System.Windows.Forms.Label();
            this.Count_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RndmGen_btn = new System.Windows.Forms.Button();
            this.RandomMax_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RandomMin_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Repeat_checkBox = new System.Windows.Forms.CheckBox();
            this.ElemToSort_listBox = new System.Windows.Forms.ListBox();
            this.UsingAlgo_listBox = new System.Windows.Forms.ListBox();
            this.Import_textBox = new System.Windows.Forms.TextBox();
            this.Helper_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WastedTime_listBox = new System.Windows.Forms.ListBox();
            this.TempChosen_btn = new System.Windows.Forms.Button();
            this.Temp_panel = new System.Windows.Forms.Panel();
            this.ElementToAdd_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.comboBox_Algo = new System.Windows.Forms.ComboBox();
            this.Compare_label = new System.Windows.Forms.Label();
            this.Func_panel.SuspendLayout();
            this.Random_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Count_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomMax_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomMin_numericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.Temp_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElementToAdd_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer_functions
            // 
            this.Timer_functions.Interval = 10;
            this.Timer_functions.Tick += new System.EventHandler(this.Timer_functions_Tick);
            // 
            // Sort_btn
            // 
            this.Sort_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Sort_btn.FlatAppearance.BorderSize = 0;
            this.Sort_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.Sort_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.Sort_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sort_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sort_btn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Sort_btn.Location = new System.Drawing.Point(927, 97);
            this.Sort_btn.Name = "Sort_btn";
            this.Sort_btn.Size = new System.Drawing.Size(127, 35);
            this.Sort_btn.TabIndex = 27;
            this.Sort_btn.Text = "Сортувати";
            this.Sort_btn.UseVisualStyleBackColor = true;
            this.Sort_btn.Click += new System.EventHandler(this.Sort_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_btn.FlatAppearance.BorderSize = 0;
            this.Add_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.Add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_btn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Add_btn.Location = new System.Drawing.Point(927, 60);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(127, 35);
            this.Add_btn.TabIndex = 26;
            this.Add_btn.Text = "Додати";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Func_panel
            // 
            this.Func_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Func_panel.Controls.Add(this.Random_btn);
            this.Func_panel.Controls.Add(this.Compare_btn);
            this.Func_panel.Controls.Add(this.Import_btn);
            this.Func_panel.Controls.Add(this.Temp_btn);
            this.Func_panel.Controls.Add(this.Func_btn);
            this.Func_panel.Location = new System.Drawing.Point(36, 110);
            this.Func_panel.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.Func_panel.MaximumSize = new System.Drawing.Size(265, 185);
            this.Func_panel.MinimumSize = new System.Drawing.Size(0, 35);
            this.Func_panel.Name = "Func_panel";
            this.Func_panel.Size = new System.Drawing.Size(183, 185);
            this.Func_panel.TabIndex = 25;
            // 
            // Random_btn
            // 
            this.Random_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Random_btn.FlatAppearance.BorderSize = 0;
            this.Random_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.Random_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.Random_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Random_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Random_btn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Random_btn.Location = new System.Drawing.Point(0, 140);
            this.Random_btn.Name = "Random_btn";
            this.Random_btn.Size = new System.Drawing.Size(183, 35);
            this.Random_btn.TabIndex = 19;
            this.Random_btn.Text = "Випадкова ген.";
            this.Random_btn.UseVisualStyleBackColor = true;
            this.Random_btn.Click += new System.EventHandler(this.Random_btn_Click);
            // 
            // Compare_btn
            // 
            this.Compare_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Compare_btn.FlatAppearance.BorderSize = 0;
            this.Compare_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Compare_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.Compare_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Compare_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Compare_btn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Compare_btn.Location = new System.Drawing.Point(0, 105);
            this.Compare_btn.Name = "Compare_btn";
            this.Compare_btn.Size = new System.Drawing.Size(183, 35);
            this.Compare_btn.TabIndex = 22;
            this.Compare_btn.Text = "Порівняти";
            this.Compare_btn.UseVisualStyleBackColor = true;
            this.Compare_btn.Click += new System.EventHandler(this.Compare_btn_Click);
            // 
            // Import_btn
            // 
            this.Import_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Import_btn.FlatAppearance.BorderSize = 0;
            this.Import_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Import_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.Import_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Import_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Import_btn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Import_btn.Location = new System.Drawing.Point(0, 70);
            this.Import_btn.Name = "Import_btn";
            this.Import_btn.Size = new System.Drawing.Size(183, 35);
            this.Import_btn.TabIndex = 21;
            this.Import_btn.Text = "Імпортувати";
            this.Import_btn.UseVisualStyleBackColor = true;
            this.Import_btn.Click += new System.EventHandler(this.Import_btn_Click);
            // 
            // Temp_btn
            // 
            this.Temp_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Temp_btn.FlatAppearance.BorderSize = 0;
            this.Temp_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Temp_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.Temp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Temp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Temp_btn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Temp_btn.Location = new System.Drawing.Point(0, 35);
            this.Temp_btn.Name = "Temp_btn";
            this.Temp_btn.Size = new System.Drawing.Size(183, 35);
            this.Temp_btn.TabIndex = 20;
            this.Temp_btn.Text = "Шаблони";
            this.Temp_btn.UseVisualStyleBackColor = true;
            this.Temp_btn.Click += new System.EventHandler(this.Temp_btn_Click);
            // 
            // Func_btn
            // 
            this.Func_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Func_btn.FlatAppearance.BorderSize = 0;
            this.Func_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Func_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.Func_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Func_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Func_btn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Func_btn.Location = new System.Drawing.Point(0, 0);
            this.Func_btn.Name = "Func_btn";
            this.Func_btn.Size = new System.Drawing.Size(183, 35);
            this.Func_btn.TabIndex = 1;
            this.Func_btn.Text = "Інші функції";
            this.Func_btn.UseVisualStyleBackColor = true;
            this.Func_btn.Click += new System.EventHandler(this.Func_btn_Click);
            // 
            // mixElem_btn
            // 
            this.mixElem_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mixElem_btn.FlatAppearance.BorderSize = 0;
            this.mixElem_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.mixElem_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.mixElem_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mixElem_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mixElem_btn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.mixElem_btn.Location = new System.Drawing.Point(927, 138);
            this.mixElem_btn.Name = "mixElem_btn";
            this.mixElem_btn.Size = new System.Drawing.Size(127, 35);
            this.mixElem_btn.TabIndex = 28;
            this.mixElem_btn.Text = "Змішати";
            this.mixElem_btn.UseVisualStyleBackColor = true;
            this.mixElem_btn.Click += new System.EventHandler(this.mixElem_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "max";
            // 
            // Temp_comboBox
            // 
            this.Temp_comboBox.BackColor = System.Drawing.Color.LightGray;
            this.Temp_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Temp_comboBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Temp_comboBox.ForeColor = System.Drawing.Color.DimGray;
            this.Temp_comboBox.FormattingEnabled = true;
            this.Temp_comboBox.Location = new System.Drawing.Point(3, 5);
            this.Temp_comboBox.Name = "Temp_comboBox";
            this.Temp_comboBox.Size = new System.Drawing.Size(261, 34);
            this.Temp_comboBox.Sorted = true;
            this.Temp_comboBox.TabIndex = 35;
            this.Temp_comboBox.Text = "Template";
            // 
            // Random_panel
            // 
            this.Random_panel.Controls.Add(this.Random_count);
            this.Random_panel.Controls.Add(this.Count_numericUpDown);
            this.Random_panel.Controls.Add(this.RndmGen_btn);
            this.Random_panel.Controls.Add(this.RandomMax_numericUpDown);
            this.Random_panel.Controls.Add(this.RandomMin_numericUpDown);
            this.Random_panel.Controls.Add(this.Repeat_checkBox);
            this.Random_panel.Controls.Add(this.label1);
            this.Random_panel.Controls.Add(this.label3);
            this.Random_panel.Location = new System.Drawing.Point(225, 216);
            this.Random_panel.Name = "Random_panel";
            this.Random_panel.Size = new System.Drawing.Size(380, 113);
            this.Random_panel.TabIndex = 37;
            this.Random_panel.Visible = false;
            // 
            // Random_count
            // 
            this.Random_count.AutoSize = true;
            this.Random_count.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Random_count.ForeColor = System.Drawing.Color.DarkGray;
            this.Random_count.Location = new System.Drawing.Point(164, 6);
            this.Random_count.Name = "Random_count";
            this.Random_count.Size = new System.Drawing.Size(83, 29);
            this.Random_count.TabIndex = 45;
            this.Random_count.Text = "кіл-сть";
            // 
            // Count_numericUpDown
            // 
            this.Count_numericUpDown.BackColor = System.Drawing.Color.Silver;
            this.Count_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Count_numericUpDown.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count_numericUpDown.ForeColor = System.Drawing.Color.DimGray;
            this.Count_numericUpDown.Location = new System.Drawing.Point(250, 6);
            this.Count_numericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Count_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Count_numericUpDown.Name = "Count_numericUpDown";
            this.Count_numericUpDown.Size = new System.Drawing.Size(110, 30);
            this.Count_numericUpDown.TabIndex = 45;
            this.Count_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Count_numericUpDown.ThousandsSeparator = true;
            this.Count_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RndmGen_btn
            // 
            this.RndmGen_btn.FlatAppearance.BorderSize = 0;
            this.RndmGen_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.RndmGen_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.RndmGen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RndmGen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RndmGen_btn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.RndmGen_btn.Location = new System.Drawing.Point(3, 73);
            this.RndmGen_btn.Name = "RndmGen_btn";
            this.RndmGen_btn.Size = new System.Drawing.Size(156, 35);
            this.RndmGen_btn.TabIndex = 40;
            this.RndmGen_btn.Text = "Сгенерувати";
            this.RndmGen_btn.UseVisualStyleBackColor = true;
            this.RndmGen_btn.Click += new System.EventHandler(this.RndmGen_btn_Click);
            // 
            // RandomMax_numericUpDown
            // 
            this.RandomMax_numericUpDown.BackColor = System.Drawing.Color.Silver;
            this.RandomMax_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RandomMax_numericUpDown.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RandomMax_numericUpDown.ForeColor = System.Drawing.Color.DimGray;
            this.RandomMax_numericUpDown.Location = new System.Drawing.Point(49, 39);
            this.RandomMax_numericUpDown.Name = "RandomMax_numericUpDown";
            this.RandomMax_numericUpDown.Size = new System.Drawing.Size(110, 30);
            this.RandomMax_numericUpDown.TabIndex = 44;
            this.RandomMax_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RandomMax_numericUpDown.ThousandsSeparator = true;
            // 
            // RandomMin_numericUpDown
            // 
            this.RandomMin_numericUpDown.BackColor = System.Drawing.Color.Silver;
            this.RandomMin_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RandomMin_numericUpDown.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RandomMin_numericUpDown.ForeColor = System.Drawing.Color.DimGray;
            this.RandomMin_numericUpDown.Location = new System.Drawing.Point(49, 5);
            this.RandomMin_numericUpDown.Name = "RandomMin_numericUpDown";
            this.RandomMin_numericUpDown.Size = new System.Drawing.Size(110, 30);
            this.RandomMin_numericUpDown.TabIndex = 43;
            this.RandomMin_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RandomMin_numericUpDown.ThousandsSeparator = true;
            // 
            // Repeat_checkBox
            // 
            this.Repeat_checkBox.AutoSize = true;
            this.Repeat_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Repeat_checkBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Repeat_checkBox.ForeColor = System.Drawing.Color.DarkGray;
            this.Repeat_checkBox.Location = new System.Drawing.Point(165, 36);
            this.Repeat_checkBox.Name = "Repeat_checkBox";
            this.Repeat_checkBox.Size = new System.Drawing.Size(148, 33);
            this.Repeat_checkBox.TabIndex = 38;
            this.Repeat_checkBox.Text = "повторення";
            this.Repeat_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Repeat_checkBox.UseVisualStyleBackColor = true;
            // 
            // ElemToSort_listBox
            // 
            this.ElemToSort_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ElemToSort_listBox.BackColor = System.Drawing.Color.DarkGray;
            this.ElemToSort_listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ElemToSort_listBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElemToSort_listBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ElemToSort_listBox.FormattingEnabled = true;
            this.ElemToSort_listBox.ItemHeight = 29;
            this.ElemToSort_listBox.Location = new System.Drawing.Point(1071, 86);
            this.ElemToSort_listBox.Name = "ElemToSort_listBox";
            this.ElemToSort_listBox.Size = new System.Drawing.Size(156, 580);
            this.ElemToSort_listBox.TabIndex = 39;
            // 
            // UsingAlgo_listBox
            // 
            this.UsingAlgo_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsingAlgo_listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.UsingAlgo_listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsingAlgo_listBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsingAlgo_listBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.UsingAlgo_listBox.FormattingEnabled = true;
            this.UsingAlgo_listBox.ItemHeight = 29;
            this.UsingAlgo_listBox.Location = new System.Drawing.Point(944, 289);
            this.UsingAlgo_listBox.Name = "UsingAlgo_listBox";
            this.UsingAlgo_listBox.Size = new System.Drawing.Size(110, 377);
            this.UsingAlgo_listBox.TabIndex = 40;
            // 
            // Import_textBox
            // 
            this.Import_textBox.BackColor = System.Drawing.Color.LightGray;
            this.Import_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Import_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Import_textBox.ForeColor = System.Drawing.Color.DimGray;
            this.Import_textBox.Location = new System.Drawing.Point(225, 185);
            this.Import_textBox.Name = "Import_textBox";
            this.Import_textBox.Size = new System.Drawing.Size(169, 25);
            this.Import_textBox.TabIndex = 41;
            this.Import_textBox.Text = "розділовий знак";
            this.Import_textBox.Visible = false;
            this.Import_textBox.Enter += new System.EventHandler(this.Import_textBox_Enter);
            // 
            // Helper_label
            // 
            this.Helper_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Helper_label.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Helper_label.ForeColor = System.Drawing.Color.DarkGray;
            this.Helper_label.Location = new System.Drawing.Point(0, 0);
            this.Helper_label.Name = "Helper_label";
            this.Helper_label.Size = new System.Drawing.Size(569, 318);
            this.Helper_label.TabIndex = 42;
            this.Helper_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Helper_label);
            this.panel1.Location = new System.Drawing.Point(36, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 318);
            this.panel1.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(937, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 58);
            this.label2.TabIndex = 44;
            this.label2.Text = "Дійсні \r\nалгоритми:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(829, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 46;
            this.label4.Text = "Час (мс):";
            // 
            // WastedTime_listBox
            // 
            this.WastedTime_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WastedTime_listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.WastedTime_listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WastedTime_listBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WastedTime_listBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.WastedTime_listBox.FormattingEnabled = true;
            this.WastedTime_listBox.ItemHeight = 29;
            this.WastedTime_listBox.Location = new System.Drawing.Point(821, 289);
            this.WastedTime_listBox.Name = "WastedTime_listBox";
            this.WastedTime_listBox.Size = new System.Drawing.Size(110, 377);
            this.WastedTime_listBox.TabIndex = 45;
            // 
            // TempChosen_btn
            // 
            this.TempChosen_btn.FlatAppearance.BorderSize = 0;
            this.TempChosen_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.TempChosen_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.TempChosen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TempChosen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TempChosen_btn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.TempChosen_btn.Location = new System.Drawing.Point(270, 4);
            this.TempChosen_btn.Name = "TempChosen_btn";
            this.TempChosen_btn.Size = new System.Drawing.Size(42, 35);
            this.TempChosen_btn.TabIndex = 46;
            this.TempChosen_btn.Text = "«";
            this.TempChosen_btn.UseVisualStyleBackColor = true;
            this.TempChosen_btn.Click += new System.EventHandler(this.TempChosen_btn_Click);
            // 
            // Temp_panel
            // 
            this.Temp_panel.Controls.Add(this.Temp_comboBox);
            this.Temp_panel.Controls.Add(this.TempChosen_btn);
            this.Temp_panel.Location = new System.Drawing.Point(221, 138);
            this.Temp_panel.Name = "Temp_panel";
            this.Temp_panel.Size = new System.Drawing.Size(317, 45);
            this.Temp_panel.TabIndex = 46;
            this.Temp_panel.Visible = false;
            // 
            // ElementToAdd_numericUpDown
            // 
            this.ElementToAdd_numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ElementToAdd_numericUpDown.BackColor = System.Drawing.Color.Silver;
            this.ElementToAdd_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ElementToAdd_numericUpDown.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElementToAdd_numericUpDown.ForeColor = System.Drawing.Color.DimGray;
            this.ElementToAdd_numericUpDown.Location = new System.Drawing.Point(1071, 50);
            this.ElementToAdd_numericUpDown.Name = "ElementToAdd_numericUpDown";
            this.ElementToAdd_numericUpDown.Size = new System.Drawing.Size(156, 30);
            this.ElementToAdd_numericUpDown.TabIndex = 46;
            this.ElementToAdd_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ElementToAdd_numericUpDown.ThousandsSeparator = true;
            // 
            // Clear_btn
            // 
            this.Clear_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear_btn.FlatAppearance.BorderSize = 0;
            this.Clear_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.Clear_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.Clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_btn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Clear_btn.Location = new System.Drawing.Point(927, 175);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(127, 35);
            this.Clear_btn.TabIndex = 47;
            this.Clear_btn.Text = "Очистити";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // comboBox_Algo
            // 
            this.comboBox_Algo.BackColor = System.Drawing.Color.LightGray;
            this.comboBox_Algo.CausesValidation = false;
            this.comboBox_Algo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Algo.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Algo.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox_Algo.FormattingEnabled = true;
            this.comboBox_Algo.Location = new System.Drawing.Point(45, 65);
            this.comboBox_Algo.Name = "comboBox_Algo";
            this.comboBox_Algo.Size = new System.Drawing.Size(265, 37);
            this.comboBox_Algo.Sorted = true;
            this.comboBox_Algo.TabIndex = 24;
            this.comboBox_Algo.Text = "Algo";
            // 
            // Compare_label
            // 
            this.Compare_label.AutoSize = true;
            this.Compare_label.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Compare_label.ForeColor = System.Drawing.Color.DarkGray;
            this.Compare_label.Location = new System.Drawing.Point(316, 65);
            this.Compare_label.Name = "Compare_label";
            this.Compare_label.Size = new System.Drawing.Size(195, 29);
            this.Compare_label.TabIndex = 41;
            this.Compare_label.Text = "Режим порівняння";
            this.Compare_label.Visible = false;
            // 
            // Practice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.ElementToAdd_numericUpDown);
            this.Controls.Add(this.Temp_panel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Import_textBox);
            this.Controls.Add(this.Compare_label);
            this.Controls.Add(this.ElemToSort_listBox);
            this.Controls.Add(this.Random_panel);
            this.Controls.Add(this.mixElem_btn);
            this.Controls.Add(this.Sort_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Func_panel);
            this.Controls.Add(this.comboBox_Algo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WastedTime_listBox);
            this.Controls.Add(this.UsingAlgo_listBox);
            this.MinimumSize = new System.Drawing.Size(670, 0);
            this.Name = "Practice";
            this.Size = new System.Drawing.Size(1264, 703);
            this.Func_panel.ResumeLayout(false);
            this.Random_panel.ResumeLayout(false);
            this.Random_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Count_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomMax_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomMin_numericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Temp_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ElementToAdd_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Timer_functions;
        private System.Windows.Forms.Button Sort_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Panel Func_panel;
        private System.Windows.Forms.Button Compare_btn;
        private System.Windows.Forms.Button Import_btn;
        private System.Windows.Forms.Button Temp_btn;
        private System.Windows.Forms.Button Random_btn;
        private System.Windows.Forms.Button Func_btn;
        private System.Windows.Forms.Button mixElem_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Temp_comboBox;
        private System.Windows.Forms.Panel Random_panel;
        private System.Windows.Forms.CheckBox Repeat_checkBox;
        private System.Windows.Forms.ListBox ElemToSort_listBox;
        private System.Windows.Forms.Button RndmGen_btn;
        private System.Windows.Forms.ListBox UsingAlgo_listBox;
        private System.Windows.Forms.TextBox Import_textBox;
        private System.Windows.Forms.Label Helper_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown RandomMax_numericUpDown;
        private System.Windows.Forms.NumericUpDown RandomMin_numericUpDown;
        private System.Windows.Forms.Label Random_count;
        private System.Windows.Forms.NumericUpDown Count_numericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox WastedTime_listBox;
        private System.Windows.Forms.Button TempChosen_btn;
        private System.Windows.Forms.Panel Temp_panel;
        private System.Windows.Forms.NumericUpDown ElementToAdd_numericUpDown;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.ComboBox comboBox_Algo;
        private System.Windows.Forms.Label Compare_label;
    }
}

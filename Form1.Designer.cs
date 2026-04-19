namespace SortAlgoGuide
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
            this.MenuPanel_T = new System.Windows.Forms.Timer(this.components);
            this.panel_UserControl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.side_btn = new System.Windows.Forms.Button();
            this.SideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_GeneralInfo = new System.Windows.Forms.Button();
            this.Theory_panel = new System.Windows.Forms.Panel();
            this.time_compl_btn = new System.Windows.Forms.Button();
            this.btn_Random = new System.Windows.Forms.Button();
            this.btn_Merge = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Count = new System.Windows.Forms.Button();
            this.btn_Inserion = new System.Windows.Forms.Button();
            this.btn_Comb = new System.Windows.Forms.Button();
            this.btn_Shaker = new System.Windows.Forms.Button();
            this.btn_Radix = new System.Windows.Forms.Button();
            this.btn_Shell = new System.Windows.Forms.Button();
            this.btn_Quick = new System.Windows.Forms.Button();
            this.btn_bubble = new System.Windows.Forms.Button();
            this.theory_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Practice = new System.Windows.Forms.Button();
            this.panel_UserControl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SideBar.SuspendLayout();
            this.panel9.SuspendLayout();
            this.Theory_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel_T
            // 
            this.MenuPanel_T.Interval = 15;
            this.MenuPanel_T.Tick += new System.EventHandler(this.MenuPanel_T_Tick);
            // 
            // panel_UserControl
            // 
            this.panel_UserControl.BackColor = System.Drawing.Color.Transparent;
            this.panel_UserControl.Controls.Add(this.label2);
            this.panel_UserControl.Controls.Add(this.panel3);
            this.panel_UserControl.Controls.Add(this.side_btn);
            this.panel_UserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_UserControl.Location = new System.Drawing.Point(305, 0);
            this.panel_UserControl.Name = "panel_UserControl";
            this.panel_UserControl.Size = new System.Drawing.Size(983, 677);
            this.panel_UserControl.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(983, 677);
            this.label2.TabIndex = 45;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button12);
            this.panel3.Location = new System.Drawing.Point(3, 1092);
            this.panel3.MaximumSize = new System.Drawing.Size(270, 115);
            this.panel3.MinimumSize = new System.Drawing.Size(0, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 115);
            this.panel3.TabIndex = 7;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button10.Location = new System.Drawing.Point(0, 70);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(270, 35);
            this.button10.TabIndex = 2;
            this.button10.Text = "Test";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button11.Location = new System.Drawing.Point(0, 35);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(270, 35);
            this.button11.TabIndex = 1;
            this.button11.Text = "Theory";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button12.Location = new System.Drawing.Point(0, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(270, 35);
            this.button12.TabIndex = 0;
            this.button12.Text = "RadixSort";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // side_btn
            // 
            this.side_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.side_btn.BackColor = System.Drawing.Color.Transparent;
            this.side_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("side_btn.BackgroundImage")));
            this.side_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.side_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.side_btn.FlatAppearance.BorderSize = 0;
            this.side_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.side_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.side_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.side_btn.ForeColor = System.Drawing.Color.Transparent;
            this.side_btn.Location = new System.Drawing.Point(9, 12);
            this.side_btn.Name = "side_btn";
            this.side_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.side_btn.Size = new System.Drawing.Size(45, 45);
            this.side_btn.TabIndex = 4;
            this.side_btn.TabStop = false;
            this.side_btn.UseVisualStyleBackColor = false;
            this.side_btn.Click += new System.EventHandler(this.side_btn_Click);
            // 
            // SideBar
            // 
            this.SideBar.AutoScroll = true;
            this.SideBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.SideBar.Controls.Add(this.panel9);
            this.SideBar.Controls.Add(this.Theory_panel);
            this.SideBar.Controls.Add(this.panel1);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.MaximumSize = new System.Drawing.Size(305, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(305, 677);
            this.SideBar.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel9.Controls.Add(this.btn_GeneralInfo);
            this.panel9.Location = new System.Drawing.Point(20, 3);
            this.panel9.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.panel9.MaximumSize = new System.Drawing.Size(265, 35);
            this.panel9.MinimumSize = new System.Drawing.Size(0, 35);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(265, 35);
            this.panel9.TabIndex = 13;
            // 
            // btn_GeneralInfo
            // 
            this.btn_GeneralInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_GeneralInfo.FlatAppearance.BorderSize = 0;
            this.btn_GeneralInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_GeneralInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_GeneralInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GeneralInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_GeneralInfo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_GeneralInfo.Location = new System.Drawing.Point(0, 0);
            this.btn_GeneralInfo.Name = "btn_GeneralInfo";
            this.btn_GeneralInfo.Size = new System.Drawing.Size(265, 35);
            this.btn_GeneralInfo.TabIndex = 1;
            this.btn_GeneralInfo.Text = "Загальна інформація";
            this.btn_GeneralInfo.UseVisualStyleBackColor = true;
            this.btn_GeneralInfo.Click += new System.EventHandler(this.btn_GeneralInfo_Click);
            // 
            // Theory_panel
            // 
            this.Theory_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Theory_panel.Controls.Add(this.time_compl_btn);
            this.Theory_panel.Controls.Add(this.btn_Random);
            this.Theory_panel.Controls.Add(this.btn_Merge);
            this.Theory_panel.Controls.Add(this.btn_Select);
            this.Theory_panel.Controls.Add(this.btn_Count);
            this.Theory_panel.Controls.Add(this.btn_Inserion);
            this.Theory_panel.Controls.Add(this.btn_Comb);
            this.Theory_panel.Controls.Add(this.btn_Shaker);
            this.Theory_panel.Controls.Add(this.btn_Radix);
            this.Theory_panel.Controls.Add(this.btn_Shell);
            this.Theory_panel.Controls.Add(this.btn_Quick);
            this.Theory_panel.Controls.Add(this.btn_bubble);
            this.Theory_panel.Controls.Add(this.theory_btn);
            this.Theory_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Theory_panel.Location = new System.Drawing.Point(20, 44);
            this.Theory_panel.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.Theory_panel.MaximumSize = new System.Drawing.Size(265, 465);
            this.Theory_panel.MinimumSize = new System.Drawing.Size(0, 35);
            this.Theory_panel.Name = "Theory_panel";
            this.Theory_panel.Size = new System.Drawing.Size(265, 465);
            this.Theory_panel.TabIndex = 0;
            // 
            // time_compl_btn
            // 
            this.time_compl_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.time_compl_btn.FlatAppearance.BorderSize = 0;
            this.time_compl_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.time_compl_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.time_compl_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.time_compl_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_compl_btn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.time_compl_btn.Location = new System.Drawing.Point(0, 420);
            this.time_compl_btn.Name = "time_compl_btn";
            this.time_compl_btn.Size = new System.Drawing.Size(265, 35);
            this.time_compl_btn.TabIndex = 30;
            this.time_compl_btn.Text = "Часова складність";
            this.time_compl_btn.UseVisualStyleBackColor = true;
            this.time_compl_btn.Click += new System.EventHandler(this.time_compl_btn_Click);
            // 
            // btn_Random
            // 
            this.btn_Random.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Random.FlatAppearance.BorderSize = 0;
            this.btn_Random.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Random.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Random.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Random.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Random.Location = new System.Drawing.Point(0, 385);
            this.btn_Random.Name = "btn_Random";
            this.btn_Random.Size = new System.Drawing.Size(265, 35);
            this.btn_Random.TabIndex = 29;
            this.btn_Random.Text = "Bogo/Permutation Sort";
            this.btn_Random.UseVisualStyleBackColor = true;
            this.btn_Random.Click += new System.EventHandler(this.btn_Random_Click);
            // 
            // btn_Merge
            // 
            this.btn_Merge.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Merge.FlatAppearance.BorderSize = 0;
            this.btn_Merge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Merge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Merge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Merge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Merge.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Merge.Location = new System.Drawing.Point(0, 350);
            this.btn_Merge.Name = "btn_Merge";
            this.btn_Merge.Size = new System.Drawing.Size(265, 35);
            this.btn_Merge.TabIndex = 28;
            this.btn_Merge.Text = "Merge Sort";
            this.btn_Merge.UseVisualStyleBackColor = true;
            this.btn_Merge.Click += new System.EventHandler(this.btn_Merge_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Select.FlatAppearance.BorderSize = 0;
            this.btn_Select.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Select.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Select.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Select.Location = new System.Drawing.Point(0, 315);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(265, 35);
            this.btn_Select.TabIndex = 27;
            this.btn_Select.Text = "Selection Sort";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_Count
            // 
            this.btn_Count.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Count.FlatAppearance.BorderSize = 0;
            this.btn_Count.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Count.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Count.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Count.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Count.Location = new System.Drawing.Point(0, 280);
            this.btn_Count.Name = "btn_Count";
            this.btn_Count.Size = new System.Drawing.Size(265, 35);
            this.btn_Count.TabIndex = 26;
            this.btn_Count.Text = "Counting Sort";
            this.btn_Count.UseVisualStyleBackColor = true;
            this.btn_Count.Click += new System.EventHandler(this.btn_Count_Click);
            // 
            // btn_Inserion
            // 
            this.btn_Inserion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Inserion.FlatAppearance.BorderSize = 0;
            this.btn_Inserion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Inserion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Inserion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inserion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Inserion.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Inserion.Location = new System.Drawing.Point(0, 245);
            this.btn_Inserion.Name = "btn_Inserion";
            this.btn_Inserion.Size = new System.Drawing.Size(265, 35);
            this.btn_Inserion.TabIndex = 25;
            this.btn_Inserion.Text = "Insertion Sort";
            this.btn_Inserion.UseVisualStyleBackColor = true;
            this.btn_Inserion.Click += new System.EventHandler(this.btn_Inserion_Click);
            // 
            // btn_Comb
            // 
            this.btn_Comb.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Comb.FlatAppearance.BorderSize = 0;
            this.btn_Comb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Comb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Comb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Comb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Comb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Comb.Location = new System.Drawing.Point(0, 210);
            this.btn_Comb.Name = "btn_Comb";
            this.btn_Comb.Size = new System.Drawing.Size(265, 35);
            this.btn_Comb.TabIndex = 24;
            this.btn_Comb.Text = "Comb Sort";
            this.btn_Comb.UseVisualStyleBackColor = true;
            this.btn_Comb.Click += new System.EventHandler(this.btn_Comb_Click);
            // 
            // btn_Shaker
            // 
            this.btn_Shaker.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Shaker.FlatAppearance.BorderSize = 0;
            this.btn_Shaker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Shaker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Shaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Shaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Shaker.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Shaker.Location = new System.Drawing.Point(0, 175);
            this.btn_Shaker.Name = "btn_Shaker";
            this.btn_Shaker.Size = new System.Drawing.Size(265, 35);
            this.btn_Shaker.TabIndex = 23;
            this.btn_Shaker.Text = "Shaker Sort";
            this.btn_Shaker.UseVisualStyleBackColor = true;
            this.btn_Shaker.Click += new System.EventHandler(this.btn_Shaker_Click);
            // 
            // btn_Radix
            // 
            this.btn_Radix.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Radix.FlatAppearance.BorderSize = 0;
            this.btn_Radix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Radix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Radix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Radix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Radix.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Radix.Location = new System.Drawing.Point(0, 140);
            this.btn_Radix.Name = "btn_Radix";
            this.btn_Radix.Size = new System.Drawing.Size(265, 35);
            this.btn_Radix.TabIndex = 22;
            this.btn_Radix.Text = "Radix Sort";
            this.btn_Radix.UseVisualStyleBackColor = true;
            this.btn_Radix.Click += new System.EventHandler(this.btn_Radix_Click);
            // 
            // btn_Shell
            // 
            this.btn_Shell.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Shell.FlatAppearance.BorderSize = 0;
            this.btn_Shell.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Shell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Shell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Shell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Shell.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Shell.Location = new System.Drawing.Point(0, 105);
            this.btn_Shell.Name = "btn_Shell";
            this.btn_Shell.Size = new System.Drawing.Size(265, 35);
            this.btn_Shell.TabIndex = 21;
            this.btn_Shell.Text = "Shell Sort";
            this.btn_Shell.UseVisualStyleBackColor = true;
            this.btn_Shell.Click += new System.EventHandler(this.btn_Shell_Click);
            // 
            // btn_Quick
            // 
            this.btn_Quick.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Quick.FlatAppearance.BorderSize = 0;
            this.btn_Quick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Quick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Quick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Quick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Quick.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Quick.Location = new System.Drawing.Point(0, 70);
            this.btn_Quick.Name = "btn_Quick";
            this.btn_Quick.Size = new System.Drawing.Size(265, 35);
            this.btn_Quick.TabIndex = 20;
            this.btn_Quick.Text = "Quick Sort";
            this.btn_Quick.UseVisualStyleBackColor = true;
            this.btn_Quick.Click += new System.EventHandler(this.btn_Quick_Click);
            // 
            // btn_bubble
            // 
            this.btn_bubble.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_bubble.FlatAppearance.BorderSize = 0;
            this.btn_bubble.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.btn_bubble.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.btn_bubble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_bubble.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_bubble.Location = new System.Drawing.Point(0, 35);
            this.btn_bubble.Name = "btn_bubble";
            this.btn_bubble.Size = new System.Drawing.Size(265, 35);
            this.btn_bubble.TabIndex = 19;
            this.btn_bubble.Text = "Bubble Sort";
            this.btn_bubble.UseVisualStyleBackColor = true;
            this.btn_bubble.Click += new System.EventHandler(this.bubble_theory_Click);
            // 
            // theory_btn
            // 
            this.theory_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.theory_btn.FlatAppearance.BorderSize = 0;
            this.theory_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.theory_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.theory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.theory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theory_btn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.theory_btn.Location = new System.Drawing.Point(0, 0);
            this.theory_btn.Name = "theory_btn";
            this.theory_btn.Size = new System.Drawing.Size(265, 35);
            this.theory_btn.TabIndex = 1;
            this.theory_btn.Text = "Теорія";
            this.theory_btn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.Practice);
            this.panel1.Location = new System.Drawing.Point(20, 515);
            this.panel1.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.panel1.MaximumSize = new System.Drawing.Size(265, 35);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 45);
            this.panel1.TabIndex = 14;
            // 
            // Practice
            // 
            this.Practice.Dock = System.Windows.Forms.DockStyle.Top;
            this.Practice.FlatAppearance.BorderSize = 0;
            this.Practice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Practice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Practice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Practice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Practice.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Practice.Location = new System.Drawing.Point(0, 0);
            this.Practice.Name = "Practice";
            this.Practice.Size = new System.Drawing.Size(265, 35);
            this.Practice.TabIndex = 1;
            this.Practice.Text = "Тести";
            this.Practice.UseVisualStyleBackColor = true;
            this.Practice.Click += new System.EventHandler(this.Practice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1288, 677);
            this.Controls.Add(this.panel_UserControl);
            this.Controls.Add(this.SideBar);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Form1";
            this.Text = "AlgoGuide";
            this.panel_UserControl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.SideBar.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.Theory_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer MenuPanel_T;
        private System.Windows.Forms.Button side_btn;
        private System.Windows.Forms.Panel panel_UserControl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.FlowLayoutPanel SideBar;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btn_GeneralInfo;
        private System.Windows.Forms.Panel Theory_panel;
        private System.Windows.Forms.Button btn_Random;
        private System.Windows.Forms.Button btn_Merge;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_Count;
        private System.Windows.Forms.Button btn_Inserion;
        private System.Windows.Forms.Button btn_Comb;
        private System.Windows.Forms.Button btn_Shaker;
        private System.Windows.Forms.Button btn_Radix;
        private System.Windows.Forms.Button btn_Shell;
        private System.Windows.Forms.Button btn_Quick;
        private System.Windows.Forms.Button btn_bubble;
        private System.Windows.Forms.Button theory_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Practice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button time_compl_btn;
    }
}


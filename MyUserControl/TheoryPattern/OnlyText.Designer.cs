namespace SortAlgoGuide.MyUserControl.TheoryPattern
{
    partial class OnlyText
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
            this.LabelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelText
            // 
            this.LabelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelText.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelText.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LabelText.Location = new System.Drawing.Point(0, 0);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(1108, 621);
            this.LabelText.TabIndex = 1;
            this.LabelText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelText.UseCompatibleTextRendering = true;
            // 
            // OnlyText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LabelText);
            this.Name = "OnlyText";
            this.Size = new System.Drawing.Size(1108, 621);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelText;
    }
}

namespace SortAlgoGuide.MyForms
{
    partial class CustomDialogBox
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
            this.Message_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Message_label
            // 
            this.Message_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Message_label.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message_label.ForeColor = System.Drawing.Color.DarkGray;
            this.Message_label.Location = new System.Drawing.Point(0, 0);
            this.Message_label.Name = "Message_label";
            this.Message_label.Size = new System.Drawing.Size(470, 336);
            this.Message_label.TabIndex = 42;
            this.Message_label.Text = "..";
            this.Message_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(470, 336);
            this.Controls.Add(this.Message_label);
            this.Name = "CustomDialogBox";
            this.Text = "CustomDialogBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Message_label;
    }
}
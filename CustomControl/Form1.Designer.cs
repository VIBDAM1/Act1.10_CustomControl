namespace CustomControl
{
    partial class Form1
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
            this.roundedPanel1 = new CustomControl.RoundedPanel();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.IndianRed;
            this.roundedPanel1.BorderRadius = 90;
            this.roundedPanel1.BorderSize = 12;
            this.roundedPanel1.Location = new System.Drawing.Point(238, 120);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.ShowBorder = true;
            this.roundedPanel1.Size = new System.Drawing.Size(200, 100);
            this.roundedPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundedPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel1;
    }
}
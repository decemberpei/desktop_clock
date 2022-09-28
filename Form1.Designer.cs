
namespace Clock2
{
    partial class Clock
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
            this.txt_clock = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_clock
            // 
            this.txt_clock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_clock.Enabled = false;
            this.txt_clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clock.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_clock.Location = new System.Drawing.Point(12, 12);
            this.txt_clock.Name = "txt_clock";
            this.txt_clock.Size = new System.Drawing.Size(344, 91);
            this.txt_clock.TabIndex = 0;
            this.txt_clock.Text = "12:12:12";
            this.txt_clock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FormClosing += Clock_FormClosing;
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(368, 116);
            this.Controls.Add(this.txt_clock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clock";
            this.ShowIcon = false;
            this.Text = "Clock";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_clock;
    }
}


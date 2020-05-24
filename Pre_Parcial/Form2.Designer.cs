using System.ComponentModel;

namespace Pre_Parcial
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.normalUser1 = new Pre_Parcial.NormalUser();
            this.SuspendLayout();
            // 
            // normalUser1
            // 
            this.normalUser1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.normalUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.normalUser1.Location = new System.Drawing.Point(0, 0);
            this.normalUser1.Name = "normalUser1";
            this.normalUser1.Size = new System.Drawing.Size(465, 268);
            this.normalUser1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 268);
            this.Controls.Add(this.normalUser1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
        }

        private Pre_Parcial.NormalUser normalUser1;

        #endregion
    }
}
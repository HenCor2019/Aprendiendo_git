﻿using System.ComponentModel;

namespace Pre_Parcial
{
    partial class Form1
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
            this.administrador1 = new Pre_Parcial.Administrador();
            this.SuspendLayout();
            // 
            // administrador1
            // 
            this.administrador1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.administrador1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.administrador1.Location = new System.Drawing.Point(0, 0);
            this.administrador1.Name = "administrador1";
            this.administrador1.Size = new System.Drawing.Size(488, 279);
            this.administrador1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AccessibleDescription = "ffsfsdfsfsdf";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 279);
            this.Controls.Add(this.administrador1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private Pre_Parcial.Administrador administrador1;

        #endregion
    }
}
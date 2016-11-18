﻿using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace SIF.Visualization.Excel
{
    [ComVisible(true)]
    partial class CellErrorInfoContainer
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();            // 

            // elementHost1
            // 
            this.elementHost1.SuspendLayout();
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.BackColorTransparent = true;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(150, 150);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.ElementHost1_ChildChanged);
            this.elementHost1.Child = null;
            
            // 
            // CellErrorInfoContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.elementHost1);
            this.Name = "CellErrorInfoContainer";
            this.BackColor = Color.Transparent;
            this.elementHost1.ResumeLayout(true);
            this.ResumeLayout(true);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
    }
}

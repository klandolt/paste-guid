﻿namespace NewGuid
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.getnewGuid = new System.Windows.Forms.Button();
            this.guidTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // getnewGuid
            // 
            this.getnewGuid.Location = new System.Drawing.Point(6, 18);
            this.getnewGuid.Name = "getnewGuid";
            this.getnewGuid.Size = new System.Drawing.Size(340, 70);
            this.getnewGuid.TabIndex = 0;
            this.getnewGuid.Text = "Get New Guid";
            this.getnewGuid.UseVisualStyleBackColor = true;
            this.getnewGuid.Click += new System.EventHandler(this.getnewGuid_Click);
            // 
            // guidTextBox
            // 
            this.guidTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guidTextBox.Location = new System.Drawing.Point(8, 108);
            this.guidTextBox.Name = "guidTextBox";
            this.guidTextBox.Size = new System.Drawing.Size(338, 26);
            this.guidTextBox.TabIndex = 1;
            this.guidTextBox.Text = "Push the Button for new GUID";
            this.guidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 146);
            this.Controls.Add(this.guidTextBox);
            this.Controls.Add(this.getnewGuid);
            this.Name = "Form1";
            this.Text = "New Guid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getnewGuid;
        private System.Windows.Forms.TextBox guidTextBox;
    }
}

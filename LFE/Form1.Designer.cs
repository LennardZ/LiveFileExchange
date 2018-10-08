using System;

namespace LFE
{
    partial class LifeFileExchangeForm
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
            this.btnExchange = new System.Windows.Forms.Button();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExchange
            // 
            this.btnExchange.Location = new System.Drawing.Point(400, 150);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(100, 50);
            this.btnExchange.TabIndex = 0;
            this.btnExchange.Text = "Exchange";
            this.btnExchange.UseVisualStyleBackColor = true;
            this.btnExchange.Click += new EventHandler(btnExchangeClick);
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(50, 50);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(450, 26);
            this.txtPw.TabIndex = 1;

            
            // 
            // LifeFileExchangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 244);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.btnExchange);
            this.Name = "LifeFileExchangeForm";
            this.Text = "LifeFileExchange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnExchangeClick(object sender, System.EventArgs e)
        {
            Program.btnExchange(this.txtPw.Text);
        }

        #endregion

        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.TextBox txtPw;
    }
}


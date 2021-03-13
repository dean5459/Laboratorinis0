
namespace Laboratorinis0
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
            this.comboBoxModuliuSarasas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxModuliuSarasas
            // 
            this.comboBoxModuliuSarasas.FormattingEnabled = true;
            this.comboBoxModuliuSarasas.Location = new System.Drawing.Point(369, 66);
            this.comboBoxModuliuSarasas.Name = "comboBoxModuliuSarasas";
            this.comboBoxModuliuSarasas.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModuliuSarasas.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxModuliuSarasas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxModuliuSarasas;
    }
}


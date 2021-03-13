
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
            this.buttonPridetiModuli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxModuliuSarasas
            // 
            this.comboBoxModuliuSarasas.FormattingEnabled = true;
            this.comboBoxModuliuSarasas.Location = new System.Drawing.Point(322, 12);
            this.comboBoxModuliuSarasas.Name = "comboBoxModuliuSarasas";
            this.comboBoxModuliuSarasas.Size = new System.Drawing.Size(170, 21);
            this.comboBoxModuliuSarasas.TabIndex = 0;
            // 
            // buttonPridetiModuli
            // 
            this.buttonPridetiModuli.Location = new System.Drawing.Point(227, 12);
            this.buttonPridetiModuli.Name = "buttonPridetiModuli";
            this.buttonPridetiModuli.Size = new System.Drawing.Size(75, 23);
            this.buttonPridetiModuli.TabIndex = 1;
            this.buttonPridetiModuli.Text = "button1";
            this.buttonPridetiModuli.UseVisualStyleBackColor = true;
            this.buttonPridetiModuli.Click += new System.EventHandler(this.buttonPridetiModuli_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPridetiModuli);
            this.Controls.Add(this.comboBoxModuliuSarasas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxModuliuSarasas;
        private System.Windows.Forms.Button buttonPridetiModuli;
    }
}


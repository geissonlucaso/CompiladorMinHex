
namespace CompiladorMinHex
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
            this.gpbMnemonico = new System.Windows.Forms.GroupBox();
            this.gpbHexadecimal = new System.Windows.Forms.GroupBox();
            this.ltbMnemonico = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ltbHexadecimal = new System.Windows.Forms.ListBox();
            this.btnAbrirMne = new System.Windows.Forms.Button();
            this.gpbMnemonico.SuspendLayout();
            this.gpbHexadecimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbMnemonico
            // 
            this.gpbMnemonico.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gpbMnemonico.Controls.Add(this.btnAbrirMne);
            this.gpbMnemonico.Controls.Add(this.ltbMnemonico);
            this.gpbMnemonico.Location = new System.Drawing.Point(12, 91);
            this.gpbMnemonico.Name = "gpbMnemonico";
            this.gpbMnemonico.Size = new System.Drawing.Size(281, 426);
            this.gpbMnemonico.TabIndex = 0;
            this.gpbMnemonico.TabStop = false;
            this.gpbMnemonico.Text = "Mnemônico";
            // 
            // gpbHexadecimal
            // 
            this.gpbHexadecimal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gpbHexadecimal.Controls.Add(this.ltbHexadecimal);
            this.gpbHexadecimal.Location = new System.Drawing.Point(449, 91);
            this.gpbHexadecimal.Name = "gpbHexadecimal";
            this.gpbHexadecimal.Size = new System.Drawing.Size(281, 426);
            this.gpbHexadecimal.TabIndex = 1;
            this.gpbHexadecimal.TabStop = false;
            this.gpbHexadecimal.Text = "Hexadecimal";
            // 
            // ltbMnemonico
            // 
            this.ltbMnemonico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbMnemonico.FormattingEnabled = true;
            this.ltbMnemonico.ItemHeight = 20;
            this.ltbMnemonico.Location = new System.Drawing.Point(6, 28);
            this.ltbMnemonico.Name = "ltbMnemonico";
            this.ltbMnemonico.Size = new System.Drawing.Size(269, 304);
            this.ltbMnemonico.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(15, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(246, 32);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Compilador Mne-Hex";
            // 
            // ltbHexadecimal
            // 
            this.ltbHexadecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbHexadecimal.FormattingEnabled = true;
            this.ltbHexadecimal.ItemHeight = 20;
            this.ltbHexadecimal.Location = new System.Drawing.Point(6, 28);
            this.ltbHexadecimal.Name = "ltbHexadecimal";
            this.ltbHexadecimal.Size = new System.Drawing.Size(269, 304);
            this.ltbHexadecimal.TabIndex = 3;
            // 
            // btnAbrirMne
            // 
            this.btnAbrirMne.Location = new System.Drawing.Point(200, 337);
            this.btnAbrirMne.Name = "btnAbrirMne";
            this.btnAbrirMne.Size = new System.Drawing.Size(75, 83);
            this.btnAbrirMne.TabIndex = 3;
            this.btnAbrirMne.Text = "Abrir";
            this.btnAbrirMne.UseVisualStyleBackColor = true;
            this.btnAbrirMne.Click += new System.EventHandler(this.btnAbrirMne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(742, 529);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gpbHexadecimal);
            this.Controls.Add(this.gpbMnemonico);
            this.Name = "Form1";
            this.Text = "Mne-Hex";
            this.gpbMnemonico.ResumeLayout(false);
            this.gpbHexadecimal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbMnemonico;
        private System.Windows.Forms.GroupBox gpbHexadecimal;
        private System.Windows.Forms.Button btnAbrirMne;
        private System.Windows.Forms.ListBox ltbMnemonico;
        private System.Windows.Forms.ListBox ltbHexadecimal;
        private System.Windows.Forms.Label lblTitulo;
    }
}



namespace ATIVIDADE8
{
    partial class frmExercicio3
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
            this.lblPalindromo = new System.Windows.Forms.Label();
            this.txtVerify = new System.Windows.Forms.TextBox();
            this.btnExceute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalindromo
            // 
            this.lblPalindromo.AutoSize = true;
            this.lblPalindromo.Location = new System.Drawing.Point(136, 83);
            this.lblPalindromo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPalindromo.Name = "lblPalindromo";
            this.lblPalindromo.Size = new System.Drawing.Size(237, 13);
            this.lblPalindromo.TabIndex = 0;
            this.lblPalindromo.Text = "Digite uma palavra para verificar se é Palindromo";
            // 
            // txtVerify
            // 
            this.txtVerify.Location = new System.Drawing.Point(153, 124);
            this.txtVerify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVerify.Name = "txtVerify";
            this.txtVerify.Size = new System.Drawing.Size(205, 20);
            this.txtVerify.TabIndex = 1;
            // 
            // btnExceute
            // 
            this.btnExceute.Location = new System.Drawing.Point(193, 164);
            this.btnExceute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExceute.Name = "btnExceute";
            this.btnExceute.Size = new System.Drawing.Size(122, 64);
            this.btnExceute.TabIndex = 2;
            this.btnExceute.Text = "Exceutar";
            this.btnExceute.UseVisualStyleBackColor = true;
            this.btnExceute.Click += new System.EventHandler(this.btnExceute_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnExceute);
            this.Controls.Add(this.txtVerify);
            this.Controls.Add(this.lblPalindromo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmExercicio3";
            this.Text = "Palindromo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalindromo;
        private System.Windows.Forms.TextBox txtVerify;
        private System.Windows.Forms.Button btnExceute;
    }
}
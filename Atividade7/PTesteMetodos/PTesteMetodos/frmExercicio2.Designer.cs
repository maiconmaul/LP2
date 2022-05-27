
namespace PTesteMetodos
{
    partial class frmExercicio2
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
            this.lblPalavras2 = new System.Windows.Forms.Label();
            this.lblPalavras1 = new System.Windows.Forms.Label();
            this.btnComparar = new System.Windows.Forms.Button();
            this.btnInserir1 = new System.Windows.Forms.Button();
            this.btnInserir2 = new System.Windows.Forms.Button();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPalavras2
            // 
            this.lblPalavras2.AutoSize = true;
            this.lblPalavras2.Location = new System.Drawing.Point(51, 158);
            this.lblPalavras2.Name = "lblPalavras2";
            this.lblPalavras2.Size = new System.Drawing.Size(74, 20);
            this.lblPalavras2.TabIndex = 0;
            this.lblPalavras2.Text = "Palavra 2";
            // 
            // lblPalavras1
            // 
            this.lblPalavras1.AutoSize = true;
            this.lblPalavras1.Location = new System.Drawing.Point(51, 41);
            this.lblPalavras1.Name = "lblPalavras1";
            this.lblPalavras1.Size = new System.Drawing.Size(74, 20);
            this.lblPalavras1.TabIndex = 1;
            this.lblPalavras1.Text = "Palavra 1";
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(45, 269);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(167, 69);
            this.btnComparar.TabIndex = 2;
            this.btnComparar.Text = "Testar Iguais";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // btnInserir1
            // 
            this.btnInserir1.Location = new System.Drawing.Point(298, 269);
            this.btnInserir1.Name = "btnInserir1";
            this.btnInserir1.Size = new System.Drawing.Size(167, 69);
            this.btnInserir1.TabIndex = 3;
            this.btnInserir1.Text = "Inserir texto 1 no texto 2";
            this.btnInserir1.UseVisualStyleBackColor = true;
            this.btnInserir1.Click += new System.EventHandler(this.btnInserir1_Click);
            // 
            // btnInserir2
            // 
            this.btnInserir2.Location = new System.Drawing.Point(566, 269);
            this.btnInserir2.Name = "btnInserir2";
            this.btnInserir2.Size = new System.Drawing.Size(167, 69);
            this.btnInserir2.TabIndex = 4;
            this.btnInserir2.Text = "Inserir astericos";
            this.btnInserir2.UseVisualStyleBackColor = true;
            this.btnInserir2.Click += new System.EventHandler(this.btnInserir2_Click);
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(158, 158);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(266, 26);
            this.txtPalavra2.TabIndex = 5;
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(158, 38);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(266, 26);
            this.txtPalavra1.TabIndex = 6;
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.btnInserir2);
            this.Controls.Add(this.btnInserir1);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.lblPalavras1);
            this.Controls.Add(this.lblPalavras2);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavras2;
        private System.Windows.Forms.Label lblPalavras1;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Button btnInserir1;
        private System.Windows.Forms.Button btnInserir2;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
    }
}
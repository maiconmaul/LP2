
namespace PTesteMetodos
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
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.btnRemoveReplace = new System.Windows.Forms.Button();
            this.btnInverte = new System.Windows.Forms.Button();
            this.btnRemoveOcor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(229, 152);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(231, 26);
            this.txtPalavra2.TabIndex = 2;
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(229, 76);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(231, 26);
            this.txtPalavra1.TabIndex = 1;
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(146, 76);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(70, 20);
            this.lblPalavra1.TabIndex = 2;
            this.lblPalavra1.Text = "Palavra1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(146, 152);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(70, 20);
            this.lblPalavra2.TabIndex = 3;
            this.lblPalavra2.Text = "Palavra2";
            // 
            // btnRemoveReplace
            // 
            this.btnRemoveReplace.Location = new System.Drawing.Point(302, 280);
            this.btnRemoveReplace.Name = "btnRemoveReplace";
            this.btnRemoveReplace.Size = new System.Drawing.Size(158, 90);
            this.btnRemoveReplace.TabIndex = 4;
            this.btnRemoveReplace.Text = "Remove Ocorrencias (Replace)";
            this.btnRemoveReplace.UseVisualStyleBackColor = true;
            this.btnRemoveReplace.Click += new System.EventHandler(this.btnRemoveReplace_Click);
            // 
            // btnInverte
            // 
            this.btnInverte.Location = new System.Drawing.Point(573, 280);
            this.btnInverte.Name = "btnInverte";
            this.btnInverte.Size = new System.Drawing.Size(158, 90);
            this.btnInverte.TabIndex = 5;
            this.btnInverte.Text = "Inverte (Reverse)";
            this.btnInverte.UseVisualStyleBackColor = true;
            this.btnInverte.Click += new System.EventHandler(this.btnInverte_Click);
            // 
            // btnRemoveOcor
            // 
            this.btnRemoveOcor.Location = new System.Drawing.Point(39, 280);
            this.btnRemoveOcor.Name = "btnRemoveOcor";
            this.btnRemoveOcor.Size = new System.Drawing.Size(158, 90);
            this.btnRemoveOcor.TabIndex = 6;
            this.btnRemoveOcor.Text = "Remove Ocorrencias";
            this.btnRemoveOcor.UseVisualStyleBackColor = true;
            this.btnRemoveOcor.Click += new System.EventHandler(this.btnRemoveOcor_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveOcor);
            this.Controls.Add(this.btnInverte);
            this.Controls.Add(this.btnRemoveReplace);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.txtPalavra2);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.Button btnRemoveReplace;
        private System.Windows.Forms.Button btnInverte;
        private System.Windows.Forms.Button btnRemoveOcor;
    }
}
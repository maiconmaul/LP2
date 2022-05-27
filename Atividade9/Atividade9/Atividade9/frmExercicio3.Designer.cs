
namespace Atividade9
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
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblArrayList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(284, 244);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(172, 102);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "ARRAY LIST EXCLUI OTAVIO";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lblArrayList
            // 
            this.lblArrayList.AutoSize = true;
            this.lblArrayList.Location = new System.Drawing.Point(113, 178);
            this.lblArrayList.Name = "lblArrayList";
            this.lblArrayList.Size = new System.Drawing.Size(520, 20);
            this.lblArrayList.TabIndex = 1;
            this.lblArrayList.Text = "Ana, André, Deborá, Fátima, João, Janete, Otávio, Marcelo, Pedro, Thaís";
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblArrayList);
            this.Controls.Add(this.btnExecute);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.Load += new System.EventHandler(this.frmExercicio3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lblArrayList;
    }
}
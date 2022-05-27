
namespace Atividade9
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
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblMonthlyBill = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.listQtd = new System.Windows.Forms.ListBox();
            this.listPrc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(354, 195);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(219, 115);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "Inclusão de produtos";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lblMonthlyBill
            // 
            this.lblMonthlyBill.AutoSize = true;
            this.lblMonthlyBill.Location = new System.Drawing.Point(350, 71);
            this.lblMonthlyBill.Name = "lblMonthlyBill";
            this.lblMonthlyBill.Size = new System.Drawing.Size(156, 20);
            this.lblMonthlyBill.TabIndex = 1;
            this.lblMonthlyBill.Text = "Faturamento Mensal";
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(354, 125);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(165, 26);
            this.txtResult.TabIndex = 2;
            // 
            // listQtd
            // 
            this.listQtd.FormattingEnabled = true;
            this.listQtd.ItemHeight = 20;
            this.listQtd.Location = new System.Drawing.Point(55, 22);
            this.listQtd.Name = "listQtd";
            this.listQtd.Size = new System.Drawing.Size(120, 364);
            this.listQtd.TabIndex = 3;
            // 
            // listPrc
            // 
            this.listPrc.FormattingEnabled = true;
            this.listPrc.ItemHeight = 20;
            this.listPrc.Location = new System.Drawing.Point(203, 22);
            this.listPrc.Name = "listPrc";
            this.listPrc.Size = new System.Drawing.Size(120, 364);
            this.listPrc.TabIndex = 4;
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listPrc);
            this.Controls.Add(this.listQtd);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblMonthlyBill);
            this.Controls.Add(this.btnExecute);
            this.Name = "frmExercicio2";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lblMonthlyBill;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ListBox listQtd;
        private System.Windows.Forms.ListBox listPrc;
    }
}
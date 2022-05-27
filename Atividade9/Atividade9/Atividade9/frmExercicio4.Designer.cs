
namespace Atividade9
{
    partial class frmExercicio4
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
            this.lstbxAverageStudents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(8, 104);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(113, 64);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "CALCULAR MEDIA";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lstbxAverageStudents
            // 
            this.lstbxAverageStudents.FormattingEnabled = true;
            this.lstbxAverageStudents.Location = new System.Drawing.Point(182, 8);
            this.lstbxAverageStudents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstbxAverageStudents.Name = "lstbxAverageStudents";
            this.lstbxAverageStudents.Size = new System.Drawing.Size(250, 212);
            this.lstbxAverageStudents.TabIndex = 1;
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 248);
            this.Controls.Add(this.lstbxAverageStudents);
            this.Controls.Add(this.btnExecute);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ListBox lstbxAverageStudents;
    }
}
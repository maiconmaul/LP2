
namespace Atividade9
{
    partial class frmExercicio5
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
            this.lstbxContWordNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(317, 305);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(120, 62);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "EXECUTAR";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstbxContWordNames
            // 
            this.lstbxContWordNames.ColumnWidth = 5;
            this.lstbxContWordNames.FormattingEnabled = true;
            this.lstbxContWordNames.ItemHeight = 20;
            this.lstbxContWordNames.Location = new System.Drawing.Point(161, 21);
            this.lstbxContWordNames.MultiColumn = true;
            this.lstbxContWordNames.Name = "lstbxContWordNames";
            this.lstbxContWordNames.Size = new System.Drawing.Size(570, 264);
            this.lstbxContWordNames.TabIndex = 1;
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 419);
            this.Controls.Add(this.lstbxContWordNames);
            this.Controls.Add(this.btnExecute);
            this.Name = "frmExercicio5";
            this.Text = "frmExercicio5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ListBox lstbxContWordNames;
    }
}
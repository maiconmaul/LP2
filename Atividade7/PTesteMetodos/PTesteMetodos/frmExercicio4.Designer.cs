
namespace PTesteMetodos
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
            this.rchtxtText = new System.Windows.Forms.RichTextBox();
            this.btnFindSpace = new System.Windows.Forms.Button();
            this.btnContNum = new System.Windows.Forms.Button();
            this.btnContLetters = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtText
            // 
            this.rchtxtText.Location = new System.Drawing.Point(-2, 1);
            this.rchtxtText.Name = "rchtxtText";
            this.rchtxtText.Size = new System.Drawing.Size(802, 254);
            this.rchtxtText.TabIndex = 0;
            this.rchtxtText.Text = "";
            // 
            // btnFindSpace
            // 
            this.btnFindSpace.Location = new System.Drawing.Point(320, 298);
            this.btnFindSpace.Name = "btnFindSpace";
            this.btnFindSpace.Size = new System.Drawing.Size(169, 95);
            this.btnFindSpace.TabIndex = 1;
            this.btnFindSpace.Text = "localiza primeiro espaço em branco e posição";
            this.btnFindSpace.UseVisualStyleBackColor = true;
            this.btnFindSpace.Click += new System.EventHandler(this.btnFindSpace_Click);
            // 
            // btnContNum
            // 
            this.btnContNum.Location = new System.Drawing.Point(75, 298);
            this.btnContNum.Name = "btnContNum";
            this.btnContNum.Size = new System.Drawing.Size(169, 95);
            this.btnContNum.TabIndex = 2;
            this.btnContNum.Text = "Contador de numeros";
            this.btnContNum.UseVisualStyleBackColor = true;
            this.btnContNum.Click += new System.EventHandler(this.btnContNum_Click);
            // 
            // btnContLetters
            // 
            this.btnContLetters.Location = new System.Drawing.Point(545, 298);
            this.btnContLetters.Name = "btnContLetters";
            this.btnContLetters.Size = new System.Drawing.Size(169, 95);
            this.btnContLetters.TabIndex = 3;
            this.btnContLetters.Text = "Contador de letras";
            this.btnContLetters.UseVisualStyleBackColor = true;
            this.btnContLetters.Click += new System.EventHandler(this.btnContLetters_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContLetters);
            this.Controls.Add(this.btnContNum);
            this.Controls.Add(this.btnFindSpace);
            this.Controls.Add(this.rchtxtText);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtText;
        private System.Windows.Forms.Button btnFindSpace;
        private System.Windows.Forms.Button btnContNum;
        private System.Windows.Forms.Button btnContLetters;
    }
}
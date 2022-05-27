
namespace ATIVIDADE8
{
    partial class frmExercicio1
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
            this.rchtextTexto = new System.Windows.Forms.RichTextBox();
            this.btnContR = new System.Windows.Forms.Button();
            this.btnContSequel = new System.Windows.Forms.Button();
            this.btnContSpace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtextTexto
            // 
            this.rchtextTexto.Location = new System.Drawing.Point(8, 8);
            this.rchtextTexto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rchtextTexto.MaxLength = 100;
            this.rchtextTexto.Name = "rchtextTexto";
            this.rchtextTexto.Size = new System.Drawing.Size(519, 177);
            this.rchtextTexto.TabIndex = 1;
            this.rchtextTexto.Tag = "";
            this.rchtextTexto.Text = "";
            // 
            // btnContR
            // 
            this.btnContR.Location = new System.Drawing.Point(205, 214);
            this.btnContR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnContR.Name = "btnContR";
            this.btnContR.Size = new System.Drawing.Size(121, 53);
            this.btnContR.TabIndex = 3;
            this.btnContR.Text = "Contador de letras \"R\"";
            this.btnContR.UseVisualStyleBackColor = true;
            this.btnContR.Click += new System.EventHandler(this.btnContR_Click);
            // 
            // btnContSequel
            // 
            this.btnContSequel.Location = new System.Drawing.Point(375, 214);
            this.btnContSequel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnContSequel.Name = "btnContSequel";
            this.btnContSequel.Size = new System.Drawing.Size(121, 53);
            this.btnContSequel.TabIndex = 4;
            this.btnContSequel.Text = "Contador de letras iguais seguidos";
            this.btnContSequel.UseVisualStyleBackColor = true;
            this.btnContSequel.Click += new System.EventHandler(this.btnContSequel_Click);
            // 
            // btnContSpace
            // 
            this.btnContSpace.Location = new System.Drawing.Point(31, 214);
            this.btnContSpace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnContSpace.Name = "btnContSpace";
            this.btnContSpace.Size = new System.Drawing.Size(121, 53);
            this.btnContSpace.TabIndex = 2;
            this.btnContSpace.Text = "Contador de espaços em branco";
            this.btnContSpace.UseVisualStyleBackColor = true;
            this.btnContSpace.Click += new System.EventHandler(this.btnContSpace_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnContSpace);
            this.Controls.Add(this.btnContSequel);
            this.Controls.Add(this.btnContR);
            this.Controls.Add(this.rchtextTexto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmExercicio1";
            this.Text = "Contador de textos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtextTexto;
        private System.Windows.Forms.Button btnContR;
        private System.Windows.Forms.Button btnContSequel;
        private System.Windows.Forms.Button btnContSpace;
    }
}
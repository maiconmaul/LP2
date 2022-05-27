
namespace ATIVIDADE8
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
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtProduction = new System.Windows.Forms.TextBox();
            this.txtRegistration = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtResultGrossWage = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblFunc = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.lblGrossWage = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.cbxFunction = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(176, 240);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(241, 26);
            this.txtBonus.TabIndex = 5;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(176, 388);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(241, 26);
            this.txtSalary.TabIndex = 7;
            // 
            // txtProduction
            // 
            this.txtProduction.Location = new System.Drawing.Point(176, 170);
            this.txtProduction.Name = "txtProduction";
            this.txtProduction.Size = new System.Drawing.Size(241, 26);
            this.txtProduction.TabIndex = 4;
            // 
            // txtRegistration
            // 
            this.txtRegistration.Location = new System.Drawing.Point(176, 100);
            this.txtRegistration.Name = "txtRegistration";
            this.txtRegistration.Size = new System.Drawing.Size(241, 26);
            this.txtRegistration.TabIndex = 3;
            this.txtRegistration.Validated += new System.EventHandler(this.txtRegistration_Validated);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(176, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(241, 26);
            this.txtName.TabIndex = 2;
            this.txtName.Validated += new System.EventHandler(this.txtName_Validated);
            // 
            // txtResultGrossWage
            // 
            this.txtResultGrossWage.Enabled = false;
            this.txtResultGrossWage.Location = new System.Drawing.Point(534, 153);
            this.txtResultGrossWage.Name = "txtResultGrossWage";
            this.txtResultGrossWage.ReadOnly = true;
            this.txtResultGrossWage.Size = new System.Drawing.Size(254, 26);
            this.txtResultGrossWage.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(72, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Nome";
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(72, 100);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(73, 20);
            this.lblReg.TabIndex = 8;
            this.lblReg.Text = "Matricula";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Location = new System.Drawing.Point(72, 170);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(77, 20);
            this.lblProd.TabIndex = 9;
            this.lblProd.Text = "Produção";
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(72, 240);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(95, 20);
            this.lblBonus.TabIndex = 10;
            this.lblBonus.Text = "Gratificação";
            // 
            // lblFunc
            // 
            this.lblFunc.AutoSize = true;
            this.lblFunc.Location = new System.Drawing.Point(72, 337);
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.Size = new System.Drawing.Size(52, 20);
            this.lblFunc.TabIndex = 11;
            this.lblFunc.Text = "Cargo";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Location = new System.Drawing.Point(72, 388);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(58, 20);
            this.lblSal.TabIndex = 12;
            this.lblSal.Text = "Salário";
            // 
            // lblGrossWage
            // 
            this.lblGrossWage.AutoSize = true;
            this.lblGrossWage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrossWage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossWage.Location = new System.Drawing.Point(612, 100);
            this.lblGrossWage.Name = "lblGrossWage";
            this.lblGrossWage.Size = new System.Drawing.Size(153, 28);
            this.lblGrossWage.TabIndex = 13;
            this.lblGrossWage.Text = "Salario Bruto";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(614, 209);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(126, 57);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "CALCULAR";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // cbxFunction
            // 
            this.cbxFunction.FormattingEnabled = true;
            this.cbxFunction.Items.AddRange(new object[] {
            "Eng. Computação",
            "Eng. Banco Dados",
            "Eng. Produção",
            "Dev. Mobile",
            "Dev. Front-End",
            "Dev. Back-End"});
            this.cbxFunction.Location = new System.Drawing.Point(176, 337);
            this.cbxFunction.Name = "cbxFunction";
            this.cbxFunction.Size = new System.Drawing.Size(241, 28);
            this.cbxFunction.TabIndex = 6;
            this.cbxFunction.Validated += new System.EventHandler(this.cbxFunction_Validated);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxFunction);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblGrossWage);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblFunc);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtResultGrossWage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRegistration);
            this.Controls.Add(this.txtProduction);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtBonus);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtProduction;
        private System.Windows.Forms.TextBox txtRegistration;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtResultGrossWage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblFunc;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label lblGrossWage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ComboBox cbxFunction;
    }
}
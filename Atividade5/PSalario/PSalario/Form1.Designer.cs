namespace PSalario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxQtdFilhos = new System.Windows.Forms.ComboBox();
            this.mskbxSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.pnlCasado = new System.Windows.Forms.Panel();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.rbxFemin = new System.Windows.Forms.RadioButton();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.lblNumFilhos = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblALiquotINSS = new System.Windows.Forms.Label();
            this.lblAliquotIRPF = new System.Windows.Forms.Label();
            this.lblSalFamilia = new System.Windows.Forms.Label();
            this.lblSalLiquido = new System.Windows.Forms.Label();
            this.lblDescIRPF = new System.Windows.Forms.Label();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAliquotaInss = new System.Windows.Forms.TextBox();
            this.txtAliquotaIrpf = new System.Windows.Forms.TextBox();
            this.txtSalLiquido = new System.Windows.Forms.TextBox();
            this.txtSalFamilia = new System.Windows.Forms.TextBox();
            this.txtDescInss = new System.Windows.Forms.TextBox();
            this.txtDescIrpf = new System.Windows.Forms.TextBox();
            this.lblDados = new System.Windows.Forms.Label();
            this.pnlCasado.SuspendLayout();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxQtdFilhos
            // 
            this.cbxQtdFilhos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQtdFilhos.FormattingEnabled = true;
            this.cbxQtdFilhos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbxQtdFilhos.Location = new System.Drawing.Point(136, 105);
            this.cbxQtdFilhos.MaxDropDownItems = 5;
            this.cbxQtdFilhos.Name = "cbxQtdFilhos";
            this.cbxQtdFilhos.Size = new System.Drawing.Size(121, 21);
            this.cbxQtdFilhos.TabIndex = 2;
            this.cbxQtdFilhos.Tag = "";
            // 
            // mskbxSalBruto
            // 
            this.mskbxSalBruto.Location = new System.Drawing.Point(136, 60);
            this.mskbxSalBruto.Mask = "99999.00";
            this.mskbxSalBruto.Name = "mskbxSalBruto";
            this.mskbxSalBruto.Size = new System.Drawing.Size(100, 20);
            this.mskbxSalBruto.TabIndex = 1;
            // 
            // pnlCasado
            // 
            this.pnlCasado.Controls.Add(this.ckbxCasado);
            this.pnlCasado.Location = new System.Drawing.Point(500, 18);
            this.pnlCasado.Name = "pnlCasado";
            this.pnlCasado.Size = new System.Drawing.Size(120, 37);
            this.pnlCasado.TabIndex = 3;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Location = new System.Drawing.Point(3, 9);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(62, 17);
            this.ckbxCasado.TabIndex = 3;
            this.ckbxCasado.TabStop = false;
            this.ckbxCasado.Text = "Casado";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // rbxFemin
            // 
            this.rbxFemin.AutoSize = true;
            this.rbxFemin.Location = new System.Drawing.Point(14, 50);
            this.rbxFemin.Name = "rbxFemin";
            this.rbxFemin.Size = new System.Drawing.Size(67, 17);
            this.rbxFemin.TabIndex = 5;
            this.rbxFemin.Text = "Feminino";
            this.rbxFemin.UseVisualStyleBackColor = true;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(310, 340);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(168, 46);
            this.btnExecutar.TabIndex = 6;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Checked = true;
            this.rbtnMasc.Location = new System.Drawing.Point(14, 19);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasc.TabIndex = 4;
            this.rbtnMasc.TabStop = true;
            this.rbtnMasc.Text = "Masculino";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbxFemin);
            this.gbxSexo.Controls.Add(this.rbtnMasc);
            this.gbxSexo.Location = new System.Drawing.Point(500, 61);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(120, 83);
            this.gbxSexo.TabIndex = 4;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // lblNumFilhos
            // 
            this.lblNumFilhos.AutoSize = true;
            this.lblNumFilhos.Location = new System.Drawing.Point(22, 108);
            this.lblNumFilhos.Name = "lblNumFilhos";
            this.lblNumFilhos.Size = new System.Drawing.Size(107, 13);
            this.lblNumFilhos.TabIndex = 20;
            this.lblNumFilhos.Text = "Quantidade de filhos:";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Location = new System.Drawing.Point(22, 63);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(69, 13);
            this.lblSalBruto.TabIndex = 22;
            this.lblSalBruto.Text = "Salário bruto:";
            // 
            // lblALiquotINSS
            // 
            this.lblALiquotINSS.AutoSize = true;
            this.lblALiquotINSS.Location = new System.Drawing.Point(22, 226);
            this.lblALiquotINSS.Name = "lblALiquotINSS";
            this.lblALiquotINSS.Size = new System.Drawing.Size(73, 13);
            this.lblALiquotINSS.TabIndex = 21;
            this.lblALiquotINSS.Text = "Aliquota INSS";
            // 
            // lblAliquotIRPF
            // 
            this.lblAliquotIRPF.AutoSize = true;
            this.lblAliquotIRPF.Location = new System.Drawing.Point(22, 284);
            this.lblAliquotIRPF.Name = "lblAliquotIRPF";
            this.lblAliquotIRPF.Size = new System.Drawing.Size(72, 13);
            this.lblAliquotIRPF.TabIndex = 19;
            this.lblAliquotIRPF.Text = "Aliquota IRPF";
            // 
            // lblSalFamilia
            // 
            this.lblSalFamilia.AutoSize = true;
            this.lblSalFamilia.Location = new System.Drawing.Point(278, 284);
            this.lblSalFamilia.Name = "lblSalFamilia";
            this.lblSalFamilia.Size = new System.Drawing.Size(73, 13);
            this.lblSalFamilia.TabIndex = 16;
            this.lblSalFamilia.Text = "Salário família";
            // 
            // lblSalLiquido
            // 
            this.lblSalLiquido.AutoSize = true;
            this.lblSalLiquido.Location = new System.Drawing.Point(278, 226);
            this.lblSalLiquido.Name = "lblSalLiquido";
            this.lblSalLiquido.Size = new System.Drawing.Size(74, 13);
            this.lblSalLiquido.TabIndex = 15;
            this.lblSalLiquido.Text = "Salário líquido";
            // 
            // lblDescIRPF
            // 
            this.lblDescIRPF.AutoSize = true;
            this.lblDescIRPF.Location = new System.Drawing.Point(524, 284);
            this.lblDescIRPF.Name = "lblDescIRPF";
            this.lblDescIRPF.Size = new System.Drawing.Size(95, 13);
            this.lblDescIRPF.TabIndex = 14;
            this.lblDescIRPF.Text = "Desconto de IRPF";
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Location = new System.Drawing.Point(524, 226);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(96, 13);
            this.lblDescINSS.TabIndex = 18;
            this.lblDescINSS.Text = "Desconto de INSS";
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Location = new System.Drawing.Point(22, 21);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(108, 13);
            this.lblNomeFunc.TabIndex = 8;
            this.lblNomeFunc.Text = "Nome do funcionário:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(136, 18);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(257, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // txtAliquotaInss
            // 
            this.txtAliquotaInss.Enabled = false;
            this.txtAliquotaInss.Location = new System.Drawing.Point(136, 223);
            this.txtAliquotaInss.Name = "txtAliquotaInss";
            this.txtAliquotaInss.ReadOnly = true;
            this.txtAliquotaInss.Size = new System.Drawing.Size(100, 20);
            this.txtAliquotaInss.TabIndex = 7;
            // 
            // txtAliquotaIrpf
            // 
            this.txtAliquotaIrpf.Enabled = false;
            this.txtAliquotaIrpf.Location = new System.Drawing.Point(136, 281);
            this.txtAliquotaIrpf.Name = "txtAliquotaIrpf";
            this.txtAliquotaIrpf.ReadOnly = true;
            this.txtAliquotaIrpf.Size = new System.Drawing.Size(100, 20);
            this.txtAliquotaIrpf.TabIndex = 8;
            // 
            // txtSalLiquido
            // 
            this.txtSalLiquido.Enabled = false;
            this.txtSalLiquido.Location = new System.Drawing.Point(398, 223);
            this.txtSalLiquido.Name = "txtSalLiquido";
            this.txtSalLiquido.ReadOnly = true;
            this.txtSalLiquido.Size = new System.Drawing.Size(100, 20);
            this.txtSalLiquido.TabIndex = 9;
            // 
            // txtSalFamilia
            // 
            this.txtSalFamilia.Enabled = false;
            this.txtSalFamilia.Location = new System.Drawing.Point(398, 281);
            this.txtSalFamilia.Name = "txtSalFamilia";
            this.txtSalFamilia.ReadOnly = true;
            this.txtSalFamilia.Size = new System.Drawing.Size(100, 20);
            this.txtSalFamilia.TabIndex = 10;
            // 
            // txtDescInss
            // 
            this.txtDescInss.Enabled = false;
            this.txtDescInss.Location = new System.Drawing.Point(648, 223);
            this.txtDescInss.Name = "txtDescInss";
            this.txtDescInss.ReadOnly = true;
            this.txtDescInss.Size = new System.Drawing.Size(100, 20);
            this.txtDescInss.TabIndex = 11;
            // 
            // txtDescIrpf
            // 
            this.txtDescIrpf.Enabled = false;
            this.txtDescIrpf.Location = new System.Drawing.Point(648, 281);
            this.txtDescIrpf.Name = "txtDescIrpf";
            this.txtDescIrpf.ReadOnly = true;
            this.txtDescIrpf.Size = new System.Drawing.Size(100, 20);
            this.txtDescIrpf.TabIndex = 12;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(22, 170);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(0, 13);
            this.lblDados.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 408);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.txtDescIrpf);
            this.Controls.Add(this.txtDescInss);
            this.Controls.Add(this.txtSalFamilia);
            this.Controls.Add(this.txtSalLiquido);
            this.Controls.Add(this.txtAliquotaIrpf);
            this.Controls.Add(this.txtAliquotaInss);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cbxQtdFilhos);
            this.Controls.Add(this.mskbxSalBruto);
            this.Controls.Add(this.pnlCasado);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.lblNumFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblALiquotINSS);
            this.Controls.Add(this.lblAliquotIRPF);
            this.Controls.Add(this.lblSalFamilia);
            this.Controls.Add(this.lblSalLiquido);
            this.Controls.Add(this.lblDescIRPF);
            this.Controls.Add(this.lblDescINSS);
            this.Controls.Add(this.lblNomeFunc);
            this.Name = "Form1";
            this.Text = "Calcular salario";
            this.pnlCasado.ResumeLayout(false);
            this.pnlCasado.PerformLayout();
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxQtdFilhos;
        private System.Windows.Forms.MaskedTextBox mskbxSalBruto;
        private System.Windows.Forms.Panel pnlCasado;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.RadioButton rbxFemin;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.Label lblNumFilhos;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblALiquotINSS;
        private System.Windows.Forms.Label lblAliquotIRPF;
        private System.Windows.Forms.Label lblSalFamilia;
        private System.Windows.Forms.Label lblSalLiquido;
        private System.Windows.Forms.Label lblDescIRPF;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAliquotaInss;
        private System.Windows.Forms.TextBox txtAliquotaIrpf;
        private System.Windows.Forms.TextBox txtSalLiquido;
        private System.Windows.Forms.TextBox txtSalFamilia;
        private System.Windows.Forms.TextBox txtDescInss;
        private System.Windows.Forms.TextBox txtDescIrpf;
        private System.Windows.Forms.Label lblDados;
    }
}


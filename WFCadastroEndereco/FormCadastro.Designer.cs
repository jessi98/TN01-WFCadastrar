namespace WFCadastroEndereco
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            lblNomeCompleto = new Label();
            txtNomeCompleto = new TextBox();
            btnSalvar = new Button();
            label1 = new Label();
            lblCep = new Label();
            mtbCep = new MaskedTextBox();
            lblLogradouro = new Label();
            txtLogradouro = new TextBox();
            txtNumero = new TextBox();
            lblNumero = new Label();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            txtBairro = new TextBox();
            lblBairro = new Label();
            txtCidade = new TextBox();
            lblCidade = new Label();
            lblUf = new Label();
            cbxUf = new ComboBox();
            chkSemNumero = new CheckBox();
            SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(25, 47);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(99, 15);
            lblNomeCompleto.TabIndex = 0;
            lblNomeCompleto.Text = "Nome Completo:";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(25, 65);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(377, 23);
            txtNomeCompleto.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(169, 400);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 34);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(25, 107);
            label1.Name = "label1";
            label1.Size = new Size(378, 1);
            label1.TabIndex = 9;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(17, 133);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(31, 15);
            lblCep.TabIndex = 10;
            lblCep.Text = "CEP:";
            // 
            // mtbCep
            // 
            mtbCep.Location = new Point(21, 157);
            mtbCep.Mask = "00000-999";
            mtbCep.Name = "mtbCep";
            mtbCep.Size = new Size(59, 23);
            mtbCep.TabIndex = 2;
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(21, 202);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(72, 15);
            lblLogradouro.TabIndex = 12;
            lblLogradouro.Text = "Logradouro:";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(17, 220);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(198, 23);
            txtLogradouro.TabIndex = 3;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(221, 220);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(83, 23);
            txtNumero.TabIndex = 4;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(221, 202);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 14;
            lblNumero.Text = "Número:";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(17, 273);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(167, 23);
            txtComplemento.TabIndex = 6;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(21, 255);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(87, 15);
            lblComplemento.TabIndex = 16;
            lblComplemento.Text = "Complemento:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(235, 273);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(167, 23);
            txtBairro.TabIndex = 7;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(239, 255);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(41, 15);
            lblBairro.TabIndex = 18;
            lblBairro.Text = "Bairro:";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(17, 327);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(167, 23);
            txtCidade.TabIndex = 8;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(21, 309);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(47, 15);
            lblCidade.TabIndex = 20;
            lblCidade.Text = "Cidade:";
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new Point(239, 309);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(24, 15);
            lblUf.TabIndex = 22;
            lblUf.Text = "UF:";
            // 
            // cbxUf
            // 
            cbxUf.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUf.FormattingEnabled = true;
            cbxUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbxUf.Location = new Point(235, 327);
            cbxUf.Name = "cbxUf";
            cbxUf.Size = new Size(168, 23);
            cbxUf.TabIndex = 9;
            // 
            // chkSemNumero
            // 
            chkSemNumero.AutoSize = true;
            chkSemNumero.Location = new Point(311, 221);
            chkSemNumero.Name = "chkSemNumero";
            chkSemNumero.Size = new Size(101, 19);
            chkSemNumero.TabIndex = 5;
            chkSemNumero.Text = "Sem Número?";
            chkSemNumero.UseVisualStyleBackColor = true;
            chkSemNumero.CheckedChanged += chkSemNumero_CheckedChanged;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 467);
            Controls.Add(chkSemNumero);
            Controls.Add(cbxUf);
            Controls.Add(lblUf);
            Controls.Add(txtCidade);
            Controls.Add(lblCidade);
            Controls.Add(txtBairro);
            Controls.Add(lblBairro);
            Controls.Add(txtComplemento);
            Controls.Add(lblComplemento);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(txtLogradouro);
            Controls.Add(lblLogradouro);
            Controls.Add(mtbCep);
            Controls.Add(lblCep);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblNomeCompleto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private Button btnSalvar;
        private Label label1;
        private TextBox txtComplemento;
        private Label lblCep;
        private MaskedTextBox mtbCep;
        private Label lblLogradouro;
        private TextBox txtLogradouro;
        private TextBox txtNumero;
        private Label lblNumero;
        private Label lblComplemento;
        private TextBox txtBairro;
        private Label lblBairro;
        private TextBox txtCidade;
        private Label lblCidade;
        private Label lblUf;
        private ComboBox cbxUf;
        private CheckBox chkSemNumero;
    }
}
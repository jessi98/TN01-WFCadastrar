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
            maskedTextBox1 = new MaskedTextBox();
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
            btnSalvar.TabIndex = 8;
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
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(21, 157);
            maskedTextBox1.Mask = "00000-999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(59, 23);
            maskedTextBox1.TabIndex = 11;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 467);
            Controls.Add(maskedTextBox1);
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
        private TextBox textBox1;
        private Label lblCep;
        private MaskedTextBox maskedTextBox1;
    }
}
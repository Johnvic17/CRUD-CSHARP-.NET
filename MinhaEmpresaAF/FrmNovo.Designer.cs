namespace MinhaEmpresaAF
{
    partial class FrmNovo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtSalario = new MaskedTextBox();
            label4 = new Label();
            txtCargo = new ComboBox();
            txtDepartamento = new ComboBox();
            valueDate = new DateTimePicker();
            btnAdicionar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 136);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Salario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 64);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Cargo";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(118, 22);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(296, 23);
            txtNome.TabIndex = 1;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(118, 128);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(226, 23);
            txtSalario.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 97);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 2;
            label4.Text = "Departamento";
            // 
            // txtCargo
            // 
            txtCargo.FormattingEnabled = true;
            txtCargo.Items.AddRange(new object[] { "CEO", "Gerente", "TechLead", "ScrumMaster", "Desenvolvedor Sênior", "Desenvolvedor Pleno", "Desenvolvedor Junior", "Auxiliar de Logística", "Auxiliar Administrativo", "Auxiliar de TI", "Estagiário", "Jovem Aprendiz" });
            txtCargo.Location = new Point(118, 61);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(296, 23);
            txtCargo.TabIndex = 2;
            // 
            // txtDepartamento
            // 
            txtDepartamento.FormattingEnabled = true;
            txtDepartamento.Items.AddRange(new object[] { "Administração", "Financeiro", "Recursos Humanos (RH)", "Marketing e Vendas", "Operacional", "Tecnologia da Informação (TI)" });
            txtDepartamento.Location = new Point(118, 94);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(296, 23);
            txtDepartamento.TabIndex = 3;
            // 
            // valueDate
            // 
            valueDate.Location = new Point(29, 174);
            valueDate.Name = "valueDate";
            valueDate.Size = new Size(239, 23);
            valueDate.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(128, 255, 128);
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            btnAdicionar.ForeColor = SystemColors.ControlText;
            btnAdicionar.Location = new Point(379, 165);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(128, 37);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            btnCancelar.Location = new Point(379, 208);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 243);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdicionar);
            Controls.Add(valueDate);
            Controls.Add(txtDepartamento);
            Controls.Add(txtCargo);
            Controls.Add(txtSalario);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FrmNovo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Funcionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private MaskedTextBox txtSalario;
        private Label label4;
        private ComboBox txtCargo;
        private ComboBox txtDepartamento;
        private DateTimePicker valueDate;
        private Button btnAdicionar;
        private Button btnCancelar;
    }
}
namespace MinhaEmpresaAF
{
    partial class frmModificar
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
            btnCancelar = new Button();
            btnModificar = new Button();
            valueDate = new DateTimePicker();
            txtDepartamento = new ComboBox();
            txtCargo = new ComboBox();
            txtSalario = new MaskedTextBox();
            txtNome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            btnCancelar.Location = new Point(370, 211);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(128, 255, 255);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            btnModificar.ForeColor = SystemColors.ControlText;
            btnModificar.Location = new Point(370, 168);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(128, 37);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // valueDate
            // 
            valueDate.Location = new Point(22, 182);
            valueDate.Name = "valueDate";
            valueDate.Size = new Size(239, 23);
            valueDate.TabIndex = 5;
            // 
            // txtDepartamento
            // 
            txtDepartamento.FormattingEnabled = true;
            txtDepartamento.Items.AddRange(new object[] { "Administração", "Financeiro", "Recursos Humanos (RH)", "Marketing e Vendas", "Operacional", "Tecnologia da Informação (TI)" });
            txtDepartamento.Location = new Point(111, 102);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(296, 23);
            txtDepartamento.TabIndex = 3;
            // 
            // txtCargo
            // 
            txtCargo.FormattingEnabled = true;
            txtCargo.Items.AddRange(new object[] { "CEO", "Gerente", "TechLead", "ScrumMaster", "Desenvolvedor Sênior", "Desenvolvedor Pleno", "Desenvolvedor Junior", "Auxiliar de Logística", "Auxiliar Administrativo", "Auxiliar de TI", "Estagiário", "Jovem Aprendiz" });
            txtCargo.Location = new Point(111, 69);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(296, 23);
            txtCargo.TabIndex = 2;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(111, 136);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(226, 23);
            txtSalario.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(111, 30);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(296, 23);
            txtNome.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 105);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 12;
            label4.Text = "Departamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 72);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 13;
            label3.Text = "Cargo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 144);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 11;
            label2.Text = "Salario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 38);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 10;
            label1.Text = "Nome";
            // 
            // txtId
            // 
            txtId.Location = new Point(5, -1);
            txtId.Name = "txtId";
            txtId.Size = new Size(32, 23);
            txtId.TabIndex = 14;
            txtId.Visible = false;
            // 
            // frmModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 247);
            Controls.Add(txtId);
            Controls.Add(btnCancelar);
            Controls.Add(btnModificar);
            Controls.Add(valueDate);
            Controls.Add(txtDepartamento);
            Controls.Add(txtCargo);
            Controls.Add(txtSalario);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmModificar";
            Text = "Modificar Funcionário";
            Load += frmModificar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnModificar;
        private DateTimePicker valueDate;
        private ComboBox txtDepartamento;
        private ComboBox txtCargo;
        private MaskedTextBox txtSalario;
        private TextBox txtNome;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtId;
    }
}
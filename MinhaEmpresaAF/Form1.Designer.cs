namespace MinhaEmpresaAF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gvContatos = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            btnModificar = new Button();
            btnNovo = new Button();
            gvFuncionarios = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NOME = new DataGridViewTextBoxColumn();
            CARGO = new DataGridViewTextBoxColumn();
            SALARIO = new DataGridViewTextBoxColumn();
            DATACONTRATACAO = new DataGridViewTextBoxColumn();
            DEPARTAMENTO = new DataGridViewTextBoxColumn();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)gvFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // gvContatos
            // 
            gvContatos.AutoSize = true;
            gvContatos.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gvContatos.Location = new Point(12, 9);
            gvContatos.Name = "gvContatos";
            gvContatos.Size = new Size(282, 37);
            gvContatos.TabIndex = 0;
            gvContatos.Text = "Lista de funcionários";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(128, 255, 255);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(216, 548);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(198, 39);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.UseWaitCursor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.FromArgb(128, 255, 128);
            btnNovo.FlatStyle = FlatStyle.Flat;
            btnNovo.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.ForeColor = SystemColors.ActiveCaptionText;
            btnNovo.Location = new Point(12, 548);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(198, 39);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo funcionário";
            btnNovo.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.UseWaitCursor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // gvFuncionarios
            // 
            gvFuncionarios.AllowUserToAddRows = false;
            gvFuncionarios.AllowUserToDeleteRows = false;
            gvFuncionarios.AllowUserToOrderColumns = true;
            gvFuncionarios.AllowUserToResizeRows = false;
            gvFuncionarios.BackgroundColor = SystemColors.ControlDarkDark;
            gvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvFuncionarios.Columns.AddRange(new DataGridViewColumn[] { ID, NOME, CARGO, SALARIO, DATACONTRATACAO, DEPARTAMENTO });
            gvFuncionarios.Location = new Point(12, 66);
            gvFuncionarios.MultiSelect = false;
            gvFuncionarios.Name = "gvFuncionarios";
            gvFuncionarios.ReadOnly = true;
            gvFuncionarios.Size = new Size(1213, 461);
            gvFuncionarios.TabIndex = 11;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // NOME
            // 
            NOME.DataPropertyName = "Nome";
            NOME.HeaderText = "NOME";
            NOME.Name = "NOME";
            NOME.ReadOnly = true;
            NOME.Width = 250;
            // 
            // CARGO
            // 
            CARGO.DataPropertyName = "Cargo";
            CARGO.HeaderText = "CARGO";
            CARGO.Name = "CARGO";
            CARGO.ReadOnly = true;
            CARGO.Width = 260;
            // 
            // SALARIO
            // 
            SALARIO.DataPropertyName = "Salario";
            SALARIO.HeaderText = "SALARIO";
            SALARIO.Name = "SALARIO";
            SALARIO.ReadOnly = true;
            SALARIO.Width = 200;
            // 
            // DATACONTRATACAO
            // 
            DATACONTRATACAO.DataPropertyName = "DataContratacao";
            DATACONTRATACAO.HeaderText = "DATACONTRATACAO";
            DATACONTRATACAO.Name = "DATACONTRATACAO";
            DATACONTRATACAO.ReadOnly = true;
            DATACONTRATACAO.Width = 200;
            // 
            // DEPARTAMENTO
            // 
            DEPARTAMENTO.DataPropertyName = "Departamento";
            DEPARTAMENTO.HeaderText = "DEPARTAMENTO";
            DEPARTAMENTO.Name = "DEPARTAMENTO";
            DEPARTAMENTO.ReadOnly = true;
            DEPARTAMENTO.Width = 260;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 128, 128);
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            btnExcluir.Location = new Point(1027, 548);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(198, 39);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.UseWaitCursor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1237, 603);
            Controls.Add(gvFuncionarios);
            Controls.Add(btnExcluir);
            Controls.Add(btnNovo);
            Controls.Add(btnModificar);
            Controls.Add(gvContatos);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Funcionários";
            Activated += Form1_Activated;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gvFuncionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gvContatos;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button btnModificar;
        private Button btnNovo;
        private DataGridView gvFuncionarios;
        private Button btnExcluir;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOME;
        private DataGridViewTextBoxColumn CARGO;
        private DataGridViewTextBoxColumn SALARIO;
        private DataGridViewTextBoxColumn DATACONTRATACAO;
        private DataGridViewTextBoxColumn DEPARTAMENTO;
    }
}

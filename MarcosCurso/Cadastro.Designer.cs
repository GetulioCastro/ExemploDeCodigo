namespace MarcosCurso
{
    partial class frm_Cadastro
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
            this.lbl_Aluno = new System.Windows.Forms.Label();
            this.txb_NomeAluno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_DataNascimento = new System.Windows.Forms.TextBox();
            this.lbl_Cpf = new System.Windows.Forms.Label();
            this.txb_Cpf = new System.Windows.Forms.TextBox();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.txb_Senha = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Aluno
            // 
            this.lbl_Aluno.AutoSize = true;
            this.lbl_Aluno.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aluno.Location = new System.Drawing.Point(13, 13);
            this.lbl_Aluno.Name = "lbl_Aluno";
            this.lbl_Aluno.Size = new System.Drawing.Size(134, 20);
            this.lbl_Aluno.TabIndex = 0;
            this.lbl_Aluno.Text = "Nome do Aluno:";
            // 
            // txb_NomeAluno
            // 
            this.txb_NomeAluno.Location = new System.Drawing.Point(17, 36);
            this.txb_NomeAluno.Name = "txb_NomeAluno";
            this.txb_NomeAluno.Size = new System.Drawing.Size(410, 22);
            this.txb_NomeAluno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data de Nascimento:";
            // 
            // txb_DataNascimento
            // 
            this.txb_DataNascimento.Location = new System.Drawing.Point(21, 104);
            this.txb_DataNascimento.Name = "txb_DataNascimento";
            this.txb_DataNascimento.Size = new System.Drawing.Size(165, 22);
            this.txb_DataNascimento.TabIndex = 3;
            // 
            // lbl_Cpf
            // 
            this.lbl_Cpf.AutoSize = true;
            this.lbl_Cpf.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cpf.Location = new System.Drawing.Point(17, 151);
            this.lbl_Cpf.Name = "lbl_Cpf";
            this.lbl_Cpf.Size = new System.Drawing.Size(43, 20);
            this.lbl_Cpf.TabIndex = 4;
            this.lbl_Cpf.Text = "CPF:";
            // 
            // txb_Cpf
            // 
            this.txb_Cpf.Location = new System.Drawing.Point(21, 175);
            this.txb_Cpf.Name = "txb_Cpf";
            this.txb_Cpf.Size = new System.Drawing.Size(191, 22);
            this.txb_Cpf.TabIndex = 5;
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Senha.Location = new System.Drawing.Point(17, 231);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(61, 20);
            this.lbl_Senha.TabIndex = 6;
            this.lbl_Senha.Text = "Senha:";
            // 
            // txb_Senha
            // 
            this.txb_Senha.Location = new System.Drawing.Point(21, 254);
            this.txb_Senha.Name = "txb_Senha";
            this.txb_Senha.Size = new System.Drawing.Size(137, 22);
            this.txb_Senha.TabIndex = 7;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.Location = new System.Drawing.Point(21, 348);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 33);
            this.btn_Salvar.TabIndex = 8;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Location = new System.Drawing.Point(111, 348);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 33);
            this.btn_Editar.TabIndex = 9;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deletar.Location = new System.Drawing.Point(202, 347);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(75, 34);
            this.btn_Deletar.TabIndex = 10;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = true;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.Location = new System.Drawing.Point(294, 348);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 32);
            this.btn_Sair.TabIndex = 11;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 391);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(628, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txb_Senha);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.txb_Cpf);
            this.Controls.Add(this.lbl_Cpf);
            this.Controls.Add(this.txb_DataNascimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_NomeAluno);
            this.Controls.Add(this.lbl_Aluno);
            this.Name = "frm_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Aluno;
        private System.Windows.Forms.TextBox txb_NomeAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_DataNascimento;
        private System.Windows.Forms.Label lbl_Cpf;
        private System.Windows.Forms.TextBox txb_Cpf;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.TextBox txb_Senha;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
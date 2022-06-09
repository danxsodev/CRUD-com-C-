
namespace tela_de_login
{
    partial class tela_de_login
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
            this.label_id = new System.Windows.Forms.Label();
            this.label_funcionario = new System.Windows.Forms.Label();
            this.label_cpf = new System.Windows.Forms.Label();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_func = new System.Windows.Forms.TextBox();
            this.textBox_cpf = new System.Windows.Forms.MaskedTextBox();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(231, 74);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 13);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID";
            // 
            // label_funcionario
            // 
            this.label_funcionario.AutoSize = true;
            this.label_funcionario.Location = new System.Drawing.Point(231, 148);
            this.label_funcionario.Name = "label_funcionario";
            this.label_funcionario.Size = new System.Drawing.Size(62, 13);
            this.label_funcionario.TabIndex = 1;
            this.label_funcionario.Text = "Funcionario";
            // 
            // label_cpf
            // 
            this.label_cpf.AutoSize = true;
            this.label_cpf.Location = new System.Drawing.Point(231, 231);
            this.label_cpf.Name = "label_cpf";
            this.label_cpf.Size = new System.Drawing.Size(27, 13);
            this.label_cpf.TabIndex = 2;
            this.label_cpf.Text = "CPF";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(524, 74);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisar.TabIndex = 3;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(524, 118);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 4;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(524, 162);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 5;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(255, 71);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(174, 20);
            this.textBox_id.TabIndex = 7;
            // 
            // textBox_func
            // 
            this.textBox_func.Location = new System.Drawing.Point(299, 148);
            this.textBox_func.Name = "textBox_func";
            this.textBox_func.Size = new System.Drawing.Size(161, 20);
            this.textBox_func.TabIndex = 8;
            // 
            // textBox_cpf
            // 
            this.textBox_cpf.Location = new System.Drawing.Point(290, 231);
            this.textBox_cpf.Mask = "000.000.000-00";
            this.textBox_cpf.Name = "textBox_cpf";
            this.textBox_cpf.Size = new System.Drawing.Size(106, 20);
            this.textBox_cpf.TabIndex = 9;
            this.textBox_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(524, 204);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_deletar.TabIndex = 10;
            this.btn_deletar.Text = "Excluir";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(524, 245);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 11;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // tela_de_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.textBox_cpf);
            this.Controls.Add(this.textBox_func);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.label_cpf);
            this.Controls.Add(this.label_funcionario);
            this.Controls.Add(this.label_id);
            this.Name = "tela_de_login";
            this.Text = "tela_de_login";
            this.Load += new System.EventHandler(this.tela_de_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_funcionario;
        private System.Windows.Forms.Label label_cpf;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_alterar;
   
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_func;
        private System.Windows.Forms.MaskedTextBox textBox_cpf;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_limpar;
    }
}


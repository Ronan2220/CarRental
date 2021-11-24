
namespace CarRental
{
    partial class FrmCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroCliente));
            this.lbCodigoCliente = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lbDtNascimento = new System.Windows.Forms.Label();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btGravar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btProcurar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCodigoCliente
            // 
            this.lbCodigoCliente.AutoSize = true;
            this.lbCodigoCliente.Location = new System.Drawing.Point(12, 38);
            this.lbCodigoCliente.Name = "lbCodigoCliente";
            this.lbCodigoCliente.Size = new System.Drawing.Size(189, 25);
            this.lbCodigoCliente.TabIndex = 0;
            this.lbCodigoCliente.Text = "Código do Cliente:";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(17, 66);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(184, 31);
            this.txtCodCliente.TabIndex = 1;
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(281, 38);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(60, 25);
            this.lbCPF.TabIndex = 2;
            this.lbCPF.Text = "CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(286, 66);
            this.txtCPF.Mask = "999.999.999-99";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(170, 31);
            this.txtCPF.TabIndex = 3;
            // 
            // lbDtNascimento
            // 
            this.lbDtNascimento.AutoSize = true;
            this.lbDtNascimento.Location = new System.Drawing.Point(537, 38);
            this.lbDtNascimento.Name = "lbDtNascimento";
            this.lbDtNascimento.Size = new System.Drawing.Size(212, 25);
            this.lbDtNascimento.TabIndex = 4;
            this.lbDtNascimento.Text = "Data de Nascimento:";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(542, 66);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(124, 31);
            this.txtDataNasc.TabIndex = 5;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Location = new System.Drawing.Point(12, 145);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(177, 25);
            this.lbNomeCliente.TabIndex = 6;
            this.lbNomeCliente.Text = "Nome do Cliente:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(17, 173);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(732, 31);
            this.txtNome.TabIndex = 7;
            // 
            // btGravar
            // 
            this.btGravar.Location = new System.Drawing.Point(12, 252);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(142, 48);
            this.btGravar.TabIndex = 8;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btFechar.Location = new System.Drawing.Point(607, 252);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(142, 48);
            this.btFechar.TabIndex = 10;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(160, 252);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(142, 48);
            this.btExcluir.TabIndex = 11;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btProcurar
            // 
            this.btProcurar.Location = new System.Drawing.Point(314, 252);
            this.btProcurar.Name = "btProcurar";
            this.btProcurar.Size = new System.Drawing.Size(142, 48);
            this.btProcurar.TabIndex = 12;
            this.btProcurar.Text = "Procurar";
            this.btProcurar.UseVisualStyleBackColor = true;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(12, 316);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(184, 48);
            this.btLimpar.TabIndex = 13;
            this.btLimpar.Text = "Limpar Campos";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 410);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btProcurar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNomeCliente);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.lbDtNascimento);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.lbCodigoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroCliente";
            this.Text = "Cadastro de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigoCliente;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lbDtNascimento;
        private System.Windows.Forms.MaskedTextBox txtDataNasc;
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btProcurar;
        private System.Windows.Forms.Button btLimpar;
    }
}
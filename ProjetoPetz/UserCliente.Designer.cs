namespace ProjetoZeeDog
{
    partial class UserCliente
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCliente));
            this.mskDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeC = new System.Windows.Forms.TextBox();
            this.mskRg = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnInserirC = new System.Windows.Forms.Button();
            this.btnExcluirC = new System.Windows.Forms.Button();
            this.btnEditarC = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mskDataNasc
            // 
            this.mskDataNasc.Font = new System.Drawing.Font("Arial", 9.75F);
            this.mskDataNasc.Location = new System.Drawing.Point(684, 91);
            this.mskDataNasc.Mask = " 00/00/0000";
            this.mskDataNasc.Name = "mskDataNasc";
            this.mskDataNasc.Size = new System.Drawing.Size(81, 22);
            this.mskDataNasc.TabIndex = 26;
            this.mskDataNasc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mskDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // txtNomeC
            // 
            this.txtNomeC.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtNomeC.Location = new System.Drawing.Point(105, 20);
            this.txtNomeC.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeC.Name = "txtNomeC";
            this.txtNomeC.Size = new System.Drawing.Size(122, 22);
            this.txtNomeC.TabIndex = 27;
            this.txtNomeC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeC_KeyPress);
            // 
            // mskRg
            // 
            this.mskRg.Font = new System.Drawing.Font("Arial", 9.75F);
            this.mskRg.Location = new System.Drawing.Point(105, 51);
            this.mskRg.Margin = new System.Windows.Forms.Padding(2);
            this.mskRg.Mask = " 99,999,999";
            this.mskRg.Name = "mskRg";
            this.mskRg.Size = new System.Drawing.Size(79, 22);
            this.mskRg.TabIndex = 28;
            this.mskRg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Arial", 9.75F);
            this.mskTelefone.Location = new System.Drawing.Point(105, 87);
            this.mskTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.mskTelefone.Mask = " 99999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(96, 22);
            this.mskTelefone.TabIndex = 29;
            this.mskTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtEmail.Location = new System.Drawing.Point(362, 18);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(154, 22);
            this.txtEmail.TabIndex = 30;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtEstado.Location = new System.Drawing.Point(611, 57);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(96, 22);
            this.txtEstado.TabIndex = 31;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtEndereco.Location = new System.Drawing.Point(362, 57);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(154, 22);
            this.txtEndereco.TabIndex = 32;
            this.txtEndereco.Leave += new System.EventHandler(this.txtEndereco_Leave);
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtCidade.Location = new System.Drawing.Point(611, 16);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(96, 22);
            this.txtCidade.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(544, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Data de nascimento: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(35, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "RG: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(35, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(267, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(267, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Endereço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(544, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Cidade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(545, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "Estado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(267, 89);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "País:";
            // 
            // txtPais
            // 
            this.txtPais.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtPais.Location = new System.Drawing.Point(362, 89);
            this.txtPais.Margin = new System.Windows.Forms.Padding(2);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(96, 22);
            this.txtPais.TabIndex = 43;
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(30, 236);
            this.dgvClientes.Name = "dgvClientes";
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.Size = new System.Drawing.Size(776, 150);
            this.dgvClientes.TabIndex = 45;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAtualizar.Location = new System.Drawing.Point(668, 196);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(138, 22);
            this.btnAtualizar.TabIndex = 46;
            this.btnAtualizar.Text = "Clientes cadastrados";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnInserirC
            // 
            this.btnInserirC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirC.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirC.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnInserirC.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirC.Image")));
            this.btnInserirC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirC.Location = new System.Drawing.Point(39, 416);
            this.btnInserirC.Name = "btnInserirC";
            this.btnInserirC.Size = new System.Drawing.Size(175, 42);
            this.btnInserirC.TabIndex = 49;
            this.btnInserirC.Text = "Inserir cliente";
            this.btnInserirC.UseVisualStyleBackColor = true;
            this.btnInserirC.Click += new System.EventHandler(this.btnInserirC_Click);
            // 
            // btnExcluirC
            // 
            this.btnExcluirC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirC.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirC.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnExcluirC.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirC.Image")));
            this.btnExcluirC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirC.Location = new System.Drawing.Point(425, 416);
            this.btnExcluirC.Name = "btnExcluirC";
            this.btnExcluirC.Size = new System.Drawing.Size(175, 42);
            this.btnExcluirC.TabIndex = 48;
            this.btnExcluirC.Text = "Excluir cliente";
            this.btnExcluirC.UseVisualStyleBackColor = true;
            this.btnExcluirC.Click += new System.EventHandler(this.btnExcluirC_Click);
            // 
            // btnEditarC
            // 
            this.btnEditarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarC.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarC.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEditarC.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarC.Image")));
            this.btnEditarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarC.Location = new System.Drawing.Point(232, 416);
            this.btnEditarC.Name = "btnEditarC";
            this.btnEditarC.Size = new System.Drawing.Size(175, 42);
            this.btnEditarC.TabIndex = 47;
            this.btnEditarC.Text = "Editar cliente";
            this.btnEditarC.UseVisualStyleBackColor = true;
            this.btnEditarC.Click += new System.EventHandler(this.btnEditarC_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblBuscar.Location = new System.Drawing.Point(26, 198);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(103, 20);
            this.lblBuscar.TabIndex = 83;
            this.lblBuscar.Text = "Buscar cliente: ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(135, 200);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 82;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnValidar
            // 
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnValidar.Image = ((System.Drawing.Image)(resources.GetObject("btnValidar.Image")));
            this.btnValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidar.Location = new System.Drawing.Point(618, 416);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(175, 42);
            this.btnValidar.TabIndex = 84;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(777, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 56);
            this.pictureBox2.TabIndex = 85;
            this.pictureBox2.TabStop = false;
            // 
            // UserCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnInserirC);
            this.Controls.Add(this.btnExcluirC);
            this.Controls.Add(this.btnEditarC);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.mskRg);
            this.Controls.Add(this.txtNomeC);
            this.Controls.Add(this.mskDataNasc);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserCliente";
            this.Size = new System.Drawing.Size(836, 480);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mskDataNasc;
        private System.Windows.Forms.TextBox txtNomeC;
        private System.Windows.Forms.MaskedTextBox mskRg;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnInserirC;
        private System.Windows.Forms.Button btnExcluirC;
        private System.Windows.Forms.Button btnEditarC;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

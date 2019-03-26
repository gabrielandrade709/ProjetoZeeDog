namespace ProjetoZeeDog
{
    partial class UserFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserFuncionario));
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dgvFunc = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPaisF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCidadeF = new System.Windows.Forms.TextBox();
            this.txtEnderecoF = new System.Windows.Forms.TextBox();
            this.txtEstadoF = new System.Windows.Forms.TextBox();
            this.txtEmailF = new System.Windows.Forms.TextBox();
            this.mskTelefoneF = new System.Windows.Forms.MaskedTextBox();
            this.mskRgF = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeF = new System.Windows.Forms.TextBox();
            this.mskDataNascF = new System.Windows.Forms.MaskedTextBox();
            this.btnInserirF = new System.Windows.Forms.Button();
            this.btnExcluirF = new System.Windows.Forms.Button();
            this.btnEditarF = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cboTipoFunc = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAtualizar.Location = new System.Drawing.Point(692, 348);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(124, 22);
            this.btnAtualizar.TabIndex = 71;
            this.btnAtualizar.Text = "Mostrar funcionários";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dgvFunc
            // 
            this.dgvFunc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunc.Location = new System.Drawing.Point(523, 79);
            this.dgvFunc.Name = "dgvFunc";
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dgvFunc.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFunc.Size = new System.Drawing.Size(293, 263);
            this.dgvFunc.TabIndex = 70;
            this.dgvFunc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunc_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(286, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 69;
            this.label10.Text = "País:";
            // 
            // txtPaisF
            // 
            this.txtPaisF.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtPaisF.Location = new System.Drawing.Point(410, 42);
            this.txtPaisF.Margin = new System.Windows.Forms.Padding(2);
            this.txtPaisF.Name = "txtPaisF";
            this.txtPaisF.Size = new System.Drawing.Size(84, 22);
            this.txtPaisF.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(287, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 67;
            this.label9.Text = "Estado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(286, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 66;
            this.label8.Text = "Cidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(33, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "Endereço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(33, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(30, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(33, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "RG: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(28, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Data de nascimento: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Nome:";
            // 
            // txtCidadeF
            // 
            this.txtCidadeF.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtCidadeF.Location = new System.Drawing.Point(410, 81);
            this.txtCidadeF.Margin = new System.Windows.Forms.Padding(2);
            this.txtCidadeF.Name = "txtCidadeF";
            this.txtCidadeF.Size = new System.Drawing.Size(84, 22);
            this.txtCidadeF.TabIndex = 58;
            // 
            // txtEnderecoF
            // 
            this.txtEnderecoF.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtEnderecoF.Location = new System.Drawing.Point(108, 174);
            this.txtEnderecoF.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnderecoF.Name = "txtEnderecoF";
            this.txtEnderecoF.Size = new System.Drawing.Size(137, 22);
            this.txtEnderecoF.TabIndex = 57;
            this.txtEnderecoF.Leave += new System.EventHandler(this.txtEnderecoF_Leave);
            // 
            // txtEstadoF
            // 
            this.txtEstadoF.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtEstadoF.Location = new System.Drawing.Point(410, 124);
            this.txtEstadoF.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstadoF.Name = "txtEstadoF";
            this.txtEstadoF.Size = new System.Drawing.Size(84, 22);
            this.txtEstadoF.TabIndex = 56;
            // 
            // txtEmailF
            // 
            this.txtEmailF.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtEmailF.Location = new System.Drawing.Point(108, 225);
            this.txtEmailF.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailF.Name = "txtEmailF";
            this.txtEmailF.Size = new System.Drawing.Size(153, 22);
            this.txtEmailF.TabIndex = 55;
            this.txtEmailF.Leave += new System.EventHandler(this.txtEmailF_Leave);
            // 
            // mskTelefoneF
            // 
            this.mskTelefoneF.Font = new System.Drawing.Font("Arial", 9.75F);
            this.mskTelefoneF.Location = new System.Drawing.Point(108, 124);
            this.mskTelefoneF.Margin = new System.Windows.Forms.Padding(2);
            this.mskTelefoneF.Mask = "99999-9999";
            this.mskTelefoneF.Name = "mskTelefoneF";
            this.mskTelefoneF.Size = new System.Drawing.Size(100, 22);
            this.mskTelefoneF.TabIndex = 54;
            this.mskTelefoneF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskRgF
            // 
            this.mskRgF.Font = new System.Drawing.Font("Arial", 9.75F);
            this.mskRgF.Location = new System.Drawing.Point(108, 79);
            this.mskRgF.Margin = new System.Windows.Forms.Padding(2);
            this.mskRgF.Mask = "99,999,999";
            this.mskRgF.Name = "mskRgF";
            this.mskRgF.Size = new System.Drawing.Size(122, 22);
            this.mskRgF.TabIndex = 53;
            this.mskRgF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtNomeF
            // 
            this.txtNomeF.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtNomeF.Location = new System.Drawing.Point(108, 40);
            this.txtNomeF.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeF.Name = "txtNomeF";
            this.txtNomeF.Size = new System.Drawing.Size(122, 22);
            this.txtNomeF.TabIndex = 52;
            this.txtNomeF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeF_KeyPress);
            // 
            // mskDataNascF
            // 
            this.mskDataNascF.Font = new System.Drawing.Font("Arial", 9.75F);
            this.mskDataNascF.Location = new System.Drawing.Point(173, 274);
            this.mskDataNascF.Mask = "00/00/0000";
            this.mskDataNascF.Name = "mskDataNascF";
            this.mskDataNascF.Size = new System.Drawing.Size(78, 22);
            this.mskDataNascF.TabIndex = 51;
            this.mskDataNascF.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mskDataNascF.ValidatingType = typeof(System.DateTime);
            // 
            // btnInserirF
            // 
            this.btnInserirF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirF.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirF.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnInserirF.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirF.Image")));
            this.btnInserirF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirF.Location = new System.Drawing.Point(37, 407);
            this.btnInserirF.Name = "btnInserirF";
            this.btnInserirF.Size = new System.Drawing.Size(175, 42);
            this.btnInserirF.TabIndex = 74;
            this.btnInserirF.Text = "Inserir funcionário";
            this.btnInserirF.UseVisualStyleBackColor = true;
            this.btnInserirF.Click += new System.EventHandler(this.btnInserirF_Click);
            // 
            // btnExcluirF
            // 
            this.btnExcluirF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirF.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirF.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnExcluirF.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirF.Image")));
            this.btnExcluirF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirF.Location = new System.Drawing.Point(423, 407);
            this.btnExcluirF.Name = "btnExcluirF";
            this.btnExcluirF.Size = new System.Drawing.Size(175, 42);
            this.btnExcluirF.TabIndex = 73;
            this.btnExcluirF.Text = "Excluir funcionário";
            this.btnExcluirF.UseVisualStyleBackColor = true;
            this.btnExcluirF.Click += new System.EventHandler(this.btnExcluirF_Click);
            // 
            // btnEditarF
            // 
            this.btnEditarF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarF.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarF.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEditarF.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarF.Image")));
            this.btnEditarF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarF.Location = new System.Drawing.Point(230, 407);
            this.btnEditarF.Name = "btnEditarF";
            this.btnEditarF.Size = new System.Drawing.Size(175, 42);
            this.btnEditarF.TabIndex = 72;
            this.btnEditarF.Text = "Editar funcionário";
            this.btnEditarF.UseVisualStyleBackColor = true;
            this.btnEditarF.Click += new System.EventHandler(this.btnEditarF_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(286, 174);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 20);
            this.label11.TabIndex = 76;
            this.label11.Text = "Tipo Funcionário:";
            // 
            // cboTipoFunc
            // 
            this.cboTipoFunc.FormattingEnabled = true;
            this.cboTipoFunc.Items.AddRange(new object[] {
            "Administrador",
            "Balconista",
            "Veterinário"});
            this.cboTipoFunc.Location = new System.Drawing.Point(410, 173);
            this.cboTipoFunc.Name = "cboTipoFunc";
            this.cboTipoFunc.Size = new System.Drawing.Size(105, 21);
            this.cboTipoFunc.TabIndex = 77;
            this.cboTipoFunc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cboTipoFunc.Leave += new System.EventHandler(this.cboTipoFunc_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(287, 227);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 79;
            this.label12.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtSenha.Location = new System.Drawing.Point(354, 227);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(161, 22);
            this.txtSenha.TabIndex = 78;
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblBuscar.Location = new System.Drawing.Point(519, 40);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(133, 20);
            this.lblBuscar.TabIndex = 81;
            this.lblBuscar.Text = "Buscar funcionário: ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(658, 40);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 80;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnValidar
            // 
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnValidar.Image = ((System.Drawing.Image)(resources.GetObject("btnValidar.Image")));
            this.btnValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidar.Location = new System.Drawing.Point(616, 407);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(175, 42);
            this.btnValidar.TabIndex = 85;
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
            this.pictureBox2.TabIndex = 86;
            this.pictureBox2.TabStop = false;
            // 
            // UserFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.cboTipoFunc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnInserirF);
            this.Controls.Add(this.btnExcluirF);
            this.Controls.Add(this.btnEditarF);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvFunc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPaisF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCidadeF);
            this.Controls.Add(this.txtEnderecoF);
            this.Controls.Add(this.txtEstadoF);
            this.Controls.Add(this.txtEmailF);
            this.Controls.Add(this.mskTelefoneF);
            this.Controls.Add(this.mskRgF);
            this.Controls.Add(this.txtNomeF);
            this.Controls.Add(this.mskDataNascF);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserFuncionario";
            this.Size = new System.Drawing.Size(836, 480);
            this.Load += new System.EventHandler(this.UserFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserirF;
        private System.Windows.Forms.Button btnExcluirF;
        private System.Windows.Forms.Button btnEditarF;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView dgvFunc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPaisF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCidadeF;
        private System.Windows.Forms.TextBox txtEnderecoF;
        private System.Windows.Forms.TextBox txtEstadoF;
        private System.Windows.Forms.TextBox txtEmailF;
        private System.Windows.Forms.MaskedTextBox mskTelefoneF;
        private System.Windows.Forms.MaskedTextBox mskRgF;
        private System.Windows.Forms.TextBox txtNomeF;
        private System.Windows.Forms.MaskedTextBox mskDataNascF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboTipoFunc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

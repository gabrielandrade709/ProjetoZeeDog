namespace ProjetoZeeDog
{
    partial class UserExecucao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserExecucao));
            this.lblServiço = new System.Windows.Forms.Label();
            this.lblVet = new System.Windows.Forms.Label();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.dgvDoServico = new System.Windows.Forms.DataGridView();
            this.dgvDoVet = new System.Windows.Forms.DataGridView();
            this.dgvDoAnimal = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.mskDataExec = new System.Windows.Forms.MaskedTextBox();
            this.mskHoraExec = new System.Windows.Forms.MaskedTextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dgvAgendamento = new System.Windows.Forms.DataGridView();
            this.lblHoraExecucao = new System.Windows.Forms.Label();
            this.lblDataExecucao = new System.Windows.Forms.Label();
            this.lblCodVet = new System.Windows.Forms.Label();
            this.lblCodServ = new System.Windows.Forms.Label();
            this.lblCodigoAnimal = new System.Windows.Forms.Label();
            this.txtCodVet = new System.Windows.Forms.TextBox();
            this.txtCodServ = new System.Windows.Forms.TextBox();
            this.txtCodAnimal = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnAtuS = new System.Windows.Forms.Button();
            this.btnAtuA = new System.Windows.Forms.Button();
            this.btnAtuV = new System.Windows.Forms.Button();
            this.btnInserirS = new System.Windows.Forms.Button();
            this.btnExcluirS = new System.Windows.Forms.Button();
            this.btnEditarS = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoVet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServiço
            // 
            this.lblServiço.AutoSize = true;
            this.lblServiço.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiço.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblServiço.Location = new System.Drawing.Point(634, 125);
            this.lblServiço.Name = "lblServiço";
            this.lblServiço.Size = new System.Drawing.Size(121, 16);
            this.lblServiço.TabIndex = 109;
            this.lblServiço.Text = "Escolha um serviço";
            // 
            // lblVet
            // 
            this.lblVet.AutoSize = true;
            this.lblVet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVet.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblVet.Location = new System.Drawing.Point(347, 128);
            this.lblVet.Name = "lblVet";
            this.lblVet.Size = new System.Drawing.Size(139, 16);
            this.lblVet.TabIndex = 108;
            this.lblVet.Text = "Escolha um veterinário";
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblAnimal.Location = new System.Drawing.Point(72, 125);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(119, 16);
            this.lblAnimal.TabIndex = 107;
            this.lblAnimal.Text = "Escolha um animal";
            // 
            // dgvDoServico
            // 
            this.dgvDoServico.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDoServico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoServico.Location = new System.Drawing.Point(583, 157);
            this.dgvDoServico.Name = "dgvDoServico";
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dgvDoServico.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoServico.Size = new System.Drawing.Size(225, 76);
            this.dgvDoServico.TabIndex = 106;
            this.dgvDoServico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoServico_CellClick);
            // 
            // dgvDoVet
            // 
            this.dgvDoVet.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDoVet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoVet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoVet.Location = new System.Drawing.Point(294, 157);
            this.dgvDoVet.Name = "dgvDoVet";
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dgvDoVet.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDoVet.Size = new System.Drawing.Size(234, 76);
            this.dgvDoVet.TabIndex = 105;
            this.dgvDoVet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoVet_CellClick);
            // 
            // dgvDoAnimal
            // 
            this.dgvDoAnimal.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDoAnimal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoAnimal.Location = new System.Drawing.Point(24, 157);
            this.dgvDoAnimal.Name = "dgvDoAnimal";
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dgvDoAnimal.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDoAnimal.Size = new System.Drawing.Size(215, 76);
            this.dgvDoAnimal.TabIndex = 104;
            this.dgvDoAnimal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoAnimal_CellClick);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblBuscar.Location = new System.Drawing.Point(29, 365);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(142, 20);
            this.lblBuscar.TabIndex = 103;
            this.lblBuscar.Text = "Buscar agendamento:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(177, 365);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 102;
            // 
            // mskDataExec
            // 
            this.mskDataExec.Location = new System.Drawing.Point(196, 67);
            this.mskDataExec.Mask = "00/00/0000";
            this.mskDataExec.Name = "mskDataExec";
            this.mskDataExec.Size = new System.Drawing.Size(81, 20);
            this.mskDataExec.TabIndex = 101;
            this.mskDataExec.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mskDataExec.ValidatingType = typeof(System.DateTime);
            // 
            // mskHoraExec
            // 
            this.mskHoraExec.Location = new System.Drawing.Point(447, 67);
            this.mskHoraExec.Mask = "00:00";
            this.mskHoraExec.Name = "mskHoraExec";
            this.mskHoraExec.Size = new System.Drawing.Size(81, 20);
            this.mskHoraExec.TabIndex = 100;
            this.mskHoraExec.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mskHoraExec.ValidatingType = typeof(System.DateTime);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAtualizar.Location = new System.Drawing.Point(689, 365);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(124, 22);
            this.btnAtualizar.TabIndex = 99;
            this.btnAtualizar.Text = "Serviços executados";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dgvAgendamento
            // 
            this.dgvAgendamento.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAgendamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendamento.Location = new System.Drawing.Point(28, 249);
            this.dgvAgendamento.Name = "dgvAgendamento";
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dgvAgendamento.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAgendamento.Size = new System.Drawing.Size(785, 110);
            this.dgvAgendamento.TabIndex = 95;
            this.dgvAgendamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgendamento_CellClick);
            // 
            // lblHoraExecucao
            // 
            this.lblHoraExecucao.AutoSize = true;
            this.lblHoraExecucao.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblHoraExecucao.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHoraExecucao.Location = new System.Drawing.Point(297, 65);
            this.lblHoraExecucao.Name = "lblHoraExecucao";
            this.lblHoraExecucao.Size = new System.Drawing.Size(105, 20);
            this.lblHoraExecucao.TabIndex = 94;
            this.lblHoraExecucao.Text = "Hora execução: ";
            // 
            // lblDataExecucao
            // 
            this.lblDataExecucao.AutoSize = true;
            this.lblDataExecucao.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDataExecucao.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDataExecucao.Location = new System.Drawing.Point(29, 67);
            this.lblDataExecucao.Name = "lblDataExecucao";
            this.lblDataExecucao.Size = new System.Drawing.Size(103, 20);
            this.lblDataExecucao.TabIndex = 93;
            this.lblDataExecucao.Text = "Data execução: ";
            // 
            // lblCodVet
            // 
            this.lblCodVet.AutoSize = true;
            this.lblCodVet.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCodVet.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCodVet.Location = new System.Drawing.Point(297, 24);
            this.lblCodVet.Name = "lblCodVet";
            this.lblCodVet.Size = new System.Drawing.Size(149, 20);
            this.lblCodVet.TabIndex = 92;
            this.lblCodVet.Text = "Código do veterinário: ";
            // 
            // lblCodServ
            // 
            this.lblCodServ.AutoSize = true;
            this.lblCodServ.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCodServ.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCodServ.Location = new System.Drawing.Point(534, 49);
            this.lblCodServ.Name = "lblCodServ";
            this.lblCodServ.Size = new System.Drawing.Size(128, 20);
            this.lblCodServ.TabIndex = 91;
            this.lblCodServ.Text = "Código do serviço: ";
            // 
            // lblCodigoAnimal
            // 
            this.lblCodigoAnimal.AutoSize = true;
            this.lblCodigoAnimal.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCodigoAnimal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCodigoAnimal.Location = new System.Drawing.Point(29, 22);
            this.lblCodigoAnimal.Name = "lblCodigoAnimal";
            this.lblCodigoAnimal.Size = new System.Drawing.Size(124, 20);
            this.lblCodigoAnimal.TabIndex = 90;
            this.lblCodigoAnimal.Text = "Código do animal: ";
            // 
            // txtCodVet
            // 
            this.txtCodVet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodVet.Location = new System.Drawing.Point(452, 22);
            this.txtCodVet.Name = "txtCodVet";
            this.txtCodVet.Size = new System.Drawing.Size(83, 22);
            this.txtCodVet.TabIndex = 89;
            // 
            // txtCodServ
            // 
            this.txtCodServ.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodServ.Location = new System.Drawing.Point(668, 49);
            this.txtCodServ.Name = "txtCodServ";
            this.txtCodServ.Size = new System.Drawing.Size(81, 22);
            this.txtCodServ.TabIndex = 88;
            // 
            // txtCodAnimal
            // 
            this.txtCodAnimal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodAnimal.Location = new System.Drawing.Point(196, 22);
            this.txtCodAnimal.Name = "txtCodAnimal";
            this.txtCodAnimal.Size = new System.Drawing.Size(81, 22);
            this.txtCodAnimal.TabIndex = 87;
            // 
            // btnValidar
            // 
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnValidar.Image = ((System.Drawing.Image)(resources.GetObject("btnValidar.Image")));
            this.btnValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidar.Location = new System.Drawing.Point(623, 416);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(175, 42);
            this.btnValidar.TabIndex = 113;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnAtuS
            // 
            this.btnAtuS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtuS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAtuS.Image = ((System.Drawing.Image)(resources.GetObject("btnAtuS.Image")));
            this.btnAtuS.Location = new System.Drawing.Point(760, 122);
            this.btnAtuS.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtuS.Name = "btnAtuS";
            this.btnAtuS.Size = new System.Drawing.Size(23, 22);
            this.btnAtuS.TabIndex = 112;
            this.btnAtuS.UseVisualStyleBackColor = true;
            this.btnAtuS.Click += new System.EventHandler(this.btnAtuS_Click);
            // 
            // btnAtuA
            // 
            this.btnAtuA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtuA.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAtuA.Image = ((System.Drawing.Image)(resources.GetObject("btnAtuA.Image")));
            this.btnAtuA.Location = new System.Drawing.Point(196, 122);
            this.btnAtuA.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtuA.Name = "btnAtuA";
            this.btnAtuA.Size = new System.Drawing.Size(23, 22);
            this.btnAtuA.TabIndex = 111;
            this.btnAtuA.UseVisualStyleBackColor = true;
            this.btnAtuA.Click += new System.EventHandler(this.btnAtuA_Click);
            // 
            // btnAtuV
            // 
            this.btnAtuV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtuV.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAtuV.Image = ((System.Drawing.Image)(resources.GetObject("btnAtuV.Image")));
            this.btnAtuV.Location = new System.Drawing.Point(491, 125);
            this.btnAtuV.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtuV.Name = "btnAtuV";
            this.btnAtuV.Size = new System.Drawing.Size(23, 22);
            this.btnAtuV.TabIndex = 110;
            this.btnAtuV.UseVisualStyleBackColor = true;
            this.btnAtuV.Click += new System.EventHandler(this.btnAtuV_Click);
            // 
            // btnInserirS
            // 
            this.btnInserirS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirS.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnInserirS.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirS.Image")));
            this.btnInserirS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirS.Location = new System.Drawing.Point(30, 416);
            this.btnInserirS.Name = "btnInserirS";
            this.btnInserirS.Size = new System.Drawing.Size(201, 42);
            this.btnInserirS.TabIndex = 98;
            this.btnInserirS.Text = "Agendar";
            this.btnInserirS.UseVisualStyleBackColor = true;
            this.btnInserirS.Click += new System.EventHandler(this.btnInserirS_Click);
            // 
            // btnExcluirS
            // 
            this.btnExcluirS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirS.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnExcluirS.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirS.Image")));
            this.btnExcluirS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirS.Location = new System.Drawing.Point(434, 416);
            this.btnExcluirS.Name = "btnExcluirS";
            this.btnExcluirS.Size = new System.Drawing.Size(175, 42);
            this.btnExcluirS.TabIndex = 97;
            this.btnExcluirS.Text = "Excluir agend.";
            this.btnExcluirS.UseVisualStyleBackColor = true;
            this.btnExcluirS.Click += new System.EventHandler(this.btnExcluirS_Click);
            // 
            // btnEditarS
            // 
            this.btnEditarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarS.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEditarS.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarS.Image")));
            this.btnEditarS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarS.Location = new System.Drawing.Point(245, 416);
            this.btnEditarS.Name = "btnEditarS";
            this.btnEditarS.Size = new System.Drawing.Size(175, 42);
            this.btnEditarS.TabIndex = 96;
            this.btnEditarS.Text = "Editar agend.";
            this.btnEditarS.UseVisualStyleBackColor = true;
            this.btnEditarS.Click += new System.EventHandler(this.btnEditarS_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(777, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 56);
            this.pictureBox2.TabIndex = 114;
            this.pictureBox2.TabStop = false;
            // 
            // UserExecucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnAtuS);
            this.Controls.Add(this.btnAtuA);
            this.Controls.Add(this.btnAtuV);
            this.Controls.Add(this.lblServiço);
            this.Controls.Add(this.lblVet);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.dgvDoServico);
            this.Controls.Add(this.dgvDoVet);
            this.Controls.Add(this.dgvDoAnimal);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.mskDataExec);
            this.Controls.Add(this.mskHoraExec);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnInserirS);
            this.Controls.Add(this.btnExcluirS);
            this.Controls.Add(this.btnEditarS);
            this.Controls.Add(this.dgvAgendamento);
            this.Controls.Add(this.lblHoraExecucao);
            this.Controls.Add(this.lblDataExecucao);
            this.Controls.Add(this.lblCodVet);
            this.Controls.Add(this.lblCodServ);
            this.Controls.Add(this.lblCodigoAnimal);
            this.Controls.Add(this.txtCodVet);
            this.Controls.Add(this.txtCodServ);
            this.Controls.Add(this.txtCodAnimal);
            this.Name = "UserExecucao";
            this.Size = new System.Drawing.Size(836, 480);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoVet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnAtuS;
        private System.Windows.Forms.Button btnAtuA;
        private System.Windows.Forms.Button btnAtuV;
        private System.Windows.Forms.Label lblServiço;
        private System.Windows.Forms.Label lblVet;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.DataGridView dgvDoServico;
        private System.Windows.Forms.DataGridView dgvDoVet;
        private System.Windows.Forms.DataGridView dgvDoAnimal;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.MaskedTextBox mskDataExec;
        private System.Windows.Forms.MaskedTextBox mskHoraExec;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnInserirS;
        private System.Windows.Forms.Button btnExcluirS;
        private System.Windows.Forms.Button btnEditarS;
        private System.Windows.Forms.DataGridView dgvAgendamento;
        private System.Windows.Forms.Label lblHoraExecucao;
        private System.Windows.Forms.Label lblDataExecucao;
        private System.Windows.Forms.Label lblCodVet;
        private System.Windows.Forms.Label lblCodServ;
        private System.Windows.Forms.Label lblCodigoAnimal;
        private System.Windows.Forms.TextBox txtCodVet;
        private System.Windows.Forms.TextBox txtCodServ;
        private System.Windows.Forms.TextBox txtCodAnimal;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

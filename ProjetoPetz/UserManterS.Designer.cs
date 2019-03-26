namespace ProjetoZeeDog
{
    partial class UserManterS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManterS));
            this.txtCodAnimal = new System.Windows.Forms.TextBox();
            this.txtCodServ = new System.Windows.Forms.TextBox();
            this.txtCodVet = new System.Windows.Forms.TextBox();
            this.lblCodigoAnimal = new System.Windows.Forms.Label();
            this.lblCodServ = new System.Windows.Forms.Label();
            this.lblCodVet = new System.Windows.Forms.Label();
            this.lblDataPrevista = new System.Windows.Forms.Label();
            this.lblHoraPrevista = new System.Windows.Forms.Label();
            this.dgvAgendamento = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.mskHoraPrev = new System.Windows.Forms.MaskedTextBox();
            this.mskDataPrev = new System.Windows.Forms.MaskedTextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvDoAnimal = new System.Windows.Forms.DataGridView();
            this.dgvDoVet = new System.Windows.Forms.DataGridView();
            this.dgvDoServico = new System.Windows.Forms.DataGridView();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.lblVet = new System.Windows.Forms.Label();
            this.lblServiço = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnAtuS = new System.Windows.Forms.Button();
            this.btnAtuA = new System.Windows.Forms.Button();
            this.btnAtuV = new System.Windows.Forms.Button();
            this.btnInserirS = new System.Windows.Forms.Button();
            this.btnExcluirS = new System.Windows.Forms.Button();
            this.btnEditarS = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoVet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodAnimal
            // 
            this.txtCodAnimal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodAnimal.Location = new System.Drawing.Point(158, 32);
            this.txtCodAnimal.Name = "txtCodAnimal";
            this.txtCodAnimal.Size = new System.Drawing.Size(81, 22);
            this.txtCodAnimal.TabIndex = 0;
            // 
            // txtCodServ
            // 
            this.txtCodServ.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodServ.Location = new System.Drawing.Point(691, 55);
            this.txtCodServ.Name = "txtCodServ";
            this.txtCodServ.Size = new System.Drawing.Size(81, 22);
            this.txtCodServ.TabIndex = 3;
            // 
            // txtCodVet
            // 
            this.txtCodVet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodVet.Location = new System.Drawing.Point(454, 30);
            this.txtCodVet.Name = "txtCodVet";
            this.txtCodVet.Size = new System.Drawing.Size(83, 22);
            this.txtCodVet.TabIndex = 7;
            // 
            // lblCodigoAnimal
            // 
            this.lblCodigoAnimal.AutoSize = true;
            this.lblCodigoAnimal.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCodigoAnimal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCodigoAnimal.Location = new System.Drawing.Point(28, 30);
            this.lblCodigoAnimal.Name = "lblCodigoAnimal";
            this.lblCodigoAnimal.Size = new System.Drawing.Size(124, 20);
            this.lblCodigoAnimal.TabIndex = 9;
            this.lblCodigoAnimal.Text = "Código do animal: ";
            // 
            // lblCodServ
            // 
            this.lblCodServ.AutoSize = true;
            this.lblCodServ.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCodServ.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCodServ.Location = new System.Drawing.Point(556, 55);
            this.lblCodServ.Name = "lblCodServ";
            this.lblCodServ.Size = new System.Drawing.Size(128, 20);
            this.lblCodServ.TabIndex = 10;
            this.lblCodServ.Text = "Código do serviço: ";
            // 
            // lblCodVet
            // 
            this.lblCodVet.AutoSize = true;
            this.lblCodVet.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCodVet.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCodVet.Location = new System.Drawing.Point(299, 32);
            this.lblCodVet.Name = "lblCodVet";
            this.lblCodVet.Size = new System.Drawing.Size(149, 20);
            this.lblCodVet.TabIndex = 11;
            this.lblCodVet.Text = "Código do veterinário: ";
            // 
            // lblDataPrevista
            // 
            this.lblDataPrevista.AutoSize = true;
            this.lblDataPrevista.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDataPrevista.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDataPrevista.Location = new System.Drawing.Point(28, 75);
            this.lblDataPrevista.Name = "lblDataPrevista";
            this.lblDataPrevista.Size = new System.Drawing.Size(95, 20);
            this.lblDataPrevista.TabIndex = 12;
            this.lblDataPrevista.Text = "Data prevista: ";
            // 
            // lblHoraPrevista
            // 
            this.lblHoraPrevista.AutoSize = true;
            this.lblHoraPrevista.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblHoraPrevista.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHoraPrevista.Location = new System.Drawing.Point(299, 77);
            this.lblHoraPrevista.Name = "lblHoraPrevista";
            this.lblHoraPrevista.Size = new System.Drawing.Size(97, 20);
            this.lblHoraPrevista.TabIndex = 17;
            this.lblHoraPrevista.Text = "Hora prevista: ";
            // 
            // dgvAgendamento
            // 
            this.dgvAgendamento.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAgendamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendamento.Location = new System.Drawing.Point(26, 247);
            this.dgvAgendamento.Name = "dgvAgendamento";
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dgvAgendamento.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgendamento.Size = new System.Drawing.Size(807, 110);
            this.dgvAgendamento.TabIndex = 18;
            this.dgvAgendamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgendamento_CellClick);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAtualizar.Location = new System.Drawing.Point(691, 373);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(124, 30);
            this.btnAtualizar.TabIndex = 22;
            this.btnAtualizar.Text = "Serviços agendados";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // mskHoraPrev
            // 
            this.mskHoraPrev.Location = new System.Drawing.Point(456, 79);
            this.mskHoraPrev.Mask = "00:00";
            this.mskHoraPrev.Name = "mskHoraPrev";
            this.mskHoraPrev.Size = new System.Drawing.Size(81, 20);
            this.mskHoraPrev.TabIndex = 23;
            this.mskHoraPrev.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mskHoraPrev.ValidatingType = typeof(System.DateTime);
            // 
            // mskDataPrev
            // 
            this.mskDataPrev.Location = new System.Drawing.Point(158, 75);
            this.mskDataPrev.Mask = "00/00/0000";
            this.mskDataPrev.Name = "mskDataPrev";
            this.mskDataPrev.Size = new System.Drawing.Size(81, 20);
            this.mskDataPrev.TabIndex = 24;
            this.mskDataPrev.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mskDataPrev.ValidatingType = typeof(System.DateTime);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblBuscar.Location = new System.Drawing.Point(31, 373);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(142, 20);
            this.lblBuscar.TabIndex = 28;
            this.lblBuscar.Text = "Buscar agendamento:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(179, 373);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 27;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvDoAnimal
            // 
            this.dgvDoAnimal.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDoAnimal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoAnimal.Location = new System.Drawing.Point(26, 165);
            this.dgvDoAnimal.Name = "dgvDoAnimal";
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dgvDoAnimal.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDoAnimal.Size = new System.Drawing.Size(215, 76);
            this.dgvDoAnimal.TabIndex = 29;
            this.dgvDoAnimal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoAmimal_CellClick);
            // 
            // dgvDoVet
            // 
            this.dgvDoVet.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDoVet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoVet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoVet.Location = new System.Drawing.Point(296, 165);
            this.dgvDoVet.Name = "dgvDoVet";
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dgvDoVet.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDoVet.Size = new System.Drawing.Size(234, 76);
            this.dgvDoVet.TabIndex = 30;
            this.dgvDoVet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoVet_CellClick);
            // 
            // dgvDoServico
            // 
            this.dgvDoServico.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDoServico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoServico.Location = new System.Drawing.Point(585, 165);
            this.dgvDoServico.Name = "dgvDoServico";
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dgvDoServico.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDoServico.Size = new System.Drawing.Size(225, 76);
            this.dgvDoServico.TabIndex = 31;
            this.dgvDoServico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoServiço_CellClick);
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblAnimal.Location = new System.Drawing.Point(29, 133);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(119, 16);
            this.lblAnimal.TabIndex = 32;
            this.lblAnimal.Text = "Escolha um animal";
            // 
            // lblVet
            // 
            this.lblVet.AutoSize = true;
            this.lblVet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVet.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblVet.Location = new System.Drawing.Point(349, 136);
            this.lblVet.Name = "lblVet";
            this.lblVet.Size = new System.Drawing.Size(139, 16);
            this.lblVet.TabIndex = 33;
            this.lblVet.Text = "Escolha um veterinário";
            // 
            // lblServiço
            // 
            this.lblServiço.AutoSize = true;
            this.lblServiço.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiço.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblServiço.Location = new System.Drawing.Point(636, 133);
            this.lblServiço.Name = "lblServiço";
            this.lblServiço.Size = new System.Drawing.Size(121, 16);
            this.lblServiço.TabIndex = 34;
            this.lblServiço.Text = "Escolha um serviço";
            // 
            // btnValidar
            // 
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnValidar.Image = ((System.Drawing.Image)(resources.GetObject("btnValidar.Image")));
            this.btnValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidar.Location = new System.Drawing.Point(625, 424);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(175, 42);
            this.btnValidar.TabIndex = 86;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnAtuS
            // 
            this.btnAtuS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtuS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAtuS.Image = ((System.Drawing.Image)(resources.GetObject("btnAtuS.Image")));
            this.btnAtuS.Location = new System.Drawing.Point(762, 130);
            this.btnAtuS.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtuS.Name = "btnAtuS";
            this.btnAtuS.Size = new System.Drawing.Size(23, 22);
            this.btnAtuS.TabIndex = 37;
            this.btnAtuS.UseVisualStyleBackColor = true;
            this.btnAtuS.Click += new System.EventHandler(this.btnAtuS_Click);
            // 
            // btnAtuA
            // 
            this.btnAtuA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtuA.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAtuA.Image = ((System.Drawing.Image)(resources.GetObject("btnAtuA.Image")));
            this.btnAtuA.Location = new System.Drawing.Point(167, 130);
            this.btnAtuA.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtuA.Name = "btnAtuA";
            this.btnAtuA.Size = new System.Drawing.Size(23, 22);
            this.btnAtuA.TabIndex = 36;
            this.btnAtuA.UseVisualStyleBackColor = true;
            this.btnAtuA.Click += new System.EventHandler(this.btnAtuA_Click);
            // 
            // btnAtuV
            // 
            this.btnAtuV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtuV.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAtuV.Image = ((System.Drawing.Image)(resources.GetObject("btnAtuV.Image")));
            this.btnAtuV.Location = new System.Drawing.Point(493, 133);
            this.btnAtuV.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtuV.Name = "btnAtuV";
            this.btnAtuV.Size = new System.Drawing.Size(23, 22);
            this.btnAtuV.TabIndex = 35;
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
            this.btnInserirS.Location = new System.Drawing.Point(32, 424);
            this.btnInserirS.Name = "btnInserirS";
            this.btnInserirS.Size = new System.Drawing.Size(201, 42);
            this.btnInserirS.TabIndex = 21;
            this.btnInserirS.Text = "Agendar";
            this.btnInserirS.UseVisualStyleBackColor = true;
            this.btnInserirS.Click += new System.EventHandler(this.btnInserirS_Click);
            // 
            // btnExcluirS
            // 
            this.btnExcluirS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirS.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirS.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirS.Image")));
            this.btnExcluirS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirS.Location = new System.Drawing.Point(436, 424);
            this.btnExcluirS.Name = "btnExcluirS";
            this.btnExcluirS.Size = new System.Drawing.Size(175, 42);
            this.btnExcluirS.TabIndex = 20;
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
            this.btnEditarS.Location = new System.Drawing.Point(247, 424);
            this.btnEditarS.Name = "btnEditarS";
            this.btnEditarS.Size = new System.Drawing.Size(175, 42);
            this.btnEditarS.TabIndex = 19;
            this.btnEditarS.Text = "Editar agend.";
            this.btnEditarS.UseVisualStyleBackColor = true;
            this.btnEditarS.Click += new System.EventHandler(this.btnEditarS_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(778, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 56);
            this.pictureBox2.TabIndex = 87;
            this.pictureBox2.TabStop = false;
            // 
            // UserManterS
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
            this.Controls.Add(this.mskDataPrev);
            this.Controls.Add(this.mskHoraPrev);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnInserirS);
            this.Controls.Add(this.btnExcluirS);
            this.Controls.Add(this.btnEditarS);
            this.Controls.Add(this.dgvAgendamento);
            this.Controls.Add(this.lblHoraPrevista);
            this.Controls.Add(this.lblDataPrevista);
            this.Controls.Add(this.lblCodVet);
            this.Controls.Add(this.lblCodServ);
            this.Controls.Add(this.lblCodigoAnimal);
            this.Controls.Add(this.txtCodVet);
            this.Controls.Add(this.txtCodServ);
            this.Controls.Add(this.txtCodAnimal);
            this.Name = "UserManterS";
            this.Size = new System.Drawing.Size(836, 480);
            this.Load += new System.EventHandler(this.UserManterS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoVet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodAnimal;
        private System.Windows.Forms.TextBox txtCodServ;
        private System.Windows.Forms.TextBox txtCodVet;
        private System.Windows.Forms.Label lblCodigoAnimal;
        private System.Windows.Forms.Label lblCodServ;
        private System.Windows.Forms.Label lblCodVet;
        private System.Windows.Forms.Label lblDataPrevista;
        private System.Windows.Forms.Label lblHoraPrevista;
        private System.Windows.Forms.DataGridView dgvAgendamento;
        private System.Windows.Forms.Button btnInserirS;
        private System.Windows.Forms.Button btnExcluirS;
        private System.Windows.Forms.Button btnEditarS;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.MaskedTextBox mskHoraPrev;
        private System.Windows.Forms.MaskedTextBox mskDataPrev;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvDoAnimal;
        private System.Windows.Forms.DataGridView dgvDoVet;
        private System.Windows.Forms.DataGridView dgvDoServico;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Label lblVet;
        private System.Windows.Forms.Label lblServiço;
        private System.Windows.Forms.Button btnAtuV;
        private System.Windows.Forms.Button btnAtuA;
        private System.Windows.Forms.Button btnAtuS;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

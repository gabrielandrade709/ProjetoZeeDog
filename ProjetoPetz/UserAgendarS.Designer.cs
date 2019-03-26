namespace ProjetoZeeDog
{
    partial class UserAgendarS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAgendarS));
            this.txtValorServico = new System.Windows.Forms.TextBox();
            this.dgvServico = new System.Windows.Forms.DataGridView();
            this.btnEditarS = new System.Windows.Forms.Button();
            this.btnExcluirS = new System.Windows.Forms.Button();
            this.lblNomeS = new System.Windows.Forms.Label();
            this.lblDescricaoS = new System.Windows.Forms.Label();
            this.lblValorS = new System.Windows.Forms.Label();
            this.cbmServico = new System.Windows.Forms.ComboBox();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.btnInserirS = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValorServico
            // 
            this.txtValorServico.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorServico.Location = new System.Drawing.Point(266, 143);
            this.txtValorServico.Name = "txtValorServico";
            this.txtValorServico.Size = new System.Drawing.Size(175, 22);
            this.txtValorServico.TabIndex = 2;
            this.txtValorServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorServico_KeyPress);
            // 
            // dgvServico
            // 
            this.dgvServico.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvServico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServico.Location = new System.Drawing.Point(510, 52);
            this.dgvServico.Name = "dgvServico";
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dgvServico.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServico.Size = new System.Drawing.Size(263, 261);
            this.dgvServico.TabIndex = 3;
            this.dgvServico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServico_CellClick);
            // 
            // btnEditarS
            // 
            this.btnEditarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarS.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEditarS.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarS.Image")));
            this.btnEditarS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarS.Location = new System.Drawing.Point(327, 397);
            this.btnEditarS.Name = "btnEditarS";
            this.btnEditarS.Size = new System.Drawing.Size(175, 42);
            this.btnEditarS.TabIndex = 4;
            this.btnEditarS.Text = "Editar serviço";
            this.btnEditarS.UseVisualStyleBackColor = true;
            this.btnEditarS.Click += new System.EventHandler(this.btnEditarS_Click);
            // 
            // btnExcluirS
            // 
            this.btnExcluirS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirS.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnExcluirS.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirS.Image")));
            this.btnExcluirS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirS.Location = new System.Drawing.Point(520, 397);
            this.btnExcluirS.Name = "btnExcluirS";
            this.btnExcluirS.Size = new System.Drawing.Size(175, 42);
            this.btnExcluirS.TabIndex = 5;
            this.btnExcluirS.Text = "Excluir serviço";
            this.btnExcluirS.UseVisualStyleBackColor = true;
            this.btnExcluirS.Click += new System.EventHandler(this.btnExcluirS_Click);
            // 
            // lblNomeS
            // 
            this.lblNomeS.AutoSize = true;
            this.lblNomeS.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNomeS.Location = new System.Drawing.Point(124, 98);
            this.lblNomeS.Name = "lblNomeS";
            this.lblNomeS.Size = new System.Drawing.Size(62, 20);
            this.lblNomeS.TabIndex = 7;
            this.lblNomeS.Text = "Serviço: ";
            // 
            // lblDescricaoS
            // 
            this.lblDescricaoS.AutoSize = true;
            this.lblDescricaoS.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDescricaoS.Location = new System.Drawing.Point(124, 214);
            this.lblDescricaoS.Name = "lblDescricaoS";
            this.lblDescricaoS.Size = new System.Drawing.Size(77, 20);
            this.lblDescricaoS.TabIndex = 8;
            this.lblDescricaoS.Text = "Descrição: ";
            // 
            // lblValorS
            // 
            this.lblValorS.AutoSize = true;
            this.lblValorS.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblValorS.Location = new System.Drawing.Point(124, 143);
            this.lblValorS.Name = "lblValorS";
            this.lblValorS.Size = new System.Drawing.Size(114, 20);
            this.lblValorS.TabIndex = 9;
            this.lblValorS.Text = "Valor do serviço: ";
            // 
            // cbmServico
            // 
            this.cbmServico.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmServico.FormattingEnabled = true;
            this.cbmServico.Items.AddRange(new object[] {
            "Consulta",
            "Higiene e beleza",
            "Sacríficio",
            "Vacinação"});
            this.cbmServico.Location = new System.Drawing.Point(266, 98);
            this.cbmServico.Name = "cbmServico";
            this.cbmServico.Size = new System.Drawing.Size(175, 24);
            this.cbmServico.TabIndex = 10;
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rtbDescricao.Location = new System.Drawing.Point(266, 185);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.Size = new System.Drawing.Size(175, 92);
            this.rtbDescricao.TabIndex = 11;
            this.rtbDescricao.Text = "";
            // 
            // btnInserirS
            // 
            this.btnInserirS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirS.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnInserirS.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirS.Image")));
            this.btnInserirS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirS.Location = new System.Drawing.Point(134, 397);
            this.btnInserirS.Name = "btnInserirS";
            this.btnInserirS.Size = new System.Drawing.Size(175, 42);
            this.btnInserirS.TabIndex = 6;
            this.btnInserirS.Text = "Inserir serviço";
            this.btnInserirS.UseVisualStyleBackColor = true;
            this.btnInserirS.Click += new System.EventHandler(this.btnInserirS_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAtualizar.Location = new System.Drawing.Point(573, 23);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(144, 24);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "Serviços cadastrados";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(673, 319);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 13;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblBuscar.Location = new System.Drawing.Point(560, 317);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(107, 20);
            this.lblBuscar.TabIndex = 14;
            this.lblBuscar.Text = "Buscar serviço: ";
            this.lblBuscar.Click += new System.EventHandler(this.lblBuscar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(778, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 56);
            this.pictureBox2.TabIndex = 86;
            this.pictureBox2.TabStop = false;
            // 
            // UserAgendarS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.rtbDescricao);
            this.Controls.Add(this.cbmServico);
            this.Controls.Add(this.lblValorS);
            this.Controls.Add(this.lblDescricaoS);
            this.Controls.Add(this.lblNomeS);
            this.Controls.Add(this.btnInserirS);
            this.Controls.Add(this.btnExcluirS);
            this.Controls.Add(this.btnEditarS);
            this.Controls.Add(this.dgvServico);
            this.Controls.Add(this.txtValorServico);
            this.Name = "UserAgendarS";
            this.Size = new System.Drawing.Size(836, 480);
            this.Load += new System.EventHandler(this.UserAgendarS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtValorServico;
        private System.Windows.Forms.DataGridView dgvServico;
        private System.Windows.Forms.Button btnEditarS;
        private System.Windows.Forms.Button btnExcluirS;
        private System.Windows.Forms.Button btnInserirS;
        private System.Windows.Forms.Label lblNomeS;
        private System.Windows.Forms.Label lblDescricaoS;
        private System.Windows.Forms.Label lblValorS;
        private System.Windows.Forms.ComboBox cbmServico;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

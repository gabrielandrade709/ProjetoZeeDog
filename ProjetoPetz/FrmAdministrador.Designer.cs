namespace ProjetoZeeDog
{
    partial class FrmAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministrador));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEmitirR = new System.Windows.Forms.Button();
            this.btnManterF = new System.Windows.Forms.Button();
            this.pnlFerramentas = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.userTelaAdm1 = new ProjetoZeeDog.UserTelaAdm();
            this.userEmitirR1 = new ProjetoZeeDog.UserEmitirR();
            this.userFuncionario1 = new ProjetoZeeDog.UserFuncionario();
            this.userExecucao1 = new ProjetoZeeDog.UserExecucao();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlFerramentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Black;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.pictureBox2);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.btnEmitirR);
            this.pnlMenu.Controls.Add(this.btnManterF);
            this.pnlMenu.Location = new System.Drawing.Point(0, -8);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(169, 526);
            this.pnlMenu.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(25, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 90);
            this.pictureBox2.TabIndex = 89;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(25, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cadastro de Execução";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmitirR
            // 
            this.btnEmitirR.FlatAppearance.BorderSize = 0;
            this.btnEmitirR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitirR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitirR.ForeColor = System.Drawing.Color.White;
            this.btnEmitirR.Location = new System.Drawing.Point(25, 263);
            this.btnEmitirR.Name = "btnEmitirR";
            this.btnEmitirR.Size = new System.Drawing.Size(112, 49);
            this.btnEmitirR.TabIndex = 2;
            this.btnEmitirR.Text = "Emitir relatório";
            this.btnEmitirR.UseVisualStyleBackColor = true;
            this.btnEmitirR.Click += new System.EventHandler(this.btnEmitirR_Click);
            // 
            // btnManterF
            // 
            this.btnManterF.BackColor = System.Drawing.Color.Transparent;
            this.btnManterF.FlatAppearance.BorderSize = 0;
            this.btnManterF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManterF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManterF.ForeColor = System.Drawing.Color.White;
            this.btnManterF.Location = new System.Drawing.Point(25, 180);
            this.btnManterF.Name = "btnManterF";
            this.btnManterF.Size = new System.Drawing.Size(112, 49);
            this.btnManterF.TabIndex = 1;
            this.btnManterF.Text = "Cadastrar funcionários";
            this.btnManterF.UseVisualStyleBackColor = false;
            this.btnManterF.Click += new System.EventHandler(this.btnManterF_Click);
            // 
            // pnlFerramentas
            // 
            this.pnlFerramentas.BackColor = System.Drawing.SystemColors.Desktop;
            this.pnlFerramentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFerramentas.Controls.Add(this.btnMinimizar);
            this.pnlFerramentas.Controls.Add(this.btnFechar);
            this.pnlFerramentas.Location = new System.Drawing.Point(164, -4);
            this.pnlFerramentas.Name = "pnlFerramentas";
            this.pnlFerramentas.Size = new System.Drawing.Size(837, 36);
            this.pnlFerramentas.TabIndex = 19;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(764, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(33, 26);
            this.btnMinimizar.TabIndex = 11;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(802, 4);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(30, 22);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // userTelaAdm1
            // 
            this.userTelaAdm1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userTelaAdm1.Location = new System.Drawing.Point(165, 31);
            this.userTelaAdm1.Margin = new System.Windows.Forms.Padding(2);
            this.userTelaAdm1.Name = "userTelaAdm1";
            this.userTelaAdm1.Size = new System.Drawing.Size(836, 490);
            this.userTelaAdm1.TabIndex = 23;
            // 
            // userEmitirR1
            // 
            this.userEmitirR1.BackColor = System.Drawing.Color.White;
            this.userEmitirR1.Location = new System.Drawing.Point(165, 31);
            this.userEmitirR1.Name = "userEmitirR1";
            this.userEmitirR1.Size = new System.Drawing.Size(836, 490);
            this.userEmitirR1.TabIndex = 22;
            // 
            // userFuncionario1
            // 
            this.userFuncionario1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userFuncionario1.Location = new System.Drawing.Point(163, 31);
            this.userFuncionario1.Margin = new System.Windows.Forms.Padding(2);
            this.userFuncionario1.Name = "userFuncionario1";
            this.userFuncionario1.Size = new System.Drawing.Size(837, 483);
            this.userFuncionario1.TabIndex = 21;
            // 
            // userExecucao1
            // 
            this.userExecucao1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userExecucao1.Location = new System.Drawing.Point(164, 32);
            this.userExecucao1.Name = "userExecucao1";
            this.userExecucao1.Size = new System.Drawing.Size(836, 480);
            this.userExecucao1.TabIndex = 20;
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1000, 517);
            this.Controls.Add(this.userTelaAdm1);
            this.Controls.Add(this.userEmitirR1);
            this.Controls.Add(this.userFuncionario1);
            this.Controls.Add(this.userExecucao1);
            this.Controls.Add(this.pnlFerramentas);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdministrador";
            this.Load += new System.EventHandler(this.FrmAdministrador_Load);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlFerramentas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnEmitirR;
        private System.Windows.Forms.Button btnManterF;
        private System.Windows.Forms.Panel pnlFerramentas;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button button1;
        private UserExecucao userExecucao1;
        private UserFuncionario userFuncionario1;
        private UserEmitirR userEmitirR1;
        private UserTelaAdm userTelaAdm1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
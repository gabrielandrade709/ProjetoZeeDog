﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoZeeDog
{
    public partial class UserExibirDisp : UserControl
    {
        ClassAgendamento agendamento = new ClassAgendamento();
        public UserExibirDisp()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvVeterinarios.DataSource = agendamento.RetServicosEVet();
        }
    }
}

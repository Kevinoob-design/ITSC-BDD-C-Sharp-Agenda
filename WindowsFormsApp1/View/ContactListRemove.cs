﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace WindowsFormsApp1.View
{
    public partial class ContactListRemove : Form
    {
        public ContactListRemove()
        {
            InitializeComponent();
        }

        public ContactListRemove(Event evento)
        {
            InitializeComponent();

            MessageBox.Show(evento.eventID.ToString());
        }
        private void btnREmoveContact_Click(object sender, EventArgs e)
        {
            
        }

        private void ContactListRemove_Load(object sender, EventArgs e)
        {
            Conexion.LoadDataContactRemove(dgvCOntactListRemove);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PPE_BelleTable
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            DBConnection dbCon = new DBConnection();
            dbCon.Server = "127.0.0.1";
            dbCon.DatabaseName = "sucrerie";
            dbCon.UserName = "root";
            dbCon.Password = "";

            //Interface.RechercherParticipant(dbCon);
            //MessageBox.Show("Participant enregistré avec succès");
            //this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonAllParticipant_Click(object sender, EventArgs e)
        {

        }
    }
}

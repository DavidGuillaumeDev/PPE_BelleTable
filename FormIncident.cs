using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PPE_BelleTable
{
    public partial class FormIncident : Form
    {
        public FormIncident()
        {
            InitializeComponent();
        }

        private void buttonSendIncident_Click(object sender, EventArgs e)
        {
            DBConnection dbCon = new DBConnection();
            dbCon.Server = "127.0.0.1";
            dbCon.DatabaseName = "sucrerie";
            dbCon.UserName = "root";
            dbCon.Password = "";
            if (textBoxObjet.Text != "")
            {
                labelNeedObjet.Visible = false;
                if (richTextBoxDescription.Text != "")
                {
                    Interface.AjouterIncident(dbCon, textBoxObjet.Text, richTextBoxDescription.Text);
                    MessageBox.Show("Partage d'incident envoyé avec succès");
                    this.Close();
                }
                else
                {
                    labelNeedDescription.Visible = true;
                }
            }
            else
            {
                labelNeedObjet.Visible = true;
            }
        }
    }
}

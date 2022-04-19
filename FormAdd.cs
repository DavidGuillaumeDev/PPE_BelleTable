using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PPE_BelleTable
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DBConnection dbCon = new DBConnection();
            dbCon.Server = "127.0.0.1";
            dbCon.DatabaseName = "sucrerie";
            dbCon.UserName = "root";
            dbCon.Password = "";
            if (textBoxName.Text != "")
            {
                labelNeedName.Visible = false;
                if (textBoxLastname.Text != "")
                {
                    labelNeedLastname.Visible = false;
                    if (MesOutils.VeriferMail(textBoxEmail.Text))
                    {
                        labelNeedEmail.Visible = false;
                        Interface.AjouterParticipant(dbCon, textBoxName.Text, textBoxLastname.Text, textBoxEmail.Text);
                        MessageBox.Show("Participant enregistré avec succès");
                        this.Close();
                    }
                    else
                    {
                        labelNeedEmail.Visible = true;
                    }
                }
                else
                {
                    labelNeedLastname.Visible = true;
                }
            }
            else
            {
                labelNeedName.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}

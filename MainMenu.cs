using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PPE_BelleTable
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Ajouter participant
        {
            FormAdd MonForm = new FormAdd();
            MonForm.Show();
        }

        private void button2_Click(object sender, EventArgs e) //Rechercher participant
        {
            FormSearch MonForm = new FormSearch();
            MonForm.Show();
        }

        private void button3_Click(object sender, EventArgs e) ///Quitter
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormIncident MonForm = new FormIncident();
            MonForm.Show();
        }
    }
}

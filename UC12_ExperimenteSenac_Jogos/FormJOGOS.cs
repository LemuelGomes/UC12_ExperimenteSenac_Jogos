using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC12_ExperimenteSenac_Jogos
{
    public partial class FormJOGOS : Form
    {
        public FormJOGOS()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonMEMORIA_MouseHover(object sender, EventArgs e)
        {
            labelMEMORIA.Font = new Font("Sigmar", 18);
        }

        private void buttonMEMORIA_MouseLeave(object sender, EventArgs e)
        {
            labelMEMORIA.Font = new Font("Sigmar", 16);
        }

        private void buttonFORCA_MouseHover(object sender, EventArgs e)
        {
            labelFORCA.Font = new Font("Sigmar", 18);
        }

        private void buttonFORCA_MouseLeave(object sender, EventArgs e)
        {
            labelFORCA.Font = new Font("Sigmar", 16);
        }

        private void buttonVELHA_MouseHover(object sender, EventArgs e)
        {
            labelVELHA.Font = new Font("Sigmar", 18);
        }

        private void buttonVELHA_MouseLeave(object sender, EventArgs e)
        {
            labelVELHA.Font = new Font("Sigmar", 16);
        }

        private void buttonMEMORIA_Click(object sender, EventArgs e)
        {
            Form telaMEMORIA = new FormMEMORIA();
            telaMEMORIA.Show();
        }

        private void buttonFORCA_Click(object sender, EventArgs e)
        {
            Form telaFORCA_PALAVRA = new FormFORCA_PALAVRA();
            telaFORCA_PALAVRA.Show();
        }

        private void buttonVELHA_Click(object sender, EventArgs e)
        {
            Form telaVELHA_turno = new FormVELHA_TURNO();
            telaVELHA_turno.Show();

        }
    }
}

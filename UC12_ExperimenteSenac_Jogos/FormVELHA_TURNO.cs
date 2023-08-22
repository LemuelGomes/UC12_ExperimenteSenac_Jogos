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
    public partial class FormVELHA_TURNO : Form
    {
        public FormVELHA_TURNO()
        {
            InitializeComponent();
        }

        private void pictureBox_O_Click(object sender, EventArgs e)
        {
            ClassVARIAVEIS.turno = "O";

            this.Hide();
            Form telaVELHA = new FormVELHA();
            telaVELHA.Closed += (s, args) => this.Close();
            telaVELHA.Show();
        }

        private void pictureBox_X_Click(object sender, EventArgs e)
        {
            ClassVARIAVEIS.turno = "X";

            this.Hide();
            Form telaVELHA = new FormVELHA();
            telaVELHA.Closed += (s, args) => this.Close();
            telaVELHA.Show();
        }
    }
}

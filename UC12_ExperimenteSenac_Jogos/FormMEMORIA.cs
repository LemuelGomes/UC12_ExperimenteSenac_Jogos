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
    public partial class FormMEMORIA : Form
    {
        string jogada1;
        string jogada2;
        int jogadas;

        string figura1;
        string figura2;
        string figura3;
        string figura4;
        string figura5;
        string figura6;
        string figura7;
        string figura8;
        string figura9;
        string figura10;
        string figura11;
        string figura12;

        public FormMEMORIA()
        {
            InitializeComponent();

            iniciaJOGO();
        }

        private void iniciaJOGO()
        {
            pictureBox1.Image = Properties.Resources.duvida;
            pictureBox2.Image = Properties.Resources.duvida;
            pictureBox3.Image = Properties.Resources.duvida;
            pictureBox4.Image = Properties.Resources.duvida;
            pictureBox5.Image = Properties.Resources.duvida;
            pictureBox6.Image = Properties.Resources.duvida;
            pictureBox7.Image = Properties.Resources.duvida;
            pictureBox8.Image = Properties.Resources.duvida;
            pictureBox9.Image = Properties.Resources.duvida;
            pictureBox10.Image = Properties.Resources.duvida;
            pictureBox11.Image = Properties.Resources.duvida;
            pictureBox12.Image = Properties.Resources.duvida;
            figura1 = "?";
            figura2 = "?";
            figura3 = "?";
            figura4 = "?";
            figura5 = "?";
            figura6 = "?";
            figura7 = "?";
            figura8 = "?";
            figura9 = "?";
            figura10 = "?";
            figura11 = "?";
            figura12 = "?";

            jogadas = 0;
        }
        private void validaJOGO()
        {
            if (jogadas > 2)
            {
                iniciaJOGO();
                jogadas = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            jogadas++;

            if (figura1 == "?")
            {
                pictureBox1.Image = Properties.Resources.viuva_negra;
                figura1 = "f";
            }
            else
            {
                pictureBox1.Image = Properties.Resources.duvida;
                figura1 = "?";
            }

            validaJOGO();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            jogadas++;

            if (figura2 == "?")
            {
                pictureBox2.Image = Properties.Resources.homem_de_ferro;
                figura2 = "f";
            }
            else
            {
                pictureBox2.Image = Properties.Resources.duvida;
                figura2 = "?";
            }

            validaJOGO();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            jogadas++;

            if (figura3 == "?")
            {
                pictureBox3.Image = Properties.Resources.capitao_america;
                figura3 = "f";
            }
            else
            {
                pictureBox3.Image = Properties.Resources.duvida;
                figura3 = "?";
            }

            validaJOGO();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            jogadas++;

            if (figura4 == "?")
            {
                pictureBox4.Image = Properties.Resources.loki;
                figura4 = "f";
            }
            else
            {
                pictureBox4.Image = Properties.Resources.duvida;
                figura4 = "?";
            }

            validaJOGO();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            jogadas++;

            if (figura5 == "?")
            {
                pictureBox5.Image = Properties.Resources.feiticeira_escarlate;
                figura5 = "f";
            }
            else
            {
                pictureBox5.Image = Properties.Resources.duvida;
                figura5 = "?";
            }

            validaJOGO();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            jogadas++;

            if (figura6 == "?")
            {
                pictureBox6.Image = Properties.Resources.loki;
                figura6 = "f";
            }
            else
            {
                pictureBox6.Image = Properties.Resources.duvida;
                figura6 = "?";
            }

            validaJOGO();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            jogadas++;

            if (figura7 == "?")
            {
                pictureBox7.Image = Properties.Resources.viuva_negra;
                figura7 = "f";
            }
            else
            {
                pictureBox7.Image = Properties.Resources.duvida;
                figura7 = "?";
            }

            validaJOGO();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            jogadas++;

            if (figura8 == "?")
            {
                pictureBox8.Image = Properties.Resources.capita_marvel;
                figura8 = "f";
            }
            else
            {
                pictureBox8.Image = Properties.Resources.duvida;
                figura8 = "?";
            }

            validaJOGO();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            jogadas++;

            if (figura9 == "?")
            {
                pictureBox9.Image = Properties.Resources.capitao_america;
                figura9 = "f";
            }
            else
            {
                pictureBox9.Image = Properties.Resources.duvida;
                figura9 = "?";
            }

            validaJOGO();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            jogadas++;

            if (figura10 == "?")
            {
                pictureBox10.Image = Properties.Resources.capita_marvel;
                figura10 = "f";
            }
            else
            {
                pictureBox10.Image = Properties.Resources.duvida;
                figura10 = "?";
            }

            validaJOGO();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            jogadas++;

            if (figura11 == "?")
            {
                pictureBox11.Image = Properties.Resources.homem_de_ferro;
                figura11 = "f";
            }
            else
            {
                pictureBox11.Image = Properties.Resources.duvida;
                figura11 = "?";
            }

            validaJOGO();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            jogadas++;

            if (figura12 == "?")
            {
                pictureBox12.Image = Properties.Resources.feiticeira_escarlate;
                figura12 = "f";
            }
            else
            {
                pictureBox12.Image = Properties.Resources.duvida;
                figura12 = "?";
            }

            validaJOGO();
        }

        
    }
}

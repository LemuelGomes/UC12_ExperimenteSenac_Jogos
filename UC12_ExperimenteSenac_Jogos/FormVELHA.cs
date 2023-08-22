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
    public partial class FormVELHA : Form
    {
        string jogador, fim;
        string p1, p2, p3, p4, p5, p6, p7, p8, p9;

        public FormVELHA()
        {
            InitializeComponent();

            iniciaJOGO();
        }

        private void trocaJOGADOR()
        {
            if (jogador == "1")
            {
                jogador = "2";
            }
            else
            {
                jogador = "1";
            }
            labelJOGADOR.Text = "Jogador " + jogador;
        }

        private void iniciaJOGO()
        {
            buttonNOVOJOGO.Visible = false;

            jogador = "1";
            labelJOGADOR.Text = "Jogador " + jogador;
            fim = null;

            p1 = null;
            p2 = null;
            p3 = null;
            p4 = null;
            p5 = null;
            p6 = null;
            p7 = null;
            p8 = null;
            p9 = null;

            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;

            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
        }

        private void validaJOGO()
        {
            if (p1 == p2 && p2 == p3 && p1 != null)
            {
                fim = "sim";
            }
            if (p4 == p5 && p5 == p6 && p4 != null)
            {
                fim = "sim";
            }
            if (p7 == p8 && p8 == p9 && p7 != null)
            {
                fim = "sim";
            }

            if (p1 == p4 && p4 == p7 && p1 != null)
            {
                fim = "sim";
            }
            if (p2 == p5 && p5 == p8 && p2 != null)
            {
                fim = "sim";
            }
            if (p3 == p6 && p6 == p9 && p3 != null)
            {
                fim = "sim";
            }

            if (p1 == p5 && p5 == p9 && p1 != null)
            {
                fim = "sim";
            }
            if (p3 == p5 && p5 == p7 && p3 != null)
            {
                fim = "sim";
            }

            if (fim == "sim")
            {
                MessageBox.Show("O vencedor é o Jogador " + jogador);
                buttonNOVOJOGO.Visible = true;

                if (ClassVARIAVEIS.turno == "X")
                {
                    ClassVARIAVEIS.turno = "O";
                } else
                {
                    ClassVARIAVEIS.turno = "X";
                }
            } else
            {
                trocaJOGADOR();
            }

        }

        private void buttonNOVOJOGO_Click(object sender, EventArgs e)
        {
            iniciaJOGO();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ClassVARIAVEIS.turno == "O")
            {
                pictureBox1.Image = Properties.Resources.letra_o;
                ClassVARIAVEIS.turno = "X";
            }
            else
            {
                pictureBox1.Image = Properties.Resources.letra_x;
                ClassVARIAVEIS.turno = "O";
            }
            p1 = jogador;
            pictureBox1.Enabled = false;
            validaJOGO();            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (ClassVARIAVEIS.turno == "O")
            {
                pictureBox2.Image = Properties.Resources.letra_o;
                ClassVARIAVEIS.turno = "X";
            }
            else
            {
                pictureBox2.Image = Properties.Resources.letra_x;
                ClassVARIAVEIS.turno = "O";
            }
            p2 = jogador;
            pictureBox2.Enabled = false;
            validaJOGO();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (ClassVARIAVEIS.turno == "O")
            {
                pictureBox3.Image = Properties.Resources.letra_o;
                ClassVARIAVEIS.turno = "X";
            }
            else
            {
                pictureBox3.Image = Properties.Resources.letra_x;
                ClassVARIAVEIS.turno = "O";
            }
            p3 = jogador;
            pictureBox3.Enabled = false;
            validaJOGO();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (ClassVARIAVEIS.turno == "O")
            {
                pictureBox4.Image = Properties.Resources.letra_o;
                ClassVARIAVEIS.turno = "X";
            }
            else
            {
                pictureBox4.Image = Properties.Resources.letra_x;
                ClassVARIAVEIS.turno = "O";
            }
            p4 = jogador;
            pictureBox4.Enabled = false;
            validaJOGO();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (ClassVARIAVEIS.turno == "O")
            {
                pictureBox5.Image = Properties.Resources.letra_o;
                ClassVARIAVEIS.turno = "X";
            }
            else
            {
                pictureBox5.Image = Properties.Resources.letra_x;
                ClassVARIAVEIS.turno = "O";
            }
            p5 = jogador;
            pictureBox5.Enabled = false;
            validaJOGO();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (ClassVARIAVEIS.turno == "O")
            {
                pictureBox6.Image = Properties.Resources.letra_o;
                ClassVARIAVEIS.turno = "X";
            }
            else
            {
                pictureBox6.Image = Properties.Resources.letra_x;
                ClassVARIAVEIS.turno = "O";
            }
            p6 = jogador;
            pictureBox6.Enabled = false;
            validaJOGO();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (ClassVARIAVEIS.turno == "O")
            {
                pictureBox7.Image = Properties.Resources.letra_o;
                ClassVARIAVEIS.turno = "X";
            }
            else
            {
                pictureBox7.Image = Properties.Resources.letra_x;
                ClassVARIAVEIS.turno = "O";
            }
            p7 = jogador;
            pictureBox7.Enabled = false;
            validaJOGO();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (ClassVARIAVEIS.turno == "O")
            {
                pictureBox8.Image = Properties.Resources.letra_o;
                ClassVARIAVEIS.turno = "X";
            }
            else
            {
                pictureBox8.Image = Properties.Resources.letra_x;
                ClassVARIAVEIS.turno = "O";
            }
            p8 = jogador;
            pictureBox8.Enabled = false;
            validaJOGO();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (ClassVARIAVEIS.turno == "O")
            {
                pictureBox9.Image = Properties.Resources.letra_o;
                ClassVARIAVEIS.turno = "X";
            }
            else
            {
                pictureBox9.Image = Properties.Resources.letra_x;
                ClassVARIAVEIS.turno = "O";
            }
            p9 = jogador;
            pictureBox9.Enabled = false;
            validaJOGO();
        }
    }
}

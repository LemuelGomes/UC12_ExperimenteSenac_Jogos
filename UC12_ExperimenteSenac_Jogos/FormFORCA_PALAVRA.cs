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
    public partial class FormFORCA_PALAVRA : Form
    {
        public FormFORCA_PALAVRA()
        {
            InitializeComponent();
        }

        private void buttonJOGAR_Click(object sender, EventArgs e)
        {
            if (textBoxPALAVRA.Text.Length <= 10)
            {
                for (int i = 0; i < textBoxPALAVRA.Text.Length; i++)
                {
                    ClassVARIAVEIS.palavra_secreta[i] = textBoxPALAVRA.Text.Substring(i, 1);
                }

                this.Hide();
                Form telaFORCA = new FormFORCA();
                telaFORCA.Closed += (s, args) => this.Close();
                telaFORCA.Show();
            } else
            {
                MessageBox.Show("Você usou uma PALAVRA com mais de 10 Letras...");
            }

            
        }
    }
}

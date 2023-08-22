namespace UC12_ExperimenteSenac_Jogos
{
    partial class FormJOGOS
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJOGOS));
            this.buttonMEMORIA = new System.Windows.Forms.Button();
            this.buttonFORCA = new System.Windows.Forms.Button();
            this.buttonVELHA = new System.Windows.Forms.Button();
            this.labelMEMORIA = new System.Windows.Forms.Label();
            this.labelFORCA = new System.Windows.Forms.Label();
            this.labelVELHA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMEMORIA
            // 
            this.buttonMEMORIA.BackColor = System.Drawing.Color.Transparent;
            this.buttonMEMORIA.BackgroundImage = global::UC12_ExperimenteSenac_Jogos.Properties.Resources.jogo_memoria;
            this.buttonMEMORIA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMEMORIA.FlatAppearance.BorderSize = 0;
            this.buttonMEMORIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMEMORIA.Location = new System.Drawing.Point(72, 54);
            this.buttonMEMORIA.Name = "buttonMEMORIA";
            this.buttonMEMORIA.Size = new System.Drawing.Size(110, 110);
            this.buttonMEMORIA.TabIndex = 0;
            this.buttonMEMORIA.UseVisualStyleBackColor = false;
            this.buttonMEMORIA.Click += new System.EventHandler(this.buttonMEMORIA_Click);
            this.buttonMEMORIA.MouseLeave += new System.EventHandler(this.buttonMEMORIA_MouseLeave);
            this.buttonMEMORIA.MouseHover += new System.EventHandler(this.buttonMEMORIA_MouseHover);
            // 
            // buttonFORCA
            // 
            this.buttonFORCA.BackColor = System.Drawing.Color.Transparent;
            this.buttonFORCA.BackgroundImage = global::UC12_ExperimenteSenac_Jogos.Properties.Resources.jogo_forca;
            this.buttonFORCA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFORCA.FlatAppearance.BorderSize = 0;
            this.buttonFORCA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFORCA.Location = new System.Drawing.Point(306, 54);
            this.buttonFORCA.Name = "buttonFORCA";
            this.buttonFORCA.Size = new System.Drawing.Size(110, 110);
            this.buttonFORCA.TabIndex = 1;
            this.buttonFORCA.UseVisualStyleBackColor = false;
            this.buttonFORCA.Click += new System.EventHandler(this.buttonFORCA_Click);
            this.buttonFORCA.MouseLeave += new System.EventHandler(this.buttonFORCA_MouseLeave);
            this.buttonFORCA.MouseHover += new System.EventHandler(this.buttonFORCA_MouseHover);
            // 
            // buttonVELHA
            // 
            this.buttonVELHA.BackColor = System.Drawing.Color.Transparent;
            this.buttonVELHA.BackgroundImage = global::UC12_ExperimenteSenac_Jogos.Properties.Resources.jogo_velha;
            this.buttonVELHA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVELHA.FlatAppearance.BorderSize = 0;
            this.buttonVELHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVELHA.Location = new System.Drawing.Point(535, 54);
            this.buttonVELHA.Name = "buttonVELHA";
            this.buttonVELHA.Size = new System.Drawing.Size(110, 110);
            this.buttonVELHA.TabIndex = 2;
            this.buttonVELHA.UseVisualStyleBackColor = false;
            this.buttonVELHA.Click += new System.EventHandler(this.buttonVELHA_Click);
            this.buttonVELHA.MouseLeave += new System.EventHandler(this.buttonVELHA_MouseLeave);
            this.buttonVELHA.MouseHover += new System.EventHandler(this.buttonVELHA_MouseHover);
            // 
            // labelMEMORIA
            // 
            this.labelMEMORIA.BackColor = System.Drawing.Color.Transparent;
            this.labelMEMORIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMEMORIA.Font = new System.Drawing.Font("Sigmar", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMEMORIA.Location = new System.Drawing.Point(2, 6);
            this.labelMEMORIA.Name = "labelMEMORIA";
            this.labelMEMORIA.Size = new System.Drawing.Size(245, 36);
            this.labelMEMORIA.TabIndex = 3;
            this.labelMEMORIA.Text = "Jogo da Memória";
            this.labelMEMORIA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFORCA
            // 
            this.labelFORCA.BackColor = System.Drawing.Color.Transparent;
            this.labelFORCA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFORCA.Font = new System.Drawing.Font("Sigmar", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFORCA.Location = new System.Drawing.Point(253, 6);
            this.labelFORCA.Name = "labelFORCA";
            this.labelFORCA.Size = new System.Drawing.Size(220, 36);
            this.labelFORCA.TabIndex = 4;
            this.labelFORCA.Text = "Jogo da Forca";
            this.labelFORCA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFORCA.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelVELHA
            // 
            this.labelVELHA.BackColor = System.Drawing.Color.Transparent;
            this.labelVELHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelVELHA.Font = new System.Drawing.Font("Sigmar", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVELHA.Location = new System.Drawing.Point(479, 6);
            this.labelVELHA.Name = "labelVELHA";
            this.labelVELHA.Size = new System.Drawing.Size(220, 36);
            this.labelVELHA.TabIndex = 5;
            this.labelVELHA.Text = "Jogo da Velha";
            this.labelVELHA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVELHA.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormJOGOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UC12_ExperimenteSenac_Jogos.Properties.Resources.bg_jogos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(696, 186);
            this.Controls.Add(this.labelVELHA);
            this.Controls.Add(this.labelFORCA);
            this.Controls.Add(this.labelMEMORIA);
            this.Controls.Add(this.buttonVELHA);
            this.Controls.Add(this.buttonFORCA);
            this.Controls.Add(this.buttonMEMORIA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormJOGOS";
            this.Text = "Senac Games! - Ver.: 1.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMEMORIA;
        private System.Windows.Forms.Button buttonFORCA;
        private System.Windows.Forms.Button buttonVELHA;
        private System.Windows.Forms.Label labelMEMORIA;
        private System.Windows.Forms.Label labelFORCA;
        private System.Windows.Forms.Label labelVELHA;
    }
}


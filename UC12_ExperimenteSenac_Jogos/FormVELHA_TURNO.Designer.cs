namespace UC12_ExperimenteSenac_Jogos
{
    partial class FormVELHA_TURNO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMEMORIA = new System.Windows.Forms.Label();
            this.pictureBox_X = new System.Windows.Forms.PictureBox();
            this.pictureBox_O = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_O)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMEMORIA
            // 
            this.labelMEMORIA.BackColor = System.Drawing.Color.Transparent;
            this.labelMEMORIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMEMORIA.Font = new System.Drawing.Font("Sigmar", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMEMORIA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMEMORIA.Location = new System.Drawing.Point(13, 41);
            this.labelMEMORIA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMEMORIA.Name = "labelMEMORIA";
            this.labelMEMORIA.Size = new System.Drawing.Size(622, 55);
            this.labelMEMORIA.TabIndex = 4;
            this.labelMEMORIA.Text = "Jogador 1, escolha sua marcação!";
            this.labelMEMORIA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_X
            // 
            this.pictureBox_X.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_X.Image = global::UC12_ExperimenteSenac_Jogos.Properties.Resources.letra_x;
            this.pictureBox_X.Location = new System.Drawing.Point(368, 119);
            this.pictureBox_X.Name = "pictureBox_X";
            this.pictureBox_X.Size = new System.Drawing.Size(140, 140);
            this.pictureBox_X.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_X.TabIndex = 2;
            this.pictureBox_X.TabStop = false;
            this.pictureBox_X.Click += new System.EventHandler(this.pictureBox_X_Click);
            // 
            // pictureBox_O
            // 
            this.pictureBox_O.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_O.Image = global::UC12_ExperimenteSenac_Jogos.Properties.Resources.letra_o;
            this.pictureBox_O.Location = new System.Drawing.Point(142, 119);
            this.pictureBox_O.Name = "pictureBox_O";
            this.pictureBox_O.Size = new System.Drawing.Size(140, 140);
            this.pictureBox_O.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_O.TabIndex = 1;
            this.pictureBox_O.TabStop = false;
            this.pictureBox_O.Click += new System.EventHandler(this.pictureBox_O_Click);
            // 
            // FormVELHA_TURNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UC12_ExperimenteSenac_Jogos.Properties.Resources.bg_game_azul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 344);
            this.Controls.Add(this.labelMEMORIA);
            this.Controls.Add(this.pictureBox_X);
            this.Controls.Add(this.pictureBox_O);
            this.Name = "FormVELHA_TURNO";
            this.Text = "FormVELHA_TURNO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_O)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelMEMORIA;
        private System.Windows.Forms.PictureBox pictureBox_X;
        private System.Windows.Forms.PictureBox pictureBox_O;
    }
}
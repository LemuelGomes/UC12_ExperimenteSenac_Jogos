namespace UC12_ExperimenteSenac_Jogos
{
    partial class FormFORCA_PALAVRA
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
            this.labelPALAVRA = new System.Windows.Forms.Label();
            this.textBoxPALAVRA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonJOGAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPALAVRA
            // 
            this.labelPALAVRA.BackColor = System.Drawing.Color.Transparent;
            this.labelPALAVRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPALAVRA.Font = new System.Drawing.Font("Sigmar", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPALAVRA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPALAVRA.Location = new System.Drawing.Point(13, 41);
            this.labelPALAVRA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPALAVRA.Name = "labelPALAVRA";
            this.labelPALAVRA.Size = new System.Drawing.Size(622, 55);
            this.labelPALAVRA.TabIndex = 5;
            this.labelPALAVRA.Text = "Escolha a PALAVRA do Jogo!";
            this.labelPALAVRA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPALAVRA
            // 
            this.textBoxPALAVRA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPALAVRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPALAVRA.Location = new System.Drawing.Point(120, 160);
            this.textBoxPALAVRA.Name = "textBoxPALAVRA";
            this.textBoxPALAVRA.Size = new System.Drawing.Size(403, 37);
            this.textBoxPALAVRA.TabIndex = 14;
            this.textBoxPALAVRA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("AdAstra", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 55);
            this.label1.TabIndex = 13;
            this.label1.Text = "Maximo de 10 Letras...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonJOGAR
            // 
            this.buttonJOGAR.BackColor = System.Drawing.Color.Transparent;
            this.buttonJOGAR.FlatAppearance.BorderSize = 0;
            this.buttonJOGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJOGAR.Font = new System.Drawing.Font("Sigmar", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJOGAR.ForeColor = System.Drawing.Color.Lime;
            this.buttonJOGAR.Location = new System.Drawing.Point(120, 225);
            this.buttonJOGAR.Name = "buttonJOGAR";
            this.buttonJOGAR.Size = new System.Drawing.Size(403, 79);
            this.buttonJOGAR.TabIndex = 15;
            this.buttonJOGAR.Text = "Vamos Jogar!";
            this.buttonJOGAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonJOGAR.UseVisualStyleBackColor = false;
            this.buttonJOGAR.Click += new System.EventHandler(this.buttonJOGAR_Click);
            // 
            // FormFORCA_PALAVRA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UC12_ExperimenteSenac_Jogos.Properties.Resources.bg_game_azul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 344);
            this.Controls.Add(this.buttonJOGAR);
            this.Controls.Add(this.textBoxPALAVRA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPALAVRA);
            this.Name = "FormFORCA_PALAVRA";
            this.Text = "FormFORCA_PALAVRA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPALAVRA;
        private System.Windows.Forms.TextBox textBoxPALAVRA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonJOGAR;
    }
}
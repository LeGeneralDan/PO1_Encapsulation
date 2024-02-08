namespace PO1_Encapsulation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gb_joueur = new GroupBox();
            lbl_puissanceAttaqueJoueur = new Label();
            lbl_pointsVieJoueur = new Label();
            gb_dragon = new GroupBox();
            lbl_puissanceAttaqueDragon = new Label();
            lbl_pointsVieDragon = new Label();
            btn_attaquer = new Button();
            btn_seSoigner = new Button();
            btn_puissanceAttaque = new Button();
            gb_joueur.SuspendLayout();
            gb_dragon.SuspendLayout();
            SuspendLayout();
            // 
            // gb_joueur
            // 
            gb_joueur.Controls.Add(lbl_puissanceAttaqueJoueur);
            gb_joueur.Controls.Add(lbl_pointsVieJoueur);
            gb_joueur.Location = new Point(10, 9);
            gb_joueur.Margin = new Padding(3, 2, 3, 2);
            gb_joueur.Name = "gb_joueur";
            gb_joueur.Padding = new Padding(3, 2, 3, 2);
            gb_joueur.Size = new Size(181, 119);
            gb_joueur.TabIndex = 0;
            gb_joueur.TabStop = false;
            gb_joueur.Text = "Joueur";
            // 
            // lbl_puissanceAttaqueJoueur
            // 
            lbl_puissanceAttaqueJoueur.AutoSize = true;
            lbl_puissanceAttaqueJoueur.Location = new Point(5, 58);
            lbl_puissanceAttaqueJoueur.Name = "lbl_puissanceAttaqueJoueur";
            lbl_puissanceAttaqueJoueur.Size = new Size(118, 15);
            lbl_puissanceAttaqueJoueur.TabIndex = 3;
            lbl_puissanceAttaqueJoueur.Text = "Puissance d'attaque :";
            // 
            // lbl_pointsVieJoueur
            // 
            lbl_pointsVieJoueur.AutoSize = true;
            lbl_pointsVieJoueur.Location = new Point(5, 27);
            lbl_pointsVieJoueur.Name = "lbl_pointsVieJoueur";
            lbl_pointsVieJoueur.Size = new Size(80, 15);
            lbl_pointsVieJoueur.TabIndex = 2;
            lbl_pointsVieJoueur.Text = "Points de vie :";
            // 
            // gb_dragon
            // 
            gb_dragon.Controls.Add(lbl_puissanceAttaqueDragon);
            gb_dragon.Controls.Add(lbl_pointsVieDragon);
            gb_dragon.Location = new Point(197, 9);
            gb_dragon.Margin = new Padding(3, 2, 3, 2);
            gb_dragon.Name = "gb_dragon";
            gb_dragon.Padding = new Padding(3, 2, 3, 2);
            gb_dragon.Size = new Size(181, 119);
            gb_dragon.TabIndex = 1;
            gb_dragon.TabStop = false;
            gb_dragon.Text = "Dragon";
            // 
            // lbl_puissanceAttaqueDragon
            // 
            lbl_puissanceAttaqueDragon.AutoSize = true;
            lbl_puissanceAttaqueDragon.Location = new Point(5, 58);
            lbl_puissanceAttaqueDragon.Name = "lbl_puissanceAttaqueDragon";
            lbl_puissanceAttaqueDragon.Size = new Size(118, 15);
            lbl_puissanceAttaqueDragon.TabIndex = 5;
            lbl_puissanceAttaqueDragon.Text = "Puissance d'attaque :";
            // 
            // lbl_pointsVieDragon
            // 
            lbl_pointsVieDragon.AutoSize = true;
            lbl_pointsVieDragon.Location = new Point(5, 27);
            lbl_pointsVieDragon.Name = "lbl_pointsVieDragon";
            lbl_pointsVieDragon.Size = new Size(80, 15);
            lbl_pointsVieDragon.TabIndex = 4;
            lbl_pointsVieDragon.Text = "Points de vie :";
            // 
            // btn_attaquer
            // 
            btn_attaquer.Location = new Point(10, 133);
            btn_attaquer.Margin = new Padding(3, 2, 3, 2);
            btn_attaquer.Name = "btn_attaquer";
            btn_attaquer.Size = new Size(206, 25);
            btn_attaquer.TabIndex = 2;
            btn_attaquer.Text = "Attaquer";
            btn_attaquer.UseVisualStyleBackColor = true;
            btn_attaquer.Click += btn_attaquer_Click;
            // 
            // btn_seSoigner
            // 
            btn_seSoigner.Location = new Point(10, 162);
            btn_seSoigner.Margin = new Padding(3, 2, 3, 2);
            btn_seSoigner.Name = "btn_seSoigner";
            btn_seSoigner.Size = new Size(206, 25);
            btn_seSoigner.TabIndex = 3;
            btn_seSoigner.Text = "Se soigner";
            btn_seSoigner.UseVisualStyleBackColor = true;
            btn_seSoigner.Click += btn_seSoigner_Click;
            // 
            // btn_puissanceAttaque
            // 
            btn_puissanceAttaque.Location = new Point(10, 191);
            btn_puissanceAttaque.Margin = new Padding(3, 2, 3, 2);
            btn_puissanceAttaque.Name = "btn_puissanceAttaque";
            btn_puissanceAttaque.Size = new Size(206, 25);
            btn_puissanceAttaque.TabIndex = 4;
            btn_puissanceAttaque.Text = "Boire une potion de puissance";
            btn_puissanceAttaque.UseVisualStyleBackColor = true;
            btn_puissanceAttaque.Click += btn_puissanceAttaque_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 225);
            Controls.Add(btn_puissanceAttaque);
            Controls.Add(btn_seSoigner);
            Controls.Add(btn_attaquer);
            Controls.Add(gb_dragon);
            Controls.Add(gb_joueur);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gb_joueur.ResumeLayout(false);
            gb_joueur.PerformLayout();
            gb_dragon.ResumeLayout(false);
            gb_dragon.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_joueur;
        private Label lbl_puissanceAttaqueJoueur;
        private Label lbl_pointsVieJoueur;
        private GroupBox gb_dragon;
        private Label lbl_puissanceAttaqueDragon;
        private Label lbl_pointsVieDragon;
        private Button btn_attaquer;
        private Button btn_seSoigner;
        private Button btn_puissanceAttaque;
    }
}
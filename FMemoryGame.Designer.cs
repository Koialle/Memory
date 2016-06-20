/*
 *
 * Memory Game
 * Par Mélanie DUBREUIL et Ophélie EOUZAN, 3APP
 * Module ISI2
 * 
 */

namespace Memory
{
    partial class FMemoryGame
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMemoryGame));
            this.tlpTapisDeCartes = new System.Windows.Forms.TableLayoutPanel();
            this.pb_14 = new System.Windows.Forms.PictureBox();
            this.pb_15 = new System.Windows.Forms.PictureBox();
            this.pb_16 = new System.Windows.Forms.PictureBox();
            this.pb_10 = new System.Windows.Forms.PictureBox();
            this.pb_09 = new System.Windows.Forms.PictureBox();
            this.pb_11 = new System.Windows.Forms.PictureBox();
            this.pb_13 = new System.Windows.Forms.PictureBox();
            this.pb_12 = new System.Windows.Forms.PictureBox();
            this.pb_05 = new System.Windows.Forms.PictureBox();
            this.pb_06 = new System.Windows.Forms.PictureBox();
            this.pb_07 = new System.Windows.Forms.PictureBox();
            this.pb_08 = new System.Windows.Forms.PictureBox();
            this.pb_01 = new System.Windows.Forms.PictureBox();
            this.pb_02 = new System.Windows.Forms.PictureBox();
            this.pb_04 = new System.Windows.Forms.PictureBox();
            this.pb_03 = new System.Windows.Forms.PictureBox();
            this.btn_distribuer = new System.Windows.Forms.Button();
            this.ilSabotDeCartes = new System.Windows.Forms.ImageList(this.components);
            this.btn_retourner = new System.Windows.Forms.Button();
            this.btn_jouer = new System.Windows.Forms.Button();
            this.label_timer = new System.Windows.Forms.Label();
            this.label_règles1 = new System.Windows.Forms.Label();
            this.label_règles2 = new System.Windows.Forms.Label();
            this.label_règles3 = new System.Windows.Forms.Label();
            this.label_points = new System.Windows.Forms.Label();
            this.tlpTapisDeCartes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_09)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_03)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpTapisDeCartes
            // 
            resources.ApplyResources(this.tlpTapisDeCartes, "tlpTapisDeCartes");
            this.tlpTapisDeCartes.Controls.Add(this.pb_14, 0, 3);
            this.tlpTapisDeCartes.Controls.Add(this.pb_15, 0, 3);
            this.tlpTapisDeCartes.Controls.Add(this.pb_16, 0, 3);
            this.tlpTapisDeCartes.Controls.Add(this.pb_10, 0, 2);
            this.tlpTapisDeCartes.Controls.Add(this.pb_09, 0, 2);
            this.tlpTapisDeCartes.Controls.Add(this.pb_11, 0, 2);
            this.tlpTapisDeCartes.Controls.Add(this.pb_13, 0, 2);
            this.tlpTapisDeCartes.Controls.Add(this.pb_12, 0, 2);
            this.tlpTapisDeCartes.Controls.Add(this.pb_05, 0, 1);
            this.tlpTapisDeCartes.Controls.Add(this.pb_06, 0, 1);
            this.tlpTapisDeCartes.Controls.Add(this.pb_07, 0, 1);
            this.tlpTapisDeCartes.Controls.Add(this.pb_08, 0, 1);
            this.tlpTapisDeCartes.Controls.Add(this.pb_01, 0, 0);
            this.tlpTapisDeCartes.Controls.Add(this.pb_02, 1, 0);
            this.tlpTapisDeCartes.Controls.Add(this.pb_04, 3, 0);
            this.tlpTapisDeCartes.Controls.Add(this.pb_03, 2, 0);
            this.tlpTapisDeCartes.Name = "tlpTapisDeCartes";
            this.tlpTapisDeCartes.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pb_14
            // 
            resources.ApplyResources(this.pb_14, "pb_14");
            this.pb_14.Name = "pb_14";
            this.pb_14.TabStop = false;
            this.pb_14.Click += new System.EventHandler(this.verifierCarte);
            // 
            // pb_15
            // 
            resources.ApplyResources(this.pb_15, "pb_15");
            this.pb_15.Name = "pb_15";
            this.pb_15.TabStop = false;
            this.pb_15.Click += new System.EventHandler(this.verifierCarte);
            // 
            // pb_16
            // 
            resources.ApplyResources(this.pb_16, "pb_16");
            this.pb_16.Name = "pb_16";
            this.pb_16.TabStop = false;
            this.pb_16.Click += new System.EventHandler(this.verifierCarte);
            // 
            // pb_10
            // 
            resources.ApplyResources(this.pb_10, "pb_10");
            this.pb_10.Name = "pb_10";
            this.pb_10.TabStop = false;
            this.pb_10.Click += new System.EventHandler(this.verifierCarte);
            // 
            // pb_09
            // 
            resources.ApplyResources(this.pb_09, "pb_09");
            this.pb_09.Name = "pb_09";
            this.pb_09.TabStop = false;
            this.pb_09.Click += new System.EventHandler(this.verifierCarte);
            // 
            // pb_11
            // 
            resources.ApplyResources(this.pb_11, "pb_11");
            this.pb_11.Name = "pb_11";
            this.pb_11.TabStop = false;
            this.pb_11.Click += new System.EventHandler(this.verifierCarte);
            // 
            // pb_13
            // 
            resources.ApplyResources(this.pb_13, "pb_13");
            this.pb_13.Name = "pb_13";
            this.pb_13.TabStop = false;
            this.pb_13.Click += new System.EventHandler(this.verifierCarte);
            // 
            // pb_12
            // 
            resources.ApplyResources(this.pb_12, "pb_12");
            this.pb_12.Name = "pb_12";
            this.pb_12.TabStop = false;
            this.pb_12.Click += new System.EventHandler(this.verifierCarte);
            // 
            // pb_05
            // 
            resources.ApplyResources(this.pb_05, "pb_05");
            this.pb_05.Name = "pb_05";
            this.pb_05.TabStop = false;
            this.pb_05.Click += new System.EventHandler(this.verifierCarte);
            // 
            // pb_06
            // 
            resources.ApplyResources(this.pb_06, "pb_06");
            this.pb_06.Name = "pb_06";
            this.pb_06.TabStop = false;
            this.pb_06.Click += new System.EventHandler(this.verifierCarte);
            // 
            // pb_07
            // 
            resources.ApplyResources(this.pb_07, "pb_07");
            this.pb_07.Name = "pb_07";
            this.pb_07.TabStop = false;
            this.pb_07.Click += new System.EventHandler(this.verifierCarte);
            // 
            // pb_08
            // 
            resources.ApplyResources(this.pb_08, "pb_08");
            this.pb_08.Name = "pb_08";
            this.pb_08.TabStop = false;
            this.pb_08.Click += new System.EventHandler(this.verifierCarte);
            // 
            // pb_01
            // 
            resources.ApplyResources(this.pb_01, "pb_01");
            this.pb_01.Name = "pb_01";
            this.pb_01.TabStop = false;
            this.pb_01.Click += new System.EventHandler(this.verifierCarte);
            // 
            // pb_02
            // 
            resources.ApplyResources(this.pb_02, "pb_02");
            this.pb_02.Name = "pb_02";
            this.pb_02.TabStop = false;
            this.pb_02.Click += new System.EventHandler(this.verifierCarte);
            // 
            // pb_04
            // 
            resources.ApplyResources(this.pb_04, "pb_04");
            this.pb_04.Name = "pb_04";
            this.pb_04.TabStop = false;
            this.pb_04.Click += new System.EventHandler(this.verifierCarte);
            // 
            // pb_03
            // 
            resources.ApplyResources(this.pb_03, "pb_03");
            this.pb_03.Name = "pb_03";
            this.pb_03.TabStop = false;
            this.pb_03.Click += new System.EventHandler(this.verifierCarte);
            // 
            // btn_distribuer
            // 
            resources.ApplyResources(this.btn_distribuer, "btn_distribuer");
            this.btn_distribuer.Name = "btn_distribuer";
            this.btn_distribuer.UseVisualStyleBackColor = true;
            this.btn_distribuer.Click += new System.EventHandler(this.btn_Distribuer_Click);
            // 
            // ilSabotDeCartes
            // 
            this.ilSabotDeCartes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSabotDeCartes.ImageStream")));
            this.ilSabotDeCartes.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSabotDeCartes.Images.SetKeyName(0, "DosCarte.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(1, "Abeille.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(2, "Autruches.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(3, "Canard.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(4, "Chameau.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(5, "Chien.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(6, "ChienGamelle.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(7, "ChienMechant.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(8, "ChienSavant.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(9, "Chimpanze.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(10, "Coccinelle.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(11, "Crabe.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(12, "Crocodile.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(13, "Dauphin.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(14, "Ecureuil.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(15, "Hanneton.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(16, "Hibou.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(17, "Hippocampe.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(18, "Homard.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(19, "Kangourou.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(20, "Lapin.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(21, "LapinChapeau.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(22, "LapinRieur.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(23, "Lion.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(24, "MacareuxMoine.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(25, "Mouette.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(26, "Ocelot.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(27, "OiseauCage.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(28, "OiseauChante.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(29, "OiseauPic.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(30, "Orycterope.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(31, "Papillon.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(32, "PoissonBocal.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(33, "PoissonBulle.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(34, "PoissonPapillon.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(35, "PorcEpic.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(36, "PorcEpic2.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(37, "Renne.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(38, "Renne2.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(39, "Serpent.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(40, "Taureau.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(41, "Vache.jpg");
            // 
            // btn_retourner
            // 
            resources.ApplyResources(this.btn_retourner, "btn_retourner");
            this.btn_retourner.Name = "btn_retourner";
            this.btn_retourner.UseVisualStyleBackColor = true;
            this.btn_retourner.Click += new System.EventHandler(this.boutonRetourner);
            // 
            // btn_jouer
            // 
            resources.ApplyResources(this.btn_jouer, "btn_jouer");
            this.btn_jouer.Name = "btn_jouer";
            this.btn_jouer.UseVisualStyleBackColor = true;
            this.btn_jouer.Click += new System.EventHandler(this.lancerPartie);
            // 
            // label_timer
            // 
            resources.ApplyResources(this.label_timer, "label_timer");
            this.label_timer.Name = "label_timer";
            this.label_timer.Click += new System.EventHandler(this.label_timer_Click);
            // 
            // label_règles1
            // 
            resources.ApplyResources(this.label_règles1, "label_règles1");
            this.label_règles1.Name = "label_règles1";
            this.label_règles1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_règles2
            // 
            resources.ApplyResources(this.label_règles2, "label_règles2");
            this.label_règles2.Name = "label_règles2";
            this.label_règles2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label_règles3
            // 
            resources.ApplyResources(this.label_règles3, "label_règles3");
            this.label_règles3.Name = "label_règles3";
            this.label_règles3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_points
            // 
            resources.ApplyResources(this.label_points, "label_points");
            this.label_points.Name = "label_points";
            // 
            // FMemoryGame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_points);
            this.Controls.Add(this.label_règles3);
            this.Controls.Add(this.label_règles2);
            this.Controls.Add(this.label_règles1);
            this.Controls.Add(this.label_timer);
            this.Controls.Add(this.btn_jouer);
            this.Controls.Add(this.btn_retourner);
            this.Controls.Add(this.btn_distribuer);
            this.Controls.Add(this.tlpTapisDeCartes);
            this.Name = "FMemoryGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpTapisDeCartes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_09)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_03)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTapisDeCartes;
        private System.Windows.Forms.Button btn_distribuer;
        private System.Windows.Forms.ImageList ilSabotDeCartes;
        private System.Windows.Forms.Button btn_retourner;
        private System.Windows.Forms.Button btn_jouer;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Label label_règles1;
        private System.Windows.Forms.Label label_règles2;
        private System.Windows.Forms.Label label_règles3;
        private System.Windows.Forms.Label label_points;
        private System.Windows.Forms.PictureBox pb_05;
        private System.Windows.Forms.PictureBox pb_06;
        private System.Windows.Forms.PictureBox pb_07;
        private System.Windows.Forms.PictureBox pb_08;
        private System.Windows.Forms.PictureBox pb_01;
        private System.Windows.Forms.PictureBox pb_02;
        private System.Windows.Forms.PictureBox pb_04;
        private System.Windows.Forms.PictureBox pb_03;
        private System.Windows.Forms.PictureBox pb_14;
        private System.Windows.Forms.PictureBox pb_15;
        private System.Windows.Forms.PictureBox pb_16;
        private System.Windows.Forms.PictureBox pb_10;
        private System.Windows.Forms.PictureBox pb_09;
        private System.Windows.Forms.PictureBox pb_11;
        private System.Windows.Forms.PictureBox pb_13;
        private System.Windows.Forms.PictureBox pb_12;
    }
}


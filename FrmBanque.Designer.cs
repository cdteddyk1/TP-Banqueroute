

using System;
using System.Windows.Forms;

namespace AppWindoBanque
{
    partial class FrmBanque : Form
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAcceuil = new System.Windows.Forms.TabPage();
            this.dgv_ListeComptes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ac_Titre = new System.Windows.Forms.Label();
            this.tabConsultation = new System.Windows.Forms.TabPage();
            this.tbx_co_SoldeActuel = new System.Windows.Forms.TextBox();
            this.tbx_co_Titulaire = new System.Windows.Forms.TextBox();
            this.tbx_co_Numero = new System.Windows.Forms.TextBox();
            this.cbx_co_ChoixCompte = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabCreation = new System.Windows.Forms.TabPage();
            this.btn_cr_Annuler = new System.Windows.Forms.Button();
            this.btn_Creer = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbx_cr_SoldeInitial = new System.Windows.Forms.TextBox();
            this.tbx_cr_Titulaire = new System.Windows.Forms.TextBox();
            this.tbx_cr_Numero = new System.Windows.Forms.TextBox();
            this.lbl_cr_Message = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabVersement = new System.Windows.Forms.TabPage();
            this.lbl_ve_Message = new System.Windows.Forms.Label();
            this.btn_ve_Annuler = new System.Windows.Forms.Button();
            this.btn_ve_Enregistrer = new System.Windows.Forms.Button();
            this.tbx_ve_Montant_A_Crediter = new System.Windows.Forms.TextBox();
            this.cbb_ve_ChoixCompte = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabRetrait = new System.Windows.Forms.TabPage();
            this.btn_re_Annuler = new System.Windows.Forms.Button();
            this.btn_re_Enregistrer = new System.Windows.Forms.Button();
            this.tbx_re_Montant_A_Retrait = new System.Windows.Forms.TextBox();
            this.cbb_re_ChoixCompte = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabVirement = new System.Windows.Forms.TabPage();
            this.lbl_vii_Message = new System.Windows.Forms.Label();
            this.btn_vi_Annuler = new System.Windows.Forms.Button();
            this.btn_vi_Enregistrer = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.tbx_re_Montant_A_Virement = new System.Windows.Forms.TextBox();
            this.cbb_vi_ChoixCompteCredit = new System.Windows.Forms.ComboBox();
            this.cbb_vi_ChoixCompteDebit = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbl_re_Message = new System.Windows.Forms.Label();
            this.lbl_vi_Message = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabAcceuil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeComptes)).BeginInit();
            this.tabConsultation.SuspendLayout();
            this.tabCreation.SuspendLayout();
            this.tabVersement.SuspendLayout();
            this.tabRetrait.SuspendLayout();
            this.tabVirement.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAcceuil);
            this.tabControl1.Controls.Add(this.tabConsultation);
            this.tabControl1.Controls.Add(this.tabCreation);
            this.tabControl1.Controls.Add(this.tabVersement);
            this.tabControl1.Controls.Add(this.tabRetrait);
            this.tabControl1.Controls.Add(this.tabVirement);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAcceuil
            // 
            this.tabAcceuil.Controls.Add(this.dgv_ListeComptes);
            this.tabAcceuil.Controls.Add(this.label1);
            this.tabAcceuil.Controls.Add(this.lbl_ac_Titre);
            this.tabAcceuil.Location = new System.Drawing.Point(4, 24);
            this.tabAcceuil.Name = "tabAcceuil";
            this.tabAcceuil.Padding = new System.Windows.Forms.Padding(3);
            this.tabAcceuil.Size = new System.Drawing.Size(792, 422);
            this.tabAcceuil.TabIndex = 0;
            this.tabAcceuil.Text = "Acceuil";
            this.tabAcceuil.UseVisualStyleBackColor = true;
            this.tabAcceuil.Enter += new System.EventHandler(this.tabAcceuil_Enter);
            // 
            // dgv_ListeComptes
            // 
            this.dgv_ListeComptes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListeComptes.Location = new System.Drawing.Point(64, 164);
            this.dgv_ListeComptes.Name = "dgv_ListeComptes";
            this.dgv_ListeComptes.RowTemplate.Height = 25;
            this.dgv_ListeComptes.Size = new System.Drawing.Size(698, 214);
            this.dgv_ListeComptes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(64, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des comptes de l\'agence";
            // 
            // lbl_ac_Titre
            // 
            this.lbl_ac_Titre.AutoSize = true;
            this.lbl_ac_Titre.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ac_Titre.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_ac_Titre.Location = new System.Drawing.Point(281, 37);
            this.lbl_ac_Titre.Name = "lbl_ac_Titre";
            this.lbl_ac_Titre.Size = new System.Drawing.Size(268, 40);
            this.lbl_ac_Titre.TabIndex = 0;
            this.lbl_ac_Titre.Text = "AGENCE de MENTA";
            // 
            // tabConsultation
            // 
            this.tabConsultation.Controls.Add(this.tbx_co_SoldeActuel);
            this.tabConsultation.Controls.Add(this.tbx_co_Titulaire);
            this.tabConsultation.Controls.Add(this.tbx_co_Numero);
            this.tabConsultation.Controls.Add(this.cbx_co_ChoixCompte);
            this.tabConsultation.Controls.Add(this.label8);
            this.tabConsultation.Controls.Add(this.label9);
            this.tabConsultation.Controls.Add(this.label7);
            this.tabConsultation.Controls.Add(this.label5);
            this.tabConsultation.Controls.Add(this.label2);
            this.tabConsultation.Location = new System.Drawing.Point(4, 24);
            this.tabConsultation.Name = "tabConsultation";
            this.tabConsultation.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultation.Size = new System.Drawing.Size(792, 422);
            this.tabConsultation.TabIndex = 1;
            this.tabConsultation.Text = "Consultation";
            this.tabConsultation.UseVisualStyleBackColor = true;
            this.tabConsultation.Enter += new System.EventHandler(this.tabConsultation_Enter);
            // 
            // tbx_co_SoldeActuel
            // 
            this.tbx_co_SoldeActuel.Location = new System.Drawing.Point(313, 260);
            this.tbx_co_SoldeActuel.Name = "tbx_co_SoldeActuel";
            this.tbx_co_SoldeActuel.Size = new System.Drawing.Size(160, 23);
            this.tbx_co_SoldeActuel.TabIndex = 8;
            // 
            // tbx_co_Titulaire
            // 
            this.tbx_co_Titulaire.Location = new System.Drawing.Point(313, 229);
            this.tbx_co_Titulaire.Name = "tbx_co_Titulaire";
            this.tbx_co_Titulaire.Size = new System.Drawing.Size(438, 23);
            this.tbx_co_Titulaire.TabIndex = 7;
            // 
            // tbx_co_Numero
            // 
            this.tbx_co_Numero.Location = new System.Drawing.Point(313, 198);
            this.tbx_co_Numero.Name = "tbx_co_Numero";
            this.tbx_co_Numero.Size = new System.Drawing.Size(160, 23);
            this.tbx_co_Numero.TabIndex = 6;
            // 
            // cbx_co_ChoixCompte
            // 
            this.cbx_co_ChoixCompte.FormattingEnabled = true;
            this.cbx_co_ChoixCompte.Location = new System.Drawing.Point(313, 98);
            this.cbx_co_ChoixCompte.Name = "cbx_co_ChoixCompte";
            this.cbx_co_ChoixCompte.Size = new System.Drawing.Size(287, 23);
            this.cbx_co_ChoixCompte.TabIndex = 5;
            this.cbx_co_ChoixCompte.SelectedIndexChanged += new System.EventHandler(this.cbb_co_ChoixCompte_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(111, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Titulaire du compte";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(111, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Solde actuel du compte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(109, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Numéro du compte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(109, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Choisir un compte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(244, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "CONSULTATION DE COMPTE";
            // 
            // tabCreation
            // 
            this.tabCreation.Controls.Add(this.btn_cr_Annuler);
            this.tabCreation.Controls.Add(this.btn_Creer);
            this.tabCreation.Controls.Add(this.label12);
            this.tabCreation.Controls.Add(this.tbx_cr_SoldeInitial);
            this.tabCreation.Controls.Add(this.tbx_cr_Titulaire);
            this.tabCreation.Controls.Add(this.tbx_cr_Numero);
            this.tabCreation.Controls.Add(this.lbl_cr_Message);
            this.tabCreation.Controls.Add(this.label10);
            this.tabCreation.Controls.Add(this.label6);
            this.tabCreation.Controls.Add(this.label4);
            this.tabCreation.Controls.Add(this.label3);
            this.tabCreation.Location = new System.Drawing.Point(4, 24);
            this.tabCreation.Name = "tabCreation";
            this.tabCreation.Size = new System.Drawing.Size(792, 422);
            this.tabCreation.TabIndex = 2;
            this.tabCreation.Text = "Creation";
            this.tabCreation.UseVisualStyleBackColor = true;
            // 
            // btn_cr_Annuler
            // 
            this.btn_cr_Annuler.Location = new System.Drawing.Point(709, 301);
            this.btn_cr_Annuler.Name = "btn_cr_Annuler";
            this.btn_cr_Annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_cr_Annuler.TabIndex = 10;
            this.btn_cr_Annuler.Text = "Annuler";
            this.btn_cr_Annuler.UseVisualStyleBackColor = true;
            // 
            // btn_Creer
            // 
            this.btn_Creer.Location = new System.Drawing.Point(709, 228);
            this.btn_Creer.Name = "btn_Creer";
            this.btn_Creer.Size = new System.Drawing.Size(75, 23);
            this.btn_Creer.TabIndex = 9;
            this.btn_Creer.Text = "Créer";
            this.btn_Creer.UseVisualStyleBackColor = true;
            this.btn_Creer.Click += new System.EventHandler(this.btn_Creer_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(494, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 21);
            this.label12.TabIndex = 8;
            this.label12.Text = "C#";
            // 
            // tbx_cr_SoldeInitial
            // 
            this.tbx_cr_SoldeInitial.Location = new System.Drawing.Point(278, 225);
            this.tbx_cr_SoldeInitial.Name = "tbx_cr_SoldeInitial";
            this.tbx_cr_SoldeInitial.Size = new System.Drawing.Size(199, 23);
            this.tbx_cr_SoldeInitial.TabIndex = 7;
            // 
            // tbx_cr_Titulaire
            // 
            this.tbx_cr_Titulaire.Location = new System.Drawing.Point(278, 189);
            this.tbx_cr_Titulaire.Name = "tbx_cr_Titulaire";
            this.tbx_cr_Titulaire.Size = new System.Drawing.Size(420, 23);
            this.tbx_cr_Titulaire.TabIndex = 6;
            // 
            // tbx_cr_Numero
            // 
            this.tbx_cr_Numero.Location = new System.Drawing.Point(278, 159);
            this.tbx_cr_Numero.Name = "tbx_cr_Numero";
            this.tbx_cr_Numero.Size = new System.Drawing.Size(199, 23);
            this.tbx_cr_Numero.TabIndex = 5;
            // 
            // lbl_cr_Message
            // 
            this.lbl_cr_Message.AutoSize = true;
            this.lbl_cr_Message.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cr_Message.ForeColor = System.Drawing.Color.Red;
            this.lbl_cr_Message.Location = new System.Drawing.Point(75, 303);
            this.lbl_cr_Message.Name = "lbl_cr_Message";
            this.lbl_cr_Message.Size = new System.Drawing.Size(272, 21);
            this.lbl_cr_Message.TabIndex = 4;
            this.lbl_cr_Message.Text = "Valeur incorrecte pour le solde initial !";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(75, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 21);
            this.label10.TabIndex = 3;
            this.label10.Text = "Solde initial du Compte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(75, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Titulaire du comtpe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(75, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Numéro du Compte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(233, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "CREATION D\'UN COMPTE";
            // 
            // tabVersement
            // 
            this.tabVersement.Controls.Add(this.lbl_ve_Message);
            this.tabVersement.Controls.Add(this.btn_ve_Annuler);
            this.tabVersement.Controls.Add(this.btn_ve_Enregistrer);
            this.tabVersement.Controls.Add(this.tbx_ve_Montant_A_Crediter);
            this.tabVersement.Controls.Add(this.cbb_ve_ChoixCompte);
            this.tabVersement.Controls.Add(this.label14);
            this.tabVersement.Controls.Add(this.label13);
            this.tabVersement.Controls.Add(this.label11);
            this.tabVersement.Location = new System.Drawing.Point(4, 24);
            this.tabVersement.Name = "tabVersement";
            this.tabVersement.Size = new System.Drawing.Size(792, 422);
            this.tabVersement.TabIndex = 3;
            this.tabVersement.Text = "Versement";
            this.tabVersement.UseVisualStyleBackColor = true;
            this.tabVersement.Enter += new System.EventHandler(this.tabVersement_Enter);
            // 
            // lbl_ve_Message
            // 
            this.lbl_ve_Message.AutoSize = true;
            this.lbl_ve_Message.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ve_Message.Location = new System.Drawing.Point(45, 324);
            this.lbl_ve_Message.Name = "lbl_ve_Message";
            this.lbl_ve_Message.Size = new System.Drawing.Size(61, 21);
            this.lbl_ve_Message.TabIndex = 9;
            this.lbl_ve_Message.Text = "label15";
            // 
            // btn_ve_Annuler
            // 
            this.btn_ve_Annuler.Location = new System.Drawing.Point(651, 222);
            this.btn_ve_Annuler.Name = "btn_ve_Annuler";
            this.btn_ve_Annuler.Size = new System.Drawing.Size(102, 23);
            this.btn_ve_Annuler.TabIndex = 7;
            this.btn_ve_Annuler.Text = "Annuler";
            this.btn_ve_Annuler.UseVisualStyleBackColor = true;
            // 
            // btn_ve_Enregistrer
            // 
            this.btn_ve_Enregistrer.Location = new System.Drawing.Point(651, 170);
            this.btn_ve_Enregistrer.Name = "btn_ve_Enregistrer";
            this.btn_ve_Enregistrer.Size = new System.Drawing.Size(102, 23);
            this.btn_ve_Enregistrer.TabIndex = 6;
            this.btn_ve_Enregistrer.Text = "Enregistrement";
            this.btn_ve_Enregistrer.UseVisualStyleBackColor = true;
            this.btn_ve_Enregistrer.Click += new System.EventHandler(this.btn_ve_Enregistrer_Click);
            // 
            // tbx_ve_Montant_A_Crediter
            // 
            this.tbx_ve_Montant_A_Crediter.Location = new System.Drawing.Point(293, 194);
            this.tbx_ve_Montant_A_Crediter.Name = "tbx_ve_Montant_A_Crediter";
            this.tbx_ve_Montant_A_Crediter.Size = new System.Drawing.Size(180, 23);
            this.tbx_ve_Montant_A_Crediter.TabIndex = 5;
            // 
            // cbb_ve_ChoixCompte
            // 
            this.cbb_ve_ChoixCompte.FormattingEnabled = true;
            this.cbb_ve_ChoixCompte.Location = new System.Drawing.Point(293, 122);
            this.cbb_ve_ChoixCompte.Name = "cbb_ve_ChoixCompte";
            this.cbb_ve_ChoixCompte.Size = new System.Drawing.Size(294, 23);
            this.cbb_ve_ChoixCompte.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(45, 194);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 21);
            this.label14.TabIndex = 3;
            this.label14.Text = "Montant à créditer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(45, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(206, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Choisir un compte à créditer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(150, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(508, 41);
            this.label11.TabIndex = 1;
            this.label11.Text = "ENREGISTREMENT d\'un VERSEMENT ";
            // 
            // tabRetrait
            // 
            this.tabRetrait.Controls.Add(this.btn_re_Annuler);
            this.tabRetrait.Controls.Add(this.btn_re_Enregistrer);
            this.tabRetrait.Controls.Add(this.tbx_re_Montant_A_Retrait);
            this.tabRetrait.Controls.Add(this.cbb_re_ChoixCompte);
            this.tabRetrait.Controls.Add(this.label17);
            this.tabRetrait.Controls.Add(this.label16);
            this.tabRetrait.Controls.Add(this.label15);
            this.tabRetrait.Location = new System.Drawing.Point(4, 24);
            this.tabRetrait.Name = "tabRetrait";
            this.tabRetrait.Size = new System.Drawing.Size(792, 422);
            this.tabRetrait.TabIndex = 4;
            this.tabRetrait.Text = "Retrait";
            this.tabRetrait.UseVisualStyleBackColor = true;
            this.tabRetrait.Enter += new System.EventHandler(this.tabRetrait_Enter);
            // 
            // btn_re_Annuler
            // 
            this.btn_re_Annuler.BackColor = System.Drawing.Color.Red;
            this.btn_re_Annuler.Location = new System.Drawing.Point(618, 298);
            this.btn_re_Annuler.Name = "btn_re_Annuler";
            this.btn_re_Annuler.Size = new System.Drawing.Size(102, 31);
            this.btn_re_Annuler.TabIndex = 7;
            this.btn_re_Annuler.Text = "Annuler";
            this.btn_re_Annuler.UseVisualStyleBackColor = false;
            this.btn_re_Annuler.Click += new System.EventHandler(this.btn_re_Annuler_Click);
            // 
            // btn_re_Enregistrer
            // 
            this.btn_re_Enregistrer.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_re_Enregistrer.Location = new System.Drawing.Point(618, 232);
            this.btn_re_Enregistrer.Name = "btn_re_Enregistrer";
            this.btn_re_Enregistrer.Size = new System.Drawing.Size(102, 31);
            this.btn_re_Enregistrer.TabIndex = 6;
            this.btn_re_Enregistrer.Text = "enregistrement";
            this.btn_re_Enregistrer.UseVisualStyleBackColor = false;
            this.btn_re_Enregistrer.Click += new System.EventHandler(this.btn_re_Enregistrer_Click);
            // 
            // tbx_re_Montant_A_Retrait
            // 
            this.tbx_re_Montant_A_Retrait.Location = new System.Drawing.Point(243, 172);
            this.tbx_re_Montant_A_Retrait.Name = "tbx_re_Montant_A_Retrait";
            this.tbx_re_Montant_A_Retrait.Size = new System.Drawing.Size(250, 23);
            this.tbx_re_Montant_A_Retrait.TabIndex = 5;
            // 
            // cbb_re_ChoixCompte
            // 
            this.cbb_re_ChoixCompte.FormattingEnabled = true;
            this.cbb_re_ChoixCompte.Location = new System.Drawing.Point(243, 120);
            this.cbb_re_ChoixCompte.Name = "cbb_re_ChoixCompte";
            this.cbb_re_ChoixCompte.Size = new System.Drawing.Size(336, 23);
            this.cbb_re_ChoixCompte.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label17.Location = new System.Drawing.Point(85, 174);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 21);
            this.label17.TabIndex = 2;
            this.label17.Text = "Montant à débiter";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(85, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 21);
            this.label16.TabIndex = 1;
            this.label16.Text = "Choisir un compte";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(172, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(447, 41);
            this.label15.TabIndex = 0;
            this.label15.Text = "ENREGISTREMENT d\'un RETRAIT";
            // 
            // tabVirement
            // 
            this.tabVirement.Controls.Add(this.lbl_vii_Message);
            this.tabVirement.Controls.Add(this.btn_vi_Annuler);
            this.tabVirement.Controls.Add(this.btn_vi_Enregistrer);
            this.tabVirement.Controls.Add(this.label22);
            this.tabVirement.Controls.Add(this.tbx_re_Montant_A_Virement);
            this.tabVirement.Controls.Add(this.cbb_vi_ChoixCompteCredit);
            this.tabVirement.Controls.Add(this.cbb_vi_ChoixCompteDebit);
            this.tabVirement.Controls.Add(this.label21);
            this.tabVirement.Controls.Add(this.label20);
            this.tabVirement.Controls.Add(this.label19);
            this.tabVirement.Controls.Add(this.lbl_re_Message);
            this.tabVirement.Location = new System.Drawing.Point(4, 24);
            this.tabVirement.Name = "tabVirement";
            this.tabVirement.Size = new System.Drawing.Size(792, 422);
            this.tabVirement.TabIndex = 5;
            this.tabVirement.Text = "Virement";
            this.tabVirement.UseVisualStyleBackColor = true;
            this.tabVirement.Enter += new System.EventHandler(this.tabVirement_Enter);
            // 
            // lbl_vii_Message
            // 
            this.lbl_vii_Message.AutoSize = true;
            this.lbl_vii_Message.Location = new System.Drawing.Point(23, 245);
            this.lbl_vii_Message.Name = "lbl_vii_Message";
            this.lbl_vii_Message.Size = new System.Drawing.Size(44, 15);
            this.lbl_vii_Message.TabIndex = 11;
            this.lbl_vii_Message.Text = "label18";
            // 
            // btn_vi_Annuler
            // 
            this.btn_vi_Annuler.BackColor = System.Drawing.Color.Red;
            this.btn_vi_Annuler.Location = new System.Drawing.Point(648, 287);
            this.btn_vi_Annuler.Name = "btn_vi_Annuler";
            this.btn_vi_Annuler.Size = new System.Drawing.Size(111, 24);
            this.btn_vi_Annuler.TabIndex = 10;
            this.btn_vi_Annuler.Text = "Annuler";
            this.btn_vi_Annuler.UseVisualStyleBackColor = false;
            // 
            // btn_vi_Enregistrer
            // 
            this.btn_vi_Enregistrer.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_vi_Enregistrer.Location = new System.Drawing.Point(648, 237);
            this.btn_vi_Enregistrer.Name = "btn_vi_Enregistrer";
            this.btn_vi_Enregistrer.Size = new System.Drawing.Size(111, 24);
            this.btn_vi_Enregistrer.TabIndex = 9;
            this.btn_vi_Enregistrer.Text = "Enregistrer";
            this.btn_vi_Enregistrer.UseVisualStyleBackColor = false;
            this.btn_vi_Enregistrer.Click += new System.EventHandler(this.btn_vi_Enregistrer_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label22.Location = new System.Drawing.Point(510, 201);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 21);
            this.label22.TabIndex = 7;
            this.label22.Text = "C#";
            // 
            // tbx_re_Montant_A_Virement
            // 
            this.tbx_re_Montant_A_Virement.Location = new System.Drawing.Point(291, 198);
            this.tbx_re_Montant_A_Virement.Name = "tbx_re_Montant_A_Virement";
            this.tbx_re_Montant_A_Virement.Size = new System.Drawing.Size(197, 23);
            this.tbx_re_Montant_A_Virement.TabIndex = 6;
            // 
            // cbb_vi_ChoixCompteCredit
            // 
            this.cbb_vi_ChoixCompteCredit.FormattingEnabled = true;
            this.cbb_vi_ChoixCompteCredit.Location = new System.Drawing.Point(291, 155);
            this.cbb_vi_ChoixCompteCredit.Name = "cbb_vi_ChoixCompteCredit";
            this.cbb_vi_ChoixCompteCredit.Size = new System.Drawing.Size(326, 23);
            this.cbb_vi_ChoixCompteCredit.TabIndex = 5;
            // 
            // cbb_vi_ChoixCompteDebit
            // 
            this.cbb_vi_ChoixCompteDebit.FormattingEnabled = true;
            this.cbb_vi_ChoixCompteDebit.Location = new System.Drawing.Point(291, 116);
            this.cbb_vi_ChoixCompteDebit.Name = "cbb_vi_ChoixCompteDebit";
            this.cbb_vi_ChoixCompteDebit.Size = new System.Drawing.Size(326, 23);
            this.cbb_vi_ChoixCompteDebit.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label21.Location = new System.Drawing.Point(23, 201);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(157, 21);
            this.label21.TabIndex = 3;
            this.label21.Text = "Montant du virement";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label20.Location = new System.Drawing.Point(23, 157);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(206, 21);
            this.label20.TabIndex = 2;
            this.label20.Text = "Choisir un compte à créditer";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label19.Location = new System.Drawing.Point(23, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(196, 21);
            this.label19.TabIndex = 1;
            this.label19.Text = "Choisir le compte à débiter";
            // 
            // lbl_re_Message
            // 
            this.lbl_re_Message.AutoSize = true;
            this.lbl_re_Message.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_re_Message.ForeColor = System.Drawing.Color.Red;
            this.lbl_re_Message.Location = new System.Drawing.Point(85, 242);
            this.lbl_re_Message.Name = "lbl_re_Message";
            this.lbl_re_Message.Size = new System.Drawing.Size(0, 21);
            this.lbl_re_Message.TabIndex = 3;
            // 
            // lbl_vi_Message
            // 
            this.lbl_vi_Message.Location = new System.Drawing.Point(0, 0);
            this.lbl_vi_Message.Name = "lbl_vi_Message";
            this.lbl_vi_Message.Size = new System.Drawing.Size(100, 23);
            this.lbl_vi_Message.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(792, 422);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "à Propos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label18.Location = new System.Drawing.Point(327, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(139, 41);
            this.label18.TabIndex = 0;
            this.label18.Text = "A Propos";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label23.Location = new System.Drawing.Point(88, 124);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 28);
            this.label23.TabIndex = 1;
            this.label23.Text = "Créateur : ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label24.Location = new System.Drawing.Point(88, 177);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 28);
            this.label24.TabIndex = 2;
            this.label24.Text = "Classe :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label25.Location = new System.Drawing.Point(88, 299);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(168, 28);
            this.label25.TabIndex = 3;
            this.label25.Text = "Date de Création :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label26.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label26.Location = new System.Drawing.Point(88, 241);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(61, 28);
            this.label26.TabIndex = 4;
            this.label26.Text = "Age : ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(343, 136);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(202, 28);
            this.label27.TabIndex = 5;
            this.label27.Text = "Teddy CLEMENT DELS";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label28.Location = new System.Drawing.Point(343, 189);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(90, 28);
            this.label28.TabIndex = 6;
            this.label28.Text = "BTS SIO2";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label29.Location = new System.Drawing.Point(343, 299);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(116, 28);
            this.label29.TabIndex = 7;
            this.label29.Text = "02/03/2022";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label30.Location = new System.Drawing.Point(343, 241);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(68, 28);
            this.label30.TabIndex = 8;
            this.label30.Text = "19 ans";
            // 
            // FrmBanque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmBanque";
            this.Text = "Application Banqueroute";
            this.tabControl1.ResumeLayout(false);
            this.tabAcceuil.ResumeLayout(false);
            this.tabAcceuil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeComptes)).EndInit();
            this.tabConsultation.ResumeLayout(false);
            this.tabConsultation.PerformLayout();
            this.tabCreation.ResumeLayout(false);
            this.tabCreation.PerformLayout();
            this.tabVersement.ResumeLayout(false);
            this.tabVersement.PerformLayout();
            this.tabRetrait.ResumeLayout(false);
            this.tabRetrait.PerformLayout();
            this.tabVirement.ResumeLayout(false);
            this.tabVirement.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAcceuil;
        private System.Windows.Forms.TabPage tabConsultation;
        private System.Windows.Forms.TabPage tabCreation;
        private System.Windows.Forms.TabPage tabVersement;
        private System.Windows.Forms.TabPage tabRetrait;
        private System.Windows.Forms.TabPage tabVirement;
        private Label label1;
        private Label lbl_ac_Titre;
        private DataGridView dgv_ListeComptes;
        private Label label2;
        private Label label8;
        private Label label9;
        private Label label7;
        private Label label5;
        private ComboBox cbx_co_ChoixCompte;
        private TextBox tbx_co_SoldeActuel;
        private TextBox tbx_co_Titulaire;
        private TextBox tbx_co_Numero;
        private TextBox tbx_cr_SoldeInitial;
        private TextBox tbx_cr_Titulaire;
        private TextBox tbx_cr_Numero;
        private Label lbl_cr_Message;
        private Label label10;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label12;
        private Button btn_cr_Annuler;
        private Button btn_Creer;
        private TextBox tbx_ve_Montant_A_Crediter;
        private ComboBox cbb_ve_ChoixCompte;
        private Label label14;
        private Label label13;
        private Label label11;
        private Button btn_ve_Annuler;
        private Button btn_ve_Enregistrer;
        private Label lbl_ve_Message;
        private Button btn_re_Annuler;
        private Button btn_re_Enregistrer;
        private TextBox tbx_re_Montant_A_Retrait;
        private ComboBox cbb_re_ChoixCompte;
        private Label lbl_re_Message;
        private Label label17;
        private Label label16;
        private Label label15;
        private Button btn_vi_Annuler;
        private Button btn_vi_Enregistrer;
        private Label label22;
        private TextBox tbx_re_Montant_A_Virement;
        private ComboBox cbb_vi_ChoixCompteCredit;
        private ComboBox cbb_vi_ChoixCompteDebit;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label lbl_vi_Message;
        private Label lbl_vii_Message;
        private TabPage tabPage1;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label18;
    }
}


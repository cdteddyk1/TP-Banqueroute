using libBanque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindoBanque
{
    public partial class FrmBanque : Form
    {
        // Variables globales au formulaire = Propriétés du formulaire
        private AgenceBancaire MonAgence;
        public FrmBanque()
        {
            InitializeComponent();
            InitialiserLaBanque();
        }

        private void InitialiserLaBanque()
        {
            // Instanciation de l'objet MonAgence, en passannt en paramètre le nom de l'agence
            MonAgence = new AgenceBancaire("MENTA");
            //Modification du titre de l'onglet
            lbl_ac_Titre.Text = "AGENCE de " + MonAgence.NomAgence;

            // Appel d'un sous-programme générant le jeu d'essai, autrement dit créant les comptes de l'angence
            GenererJeuDessai();
            // Appel d'un sous-programme remplissant le DataGridView avec la liste des comptes de l'agence 
            RemplirListeComptes();
        }

        private void GenererJeuDessai()
        {
            CompteBancaire cbPatrick = new CompteBancaire("0211651079JP", "M. JANE Patrick");
            CompteBancaire cbTeresa = new CompteBancaire("1231212312LT", "Mle LISBON Teresa", 1500.00m);
            CompteBancaire cbCho = new CompteBancaire("9173826431KC", "M. KIMBALL Cho");

            MonAgence.AjouterCompte(cbPatrick);
            MonAgence.AjouterCompte(cbTeresa);
            MonAgence.AjouterCompte(cbCho);
        }

        private void RemplirListeComptes()
        {
            // Pour forcer le rafraichissement en cas de retour sur l'onglet d'accueil
            // on change le DataSourcce du DataGridView en commençannt par dire de DataSource
            dgv_ListeComptes.DataSource = null;
            // On indique tout simplement que la soruce de données de la DataGridView est une collection
            // -> La DataGridView contiendra autant de lignes que la collection contient d'objects 
            // -> La DataGridView contiendra autant de colonnes que le type d'objet contient de property
            dgv_ListeComptes.DataSource = MonAgence.LesComptes;
            // On peut éventuelllement adapter la moise en forme, ici en redimentionnant automatiquement
            // la largeur des colonnes
            // dgv_ListeComptes.AutoResizeColumns();
        }

        private void tabConsultation_Enter(object sender, EventArgs e)
        {
            RemplirCombobox(cbx_co_ChoixCompte);
        }

        private void RemplirCombobox(ComboBox laCombo)
        {
            // Supprimer le contenu actuel éventuel de la combobox
            laCombo.Items.Clear();
            // Remplir la combobox à l'aide de la structure itérative foreach
            // -> cette structure permet de parcourir facilement une collection
            // -> un foreach suivi d'une doouble tabulation génère automatiquement le squelette de la structure
            // POUR CHAQUE objet de type CompteBancaire, que nous appellerons "unCompte
            // DANS la collection MonAgence.LesComptes ...
            foreach (CompteBancaire unCompte in MonAgence.LesComptes)
            {
                // ... Ajouter le numéro du compte suivi du titulaire dans les items de la combobox
                laCombo.Items.Add(unCompte.NumCompte + " (" + unCompte.NomTitulaire + " )");
                // NB : Items est une propriété de la combobox certes, mais c'est aussi une collection
                //      En fait une collection d'items (ou lignes)
            }
        }
        // Choix d'un compte dans l'onglet de Consultation
        private void cbb_co_ChoixCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            //On récupère l'indice ( ou index ) du comtpe sélectionné 
            int iCompte = cbx_co_ChoixCompte.SelectedIndex;
            CompteBancaire leCompte; // Déclaration d'un objet CompteBancaire

            if (iCompte >= 0) // Si on a bien sélectionné un Compte
            {
                // On récupére dans la collection lesComptes de MonAgence le compte qui noous intéresse,
                // lequel compte est situé dans la collection à l'indice iCompte
                leCompte = MonAgence.LesComptes.ElementAt(iCompte);
                // Une fois l'object CompteBancaire qui nous intéresse récupéré,
                // on affiche la valeur de ses propriétés dans les TextBox
                tbx_co_Numero.Text = leCompte.NumCompte.ToString();
                tbx_co_Titulaire.Text = leCompte.NomTitulaire;
                tbx_co_SoldeActuel.Text = leCompte.SoldeCompte.ToString();
            }
        }

        private void btn_Creer_Click(object sender, EventArgs e)
        {
            // Récupération des valeurs des textbox
            string numero = tbx_cr_Numero.Text;
            string titulaire = tbx_cr_Titulaire.Text;
            string soldesString = tbx_cr_SoldeInitial.Text;
            decimal SoldeDecimal;
            if (Decimal.TryParse(soldesString, out SoldeDecimal)) // Si la conversion est possible ...
            {
                // ... je peux utiliser le paramètre en sortie soldeDecimal qui est un decimal
                CompteBancaire cb = new CompteBancaire(numero, titulaire, SoldeDecimal);
                // On ajoute ce nouveau compte à l'agence
                MonAgence.AjouterCompte(cb);
                //J'affiche un message de confirmation
                lbl_cr_Message.Text = "Le compte de " + titulaire + " a bien été créé !";
                lbl_cr_Message.ForeColor = Color.Green;
            }
            else
            {
                // J'affiche un message d'erreur
                lbl_cr_Message.Text = "Valeur incorrecte pour le solde initial !";
                lbl_cr_Message.ForeColor = Color.Red;
            }
        }

        private void tabAcceuil_Enter(object sender, EventArgs e)
        {
            // Appel d'un sosu-programme remplissant le DataGridView avec la liste des comptes de l'agence
            RemplirListeComptes();
        }

        private decimal RecupererMontant(TextBox leTextBox)
        {
            decimal montant;

            try // On essaie la conversion ...
            {
                montant = decimal.Parse(leTextBox.Text);
            }
            catch // ... Si elle ne fonctionne pas on affecte -1 comme valeur erronée
            {
                montant = -1.0m;
            }
            //Retour de la valeur
            return (montant);
        }

        private void btn_ve_Enregistrer_Click(object sender, EventArgs e)
        {
            string message = "Le versement a bien été enregistré !"; // On part du principe que c'est OK
            int iCompte = cbb_ve_ChoixCompte.SelectedIndex;
            CompteBancaire leCompte;
            // On récupère le montant en vérifiant qu'il est correct
            decimal montant = RecupererMontant(tbx_ve_Montant_A_Crediter);

            // On verifie d'abord si un compte a bien été sélectionné
            if (iCompte >= 0)
            {
                // Si le montant est positif
                if (montant > 0)
                {
                    // On tente d'effectuer le versement
                    leCompte = MonAgence.LesComptes.ElementAt(iCompte);

                    if (!leCompte.CrediterCompte(montant)) //Si l'opération de crédit s'est mal passée
                        // On signale une erreur
                        message = " Le virement n'a pu s'effectuer pour cause de montant incorrect."; // montant < 0
                    //Rappel : on sait que CrediterCompte renvoie faux si le montant est négatif ce qui ne devrait
                    // pas se produire puisqu'on l'a testé avant. Mieux vaut deux protections qu'une seule !

                }
            }
            else

            {
                message = "Le virement n'a pas pu être effectué parce que voous n'avez pas sélectionné le compte à créditer !";
            }
            // On affiche le résultat
            lbl_ve_Message.Text = message;
            if (message == "Le versement a bien été enregistré !")
                lbl_ve_Message.ForeColor = Color.Green;
            else
                lbl_ve_Message.ForeColor = Color.Red;
        }
        private void tabVersement_Enter(object sender, EventArgs e)
        {
            RemplirCombobox(cbb_ve_ChoixCompte);
        }
        private void btn_re_Enregistrer_Click(object sender, EventArgs e)
        {
            string message = "Le Retrait a bien été enregistré !"; // On part du principe que c'est OK
            int iCompte = cbb_re_ChoixCompte.SelectedIndex;
            CompteBancaire leCompte;
            // On récupère le montant en vérifiant qu'il est correct
            decimal montant = RecupererMontant(tbx_re_Montant_A_Retrait);

            // On verifie d'abord si un compte a bien été sélectionné
            if (iCompte >= 0)
            {
                // Si le montant est positif
                if (montant > 0)
                {
                    // On tente d'effectuer le versement
                    leCompte = MonAgence.LesComptes.ElementAt(iCompte);

                    if (!leCompte.DebiterCompte(montant)) //Si l'opération de crédit s'est mal passée
                        // On signale une erreur
                        message = " Le virement n'a pu s'effectuer pour cause de montant incorrect."; // montant < 0
                    //Rappel : on sait que CrediterCompte renvoie faux si le montant est négatif ce qui ne devrait
                    // pas se produire puisqu'on l'a testé avant. Mieux vaut deux protections qu'une seule !

                }
            }
            else

            {
                message = "Le retrait n'a pas pu s'effectuer sous cause de solde insufisant";
            }
            // On affiche le résultat
            lbl_re_Message.Text = message;
            if (message == "Le Retrait a bien été enregistré !")
                lbl_re_Message.ForeColor = Color.Green;
            else
                lbl_re_Message.ForeColor = Color.Red;
        }

        private void tabRetrait_Enter(object sender, EventArgs e)
        {
            RemplirCombobox(cbb_re_ChoixCompte);
        }

        private void btn_re_Annuler_Click(object sender, EventArgs e)
        {

        }

        private void btn_vi_Enregistrer_Click(object sender, EventArgs e)
        {
            string message = "Le versement a bien été enregistré !"; // On part du principe que c'est OK
            int iCompte1 = cbb_vi_ChoixCompteDebit.SelectedIndex;
            int iCompte2 = cbb_vi_ChoixCompteCredit.SelectedIndex;
            CompteBancaire leCompte;
            // On récupère le montant en vérifiant qu'il est correct
            decimal montant = RecupererMontant(tbx_re_Montant_A_Virement);

            // On verifie d'abord si un compte a bien été sélectionné
            if (iCompte1>= 0)
            {
                // Si le montant est positif
                if (montant > 0)
                {
                    // On tente d'effectuer le versement
                    leCompte = MonAgence.LesComptes.ElementAt(iCompte2);

                    if (!leCompte.CrediterCompte(montant)) //Si l'opération de crédit s'est mal passée
                        // On signale une erreur
                        message = " Le virement n'a pu s'effectuer pour cause de montant incorrect."; // montant < 0
                                                                                                      //Rappel : on sait que CrediterCompte renvoie faux si le montant est négatif ce qui ne devrait
                                                                                                      // pas se produire puisqu'on l'a testé avant. Mieux vaut deux protections qu'une seule !
                    leCompte = MonAgence.LesComptes.ElementAt(iCompte1);

                    if (!leCompte.DebiterCompte(montant)) //Si l'opération de crédit s'est mal passée
                        // On signale une erreur
                        message = " Le virement n'a pu s'effectuer pour cause de montant incorrect.";
                    // On tente d'effectuer le versement
                    // montant < 0
                    //Rappel : on sait que CrediterCompte renvoie faux si le montant est négatif ce qui ne devrait
                    // pas se produire puisqu'on l'a testé avant. Mieux vaut deux protections qu'une seule !

                }



            }
            else

            {
                message = "Le virement n'a pas pu être effectué parce que voous n'avez pas sélectionné le compte à créditer !";
            }
            // On affiche le résultat
            lbl_vii_Message.Text = message;
            if (message == "Le versement a bien été enregistré !")
                lbl_vii_Message.ForeColor = Color.Green;
            else
                lbl_vii_Message.ForeColor = Color.Red;
        }

        private void tabVirement_Enter(object sender, EventArgs e)
        {
            RemplirCombobox(cbb_vi_ChoixCompteDebit);
            RemplirCombobox(cbb_vi_ChoixCompteCredit);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

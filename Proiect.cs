using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.clase;


namespace WindowsFormsApp1
{
    public partial class FrmProiect : Form
    {
        public FrmProiect()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            lblAfisarea.BackColor = Color.LightBlue;
            lblAfisarea.ForeColor = Color.Black;
            lblAfisarea.Text = "Salavare cu succes";
            lblAfisarea.Visible = true;
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {

            string nume = txtNume.Text;
            string prenume = txtPrenume.Text;
            string scor = txtScor.Text;

            Validare validare = new Validare();

            if( validare.ValidareNume(nume) == true )
            {
                MessageBox.Show("eroare nume");
            }

            if (validare.ValidarePrenume(prenume) == true)
            {
                MessageBox.Show("eroare prenume");
            }

            if (validare.ScorValid(scor) == true)
            {
                MessageBox.Show("eroare scor");
            }

            Persoana persoana = new Persoana( nume , prenume , scor );

            Administrare administrare = new Administrare();
            administrare.Adaugare(persoana);

            txtNume.Clear();
            txtPrenume.Clear();
            txtScor.Clear();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Administrare adm = new Administrare();
            List<Persoana> lista = adm.GetPersoane();

            string t = string.Empty;

            foreach(Persoana persoana in lista)
            {
                t += persoana.PersoanaToString();
                t += "\n";
            }

            MessageBox.Show(t);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administrare adm = new Administrare();
            Persoana p = adm.PersoanaCelMaiMareScor();

            MessageBox.Show(p.PersoanaToString());
        }
    }
}

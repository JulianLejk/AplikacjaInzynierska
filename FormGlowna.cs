using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaInzynierska
{
    public partial class FormGlowna : Form
    {
        SqlDataAdapter sqladapter;
        SqlConnection sqlcon;
        DataSet dataset;
        public string stringdozadania;

        public FormGlowna()
        {
            InitializeComponent();
           
        }

        private void butFGlownaDodajZLecenie_Click(object sender, EventArgs e)
        {
            FormDodajZlecenie fdz = new FormDodajZlecenie();
            fdz.ShowDialog();
        }

        private void butFGlownaPokazZadania_Click(object sender, EventArgs e)
        {
            stringdozadania = Convert.ToString(dataZlecenia.CurrentCell.Value);
            MessageBox.Show(stringdozadania);
            FormPokazZadania fpz = new FormPokazZadania();
            fpz.ShowDialog();

        }

        private void butFGlownaDodajPrzedmiot_Click(object sender, EventArgs e)
        {
            FormDodajPrzedmiot fdp = new FormDodajPrzedmiot();
            fdp.ShowDialog();
        }

        private void buttonFGDodajKontrahenta_Click(object sender, EventArgs e)
        {
            FormDodajKontrahenta fdk = new FormDodajKontrahenta();
            fdk.ShowDialog();
        }

        private void buttonFGDodajZleceniodawce_Click(object sender, EventArgs e)
        {
            FormDodajZleceniodawce fdz = new FormDodajZleceniodawce();
            fdz.ShowDialog();
        }

        private void buttonFGDodajPracownika_Click(object sender, EventArgs e)
        {
            FormDodajPracownika fdp = new FormDodajPracownika();
            fdp.ShowDialog();
            
        }

        private void FormGlowna_Load(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection();
            sqlcon.ConnectionString = @"Data Source = KOMPJULIANA\SQLEXPRESS; Initial Catalog = DatadoINZ; Integrated Security = True";
            sqlcon.Open();
            sqladapter = new SqlDataAdapter("Select Nazwa_Zlecenia as [Nazwa Zlecenia],NazwaFirmy as [Nazwa Firmy],Imie_Pracownika as [Osoba odpowiedzialna] ,Data_Rozpoczecia as [Data Rozpoczęcia],Data_Zakonczenia as [Data Zakończenia] from Zlecenie join Kontrahent_Zleceniodawca On Kontrahent_Zleceniodawca.ID_KZ = Zlecenie.ID_KZ join Pracownik on Pracownik.ID_Pracownika = Zlecenie.ID_Pracownika", sqlcon);
            sqlcon.Close();
            dataset = new DataSet();
            sqladapter.Fill(dataset);
            dataZlecenia.DataSource = dataset.Tables[0];

            // TODO: This line of code loads data into the 'datadoINZDataSet.Zlecenie' table. You can move, or remove it, as needed.
            this.zlecenieTableAdapter.Fill(this.datadoINZDataSet.Zlecenie);
            // TODO: This line of code loads data into the 'datadoINZDataSet.Kontrahent_Zleceniodawca' table. You can move, or remove it, as needed.
            sqlcon.Open();
            sqladapter = new SqlDataAdapter("Select NazwaFirmy as [Nazwa Firmy],Imie_KZ + ' '+ Nazwisko_KZ as [Imię i Nazwisko Zleceniodawcy],Nip,REGON,Numer_Telefonu as [Numer Telefonu],Adres_Email as [Adres Email] from Kontrahent_Zleceniodawca where [Czy kontrahent] = 1", sqlcon);
            sqlcon.Close();
            dataset = new DataSet();
            sqladapter.Fill(dataset);
            dataGridViewZleceniobiorca.DataSource = dataset.Tables[0];
            

            sqlcon.Open();
            sqladapter = new SqlDataAdapter("Select NazwaFirmy as [Nazwa Firmy],Imie_KZ + ' '+ Nazwisko_KZ as [Imię i Nazwisko Zleceniodawcy],Nip,REGON,Numer_Telefonu as [Numer Telefonu],Adres_Email as [Adres Email] from Kontrahent_Zleceniodawca where [Czy kontrahent] = 0", sqlcon);
            sqlcon.Close();
            dataset = new DataSet();
            sqladapter.Fill(dataset);
            dataGridViewZleceniodawcy.DataSource = dataset.Tables[0];

            this.pracownikTableAdapter.Fill(this.datadoINZDataSet.Pracownik);
            // TODO: This line of code loads data into the 'datadoINZDataSet.Cennik' table. You can move, or remove it, as needed.
            this.cennikTableAdapter.Fill(this.datadoINZDataSet.Cennik);

        }
        
    }
}

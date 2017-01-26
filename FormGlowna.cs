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
            sqladapter = new SqlDataAdapter("Select Nazwa_Zlecenia,NazwaFirmy,Imie_Pracownika from Zlecenie join Kontrahent_Zleceniodawca On Kontrahent_Zleceniodawca.ID_KZ = Zlecenie.ID_KZ join Pracownik on Pracownik.ID_Pracownika = Zlecenie.ID_Pracownika",sqlcon);
            dataset = new DataSet();
            sqlcon.Close();
            sqladapter.Fill(dataset);
            dataZlecenia.DataSource = dataset.Tables[0];

            // TODO: This line of code loads data into the 'datadoINZDataSet.Zlecenie' table. You can move, or remove it, as needed.
            this.zlecenieTableAdapter.Fill(this.datadoINZDataSet.Zlecenie);
            // TODO: This line of code loads data into the 'datadoINZDataSet.Kontrahent_Zleceniodawca' table. You can move, or remove it, as needed.
            this.kontrahent_ZleceniodawcaTableAdapter.Fill(this.datadoINZDataSet.Kontrahent_Zleceniodawca);
            // TODO: This line of code loads data into the 'datadoINZDataSet.Pracownik' table. You can move, or remove it, as needed.
            this.pracownikTableAdapter.Fill(this.datadoINZDataSet.Pracownik);
            // TODO: This line of code loads data into the 'datadoINZDataSet.Cennik' table. You can move, or remove it, as needed.
            this.cennikTableAdapter.Fill(this.datadoINZDataSet.Cennik);

        }
    }
}

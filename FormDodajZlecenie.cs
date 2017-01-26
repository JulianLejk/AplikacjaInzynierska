using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaInzynierska
{
    public partial class FormDodajZlecenie : Form
    {
        SqlConnection sqlcon= new SqlConnection( @"Data Source = KOMPJULIANA\SQLEXPRESS; Initial Catalog = DatadoINZ; Integrated Security = True");
        SqlDataAdapter sqladapter;
        DataSet dataset;
        SqlCommand sqlcomand;
        string kk;

        public FormDodajZlecenie()
        {
            InitializeComponent();
        }

        private void FillComboboxByDataSet(SqlDataAdapter sqladapter,ComboBox comboBoxOsobaOdpowiedzialna)
        {
            sqlcon = new SqlConnection();
            sqlcon.ConnectionString = @"Data Source = KOMPJULIANA\SQLEXPRESS; Initial Catalog = DatadoINZ; Integrated Security = True";
            sqlcon.Open();
            sqladapter = new SqlDataAdapter("Select distinct Imie_Pracownika+' '+Nazwisko_Pracownika as [Podmiot Odpowiedzialny] from Pracownik union Select NazwaFirmy from Kontrahent_Zleceniodawca where [Czy kontrahent] = 1", sqlcon);
            sqlcon.Close();
            dataset = new DataSet();
            sqladapter.Fill(dataset);
            comboBoxOsobaOdpowiedzialna.DisplayMember = "Podmiot Odpowiedzialny";
            comboBoxOsobaOdpowiedzialna.ValueMember = "ID_KZ";
            comboBoxOsobaOdpowiedzialna.DataSource = dataset.Tables[0];
            
        }
        private void FormDodajZlecenie_Load(object sender, EventArgs e)
        {
            FillComboboxByDataSet(sqladapter,comboBoxOsobaOdpowiedzialna);
            
            
            // TODO: This line of code loads data into the 'datadoINZKontrahenci_Pracownik.Kontrahent_Zleceniodawca' table. You can move, or remove it, as needed.
            this.kontrahent_ZleceniodawcaTableAdapter1.Fill(this.datadoINZKontrahenci_Pracownik.Kontrahent_Zleceniodawca);
            // TODO: This line of code loads data into the 'datadoINZDataSet.Kontrahent_Zleceniodawca' table. You can move, or remove it, as needed.
            this.kontrahent_ZleceniodawcaTableAdapter.Fill(this.datadoINZDataSet.Kontrahent_Zleceniodawca);


        }

        private void butFDZDodaj_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcomand = new SqlCommand();

            String nazwaZlecenia,osobaOdpowiedzialna,nazwaFirmy;
            DateTime dataRozpoczecia, dataZakonczenia;

            nazwaZlecenia = textBoxFDZNazwaZlecenia.Text;
            osobaOdpowiedzialna = comboBoxOsobaOdpowiedzialna.Text;
            nazwaFirmy = comboBoxNazwaFirmy.Text;
            dataRozpoczecia = dateTimePickerDataRozpoczecia.Value.Date;
            dataZakonczenia = dateTimePickerDataZakonczenia.Value.Date;
            sqlcon.Close();
            

            kk = comboBoxNazwaFirmy.ValueMember;
            MessageBox.Show(kk);
        }
    }
}

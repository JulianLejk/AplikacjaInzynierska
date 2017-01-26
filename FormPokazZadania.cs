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
    public partial class FormPokazZadania : FormGlowna
    {
        SqlConnection sqlcon = new SqlConnection();
        SqlDataAdapter sqladapter;
        DataSet dataset = new DataSet();
        public FormPokazZadania()
        {
            InitializeComponent();
        }

        private void butFPZDodajZadanie_Click(object sender, EventArgs e)
        {
            FormDodajZadanie fpz = new FormDodajZadanie();
            fpz.ShowDialog();
        }

        private void FormPokazZadania_Load(object sender, EventArgs e)
        {

            sqlcon.ConnectionString = @"Data Source = KOMPJULIANA\SQLEXPRESS; Initial Catalog = DatadoINZ; Integrated Security = True";
            sqlcon.Open();
            sqladapter = new SqlDataAdapter(" Select * from Zadanie where Nazwa_Zadania = '"+stringdozadania+"'", sqlcon);
            sqladapter.Fill(dataset);
            dataGridViewZadania.DataSource = dataset.Tables[0];
        }
    }
}

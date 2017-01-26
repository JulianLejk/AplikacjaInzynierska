namespace AplikacjaInzynierska
{
    partial class FormDodajZlecenie
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
            this.components = new System.ComponentModel.Container();
            this.textBoxFDZNazwaZlecenia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxOsobaOdpowiedzialna = new System.Windows.Forms.ComboBox();
            this.comboBoxNazwaFirmy = new System.Windows.Forms.ComboBox();
            this.kontrahentZleceniodawcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datadoINZDataSet = new AplikacjaInzynierska.DatadoINZDataSet();
            this.dateTimePickerDataRozpoczecia = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDataZakonczenia = new System.Windows.Forms.DateTimePicker();
            this.kontrahent_ZleceniodawcaTableAdapter = new AplikacjaInzynierska.DatadoINZDataSetTableAdapters.Kontrahent_ZleceniodawcaTableAdapter();
            this.datadoINZKontrahenci_Pracownik = new AplikacjaInzynierska.DatadoINZKontrahenci_Pracownik();
            this.datadoINZKontrahenciPracownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kontrahentZleceniodawcaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kontrahent_ZleceniodawcaTableAdapter1 = new AplikacjaInzynierska.DatadoINZKontrahenci_PracownikTableAdapters.Kontrahent_ZleceniodawcaTableAdapter();
            this.butFDZDodaj = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kontrahentZleceniodawcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadoINZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadoINZKontrahenci_Pracownik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadoINZKontrahenciPracownikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrahentZleceniodawcaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFDZNazwaZlecenia
            // 
            this.textBoxFDZNazwaZlecenia.Location = new System.Drawing.Point(12, 39);
            this.textBoxFDZNazwaZlecenia.Name = "textBoxFDZNazwaZlecenia";
            this.textBoxFDZNazwaZlecenia.Size = new System.Drawing.Size(100, 20);
            this.textBoxFDZNazwaZlecenia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa Zlecenia";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(119, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Osoba odpowiedzialna";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(248, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nazwa Firmy";
            // 
            // comboBoxOsobaOdpowiedzialna
            // 
            this.comboBoxOsobaOdpowiedzialna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOsobaOdpowiedzialna.FormattingEnabled = true;
            this.comboBoxOsobaOdpowiedzialna.Location = new System.Drawing.Point(122, 38);
            this.comboBoxOsobaOdpowiedzialna.Name = "comboBoxOsobaOdpowiedzialna";
            this.comboBoxOsobaOdpowiedzialna.Size = new System.Drawing.Size(120, 21);
            this.comboBoxOsobaOdpowiedzialna.TabIndex = 4;
            // 
            // comboBoxNazwaFirmy
            // 
            this.comboBoxNazwaFirmy.DataSource = this.kontrahentZleceniodawcaBindingSource;
            this.comboBoxNazwaFirmy.DisplayMember = "NazwaFirmy";
            this.comboBoxNazwaFirmy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNazwaFirmy.Location = new System.Drawing.Point(251, 39);
            this.comboBoxNazwaFirmy.Name = "comboBoxNazwaFirmy";
            this.comboBoxNazwaFirmy.Size = new System.Drawing.Size(120, 21);
            this.comboBoxNazwaFirmy.TabIndex = 5;
            this.comboBoxNazwaFirmy.ValueMember = "ID_KZ";
            // 
            // kontrahentZleceniodawcaBindingSource
            // 
            this.kontrahentZleceniodawcaBindingSource.DataMember = "Kontrahent_Zleceniodawca";
            this.kontrahentZleceniodawcaBindingSource.DataSource = this.datadoINZDataSet;
            // 
            // datadoINZDataSet
            // 
            this.datadoINZDataSet.DataSetName = "DatadoINZDataSet";
            this.datadoINZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePickerDataRozpoczecia
            // 
            this.dateTimePickerDataRozpoczecia.Location = new System.Drawing.Point(12, 105);
            this.dateTimePickerDataRozpoczecia.Name = "dateTimePickerDataRozpoczecia";
            this.dateTimePickerDataRozpoczecia.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDataRozpoczecia.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data Rozpoczęcia";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(248, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data Zakończenia";
            // 
            // dateTimePickerDataZakonczenia
            // 
            this.dateTimePickerDataZakonczenia.Location = new System.Drawing.Point(251, 105);
            this.dateTimePickerDataZakonczenia.Name = "dateTimePickerDataZakonczenia";
            this.dateTimePickerDataZakonczenia.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDataZakonczenia.TabIndex = 9;
            // 
            // kontrahent_ZleceniodawcaTableAdapter
            // 
            this.kontrahent_ZleceniodawcaTableAdapter.ClearBeforeFill = true;
            // 
            // datadoINZKontrahenci_Pracownik
            // 
            this.datadoINZKontrahenci_Pracownik.DataSetName = "DatadoINZKontrahenci_Pracownik";
            this.datadoINZKontrahenci_Pracownik.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datadoINZKontrahenciPracownikBindingSource
            // 
            this.datadoINZKontrahenciPracownikBindingSource.DataSource = this.datadoINZKontrahenci_Pracownik;
            this.datadoINZKontrahenciPracownikBindingSource.Position = 0;
            // 
            // kontrahentZleceniodawcaBindingSource1
            // 
            this.kontrahentZleceniodawcaBindingSource1.DataMember = "Kontrahent_Zleceniodawca";
            this.kontrahentZleceniodawcaBindingSource1.DataSource = this.datadoINZKontrahenciPracownikBindingSource;
            // 
            // kontrahent_ZleceniodawcaTableAdapter1
            // 
            this.kontrahent_ZleceniodawcaTableAdapter1.ClearBeforeFill = true;
            // 
            // butFDZDodaj
            // 
            this.butFDZDodaj.Location = new System.Drawing.Point(13, 152);
            this.butFDZDodaj.Name = "butFDZDodaj";
            this.butFDZDodaj.Size = new System.Drawing.Size(75, 23);
            this.butFDZDodaj.TabIndex = 10;
            this.butFDZDodaj.Text = "Dodaj";
            this.butFDZDodaj.UseVisualStyleBackColor = true;
            this.butFDZDodaj.Click += new System.EventHandler(this.butFDZDodaj_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // FormDodajZlecenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 261);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.butFDZDodaj);
            this.Controls.Add(this.dateTimePickerDataZakonczenia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerDataRozpoczecia);
            this.Controls.Add(this.comboBoxNazwaFirmy);
            this.Controls.Add(this.comboBoxOsobaOdpowiedzialna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFDZNazwaZlecenia);
            this.Name = "FormDodajZlecenie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDodajZlecenie";
            this.Load += new System.EventHandler(this.FormDodajZlecenie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kontrahentZleceniodawcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadoINZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadoINZKontrahenci_Pracownik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadoINZKontrahenciPracownikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrahentZleceniodawcaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFDZNazwaZlecenia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxOsobaOdpowiedzialna;
        private System.Windows.Forms.ComboBox comboBoxNazwaFirmy;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataRozpoczecia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataZakonczenia;
        private DatadoINZDataSet datadoINZDataSet;
        private System.Windows.Forms.BindingSource kontrahentZleceniodawcaBindingSource;
        private DatadoINZDataSetTableAdapters.Kontrahent_ZleceniodawcaTableAdapter kontrahent_ZleceniodawcaTableAdapter;
        private System.Windows.Forms.BindingSource datadoINZKontrahenciPracownikBindingSource;
        private DatadoINZKontrahenci_Pracownik datadoINZKontrahenci_Pracownik;
        private System.Windows.Forms.BindingSource kontrahentZleceniodawcaBindingSource1;
        private DatadoINZKontrahenci_PracownikTableAdapters.Kontrahent_ZleceniodawcaTableAdapter kontrahent_ZleceniodawcaTableAdapter1;
        private System.Windows.Forms.Button butFDZDodaj;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
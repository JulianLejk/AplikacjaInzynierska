namespace AplikacjaInzynierska
{
    partial class FormDodajZadanie
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
            this.label1 = new System.Windows.Forms.Label();
            this.Pracownik = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFDZNazwaZadania = new System.Windows.Forms.TextBox();
            this.comboBoxFDZPracownik = new System.Windows.Forms.ComboBox();
            this.comboBoxFDZStopienRealizacji = new System.Windows.Forms.ComboBox();
            this.comboBoxFDZPotrzebnyPrzedmiot = new System.Windows.Forms.ComboBox();
            this.butFDZDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa Zadania";
            // 
            // Pracownik
            // 
            this.Pracownik.Location = new System.Drawing.Point(119, 13);
            this.Pracownik.Name = "Pracownik";
            this.Pracownik.Size = new System.Drawing.Size(130, 23);
            this.Pracownik.TabIndex = 1;
            this.Pracownik.Text = "Przydzielony Pra Kontr";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(255, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stopień Realizacji";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(388, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Potrzebny przedmiot";
            // 
            // textBoxFDZNazwaZadania
            // 
            this.textBoxFDZNazwaZadania.Location = new System.Drawing.Point(16, 39);
            this.textBoxFDZNazwaZadania.Name = "textBoxFDZNazwaZadania";
            this.textBoxFDZNazwaZadania.Size = new System.Drawing.Size(97, 20);
            this.textBoxFDZNazwaZadania.TabIndex = 4;
            // 
            // comboBoxFDZPracownik
            // 
            this.comboBoxFDZPracownik.FormattingEnabled = true;
            this.comboBoxFDZPracownik.Location = new System.Drawing.Point(122, 37);
            this.comboBoxFDZPracownik.Name = "comboBoxFDZPracownik";
            this.comboBoxFDZPracownik.Size = new System.Drawing.Size(127, 21);
            this.comboBoxFDZPracownik.TabIndex = 5;
            // 
            // comboBoxFDZStopienRealizacji
            // 
            this.comboBoxFDZStopienRealizacji.FormattingEnabled = true;
            this.comboBoxFDZStopienRealizacji.Location = new System.Drawing.Point(255, 37);
            this.comboBoxFDZStopienRealizacji.Name = "comboBoxFDZStopienRealizacji";
            this.comboBoxFDZStopienRealizacji.Size = new System.Drawing.Size(127, 21);
            this.comboBoxFDZStopienRealizacji.TabIndex = 6;
            // 
            // comboBoxFDZPotrzebnyPrzedmiot
            // 
            this.comboBoxFDZPotrzebnyPrzedmiot.FormattingEnabled = true;
            this.comboBoxFDZPotrzebnyPrzedmiot.Location = new System.Drawing.Point(388, 37);
            this.comboBoxFDZPotrzebnyPrzedmiot.Name = "comboBoxFDZPotrzebnyPrzedmiot";
            this.comboBoxFDZPotrzebnyPrzedmiot.Size = new System.Drawing.Size(127, 21);
            this.comboBoxFDZPotrzebnyPrzedmiot.TabIndex = 7;
            // 
            // butFDZDodaj
            // 
            this.butFDZDodaj.Location = new System.Drawing.Point(391, 102);
            this.butFDZDodaj.Name = "butFDZDodaj";
            this.butFDZDodaj.Size = new System.Drawing.Size(75, 23);
            this.butFDZDodaj.TabIndex = 8;
            this.butFDZDodaj.Text = "Dodaj";
            this.butFDZDodaj.UseVisualStyleBackColor = true;
            // 
            // FormDodajZadanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 384);
            this.Controls.Add(this.butFDZDodaj);
            this.Controls.Add(this.comboBoxFDZPotrzebnyPrzedmiot);
            this.Controls.Add(this.comboBoxFDZStopienRealizacji);
            this.Controls.Add(this.comboBoxFDZPracownik);
            this.Controls.Add(this.textBoxFDZNazwaZadania);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pracownik);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "FormDodajZadanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DodajZadanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Pracownik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFDZNazwaZadania;
        private System.Windows.Forms.ComboBox comboBoxFDZPracownik;
        private System.Windows.Forms.ComboBox comboBoxFDZStopienRealizacji;
        private System.Windows.Forms.ComboBox comboBoxFDZPotrzebnyPrzedmiot;
        private System.Windows.Forms.Button butFDZDodaj;
    }
}
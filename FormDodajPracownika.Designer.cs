namespace AplikacjaInzynierska
{
    partial class FormDodajPracownika
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
            this.textBoxFDPImie = new System.Windows.Forms.TextBox();
            this.textBoxFDPNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxFDPStawkah = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButFDPCzyNasz = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBoxFDPImie
            // 
            this.textBoxFDPImie.Location = new System.Drawing.Point(13, 40);
            this.textBoxFDPImie.Name = "textBoxFDPImie";
            this.textBoxFDPImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxFDPImie.TabIndex = 0;
            // 
            // textBoxFDPNazwisko
            // 
            this.textBoxFDPNazwisko.Location = new System.Drawing.Point(119, 40);
            this.textBoxFDPNazwisko.Name = "textBoxFDPNazwisko";
            this.textBoxFDPNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBoxFDPNazwisko.TabIndex = 1;
            // 
            // textBoxFDPStawkah
            // 
            this.textBoxFDPStawkah.Location = new System.Drawing.Point(225, 40);
            this.textBoxFDPStawkah.Name = "textBoxFDPStawkah";
            this.textBoxFDPStawkah.Size = new System.Drawing.Size(100, 20);
            this.textBoxFDPStawkah.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(119, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(225, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stawka godzinowa";
            // 
            // radioButFDPCzyNasz
            // 
            this.radioButFDPCzyNasz.AutoSize = true;
            this.radioButFDPCzyNasz.Location = new System.Drawing.Point(332, 29);
            this.radioButFDPCzyNasz.Name = "radioButFDPCzyNasz";
            this.radioButFDPCzyNasz.Size = new System.Drawing.Size(73, 17);
            this.radioButFDPCzyNasz.TabIndex = 6;
            this.radioButFDPCzyNasz.TabStop = true;
            this.radioButFDPCzyNasz.Text = "Czy nasz?";
            this.radioButFDPCzyNasz.UseVisualStyleBackColor = true;
            // 
            // FormDodajPracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 93);
            this.Controls.Add(this.radioButFDPCzyNasz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFDPStawkah);
            this.Controls.Add(this.textBoxFDPNazwisko);
            this.Controls.Add(this.textBoxFDPImie);
            this.Name = "FormDodajPracownika";
            this.Text = "FormDodajPracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFDPImie;
        private System.Windows.Forms.TextBox textBoxFDPNazwisko;
        private System.Windows.Forms.TextBox textBoxFDPStawkah;
        private System.Windows.Forms.RadioButton radioButFDPCzyNasz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
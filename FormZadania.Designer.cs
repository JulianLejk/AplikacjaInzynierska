namespace AplikacjaInzynierska
{
    partial class FormZadania
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
            this.dataGVZadanie = new System.Windows.Forms.DataGridView();
            this.butFZadaniaDodaj = new System.Windows.Forms.Button();
            this.butFZadaniaEdytuj = new System.Windows.Forms.Button();
            this.butFZadaniaUsun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVZadanie)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVZadanie
            // 
            this.dataGVZadanie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVZadanie.Location = new System.Drawing.Point(12, 40);
            this.dataGVZadanie.Name = "dataGVZadanie";
            this.dataGVZadanie.Size = new System.Drawing.Size(319, 223);
            this.dataGVZadanie.TabIndex = 0;
            // 
            // butFZadaniaDodaj
            // 
            this.butFZadaniaDodaj.Location = new System.Drawing.Point(337, 40);
            this.butFZadaniaDodaj.Name = "butFZadaniaDodaj";
            this.butFZadaniaDodaj.Size = new System.Drawing.Size(75, 23);
            this.butFZadaniaDodaj.TabIndex = 1;
            this.butFZadaniaDodaj.Text = "Dodaj Zadanie";
            this.butFZadaniaDodaj.UseVisualStyleBackColor = true;
            // 
            // butFZadaniaEdytuj
            // 
            this.butFZadaniaEdytuj.Location = new System.Drawing.Point(337, 70);
            this.butFZadaniaEdytuj.Name = "butFZadaniaEdytuj";
            this.butFZadaniaEdytuj.Size = new System.Drawing.Size(75, 23);
            this.butFZadaniaEdytuj.TabIndex = 2;
            this.butFZadaniaEdytuj.Text = "Edytuj ";
            this.butFZadaniaEdytuj.UseVisualStyleBackColor = true;
            // 
            // butFZadaniaUsun
            // 
            this.butFZadaniaUsun.Location = new System.Drawing.Point(337, 100);
            this.butFZadaniaUsun.Name = "butFZadaniaUsun";
            this.butFZadaniaUsun.Size = new System.Drawing.Size(75, 23);
            this.butFZadaniaUsun.TabIndex = 3;
            this.butFZadaniaUsun.Text = "Usuń";
            this.butFZadaniaUsun.UseVisualStyleBackColor = true;
            // 
            // FormZadania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 275);
            this.Controls.Add(this.butFZadaniaUsun);
            this.Controls.Add(this.butFZadaniaEdytuj);
            this.Controls.Add(this.butFZadaniaDodaj);
            this.Controls.Add(this.dataGVZadanie);
            this.Name = "FormZadania";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zadania";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVZadanie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVZadanie;
        private System.Windows.Forms.Button butFZadaniaDodaj;
        private System.Windows.Forms.Button butFZadaniaEdytuj;
        private System.Windows.Forms.Button butFZadaniaUsun;
    }
}
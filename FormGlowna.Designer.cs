namespace AplikacjaInzynierska
{
    partial class FormGlowna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGlowna));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonFGUsunZleceniodawce = new System.Windows.Forms.Button();
            this.dataGridViewZleceniodawcy = new System.Windows.Forms.DataGridView();
            this.buttonFGDodajZleceniodawce = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonFGUsunKontahenta = new System.Windows.Forms.Button();
            this.buttonFGDodajKontrahenta = new System.Windows.Forms.Button();
            this.dataGridViewZleceniobiorca = new System.Windows.Forms.DataGridView();
            this.tabMagazyn = new System.Windows.Forms.TabPage();
            this.butFGlownaSzukajPrzedmiot = new System.Windows.Forms.Button();
            this.butFGlownaUsunPrzedmiot = new System.Windows.Forms.Button();
            this.butFGlownaDodajPrzedmiot = new System.Windows.Forms.Button();
            this.dataMagazyn = new System.Windows.Forms.DataGridView();
            this.cennikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datadoINZDataSet = new AplikacjaInzynierska.DatadoINZDataSet();
            this.tabZlecenia = new System.Windows.Forms.TabPage();
            this.monthCalendarZlecenie = new System.Windows.Forms.MonthCalendar();
            this.button3 = new System.Windows.Forms.Button();
            this.butFGlownaPokazZadania = new System.Windows.Forms.Button();
            this.butFGlownaDodajZLecenie = new System.Windows.Forms.Button();
            this.dataZlecenia = new System.Windows.Forms.DataGridView();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonFGUsunPracownika = new System.Windows.Forms.Button();
            this.buttonFGDodajPracownika = new System.Windows.Forms.Button();
            this.dataGridViewPracownicy = new System.Windows.Forms.DataGridView();
            this.pracownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cennikTableAdapter = new AplikacjaInzynierska.DatadoINZDataSetTableAdapters.CennikTableAdapter();
            this.pracownikTableAdapter = new AplikacjaInzynierska.DatadoINZDataSetTableAdapters.PracownikTableAdapter();
            this.kontrahentZleceniodawcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kontrahent_ZleceniodawcaTableAdapter = new AplikacjaInzynierska.DatadoINZDataSetTableAdapters.Kontrahent_ZleceniodawcaTableAdapter();
            this.zlecenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zlecenieTableAdapter = new AplikacjaInzynierska.DatadoINZDataSetTableAdapters.ZlecenieTableAdapter();
            this.datadoINZDataSet1 = new AplikacjaInzynierska.DatadoINZDataSet();
            this.datadoINZDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datadoINZDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nazwaPrzedmiotuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscPrzedmiotuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaPrzedmiotuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imiePracownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoPracownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stawkahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czyNaszDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZleceniodawcy)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZleceniobiorca)).BeginInit();
            this.tabMagazyn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMagazyn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cennikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadoINZDataSet)).BeginInit();
            this.tabZlecenia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataZlecenia)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPracownicy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrahentZleceniodawcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zlecenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadoINZDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadoINZDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadoINZDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(848, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonFGUsunZleceniodawce);
            this.tabPage3.Controls.Add(this.dataGridViewZleceniodawcy);
            this.tabPage3.Controls.Add(this.buttonFGDodajZleceniodawce);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(840, 362);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Zleceniodawcy";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonFGUsunZleceniodawce
            // 
            this.buttonFGUsunZleceniodawce.Location = new System.Drawing.Point(162, 333);
            this.buttonFGUsunZleceniodawce.Name = "buttonFGUsunZleceniodawce";
            this.buttonFGUsunZleceniodawce.Size = new System.Drawing.Size(150, 23);
            this.buttonFGUsunZleceniodawce.TabIndex = 2;
            this.buttonFGUsunZleceniodawce.Text = "Usuń";
            this.buttonFGUsunZleceniodawce.UseVisualStyleBackColor = true;
            // 
            // dataGridViewZleceniodawcy
            // 
            this.dataGridViewZleceniodawcy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZleceniodawcy.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewZleceniodawcy.Name = "dataGridViewZleceniodawcy";
            this.dataGridViewZleceniodawcy.ReadOnly = true;
            this.dataGridViewZleceniodawcy.Size = new System.Drawing.Size(834, 320);
            this.dataGridViewZleceniodawcy.TabIndex = 1;
            // 
            // buttonFGDodajZleceniodawce
            // 
            this.buttonFGDodajZleceniodawce.Location = new System.Drawing.Point(6, 333);
            this.buttonFGDodajZleceniodawce.Name = "buttonFGDodajZleceniodawce";
            this.buttonFGDodajZleceniodawce.Size = new System.Drawing.Size(150, 23);
            this.buttonFGDodajZleceniodawce.TabIndex = 0;
            this.buttonFGDodajZleceniodawce.Text = "Dodaj";
            this.buttonFGDodajZleceniodawce.UseVisualStyleBackColor = true;
            this.buttonFGDodajZleceniodawce.Click += new System.EventHandler(this.buttonFGDodajZleceniodawce_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonFGUsunKontahenta);
            this.tabPage2.Controls.Add(this.buttonFGDodajKontrahenta);
            this.tabPage2.Controls.Add(this.dataGridViewZleceniobiorca);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(840, 362);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Kontrahenci ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonFGUsunKontahenta
            // 
            this.buttonFGUsunKontahenta.Location = new System.Drawing.Point(150, 333);
            this.buttonFGUsunKontahenta.Name = "buttonFGUsunKontahenta";
            this.buttonFGUsunKontahenta.Size = new System.Drawing.Size(138, 23);
            this.buttonFGUsunKontahenta.TabIndex = 2;
            this.buttonFGUsunKontahenta.Text = "Usuń";
            this.buttonFGUsunKontahenta.UseVisualStyleBackColor = true;
            // 
            // buttonFGDodajKontrahenta
            // 
            this.buttonFGDodajKontrahenta.Location = new System.Drawing.Point(6, 333);
            this.buttonFGDodajKontrahenta.Name = "buttonFGDodajKontrahenta";
            this.buttonFGDodajKontrahenta.Size = new System.Drawing.Size(138, 23);
            this.buttonFGDodajKontrahenta.TabIndex = 1;
            this.buttonFGDodajKontrahenta.Text = "Dodaj ";
            this.buttonFGDodajKontrahenta.UseVisualStyleBackColor = true;
            this.buttonFGDodajKontrahenta.Click += new System.EventHandler(this.buttonFGDodajKontrahenta_Click);
            // 
            // dataGridViewZleceniobiorca
            // 
            this.dataGridViewZleceniobiorca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZleceniobiorca.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewZleceniobiorca.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewZleceniobiorca.Name = "dataGridViewZleceniobiorca";
            this.dataGridViewZleceniobiorca.ReadOnly = true;
            this.dataGridViewZleceniobiorca.Size = new System.Drawing.Size(834, 324);
            this.dataGridViewZleceniobiorca.TabIndex = 0;
            // 
            // tabMagazyn
            // 
            this.tabMagazyn.Controls.Add(this.butFGlownaSzukajPrzedmiot);
            this.tabMagazyn.Controls.Add(this.butFGlownaUsunPrzedmiot);
            this.tabMagazyn.Controls.Add(this.butFGlownaDodajPrzedmiot);
            this.tabMagazyn.Controls.Add(this.dataMagazyn);
            this.tabMagazyn.Location = new System.Drawing.Point(4, 22);
            this.tabMagazyn.Name = "tabMagazyn";
            this.tabMagazyn.Padding = new System.Windows.Forms.Padding(3);
            this.tabMagazyn.Size = new System.Drawing.Size(840, 362);
            this.tabMagazyn.TabIndex = 1;
            this.tabMagazyn.Text = "Magazyn";
            this.tabMagazyn.UseVisualStyleBackColor = true;
            // 
            // butFGlownaSzukajPrzedmiot
            // 
            this.butFGlownaSzukajPrzedmiot.Location = new System.Drawing.Point(327, 333);
            this.butFGlownaSzukajPrzedmiot.Name = "butFGlownaSzukajPrzedmiot";
            this.butFGlownaSzukajPrzedmiot.Size = new System.Drawing.Size(154, 23);
            this.butFGlownaSzukajPrzedmiot.TabIndex = 3;
            this.butFGlownaSzukajPrzedmiot.Text = "Szukaj Przedmiot";
            this.butFGlownaSzukajPrzedmiot.UseVisualStyleBackColor = true;
            // 
            // butFGlownaUsunPrzedmiot
            // 
            this.butFGlownaUsunPrzedmiot.Location = new System.Drawing.Point(167, 333);
            this.butFGlownaUsunPrzedmiot.Name = "butFGlownaUsunPrzedmiot";
            this.butFGlownaUsunPrzedmiot.Size = new System.Drawing.Size(154, 23);
            this.butFGlownaUsunPrzedmiot.TabIndex = 2;
            this.butFGlownaUsunPrzedmiot.Text = "Usuń Przedmiot";
            this.butFGlownaUsunPrzedmiot.UseVisualStyleBackColor = true;
            // 
            // butFGlownaDodajPrzedmiot
            // 
            this.butFGlownaDodajPrzedmiot.Location = new System.Drawing.Point(7, 333);
            this.butFGlownaDodajPrzedmiot.Name = "butFGlownaDodajPrzedmiot";
            this.butFGlownaDodajPrzedmiot.Size = new System.Drawing.Size(154, 23);
            this.butFGlownaDodajPrzedmiot.TabIndex = 1;
            this.butFGlownaDodajPrzedmiot.Text = "Dodaj Przedmiot";
            this.butFGlownaDodajPrzedmiot.UseVisualStyleBackColor = true;
            this.butFGlownaDodajPrzedmiot.Click += new System.EventHandler(this.butFGlownaDodajPrzedmiot_Click);
            // 
            // dataMagazyn
            // 
            this.dataMagazyn.AutoGenerateColumns = false;
            this.dataMagazyn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMagazyn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwaPrzedmiotuDataGridViewTextBoxColumn,
            this.iloscPrzedmiotuDataGridViewTextBoxColumn,
            this.cenaPrzedmiotuDataGridViewTextBoxColumn});
            this.dataMagazyn.DataSource = this.cennikBindingSource;
            this.dataMagazyn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataMagazyn.Location = new System.Drawing.Point(3, 3);
            this.dataMagazyn.Name = "dataMagazyn";
            this.dataMagazyn.ReadOnly = true;
            this.dataMagazyn.Size = new System.Drawing.Size(834, 322);
            this.dataMagazyn.TabIndex = 0;
            // 
            // cennikBindingSource
            // 
            this.cennikBindingSource.DataMember = "Cennik";
            this.cennikBindingSource.DataSource = this.datadoINZDataSet;
            // 
            // datadoINZDataSet
            // 
            this.datadoINZDataSet.DataSetName = "DatadoINZDataSet";
            this.datadoINZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabZlecenia
            // 
            this.tabZlecenia.Controls.Add(this.monthCalendarZlecenie);
            this.tabZlecenia.Controls.Add(this.button3);
            this.tabZlecenia.Controls.Add(this.butFGlownaPokazZadania);
            this.tabZlecenia.Controls.Add(this.butFGlownaDodajZLecenie);
            this.tabZlecenia.Controls.Add(this.dataZlecenia);
            this.tabZlecenia.Location = new System.Drawing.Point(4, 22);
            this.tabZlecenia.Name = "tabZlecenia";
            this.tabZlecenia.Padding = new System.Windows.Forms.Padding(3);
            this.tabZlecenia.Size = new System.Drawing.Size(840, 362);
            this.tabZlecenia.TabIndex = 0;
            this.tabZlecenia.Text = "Zlecenia";
            this.tabZlecenia.UseVisualStyleBackColor = true;
            // 
            // monthCalendarZlecenie
            // 
            this.monthCalendarZlecenie.Location = new System.Drawing.Point(551, 197);
            this.monthCalendarZlecenie.Name = "monthCalendarZlecenie";
            this.monthCalendarZlecenie.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(609, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // butFGlownaPokazZadania
            // 
            this.butFGlownaPokazZadania.Location = new System.Drawing.Point(545, 35);
            this.butFGlownaPokazZadania.Name = "butFGlownaPokazZadania";
            this.butFGlownaPokazZadania.Size = new System.Drawing.Size(142, 23);
            this.butFGlownaPokazZadania.TabIndex = 2;
            this.butFGlownaPokazZadania.Text = "Pokaz Zadania";
            this.butFGlownaPokazZadania.UseVisualStyleBackColor = true;
            this.butFGlownaPokazZadania.Click += new System.EventHandler(this.butFGlownaPokazZadania_Click);
            // 
            // butFGlownaDodajZLecenie
            // 
            this.butFGlownaDodajZLecenie.Location = new System.Drawing.Point(545, 6);
            this.butFGlownaDodajZLecenie.Name = "butFGlownaDodajZLecenie";
            this.butFGlownaDodajZLecenie.Size = new System.Drawing.Size(142, 23);
            this.butFGlownaDodajZLecenie.TabIndex = 1;
            this.butFGlownaDodajZLecenie.Text = "Dodaj Zlecenie";
            this.butFGlownaDodajZLecenie.UseVisualStyleBackColor = true;
            this.butFGlownaDodajZLecenie.Click += new System.EventHandler(this.butFGlownaDodajZLecenie_Click);
            // 
            // dataZlecenia
            // 
            this.dataZlecenia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataZlecenia.Location = new System.Drawing.Point(12, 9);
            this.dataZlecenia.Name = "dataZlecenia";
            this.dataZlecenia.ReadOnly = true;
            this.dataZlecenia.Size = new System.Drawing.Size(527, 350);
            this.dataZlecenia.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabZlecenia);
            this.tabMain.Controls.Add(this.tabMagazyn);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMain.Location = new System.Drawing.Point(0, 24);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(848, 388);
            this.tabMain.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonFGUsunPracownika);
            this.tabPage1.Controls.Add(this.buttonFGDodajPracownika);
            this.tabPage1.Controls.Add(this.dataGridViewPracownicy);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(840, 362);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "Pracownicy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonFGUsunPracownika
            // 
            this.buttonFGUsunPracownika.Location = new System.Drawing.Point(178, 333);
            this.buttonFGUsunPracownika.Name = "buttonFGUsunPracownika";
            this.buttonFGUsunPracownika.Size = new System.Drawing.Size(166, 23);
            this.buttonFGUsunPracownika.TabIndex = 2;
            this.buttonFGUsunPracownika.Text = "Usuń";
            this.buttonFGUsunPracownika.UseVisualStyleBackColor = true;
            // 
            // buttonFGDodajPracownika
            // 
            this.buttonFGDodajPracownika.Location = new System.Drawing.Point(6, 333);
            this.buttonFGDodajPracownika.Name = "buttonFGDodajPracownika";
            this.buttonFGDodajPracownika.Size = new System.Drawing.Size(166, 23);
            this.buttonFGDodajPracownika.TabIndex = 1;
            this.buttonFGDodajPracownika.Text = "Dodaj";
            this.buttonFGDodajPracownika.UseVisualStyleBackColor = true;
            this.buttonFGDodajPracownika.Click += new System.EventHandler(this.buttonFGDodajPracownika_Click);
            // 
            // dataGridViewPracownicy
            // 
            this.dataGridViewPracownicy.AutoGenerateColumns = false;
            this.dataGridViewPracownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPracownicy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imiePracownikaDataGridViewTextBoxColumn,
            this.nazwiskoPracownikaDataGridViewTextBoxColumn,
            this.stawkahDataGridViewTextBoxColumn,
            this.czyNaszDataGridViewCheckBoxColumn});
            this.dataGridViewPracownicy.DataSource = this.pracownikBindingSource;
            this.dataGridViewPracownicy.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewPracownicy.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewPracownicy.Enabled = false;
            this.dataGridViewPracownicy.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewPracownicy.MultiSelect = false;
            this.dataGridViewPracownicy.Name = "dataGridViewPracownicy";
            this.dataGridViewPracownicy.ReadOnly = true;
            this.dataGridViewPracownicy.Size = new System.Drawing.Size(834, 324);
            this.dataGridViewPracownicy.TabIndex = 0;
            // 
            // pracownikBindingSource
            // 
            this.pracownikBindingSource.DataMember = "Pracownik";
            this.pracownikBindingSource.DataSource = this.datadoINZDataSet;
            // 
            // cennikTableAdapter
            // 
            this.cennikTableAdapter.ClearBeforeFill = true;
            // 
            // pracownikTableAdapter
            // 
            this.pracownikTableAdapter.ClearBeforeFill = true;
            // 
            // kontrahentZleceniodawcaBindingSource
            // 
            this.kontrahentZleceniodawcaBindingSource.DataMember = "Kontrahent_Zleceniodawca";
            this.kontrahentZleceniodawcaBindingSource.DataSource = this.datadoINZDataSet;
            // 
            // kontrahent_ZleceniodawcaTableAdapter
            // 
            this.kontrahent_ZleceniodawcaTableAdapter.ClearBeforeFill = true;
            // 
            // zlecenieBindingSource
            // 
            this.zlecenieBindingSource.DataMember = "Zlecenie";
            this.zlecenieBindingSource.DataSource = this.datadoINZDataSet;
            // 
            // zlecenieTableAdapter
            // 
            this.zlecenieTableAdapter.ClearBeforeFill = true;
            // 
            // datadoINZDataSet1
            // 
            this.datadoINZDataSet1.DataSetName = "DatadoINZDataSet1";
            this.datadoINZDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datadoINZDataSet1BindingSource
            // 
            this.datadoINZDataSet1BindingSource.DataSource = this.datadoINZDataSet1;
            this.datadoINZDataSet1BindingSource.Position = 0;
            // 
            // datadoINZDataSetBindingSource
            // 
            this.datadoINZDataSetBindingSource.DataSource = this.datadoINZDataSet;
            this.datadoINZDataSetBindingSource.Position = 0;
            // 
            // nazwaPrzedmiotuDataGridViewTextBoxColumn
            // 
            this.nazwaPrzedmiotuDataGridViewTextBoxColumn.DataPropertyName = "Nazwa_Przedmiotu";
            this.nazwaPrzedmiotuDataGridViewTextBoxColumn.HeaderText = "Nazwa Przedmiotu";
            this.nazwaPrzedmiotuDataGridViewTextBoxColumn.Name = "nazwaPrzedmiotuDataGridViewTextBoxColumn";
            this.nazwaPrzedmiotuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iloscPrzedmiotuDataGridViewTextBoxColumn
            // 
            this.iloscPrzedmiotuDataGridViewTextBoxColumn.DataPropertyName = "Ilosc_Przedmiotu";
            this.iloscPrzedmiotuDataGridViewTextBoxColumn.HeaderText = "Ilość ";
            this.iloscPrzedmiotuDataGridViewTextBoxColumn.Name = "iloscPrzedmiotuDataGridViewTextBoxColumn";
            this.iloscPrzedmiotuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenaPrzedmiotuDataGridViewTextBoxColumn
            // 
            this.cenaPrzedmiotuDataGridViewTextBoxColumn.DataPropertyName = "Cena_Przedmiotu";
            this.cenaPrzedmiotuDataGridViewTextBoxColumn.HeaderText = "Cena ";
            this.cenaPrzedmiotuDataGridViewTextBoxColumn.Name = "cenaPrzedmiotuDataGridViewTextBoxColumn";
            this.cenaPrzedmiotuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imiePracownikaDataGridViewTextBoxColumn
            // 
            this.imiePracownikaDataGridViewTextBoxColumn.DataPropertyName = "Imie_Pracownika";
            this.imiePracownikaDataGridViewTextBoxColumn.HeaderText = "Imię Pracownika";
            this.imiePracownikaDataGridViewTextBoxColumn.Name = "imiePracownikaDataGridViewTextBoxColumn";
            this.imiePracownikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.imiePracownikaDataGridViewTextBoxColumn.Width = 198;
            // 
            // nazwiskoPracownikaDataGridViewTextBoxColumn
            // 
            this.nazwiskoPracownikaDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko_Pracownika";
            this.nazwiskoPracownikaDataGridViewTextBoxColumn.HeaderText = "Nazwisko Pracownika";
            this.nazwiskoPracownikaDataGridViewTextBoxColumn.Name = "nazwiskoPracownikaDataGridViewTextBoxColumn";
            this.nazwiskoPracownikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazwiskoPracownikaDataGridViewTextBoxColumn.Width = 198;
            // 
            // stawkahDataGridViewTextBoxColumn
            // 
            this.stawkahDataGridViewTextBoxColumn.DataPropertyName = "Stawka/h";
            this.stawkahDataGridViewTextBoxColumn.HeaderText = "Stawka/h";
            this.stawkahDataGridViewTextBoxColumn.Name = "stawkahDataGridViewTextBoxColumn";
            this.stawkahDataGridViewTextBoxColumn.ReadOnly = true;
            this.stawkahDataGridViewTextBoxColumn.Width = 197;
            // 
            // czyNaszDataGridViewCheckBoxColumn
            // 
            this.czyNaszDataGridViewCheckBoxColumn.DataPropertyName = "Czy nasz";
            this.czyNaszDataGridViewCheckBoxColumn.HeaderText = "Czy nasz";
            this.czyNaszDataGridViewCheckBoxColumn.Name = "czyNaszDataGridViewCheckBoxColumn";
            this.czyNaszDataGridViewCheckBoxColumn.ReadOnly = true;
            this.czyNaszDataGridViewCheckBoxColumn.Width = 198;
            // 
            // FormGlowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 438);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGlowna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikacja do zarządzania Zleceniami";
            this.Load += new System.EventHandler(this.FormGlowna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZleceniodawcy)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZleceniobiorca)).EndInit();
            this.tabMagazyn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMagazyn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cennikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadoINZDataSet)).EndInit();
            this.tabZlecenia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataZlecenia)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPracownicy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrahentZleceniodawcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zlecenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadoINZDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadoINZDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadoINZDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonFGUsunZleceniodawce;
        private System.Windows.Forms.DataGridView dataGridViewZleceniodawcy;
        private System.Windows.Forms.Button buttonFGDodajZleceniodawce;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonFGUsunKontahenta;
        private System.Windows.Forms.Button buttonFGDodajKontrahenta;
        private System.Windows.Forms.DataGridView dataGridViewZleceniobiorca;
        private System.Windows.Forms.TabPage tabMagazyn;
        private System.Windows.Forms.Button butFGlownaSzukajPrzedmiot;
        private System.Windows.Forms.Button butFGlownaUsunPrzedmiot;
        private System.Windows.Forms.Button butFGlownaDodajPrzedmiot;
        private System.Windows.Forms.DataGridView dataMagazyn;
        private System.Windows.Forms.TabPage tabZlecenia;
        private System.Windows.Forms.MonthCalendar monthCalendarZlecenie;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button butFGlownaPokazZadania;
        private System.Windows.Forms.Button butFGlownaDodajZLecenie;
        private System.Windows.Forms.DataGridView dataZlecenia;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonFGUsunPracownika;
        private System.Windows.Forms.Button buttonFGDodajPracownika;
        private System.Windows.Forms.DataGridView dataGridViewPracownicy;
        private DatadoINZDataSet datadoINZDataSet;
        private System.Windows.Forms.BindingSource cennikBindingSource;
        private DatadoINZDataSetTableAdapters.CennikTableAdapter cennikTableAdapter;
        private System.Windows.Forms.BindingSource pracownikBindingSource;
        private DatadoINZDataSetTableAdapters.PracownikTableAdapter pracownikTableAdapter;
        private System.Windows.Forms.BindingSource kontrahentZleceniodawcaBindingSource;
        private DatadoINZDataSetTableAdapters.Kontrahent_ZleceniodawcaTableAdapter kontrahent_ZleceniodawcaTableAdapter;
        private System.Windows.Forms.BindingSource zlecenieBindingSource;
        private DatadoINZDataSetTableAdapters.ZlecenieTableAdapter zlecenieTableAdapter;
        private System.Windows.Forms.BindingSource datadoINZDataSet1BindingSource;
        private DatadoINZDataSet datadoINZDataSet1;
        private System.Windows.Forms.BindingSource datadoINZDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaPrzedmiotuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscPrzedmiotuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaPrzedmiotuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imiePracownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoPracownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stawkahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn czyNaszDataGridViewCheckBoxColumn;
    }
}


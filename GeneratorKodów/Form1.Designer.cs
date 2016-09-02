namespace GeneratorKodów
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.twIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.twNazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.twPodstKodKreskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.twTowarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEST_CIAPODataSet = new GeneratorKodów.TEST_CIAPODataSet();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonUpDown1 = new System.Windows.Forms.RibbonUpDown();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.rbConnect = new System.Windows.Forms.RibbonButton();
            this.rbConfigDb = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.rbGeneruj = new System.Windows.Forms.RibbonButton();
            this.ribbonButton6 = new System.Windows.Forms.RibbonButton();
            this.rbZapiszRekord = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.rbTextBoxProducent = new System.Windows.Forms.RibbonTextBox();
            this.rbTextBoxPrefix = new System.Windows.Forms.RibbonTextBox();
            this.rbButtonZatwierdz = new System.Windows.Forms.RibbonButton();
            this.ribbonLabel3 = new System.Windows.Forms.RibbonLabel();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton5 = new System.Windows.Forms.RibbonButton();
            this.tw__TowarTableAdapter = new GeneratorKodów.TEST_CIAPODataSetTableAdapters.tw__TowarTableAdapter();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonLabel4 = new System.Windows.Forms.RibbonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twTowarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEST_CIAPODataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.twIdDataGridViewTextBoxColumn,
            this.twNazwaDataGridViewTextBoxColumn,
            this.twPodstKodKreskDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.twTowarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(616, 270);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Aktualizuj";
            this.Column1.Name = "Column1";
            this.Column1.Width = 58;
            // 
            // twIdDataGridViewTextBoxColumn
            // 
            this.twIdDataGridViewTextBoxColumn.DataPropertyName = "tw_Id";
            this.twIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.twIdDataGridViewTextBoxColumn.Name = "twIdDataGridViewTextBoxColumn";
            this.twIdDataGridViewTextBoxColumn.Width = 41;
            // 
            // twNazwaDataGridViewTextBoxColumn
            // 
            this.twNazwaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.twNazwaDataGridViewTextBoxColumn.DataPropertyName = "tw_Nazwa";
            this.twNazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.twNazwaDataGridViewTextBoxColumn.Name = "twNazwaDataGridViewTextBoxColumn";
            this.twNazwaDataGridViewTextBoxColumn.Width = 350;
            // 
            // twPodstKodKreskDataGridViewTextBoxColumn
            // 
            this.twPodstKodKreskDataGridViewTextBoxColumn.DataPropertyName = "tw_PodstKodKresk";
            this.twPodstKodKreskDataGridViewTextBoxColumn.HeaderText = "Kod EAN";
            this.twPodstKodKreskDataGridViewTextBoxColumn.Name = "twPodstKodKreskDataGridViewTextBoxColumn";
            // 
            // twTowarBindingSource
            // 
            this.twTowarBindingSource.DataMember = "tw__Towar";
            this.twTowarBindingSource.DataSource = this.tEST_CIAPODataSet;
            // 
            // tEST_CIAPODataSet
            // 
            this.tEST_CIAPODataSet.DataSetName = "TEST_CIAPODataSet";
            this.tEST_CIAPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbLogin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(616, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbLogin
            // 
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(28, 17);
            this.lbLogin.Text = "Szef";
            // 
            // ribbonUpDown1
            // 
            this.ribbonUpDown1.TextBoxText = "";
            this.ribbonUpDown1.TextBoxWidth = 50;
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "ribbonButton2";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Panels.Add(this.ribbonPanel3);
            this.ribbonTab1.Text = "";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.rbConnect);
            this.ribbonPanel1.Items.Add(this.rbConfigDb);
            this.ribbonPanel1.Text = "Serwer";
            // 
            // rbConnect
            // 
            this.rbConnect.Image = ((System.Drawing.Image)(resources.GetObject("rbConnect.Image")));
            this.rbConnect.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbConnect.SmallImage")));
            this.rbConnect.Text = "Odśwież";
            this.rbConnect.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbConnect.Click += new System.EventHandler(this.ribbonButton6_Click);
            // 
            // rbConfigDb
            // 
            this.rbConfigDb.Image = ((System.Drawing.Image)(resources.GetObject("rbConfigDb.Image")));
            this.rbConfigDb.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbConfigDb.SmallImage")));
            this.rbConfigDb.Text = "Konfiguracja";
            this.rbConfigDb.Click += new System.EventHandler(this.rbKongiguruj_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.rbGeneruj);
            this.ribbonPanel2.Items.Add(this.rbZapiszRekord);
            this.ribbonPanel2.Text = "Opcje";
            // 
            // rbGeneruj
            // 
            this.rbGeneruj.DropDownItems.Add(this.ribbonButton6);
            this.rbGeneruj.Image = ((System.Drawing.Image)(resources.GetObject("rbGeneruj.Image")));
            this.rbGeneruj.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbGeneruj.SmallImage")));
            this.rbGeneruj.Text = "Generuj kod";
            this.rbGeneruj.Click += new System.EventHandler(this.rbGeneruj_Click);
            // 
            // ribbonButton6
            // 
            this.ribbonButton6.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.Image")));
            this.ribbonButton6.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.SmallImage")));
            this.ribbonButton6.Text = "ribbonButton6";
            // 
            // rbZapiszRekord
            // 
            this.rbZapiszRekord.Image = ((System.Drawing.Image)(resources.GetObject("rbZapiszRekord.Image")));
            this.rbZapiszRekord.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbZapiszRekord.SmallImage")));
            this.rbZapiszRekord.Text = "Zapisz";
            this.rbZapiszRekord.Click += new System.EventHandler(this.rbZapiszRekord_Click);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.rbTextBoxProducent);
            this.ribbonPanel3.Items.Add(this.rbTextBoxPrefix);
            this.ribbonPanel3.Items.Add(this.rbButtonZatwierdz);
            this.ribbonPanel3.Text = "Spodób generowania kodu EAN";
            // 
            // rbTextBoxProducent
            // 
            this.rbTextBoxProducent.Text = "Kod producenta";
            this.rbTextBoxProducent.TextBoxText = "";
            // 
            // rbTextBoxPrefix
            // 
            this.rbTextBoxPrefix.Text = "Prefix kraju";
            this.rbTextBoxPrefix.TextBoxText = "";
            this.rbTextBoxPrefix.Click += new System.EventHandler(this.rbButtonZatwierdz_Click);
            // 
            // rbButtonZatwierdz
            // 
            this.rbButtonZatwierdz.DropDownItems.Add(this.ribbonLabel3);
            this.rbButtonZatwierdz.Image = ((System.Drawing.Image)(resources.GetObject("rbButtonZatwierdz.Image")));
            this.rbButtonZatwierdz.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbButtonZatwierdz.SmallImage")));
            this.rbButtonZatwierdz.Text = "Zatwierdź";
            this.rbButtonZatwierdz.Click += new System.EventHandler(this.rbButtonZatwierdz_Click);
            // 
            // ribbonLabel3
            // 
            this.ribbonLabel3.Text = "ribbonLabel3";
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.Image")));
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.Image")));
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.Image")));
            this.ribbonButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.SmallImage")));
            // 
            // tw__TowarTableAdapter
            // 
            this.tw__TowarTableAdapter.ClearBeforeFill = true;
            // 
            // ribbon1
            // 
            this.ribbon1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbon1.CaptionBarVisible = false;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.Items.Add(this.ribbonButton1);
            this.ribbon1.QuickAcessToolbar.Items.Add(this.ribbonButton2);
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(616, 110);
            this.ribbon1.TabIndex = 6;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 0);
            this.ribbon1.Text = "Plik";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // ribbonLabel4
            // 
            this.ribbonLabel4.Text = "ribbonLabel4";
            this.ribbonLabel4.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 411);
            this.Controls.Add(this.ribbon1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twTowarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEST_CIAPODataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbLogin;
        private System.Windows.Forms.RibbonUpDown ribbonUpDown1;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.RibbonButton ribbonButton5;
        private System.Windows.Forms.RibbonButton rbConnect;
        private System.Windows.Forms.RibbonButton rbGeneruj;
        private TEST_CIAPODataSet tEST_CIAPODataSet;
        private System.Windows.Forms.BindingSource twTowarBindingSource;
        private TEST_CIAPODataSetTableAdapters.tw__TowarTableAdapter tw__TowarTableAdapter;
        private System.Windows.Forms.RibbonButton ribbonButton6;
        private System.Windows.Forms.RibbonButton rbZapiszRekord;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonTextBox rbTextBoxProducent;
        private System.Windows.Forms.RibbonTextBox rbTextBoxPrefix;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonLabel ribbonLabel4;
        private System.Windows.Forms.RibbonButton rbConfigDb;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn twIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn twNazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn twPodstKodKreskDataGridViewTextBoxColumn;
        private System.Windows.Forms.RibbonButton rbButtonZatwierdz;
        private System.Windows.Forms.RibbonLabel ribbonLabel3;
    }
}


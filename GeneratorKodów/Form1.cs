using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratorKodów
{

    public partial class Form1 : Form
    {
        jodb baza = null;
        Generator generowanie = null;
        List<ZakresKodu> prefix = new List<ZakresKodu>();
        List<ZakresKodu> producent = new List<ZakresKodu>();
        public String id;
        public String pass;
        public String server;
        public String dataBase;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(String nId, String nPass, String nServer, String nDataBase)
        {
            InitializeComponent();
            id = nId;
            pass = nPass;
            server = nServer;
            dataBase = nDataBase;
            baza = new jodb(id, pass, server, dataBase);
        }

       private void ribbonButton6_Click(object sender, EventArgs e)
        {
            //baza = new jodb(id, pass, server, dataBase);

            //baza = new jodb("sa", "adam", "localhost\\insertgt", "TEST_CIAPO");
            dataGridView1.DataSource
                = baza.pobierzDane("SELECT tw_Id, tw_Masa, tw_Nazwa, tw_PodstKodKresk from tw__Towar");

        }

        private void rbGeneruj_Click(object sender, EventArgs e)
        {
            System.Random kod = new Random(DateTime.Now.Millisecond);
            dataGridView1.EndEdit();
            generowanie = new Generator();
            ZakresKodu oPrefix = prefix[0];
            String zPrefix = oPrefix.wartosc;
            ZakresKodu oKodProducenta = producent[0];
            String kodProducenta = oKodProducenta.wartosc;
            //int x = 0;
            Licznik licznik;

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                int x = Licznik.LICZNIK;
                String kodProduktu = generowanie.zwróćZera(x.ToString());
                String cyfraKontrolna = generowanie.generujCyfręKontrolną(zPrefix, kodProducenta, kodProduktu);
                DataGridViewCell cb = r.Cells[0];
                //DataGridViewCell id = r.Cells[1];
                DataGridViewCell cellKod = r.Cells[3];

                if (cb.Value != null && (bool)cb.Value)
                {
                    cellKod.Value = zPrefix + kodProducenta + kodProduktu + cyfraKontrolna;
                    licznik = new Licznik();
                    //x++;
                    // cellKod.Value = zPrefix + kodProducenta + kodProduktu + cyfraKontrolna;
                }
               
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tEST_CIAPODataSet.tw__Towar' table. You can move, or remove it, as needed.
            //this.tw__TowarTableAdapter.Fill(this.tEST_CIAPODataSet.tw__Towar);

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rbZapiszRekord_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                DataGridViewCell id = r.Cells[1];
                DataGridViewCell cellKod = r.Cells[3];
                baza.ZapiszDane((int)id.Value, (string)cellKod.Value);
            }

            MessageBox.Show("Dodano nowe kody do bazy danych");
        }

        private void rbButtonZatwierdz_Click(object sender, EventArgs e)
        {
            prefix.Clear();
            prefix.Add(new ZakresKodu(rbTextBoxPrefix.TextBoxText));
            producent.Clear();
            producent.Add(new ZakresKodu(rbTextBoxProducent.TextBoxText));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbKongiguruj_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}

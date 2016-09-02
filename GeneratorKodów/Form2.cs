using System;
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
    public partial class Form2 : Form
    {
        public string Db { get; set; }
        public string Server { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }

        public Form2()
        {
            InitializeComponent();
            
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            User = tbId.Text;
            Pass = tbPass.Text;
            Server = tbServer.Text;
            Db = tbDb.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

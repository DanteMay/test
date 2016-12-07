using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kundenakquise
{
    public partial class btnsafe : Form
    {
        public btnsafe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            tbid.ReadOnly = false;
            tbnachname.ReadOnly = false;
            tbvorname.ReadOnly = false;
            tag.ReadOnly = false;
            monat.ReadOnly = false;
            jahr.ReadOnly = false;
            tbadresse.ReadOnly = false;
            tbplz.ReadOnly = false;
            tbort.ReadOnly = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.kundeBindingSource.EndEdit();
                this.kundeTableAdapter.Update(this.datenbank1DataSet.Kunde);
                this.kundeTableAdapter.Fill(this.datenbank1DataSet.Kunde);
                MessageBox.Show("Erfolgreich");
                datenbank1DataSet.AcceptChanges();
            }
            catch
            {
                MessageBox.Show("nicht erfolgreich!");
            }



            button2.Enabled = false;
            tbid.ReadOnly = true;
            tbnachname.ReadOnly = true;
            tbvorname.ReadOnly = true;
            tag.ReadOnly = false;
            monat.ReadOnly = false;
            jahr.ReadOnly = false;
            tbadresse.ReadOnly = true;
            tbort.ReadOnly = true;
            tbplz.ReadOnly = true;
        }

        private void btnsafe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datenbank1DataSet1.IBAN' table. You can move, or remove it, as needed.
            this.iBANTableAdapter.Fill(this.datenbank1DataSet1.IBAN);
            // TODO: This line of code loads data into the 'datenbank1DataSet.Bank' table. You can move, or remove it, as needed.
            this.bankTableAdapter.Fill(this.datenbank1DataSet.Bank);
            // TODO: This line of code loads data into the 'datenbank1DataSet.Kunde' table. You can move, or remove it, as needed.
            this.kundeTableAdapter.Fill(this.datenbank1DataSet.Kunde);
           
           
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}

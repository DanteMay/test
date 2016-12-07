using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kundenakquise
{
    public partial class Form1 : Form
    {
        private OleDbConnection con;
        private OleDbCommand test;
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datenbank1DataSet.Ärzte' table. You can move, or remove it, as needed.
            this.ärzteTableAdapter.Fill(this.datenbank1DataSet.Ärzte);
            // TODO: This line of code loads data into the 'datenbank1DataSet.Kunde' table. You can move, or remove it, as needed.
            this.kundeTableAdapter.Fill(this.datenbank1DataSet.Kunde);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Searchinput_Click(object sender, EventArgs e)
        {
            searchinput.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            int index = listBox1.FindString(searchinput.Text);
            listBox1.SelectedIndex = index;
        }

       

        private void btnsearch_Click(object sender, EventArgs e)
        {
            
           

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string combo = comboBox1.SelectedItem.ToString();
            if (combo == "Nach Kunden suchen:")
            { 
                label2.Text = "Name";
                label3.Text = "Vorname";
                listBox1.DataSource = kundeBindingSource;
                listBox1.DisplayMember = "KNachname";
                listBox2.DataSource = kundeBindingSource;
                listBox2.DisplayMember = "KVorname";
                listBox3.DataSource = kundeBindingSource;
                listBox3.DisplayMember = "KAdresse";
                listBox3.Visible = true;
                label4.Visible = true;

            }
            else
            {

                label2.Text = "Abteilung";
                label3.Text = "Name";
                listBox1.DataSource = ärzteBindingSource;
                listBox1.DisplayMember = "Arzt";
                listBox2.DataSource = ärzteBindingSource;
                listBox2.DisplayMember = "Straße";
                listBox3.Visible = false;
                label4.Visible = false;

            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            btnsafe edit = new btnsafe();
            edit.Show();
        }

        private void btnaddcustomer_Click(object sender, EventArgs e)
        {
            string connect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Datenbank1.accdb";
            con = new OleDbConnection(connect);
            con.Open();
            test = con.CreateCommand();
            test.CommandText = "insert into test(Vorname) values(Dragonil)";
            test.ExecuteNonQuery();
            con.Close();
            /*string query = "Select * from data";
            dAdapter = new OleDbDataAdapter(query, connect);
            OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(dAdapter);
            DataGridTableStyle = new DataTable();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dTable;
            tbtest.DataSource = bSource;*/
        }
    }   
}

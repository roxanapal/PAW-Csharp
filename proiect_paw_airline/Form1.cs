using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

// Tema 32 - Airline

namespace proiect_paw_airline
{
    public partial class Form1 : Form
    {
        ArrayList listaRute = new ArrayList();
        OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Facultate\Ale mele\An 2\SEMESTRUL 2\PAW\ProiectPawPal\proiect_paw_airline\proiect_paw_airline\BazaDeDate1.accdb;
Persist Security Info=False;";
        }

        private void btn_adaugaRuta_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into rute (ID_Ruta,Nr_zbor,Nr_locuri,Oras_Plecare,Tara_Plecare,Oras_destinatie,Tara_destinatie,Ora_plecare,Ora_sosire) values ("+
                    tb_idRuta.Text + "," + tb_nrZbor.Text + "," + tb_nrLocuri.Text + ",'" + tb_orasPlecare.Text + "','" + tb_taraPlecare.Text + "','" + tb_orasDestinatie.Text + "','" + tb_taraDestinatie.Text +
                    "','" + tb_oraPlecare.Text + "','" + tb_oraSosire.Text + "')";

                command.ExecuteNonQuery();
                MessageBox.Show("Salvat in BD");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            
            int id = Convert.ToInt32(tb_idRuta.Text);
            int nrZbor = Convert.ToInt32(tb_nrZbor.Text);
            int nrLocuri = Convert.ToInt32(tb_nrLocuri.Text);
            string orasP = tb_orasPlecare.Text;
            string taraP = tb_taraPlecare.Text;
            string oraP = tb_oraPlecare.Text;
            string orasD = tb_orasDestinatie.Text;
            string taraD = tb_taraDestinatie.Text;
            string oraD = tb_oraSosire.Text;
            Ruta r = new Ruta(id, nrZbor, nrLocuri, orasP, taraP, oraP, orasD, taraD, oraD);

            listaRute.Add(r);

            //ListViewItem ruta = new ListViewItem(tb_idRuta.Text);
            //ruta.SubItems.Add(tb_nrZbor.Text);
            //ruta.SubItems.Add(tb_nrLocuri.Text);
            //ruta.SubItems.Add(tb_orasPlecare.Text);
            //ruta.SubItems.Add(tb_taraPlecare.Text);
            //ruta.SubItems.Add(tb_oraPlecare.Text);
            //ruta.SubItems.Add(tb_orasDestinatie.Text);
            //ruta.SubItems.Add(tb_taraDestinatie.Text);
            //ruta.SubItems.Add(tb_oraSosire.Text);
            //listview_rute.Items.Add(ruta);

            tb_idRuta.Clear(); tb_nrZbor.Clear(); tb_nrLocuri.Clear();
            tb_orasPlecare.Clear(); tb_taraPlecare.Clear(); tb_oraPlecare.Clear();
            tb_orasDestinatie.Clear(); tb_taraDestinatie.Clear(); tb_oraSosire.Clear();

            connection.Open();
            OleDbCommand command2 = new OleDbCommand();
            command2.Connection = connection;
            command2.CommandText = "select * from rute";

            OleDbDataAdapter da = new OleDbDataAdapter(command2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewRute.DataSource = dt;
            connection.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_printare_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Arial", 12);
            float fontH = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offSet = 40;

            graphic.DrawString("Printeaza tabelul", new Font("Arial", 18), new SolidBrush(Color.Black), startX, startY);
        }

        private void btn_restaurare_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from rute";

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewRute.DataSource = dt;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }


    }
}

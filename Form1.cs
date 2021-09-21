using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Rezervasyon
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider = Microsoft.ACE.Oledb.12.0; Data Source =" + Application.StartupPath + @"/db.accdb");
            da = new OleDbDataAdapter("Select fNumber AS Flight_Number , fromm AS Nereden , too AS Nereye from flights where fDate='" + DateTime.Today.ToShortDateString() + "' ", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "flights");
            gridControl2.DataSource = ds.Tables["flights"];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fli = new addFlight();
            fli.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(date.Text!="" && from.Text != "" && to.Text != "")
            {
            da = new OleDbDataAdapter("Select * from flights where fDate='"+date.Text+"' AND fromm='"+from.Text+ "' AND too='" +to.Text + "' ", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "flights");
            gridControl1.DataSource = ds.Tables["flights"];
            con.Close();
            }
            else if(date.Text != "" && from.Text == "" && to.Text != "")
            {
                da = new OleDbDataAdapter("Select * from flights where fDate='" + date.Text + "' AND too='" + to.Text + "' ", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "flights");
                gridControl1.DataSource = ds.Tables["flights"];
                con.Close();
            }
            else if (date.Text != "" && from.Text != "" && to.Text == "")
            {
                da = new OleDbDataAdapter("Select * from flights where fDate='" + date.Text + "' AND fromm='" + from.Text + "' ", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "flights");
                gridControl1.DataSource = ds.Tables["flights"];
                con.Close();
            }
            else if (date.Text == "" && from.Text != "" && to.Text != "")
            {
                da = new OleDbDataAdapter("Select * from flights where fromm='" + from.Text + "' AND too='" + to.Text + "' ", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "flights");
                gridControl1.DataSource = ds.Tables["flights"];
                con.Close();
            }
            else if (date.Text != "" && from.Text == "" && to.Text == "")
            {
                da = new OleDbDataAdapter("Select * from flights where fDate='" + date.Text + "' ", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "flights");
                gridControl1.DataSource = ds.Tables["flights"];
                con.Close();
            }
            else
            {
                MessageBox.Show("Arama Kriterlerini Kontrol Ediniz");
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Form fli = new flight(gridView1.GetFocusedRowCellValue("fNumber").ToString());
            fli.Show();
         

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }
    }
}

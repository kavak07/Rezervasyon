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
    public partial class addFlight : DevExpress.XtraEditors.XtraForm
    {

        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;


        public addFlight()
        {
            InitializeComponent();
        }


        private void addFlight_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider = Microsoft.ACE.Oledb.12.0; Data Source ="+Application.StartupPath+@"/db.accdb");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into flights(fNumber,fDate,estTime,totalTime,fromm,too) values('"+flightNumber.Text+ "','" + date.Text + "','" +estTime.Text + "','" + time.Text + "','" + from.Text + "','" + to.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Uçuş Kaydedildi");
            flightNumber.Text = "";
            date.Text = "";
            estTime.Text = "01:00";
            time.Text = "0";
            from.Text = "Seçiniz";
            to.Text = "Seçiniz";
        }
    }
}

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
using DevExpress.XtraEditors;
namespace Rezervasyon
{

    public partial class flight : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;

        void getir()
        {
            con.Open();
            da = new OleDbDataAdapter("select identidy AS Kimlik , pname AS Name , psurname AS Surname , seat  AS Koltuk , gender AS Gender , phonenumber AS Phone from reservations where fNumber='" + flightId + "'", con);
            ds = new DataSet();
            da.Fill(ds, "reservations");
            gridControl1.DataSource = ds.Tables["reservations"];
            cmd.Connection = con;
            cmd.CommandText = "select * from reservations where fNumber='" + flightId + "'";
            OleDbDataReader dr = cmd.ExecuteReader();
            var x = groupControl1.Controls.OfType<SimpleButton>().Select(f => f.Name).ToArray();

            while (dr.Read())
            {

                if (x.Contains(dr["seat"].ToString()))
                {

                    if (dr["gender"].ToString() == "M")
                    {
                        ((SimpleButton)groupControl1.Controls[dr["seat"].ToString()]).Appearance.BackColor = Color.Blue;
                    }
                    else if (dr["gender"].ToString() == "F")
                    {
                        ((SimpleButton)groupControl1.Controls[dr["seat"].ToString()]).Appearance.BackColor = Color.Pink;
                    }
                   
                }

            }
            con.Close();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select count(*) AS total from reservations where fNumber='" + flightId + "'";
            OleDbDataReader dr3 = cmd.ExecuteReader();
            while (dr3.Read())
            {
                total.Text="TOPLAM " + dr3["total"].ToString() + " YOLCU " ;
            }
            con.Close();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select count(*) AS totalw from reservations where fNumber='" + flightId + "' AND gender='F' ";
            OleDbDataReader dr4 = cmd.ExecuteReader();
            while (dr4.Read())
            {
                kadin.Text = dr4["totalw"].ToString() + " KADIN";
            }
            con.Close();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select count(*) AS totalm from reservations where fNumber='" + flightId + "' AND gender='M' ";
            OleDbDataReader dr5 = cmd.ExecuteReader();
            while (dr5.Read())
            {
                erkek.Text = dr5["totalm"].ToString() + " ERKEK ";
            }
            con.Close();

        }
        string flightId;
        public flight(string fid)
        {
            InitializeComponent();
            flightId = fid;
            cmd = new OleDbCommand();
            con = new OleDbConnection("Provider = Microsoft.ACE.Oledb.12.0; Data Source =" + Application.StartupPath + @"/db.accdb");
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from flights where fNumber='" + flightId + "'";
           
            OleDbDataReader dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                flightNumber.Text = dr2["fNumber"].ToString();
                date.Text = dr2["fDate"].ToString();
                estimated.Text = dr2["estTime"].ToString();
                flightTime.Text = dr2["totalTime"].ToString() + " DK";
                from.Text= dr2["fromm"].ToString();
                to.Text = dr2["too"].ToString();
                this.Text = "FLIGHT RESERVATION PAGE [ FLIGHT " + flightNumber.Text+" FROM "+from.Text+" TO "+ to.Text + " ]";
            }
            con.Close();
            getir();
           
        }

        private void flight_Load(object sender, EventArgs e)
        {
           
        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void a25_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (sender as SimpleButton);
            if(btn.Appearance.BackColor==Color.Blue || btn.Appearance.BackColor == Color.Pink)
            {
                MessageBox.Show("BU KOLTUK DOLU");
            }
            else
            {
                string yanKoltuk, SubString = btn.Name.Substring(0, 1);
                if (SubString == "a")
                {
                    yanKoltuk = btn.Name.Replace("a", "b");

                    if(((SimpleButton)groupControl1.Controls[yanKoltuk]).Appearance.BackColor == Color.Pink && gender.Text=="ERKEK")
                    {
                        MessageBox.Show("KADIN YOLCU BULUNAN KOLTUKLARA YİNE KADIN YOLCU OTURABİLİR");
                    }
                    else if (((SimpleButton)groupControl1.Controls[yanKoltuk]).Appearance.BackColor == Color.Blue && gender.Text == "KADIN")
                    {
                        MessageBox.Show("ERKEK YOLCU BULUNAN KOLTUKLARA YİNE ERKEK YOLCU OTURABİLİR");
                    }
                    else
                    {
                        if (check.Checked == true)
                        {
                            seatView.Text = btn.Name;
                        }
                        else
                        {
                            seat.Text = btn.Name;
                        }
                      
                    }
                }
                else if (SubString == "b")
                {
                    yanKoltuk = btn.Name.Replace("b", "a");
                    if (((SimpleButton)groupControl1.Controls[yanKoltuk]).Appearance.BackColor == Color.Pink && gender.Text == "ERKEK")
                    {
                        MessageBox.Show("KADIN YOLCU BULUNAN KOLTUKLARA YİNE KADIN YOLCU OTURABİLİR");
                    }
                    else if (((SimpleButton)groupControl1.Controls[yanKoltuk]).Appearance.BackColor == Color.Blue && gender.Text == "KADIN")
                    {
                        MessageBox.Show("ERKEK YOLCU BULUNAN KOLTUKLARA YİNE ERKEK YOLCU OTURABİLİR");
                    }
                    else
                    {
                        if (check.Checked == true)
                        {
                            seatView.Text = btn.Name;
                        }
                        else
                        {
                            seat.Text = btn.Name;
                        }
                    }
                }
                else if (SubString == "c")
                {
                    yanKoltuk = btn.Name.Replace("c", "d");
                    if (((SimpleButton)groupControl1.Controls[yanKoltuk]).Appearance.BackColor == Color.Pink && gender.Text == "ERKEK")
                    {
                        MessageBox.Show("KADIN YOLCU BULUNAN KOLTUKLARA YİNE KADIN YOLCU OTURABİLİR");
                    }
                    else if (((SimpleButton)groupControl1.Controls[yanKoltuk]).Appearance.BackColor == Color.Blue && gender.Text == "KADIN")
                    {
                        MessageBox.Show("ERKEK YOLCU BULUNAN KOLTUKLARA YİNE ERKEK YOLCU OTURABİLİR");
                    }
                    else
                    {
                        if (check.Checked == true)
                        {
                            seatView.Text = btn.Name;
                        }
                        else
                        {
                            seat.Text = btn.Name;
                        }
                    }
                }
                else if (SubString == "d")
                {
                    yanKoltuk = btn.Name.Replace("d", "c");
                    if (((SimpleButton)groupControl1.Controls[yanKoltuk]).Appearance.BackColor == Color.Pink && gender.Text == "ERKEK")
                    {
                        MessageBox.Show("KADIN YOLCU BULUNAN KOLTUKLARA YİNE KADIN YOLCU OTURABİLİR");
                    }
                    else if (((SimpleButton)groupControl1.Controls[yanKoltuk]).Appearance.BackColor == Color.Blue && gender.Text == "KADIN")
                    {
                        MessageBox.Show("ERKEK YOLCU BULUNAN KOLTUKLARA YİNE ERKEK YOLCU OTURABİLİR");
                    }
                    else
                    {
                        if (check.Checked == true)
                        {
                            seatView.Text = btn.Name;
                        }
                        else
                        {
                            seat.Text = btn.Name;
                        }
                    }
                }

               
                
            }
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try {
            if (gender.Text == "ERKEK")
            {
                gender.Text = "M";
            }
            else
            {
                gender.Text = "F";
            }

            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into reservations(fNumber,pname,psurname,identidy,phonenumber,gender,seat) values('" + flightNumber.Text + "','" + name.Text + "','" + sname.Text + "','" + kimlik.Text + "','" + phone.Text + "','" + gender.Text + "','"+seat.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kişi Kaydedildi");
            getir();

            gender.Text = "ERKEK";
            name.Text = "";
            sname.Text = "";
            phone.Text = "";
            kimlik.Text = "";
            seat.Text = "";
            }
            catch
            {
                MessageBox.Show("Eksik Alan  yada Yolcu Zaten Mevcut");
                gender.Text = "ERKEK";
                name.Text = "";
                sname.Text = "";
                phone.Text = "";
                kimlik.Text = "";
                seat.Text = "";
            }



        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (textEdit1.Text != "") {
            con.Open();
            da = new OleDbDataAdapter("select identidy AS Kimlik , pname AS Name , psurname AS Surname , seat  AS Koltuk , gender AS Gender , phonenumber AS Phone from reservations where fNumber='" + flightId + "' AND identidy LIKE '"+textEdit1.Text+"%'", con);
            ds = new DataSet();
            da.Fill(ds, "reservations");
            gridControl1.DataSource = ds.Tables["reservations"];
                con.Close();
            }
            else
            {
                con.Open();
                da = new OleDbDataAdapter("select identidy AS Kimlik , pname AS Name , psurname AS Surname , seat  AS Koltuk , gender AS Gender , phonenumber AS Phone from reservations where fNumber='" + flightId + "'", con);
                ds = new DataSet();
                da.Fill(ds, "reservations");
                gridControl1.DataSource = ds.Tables["reservations"];
                con.Close();

            }

        }

        public string seatMemory;
        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                idView.Text = gridView1.GetFocusedRowCellValue("Kimlik").ToString();
                nameView.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
                snameView.Text = gridView1.GetFocusedRowCellValue("Surname").ToString();
                seatView.Text = gridView1.GetFocusedRowCellValue("Koltuk").ToString();
                genderView.Text = gridView1.GetFocusedRowCellValue("Gender").ToString();
                mobilePhoneView.Text = gridView1.GetFocusedRowCellValue("Phone").ToString();
                seatMemory = gridView1.GetFocusedRowCellValue("Koltuk").ToString();
            }
            catch
            {
               
            }
         
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (check.Checked == true)
            {
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "update reservations set seat = '" + seatView.Text + "' where identidy='" + idView.Text + "' AND fNumber='" + flightId + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                getir();
                check.Checked = false;
                ((SimpleButton)groupControl1.Controls[seatMemory]).Appearance.BackColor = Color.SeaGreen;
                MessageBox.Show("Koltuk Güncellendi");
            }
            else
            {
                MessageBox.Show("Güncellemek için kutucuğu işaretleyin.");
            }
          
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from reservations where identidy='" + idView.Text + "' AND fNumber='" + flightId + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            getir();
            ((SimpleButton)groupControl1.Controls[seatMemory]).Appearance.BackColor = Color.SeaGreen;
            MessageBox.Show("Silindi");
        }
    }
}

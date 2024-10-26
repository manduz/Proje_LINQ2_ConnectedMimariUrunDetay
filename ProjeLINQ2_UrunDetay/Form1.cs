using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeLINQ2_UrunDetay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sql = new SqlConnection("Data Source=DESKTOP-CU1M14V\\SQLKODLAB;Initial Catalog=sqlexample1;Integrated Security=True;Encrypt=False");
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM Categories",sql);
            //komut ile kategorileri okuyoruz

            sql.Open();
            SqlDataReader okuyucu = komut.ExecuteReader();
            //combobox ın tuttuğu değer
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";

            List<Category> list = new List<Category>();
            while (okuyucu.Read())
            {
                //database den okuduğu herbir elemanı category clasını new leyip category klasına atayacak
                Category c = new Category();
                c.CategoryID = (int)okuyucu["CategoryID"];
                c.CategoryName = okuyucu["CategoryName"].ToString();
                list.Add(c);//listeye ekledik
            }
            sql.Close();
            comboBox1.DataSource = list;



        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            //comboBox1.ValueMember bu deger secilenID'ye eşit demektir
            var secilenID = comboBox1.SelectedValue;
            sql.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where CategoryID = " + secilenID,sql);
            SqlDataReader okuyucu = cmd.ExecuteReader();
            //okuyucu artık verdiğim komutu okuyacak getirecek
            //butonla getirebilmesi için buton oluşturuyorum

            while (okuyucu.Read())
            {
                Button buton = new Button();
                buton.Name = "b" + okuyucu["ProductID"];
                buton.Height = 50;
                buton.AutoSize = true;//tam sığdıracak
                buton.Text = okuyucu["ProductName"].ToString();

                flowLayoutPanel1.Controls.Add(buton);

                buton.Click += UrunDetayGetir;

            }
            sql.Close();
        }
        private void UrunDetayGetir(object tiklanilan, EventArgs tikDetay)
        {
            Button tiklanilanButton = (Button)tiklanilan;
            var IDtxt = tiklanilanButton.Name.Remove(0, 1);

            sql.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where ProductID="+ IDtxt,sql);
            SqlDataReader okuyucu = cmd.ExecuteReader();
            okuyucu.Read();
            UrunDetay detay = new UrunDetay();
            detay.label_UrunAdi.Text = okuyucu["ProductName"].ToString();
            detay.label3_qpu.Text = okuyucu["QuantityPerUnit"].ToString();
            detay.Show();
            sql.Close();

        }
    }
}

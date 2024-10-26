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

        
    }
}

using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace SimpleSQLConApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string ConnString = "Data Source=DESKTOP-TNTQ7TC\\SQLEXPRESS;Initial Catalog=FlashCardDB;Integrated Security=True;Pooling=False;Encrypt=False";

                ////"Data Source=DESKTOP - TNTQ7TC\\SQLEXPRESS; Initial Catalog=FlashCardDB; trusted_connection=true; Encrypted=False";
                //Data Source=DESKTOP-TNTQ7TC\SQLEXPRESS;Initial Catalog=FlashCardDB;Integrated Security=True;Pooling=False


            // ConnString = ConnString + "Integrated Security";Encrypt=False";
            // 

            SqlConnection con = new SqlConnection(ConnString);
            con.Open();

            textBox1.Text = "Connected";

            //DESKTOP-TNTQ7TC\SQLEXPRESS

        }
    }
}
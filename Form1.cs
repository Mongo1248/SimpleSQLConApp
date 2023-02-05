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
            string ConnString = "Date Source = DESKTOP-TNTQ7TC\\SQLEXPRESS, Initial Catelog = FlashCardDB ";
            ConnString = ConnString + "Integrated Security, Encrypted = False";

           // SqlConnection con = new SqlConnection(ConnString);

        }
    }
}
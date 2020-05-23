using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _5_16
{
    public partial class listBox : Form
    {
        static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=namishop;";
        static string query = "SELECT * FROM admin";
        static MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
        public listBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             txtResult.Text = lstBox.GetItemText(lstBox.SelectedItem);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySql;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ADO
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection connection;
        public MainWindow()
        {
            InitializeComponent();
            this.Close();
            SqlConnectionStringBuilder s = new SqlConnectionStringBuilder()
            {
                DataSource = @"(localdb)\MSSQLLocalDB",
                InitialCatalog = "SQLDb",
                IntegratedSecurity = true,
                Pooling = false
            };

            connection = new SqlConnection(s.ConnectionString);
            connection.Open();

            var sql = Properties.Resources.SQLScript;
            MessageBox.Show(sql);
            SqlCommand a = new SqlCommand(sql, connection);
            //a.ExecuteReader();
        }
    }
}

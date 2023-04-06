using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using WpfApp1;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }




        private void Login_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC14\LOCALHOST; Initial Catalog=SuperSuperSQL; Integrated Security=True");
            try
            {
                if (sqlCon.State == System.Data.ConnectionState.Closed)
                    sqlCon.Open();
                string query = "SELECT COUNT(1) FROM SuperSuperSQL2 Where txtFirstName=@txtFirstName and txtPasswordBox=@txtPasswordBox";

                SqlCommand sqlCommand = new SqlCommand(query, sqlCon);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@txtFirstName", User.Text);
                sqlCommand.Parameters.AddWithValue("@txtPasswordBox", txtPass.Password);
                int count = Convert.ToInt32(sqlCommand.ExecuteScalar()); //returns the first record in the first row and the first column of your database
                object result = sqlCommand.ExecuteScalar();
                if (result.ToString() == "0")
                {
                    MessageBox.Show("No match between the username and the password");
                }
                else {
                    WAfterSignUpLogIn Page4 = new WAfterSignUpLogIn();
                    Page4.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close(); // close the connection to the database
            }
        }


        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            SignUp2 Page3 = new SignUp2();
            Page3.Show();
            this.Close();
        }
    }
}

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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp2 : Window
    {
        public SignUp2()
        {
            InitializeComponent();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {

            //we establish the connection to the db
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC14\LOCALHOST; Initial Catalog=SuperSuperSQL; Integrated Security=True");
            try
            {
                //open connection to the db
                if (Pass2.Password == Pass.Password)
                {
                    if (Email.Text.Contains("@")) {
                        sqlCon.Open();
                        string query = "Insert into SuperSuperSQL2 (txtFirstName, Email, txtCompany, txtPasswordBox) values ('" + this.User.Text + "','" + this.Email.Text + "','" + this.Company.Text + "', '" + this.Pass.Password + "')";
                        SqlCommand cmd = new SqlCommand(query, sqlCon);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully created a account!");
                        WAfterSignUpLogIn w1 = new WAfterSignUpLogIn();
                        w1.Show();
                        this.Close(); }
                    else { MessageBox.Show("The email is not correct."); }
                }
                else {
                    MessageBox.Show("The two passwords do not match.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Page1 = new MainWindow();
            Page1.Show();
            this.Close();
        }
    }
}

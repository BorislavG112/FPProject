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
    /// Interaction logic for WWWWEditAccount.xaml
    /// </summary>
    public partial class WWWWEditAccount : Window
    {
        public WWWWEditAccount()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            WAfterSignUpLogIn Page1 = new WAfterSignUpLogIn();
            Page1.Show();
            this.Close();
        }
        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void ChangeDetails_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection dbConnection = new SqlConnection(@"Data Source=LABSCIFIPC14\LOCALHOST; Initial Catalog=SuperSuperSQL; Integrated Security=True");
                dbConnection.Open();

                string UPDATE = "update SuperSuperSQL2 set txtFirstName=' " + this.User.Text + " ' , txtCompany= ' " + this.Company.Text + " ' , txtPasswordBox= ' " + this.Pass.Password + " ' where Email='" + this.Email.Text + "' ";
                SqlCommand UPDATE2 = new SqlCommand(UPDATE, dbConnection);
                UPDATE2.ExecuteNonQuery();
                MessageBox.Show("updated successfully");
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

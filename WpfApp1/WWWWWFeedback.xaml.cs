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
    /// Interaction logic for WWWWWFeedback.xaml
    /// </summary>
    public partial class WWWWWFeedback : Window
    {
        public string[] role { get; set; }

        public WWWWWFeedback()
        {
            InitializeComponent();
            role = new string[] { "CEO", "CFO", "employee" };
            DataContext = this;
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
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection dbConnection = new SqlConnection(@"Data Source=LABSCIFIPC14\LOCALHOST; Initial Catalog=SuperSuperSQL; Integrated Security=True");
                dbConnection.Open();
                string ADD = "Insert into Feedback2 (Feedback, Position) values (' " + this.IDEA.Text + "','" + this.Position.SelectedItem + " ')";
                SqlCommand ADD2 = new SqlCommand(ADD, dbConnection);
                ADD2.ExecuteNonQuery();
                MessageBox.Show("added successfully");
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

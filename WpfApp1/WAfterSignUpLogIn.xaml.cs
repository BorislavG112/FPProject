using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for WAfterSignUpLogIn.xaml
    /// </summary>
    public partial class WAfterSignUpLogIn : Window
    {
        //public string User { get; set; }
        public WAfterSignUpLogIn()
        {
            InitializeComponent();
        }

        private void ShareIdeas_Click(object sender, RoutedEventArgs e)
        {
            WWShareIdeas Page3 = new WWShareIdeas();
            Page3.Show();
            this.Close();
        }

        private void ADDIDEAS_Click(object sender, RoutedEventArgs e)
        {
            WWWWEditAccount Page3 = new WWWWEditAccount();
            Page3.Show();
            this.Close();
        }

        private void OurPurpose_Click(object sender, RoutedEventArgs e)
        {
            WWWOurPurpose Page3 = new WWWOurPurpose();
            Page3.Show();
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

        private void Feedback_Click(object sender, RoutedEventArgs e)
        {
            WWWWWFeedback Page3 = new WWWWWFeedback();
            Page3.Show();
            this.Close();
        }
    }
}

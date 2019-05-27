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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_LMS_;

namespace WPF_LMS_.FrontEnd.View
{
    
    /// <summary>
    /// Interaction logic for UCSign.xaml
    /// </summary>
    public partial class UCSign : UserControl
    {
        
        public UCSign()
        {
            InitializeComponent();
        }   

        private void Sign_Click(object sender, RoutedEventArgs e)
        {
            if (usernametxt.Text == "ali" && passwordtxt.Password == "1234" && RBManager.IsChecked == true)
            {
                MessageBox.Show("شما با موفقیت وارد شدید", "Sign in", MessageBoxButton.OK, MessageBoxImage.Information);

                MainWindow win = (MainWindow)Window.GetWindow(this);

                win.main_stack.Children.Remove(win.ucsign);

                win.main_stack.Children.Add(win.ucmanager);


            }
            else
            {
                MessageBox.Show("ERROR !", "Sign in", MessageBoxButton.OK, MessageBoxImage.Error);
                usernametxt.Text = "";
                passwordtxt.Password = "";

            }
            
        }

        
    }
}

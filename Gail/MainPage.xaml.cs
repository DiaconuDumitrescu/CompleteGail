using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Gail
{

    
    public partial class MainPage : PhoneApplicationPage
    {

        public static string pacientName = "";
        public static string pacientSurname = "";
        public static string pacientAge = "";
        public static string pacientEmail = "";
        // Constructor
        public MainPage()
        {
            
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            NavigationService.RemoveBackEntry();
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page3.xaml", UriKind.Relative));
        }

        private void ApplicationBarIconButton_Click_2(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page4.xaml", UriKind.Relative));
        }

        


        
        

        private void ToggleSwitched(object sender, RoutedEventArgs e)
        {

            Microsoft.Phone.Controls.ToggleSwitch ctrl = (Microsoft.Phone.Controls.ToggleSwitch)sender;

            if (ctrl.IsChecked == true)
            {
                ctrl.Content = "Yes";
            }
            else
            {
                ctrl.Content = "No";
            }
        }

       

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int x = Convert.ToInt32(slider1.Value);
            textBox3.Text = x.ToString();
        }

        private void textBox1_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            

        }

        

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

            
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            pacientName = textBox1.Text;
            pacientSurname = textBox2.Text;
            pacientAge = textBox3.Text;
            pacientEmail = textBox4.Text;

            NavigationService.Navigate(new Uri("/Page3.xaml", UriKind.Relative));
        }

        private void textBox4_TextChanged(object sender, TextChangedEventArgs e)
        {

            
        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            textBox1.Text = string.Empty;
            
        }

        private void textBox2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            textBox2.Text = string.Empty;
            

        }

        private void textBox4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            textBox4.Text = string.Empty;
            
        }

        private void textBox1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "name";
        }

        private void textBox2_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBox2.Text == "")
                textBox2.Text = "surname";
        }

        private void textBox4_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBox4.Text == "")
                textBox4.Text = "email";
        }

        
        
    }
}
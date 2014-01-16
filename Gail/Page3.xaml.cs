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
    public partial class Page3 : PhoneApplicationPage
    {

        public static string pacientRace = "";
        public static string pacientProjectionYears = "";
        public static string pacientMenarch = "";
        public static string pacientChildbirth = "";
        public static string varRace = "Choose race";
        public Page3()
        {
            InitializeComponent();
            this.Loaded +=new RoutedEventHandler(Page3_Loaded);
        }

        private void Page3_Loaded ( object sender, RoutedEventArgs e )
        {
           textBlock1.Text = varRace;
        }


        

        
      

        private void textBlock1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.Relative));
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int x = Convert.ToInt32(slider1.Value);
            textBox1.Text = x.ToString();
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int y = Convert.ToInt32(slider2.Value);
            textBox2.Text = y.ToString();
        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void slider3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int z = Convert.ToInt32(slider3.Value);
            textBox3.Text = z.ToString();
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            textBox3.IsEnabled = true;
            slider3.IsEnabled = true;
            pacientChildbirth = textBox3.Text;
        }

        private void checkBox1_Unchecked(object sender, RoutedEventArgs e)
        {
            pacientChildbirth = "NO BIRTHS";
            textBox3.IsEnabled = false;
            slider3.IsEnabled = false;      
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            pacientRace = textBlock1.Text;
            pacientProjectionYears = textBox1.Text;
            pacientMenarch = textBox2.Text;
            pacientChildbirth = textBox3.Text;

            
            NavigationService.Navigate(new Uri("/Page4.xaml", UriKind.Relative));            
        }

        

    }
}
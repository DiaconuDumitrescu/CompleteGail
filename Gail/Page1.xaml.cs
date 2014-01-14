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
using System.Collections.ObjectModel;

namespace Gail
{
    public partial class Page1 : PhoneApplicationPage
    {

        
        public Page1()
        {
            InitializeComponent();
            ListNumber3 = new ObservableCollection<ItemModel3>();
            this.Loaded += new RoutedEventHandler(Page1_Loaded);
        }


        private void Page1_Loaded(object sender, RoutedEventArgs e)
        {
            if (ListNumber3.Count == 0)
            {
                string[] hyperplaciaAnswers = new string[3] { "Unknown", "No", "Yes" };

                foreach (string hyperplaciaAnswer in hyperplaciaAnswers)
                {
                    ListNumber3.Add(new ItemModel3 { Number3 = hyperplaciaAnswer });
                }
            }


            ContentPanel.ItemsSource = Page1.ListNumber3;
        }

        public static ObservableCollection<ItemModel3> ListNumber3 { get; private set; }
        private void ContentPanel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void textBlock1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page4.xaml", UriKind.Relative));
        }

        private void ContentPanel_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ListBox selectedItem = (ListBox)sender;
            ItemModel3 hyperplacia = (ItemModel3)selectedItem.SelectedItem;

            if (hyperplacia != null)
            {
                Page4.varHyperplacia = hyperplacia.Number3.ToString();
                NavigationService.GoBack();

            }
        }
    }
}
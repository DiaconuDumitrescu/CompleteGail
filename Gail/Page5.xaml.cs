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
    public partial class Page5 : PhoneApplicationPage
    {
        public Page5()
        {
            InitializeComponent();
            ListNumber2 = new ObservableCollection<ItemModel2>();
            this.Loaded +=new RoutedEventHandler(Page5_Loaded);
        }


        private void Page5_Loaded(object sender, RoutedEventArgs e)
        {
            if (ListNumber2.Count == 0)
            {
                string[] biopsyAnswers = new string[3] { "Unknown", "No", "Yes"};

                foreach (string biopsyAnswer in biopsyAnswers)
                {
                    ListNumber2.Add(new ItemModel2 { Number2 = biopsyAnswer });
                }
            }


            ContentPanel.ItemsSource = Page5.ListNumber2;
        }

        public static ObservableCollection<ItemModel2> ListNumber2 { get; private set; }
        private void ContentPanel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void textBlock1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page5.xaml", UriKind.Relative));
        }

        private void ContentPanel_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ListBox selectedItem = (ListBox)sender;
            ItemModel2 biopsy = (ItemModel2)selectedItem.SelectedItem;

            if (biopsy != null)
            {
                Page4.varBiopsy = biopsy.Number2.ToString();
                NavigationService.GoBack();

            }
        }
    }
}
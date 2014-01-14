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
    public partial class Page2 : PhoneApplicationPage
    {
        public Page2()
        {
            InitializeComponent();
            ListNumber = new ObservableCollection<ItemModel>();
            this.Loaded +=new RoutedEventHandler(Page2_Loaded);
        }

        private void Page2_Loaded(object sender, RoutedEventArgs e)
        {
            if (ListNumber.Count == 0)
            {
                string[] races = new string[9] { "White", "Black", "Hispanic", "Chinese", "Japanese", "Philipino", "Hawaiian", "Oceanic", "Other/Asian - American" };

                foreach (string raceType in races)
                {
                    ListNumber.Add(new ItemModel { Number = raceType });
                }
            }

            
            ContentPanel.ItemsSource = Page2.ListNumber;
        }

        public static ObservableCollection<ItemModel> ListNumber {get; private set;}

        private void ContentPanel_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ListBox selectedItem = (ListBox)sender;
            ItemModel race = (ItemModel)selectedItem.SelectedItem;

            if (race != null)
            {
                Page3.varRace = race.Number.ToString();
                NavigationService.GoBack();
                
            }
        }
       

        
        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
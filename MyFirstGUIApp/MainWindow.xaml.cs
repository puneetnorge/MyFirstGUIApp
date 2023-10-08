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

namespace MyFirstGUIApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_click_handler(object sender, RoutedEventArgs e)
        {
            EnteredText.Text = "Start Button Clicked";
        }

        private void EndButton_click_handler(object sender, RoutedEventArgs e)
        {
            EnteredText.Text = "End Button Clicked";            
        }
        private void SelectionChangedHandler(object sender, SelectionChangedEventArgs e)
        {

            // Treat sender as Listbox
            ListBox lbox = sender as ListBox;
            // Treat SelectedItem as ListBoxItem
            ListBoxItem lbi = lbox.SelectedItem as ListBoxItem;
            //ListBoxItem lbi = ((sender as ListBox).SelectedItem as ListBoxItem);
            EnteredText.Text = "You selected " + lbi.Content.ToString() + ".";
            Selected_Sensor = lbi.Content.ToString();// saved to a static variable
        }

        static string Selected_Sensor;

        private void OkButton_click_handler(object sender, RoutedEventArgs e)
        {
            // Item from the list box and the ID
            EnteredText.Text = "Sensor::" + Selected_Sensor.ToString() + " ID ==" + textBox.Text;

        }
    }
}

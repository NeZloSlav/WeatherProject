using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WeatherProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            ToggleButton toggleButton = (ToggleButton)sender;

            switch (toggleButton.Name)
            {
                case "toggleBtnDay":
                    toggleBtnMonth.IsChecked = false;
                    toggleBtnWeek.IsChecked = false;
                    break;

                case "toggleBtnWeek":
                    toggleBtnMonth.IsChecked = false;
                    toggleBtnDay.IsChecked = false;
                    break;

                case "toggleBtnMonth":
                    toggleBtnDay.IsChecked = false;
                    toggleBtnWeek.IsChecked = false;
                    break;

                default:
                    break;
            }
        }

    }
}

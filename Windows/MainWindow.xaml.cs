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

namespace WindowsShiteSieveGUI
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

        private void LoadConfig_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveConfig_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void SaveRun_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UWPApps_Click(object sender, RoutedEventArgs e)
        {
            new UWPApps().Show();
        }

        private void OtherApps_Click(object sender, RoutedEventArgs e)
        {

        }
        private void AllUsers_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void AllUsers_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void GeneralSettings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RegistryEdits_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StartMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tasks_Click(object sender, RoutedEventArgs e)
        {

        }

        private void WindowsExplorer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RevertAllChanges_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RevertRegistryEdits_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RevertSpecificChange_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

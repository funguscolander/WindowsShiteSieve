using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
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
        public ObservableCollection<BoolStringClass> List_UWPApps { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Button interaction logic
        /// </summary>
        private void LoadConfig_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog iniFileDialog = new OpenFileDialog
            {
                Title = "Select Configuration File",
                DefaultExt = ".ini",
                Filter = "Initialization (.ini)|*.ini|All files (*.*)|*.*",
                InitialDirectory = Environment.CurrentDirectory
            };
            if (iniFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    var parser = new FileIniDataParser();
                    IniData iniData = parser.ReadFile(iniFileDialog.FileName);
                    List_UWPApps = new ObservableCollection<BoolStringClass>();
                    foreach (SectionData section in iniData.Sections)
                    {
                        Console.WriteLine("[" + section.SectionName + "]");

                        // Iterating through the sections and the keys will break this if there is more than one section.
                        // Needs refactoring to acommodate new lists
                        foreach (KeyData key in section.Keys)
                        {
                            string keyValue = key.Value;
                            bool boolKeyValue = String.Equals("remove", key.Value);
                            List_UWPApps.Add(new BoolStringClass() { IsSelected = boolKeyValue, OptionName = key.KeyName });
                            Console.WriteLine(key.KeyName + " = " + boolKeyValue);
                        }
                    }
                }
                catch (SecurityException ex)
                {
                    System.Windows.MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
                DataContext = this;
            }
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

        /// <summary>
        /// Definitions
        /// </summary>
        
        public class BoolStringClass
        {
            public string OptionName { get; set; }
            public bool IsSelected { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using static WindowsShiteSieveGUI.MainWindow;

namespace WindowsShiteSieveGUI
{
    /// <summary>
    /// Interaction logic for UWPApps.xaml
    /// </summary>
    public partial class UWPApps : Window
    {
        public ObservableCollection<BoolStringClass> List_UWPApps { get; set; }

        public UWPApps()
        {
            InitializeComponent();
        }
    }
}

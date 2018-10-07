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

namespace C_DataStructures_Generator_App
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

        private void Array_Type_User_Click(object sender, RoutedEventArgs e)
        {
            this.Array_Type_Primitive_ComboBox.SelectedIndex = -1;
        }

        private void Array_Typedef_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)(this.Array_Typedef_Pointer.IsChecked))
            {
                if (!(bool)(this.Array_Typedef.IsChecked))
                {
                    this.Array_Typedef_Pointer.IsChecked = false;
                }
            }
        }
    }
}

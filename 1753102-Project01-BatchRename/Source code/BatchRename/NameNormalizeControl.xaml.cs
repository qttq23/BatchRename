using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace BatchRename
{
    /// <summary>
    /// Interaction logic for NameNormalizeControl.xaml
    /// </summary>
    public partial class NameNormalizeControl : ArgumentForStringActionControl
    {
        public NameNormalizeControl()
        {
            InitializeComponent();

    
            MainListView.ItemsSource = Options;
        }

        BindingList<MyString> Options { get; set; } = new BindingList<MyString>()
        {
            new MyString(){ Value = "Normailize name" },
        };

        public void AddToListButton_Click(object sender, RoutedEventArgs e)
        {
            // get arguments
            var selectedItem = MainListView.SelectedItem as MyString;
            string option = selectedItem.Value;

            // send to parent class
            List<string> arguments = new List<string>() { option };

            RaiseEventHandler(arguments);
        }

        override public void Clear()
        {
            MainListView.SelectedIndex = 0;
        }
    }
}

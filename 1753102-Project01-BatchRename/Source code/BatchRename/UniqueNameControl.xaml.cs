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
    /// Interaction logic for UniqueNameControl.xaml
    /// </summary>
    public partial class UniqueNameControl : ArgumentForStringActionControl
    {

        public UniqueNameControl()
        {
            InitializeComponent();

            MainListView.ItemsSource = Options;
        }


        BindingList<MyString> Options = new BindingList<MyString>()
        {
            new MyString() { Value = "Change name to GUID" },
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

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
    /// Interaction logic for NewCaseControl.xaml
    /// </summary>
    public partial class NewCaseControl : ArgumentForStringActionControl
    {

        public NewCaseControl()
        {
            InitializeComponent();

            MainGrid.DataContext = this;
            MainListView.ItemsSource = cases;
        }

        BindingList<MyString> cases = new BindingList<MyString>()
            {
                new MyString(){ Value="LowerCase" },
                new MyString(){ Value="UpperCase" },
                new MyString(){ Value="CapitalizedCase" },
            };


        public void AddToListButton_Click(object sender, RoutedEventArgs e)
        {
            // get arguments
            string newCase = null;

            var selectedItem = MainListView.SelectedItem as MyString;
            newCase = selectedItem.Value;


            // send to parent class
            List<string> arguments = new List<string>() { newCase };

            RaiseEventHandler(arguments);
            
        }



        override public void Clear()
        {
            MainListView.SelectedIndex = 0;
        }
    }
}

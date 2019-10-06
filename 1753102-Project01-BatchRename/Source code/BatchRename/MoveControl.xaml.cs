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
    /// Interaction logic for MoveControl.xaml
    /// </summary>
    public partial class MoveControl : ArgumentForStringActionControl
    {

        public MoveControl()
        {
            InitializeComponent();


            MainListView.ItemsSource = Destination;
        }

        BindingList<MyString>  Destination = new BindingList<MyString>()
        {
            new MyString() { Value = "Begin" },
            new MyString() { Value = "End" },
        };

        public void AddToListButton_Click(object sender, RoutedEventArgs e)
        {
            // get arguments
            string startAt = StartAtTextBox.Text;
            string length = LengthTextBox.Text;
            
            var selectedItem = MainListView.SelectedItem as MyString;
            string destination = selectedItem.Value;
            if (destination == "Begin")
            {
                destination = MoveAction.Begin.ToString();
            }
            else
            {
                destination = MoveAction.End.ToString();
            }

            // send to parent class
            List<string> arguments = new List<string>() { startAt, length, destination };

            RaiseEventHandler(arguments);
        }

        override public void Clear()
        {
            StartAtTextBox.Text = "0";
            LengthTextBox.Text = "13";
            MainListView.SelectedIndex = 0;
        }
    }
}

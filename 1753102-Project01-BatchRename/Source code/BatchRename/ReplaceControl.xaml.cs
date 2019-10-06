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
    

    public partial class ReplaceControl : ArgumentForStringActionControl
    {

        public ReplaceControl()
        {
            InitializeComponent();

            MainGrid.DataContext = this;
        }

        public void AddToListButton_Click(object sender, RoutedEventArgs e)
        {
            // get arguments
            var areaSelected = AreaComboBox.SelectedItem as ComboBoxItem;
            string area = areaSelected.Content as string;
            string needle = NeedleTextBox.Text;
            string hammer = HammerTextBox.Text;

            // send to parent class
            List<string> arguments = new List<string>()
            {
                needle,
                hammer,
                area
            };

            RaiseEventHandler(arguments);
        }

        override public void Clear()
        {
            AreaComboBox.SelectedIndex = 0;
            NeedleTextBox.Text = "";
            HammerTextBox.Text = "";
           
        }
    }

    


}

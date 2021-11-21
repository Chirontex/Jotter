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

namespace Jotter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _isFileButtonMenuOpened = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void FileButton_Click(object sender, RoutedEventArgs e)
        {
            if (this._isFileButtonMenuOpened)
            {
                //
            }
            else
            {
                var fileButtonListBox = new ListBox();
                fileButtonListBox.Name = "FileButtonListBox";
                fileButtonListBox.Items.Add("Открыть");
                fileButtonListBox.Width = 100;
                fileButtonListBox.Height = 30;
                fileButtonListBox.VerticalAlignment = 0;
                fileButtonListBox.HorizontalAlignment = 0;
                fileButtonListBox.SetValue(Grid.RowProperty, 1);
                MainGrid.Children.Add(fileButtonListBox);

                this._isFileButtonMenuOpened = true;
            }
        }
    }
}

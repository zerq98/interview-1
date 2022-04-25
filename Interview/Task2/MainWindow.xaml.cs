using Microsoft.Win32;
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

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextReader textReader;
        public MainWindow()
        {
            InitializeComponent();
            textReader = new TextReader();
        }

        private void LoadFileBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text Files (.txt)|*.txt";
            fileDialog.FilterIndex = 1;

            if (fileDialog.ShowDialog()==true)
            {
                textReader.ReadText(fileDialog.FileName);
                TextGrid.ItemsSource = textReader.GetLetters(false);
            }
        }

        private void SortAlphaBtn_Click(object sender, RoutedEventArgs e)
        {
            TextGrid.ItemsSource = textReader.GetLetters(false);
        }

        private void SortCountBtn_Click(object sender, RoutedEventArgs e)
        {
            TextGrid.ItemsSource = textReader.GetLetters(true);
        }
    }
}

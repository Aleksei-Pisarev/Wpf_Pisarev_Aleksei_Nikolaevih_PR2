using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Wpf_Pisarev_Aleksei_Nikolaevih_PR2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object spMain;
        private object counter;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnCloseClicked(object sender, EventArgs e)
        {
            Visibility = Visibility.Collapsed;
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == true)
            {
                File.WriteAllText(dlg.FileName, TextBox1.Text);
            }
        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Текстик (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == true)
            {
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);

                StreamReader reader = new StreamReader(fileInfo.Open(FileMode.Open, FileAccess.Read), Encoding.GetEncoding(1251));

                TextBox1.Text = reader.ReadToEnd();

                reader.Close();
                return;
            }

        }
        private void Click_1_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Gray);
        }
        private void Click_2_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Black);
        }
        private void Click_3_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Blue);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данное приложение разработал \nПисарев Алексей группа 402 ИСиП ");
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

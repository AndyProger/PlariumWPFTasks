using System;
using System.Windows;
using System.Text.RegularExpressions;
using PlariumTasks;

namespace PlariumTask2.DialogWindows
{
    /// <summary>
    /// Логика взаимодействия для Task1v1.xaml
    /// </summary>
    public partial class Task1v1 : Window
    {
        public Task1v1()
        {
            InitializeComponent();
            btnFind.Click += BtnClickFind;
        }

        public void BtnClickFind(object sender, EventArgs args)
        {
            int[] array;

            try
            {
                array = Array.ConvertAll(textNumbers.Text.Trim(' ').Split(' ', ','), int.Parse);
            }
            catch
            {
                MessageBox.Show("Wrong data!", "Error!", MessageBoxButton.OK, MessageBoxImage.Warning);
                textNumbers.Text = string.Empty;
                return;
            }

            resultLabel.Content = string.Join("", Task1.FindProduct(array));
            textNumbers.Text = textNumbers.Text.Trim(' ');
        }
    }
}

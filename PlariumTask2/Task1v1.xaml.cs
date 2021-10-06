using System;
using System.Windows;
using PlariumTasks;

namespace PlariumTask2
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
                array = Array.ConvertAll(TextNumbers.Text.Trim(' ').Split(' ', ','), int.Parse);
                Result.Content = string.Join("", Task1.FindProduct(array));
                TextNumbers.Text = TextNumbers.Text.Trim(' ');
            }
            catch
            {
                MessageBox.Show("Not valid data!"); // add warnigng sign
                TextNumbers.Text = string.Empty;
            }
        }
    }
}

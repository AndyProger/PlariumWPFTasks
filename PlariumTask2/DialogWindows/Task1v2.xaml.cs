using System;
using System.Windows;
using PlariumTasks;

namespace PlariumTask2.DialogWindows
{
    /// <summary>
    /// Логика взаимодействия для Task1v2.xaml
    /// </summary>
    public partial class Task1v2 : Window
    {
        public Task1v2()
        {
            InitializeComponent();
            btnFind.Click += ButtonFind_Click;
        }

        private void ButtonFind_Click(object sender, RoutedEventArgs e)
        {
            // очишаем ListView перед заполнением
            if(!increaseList.Items.IsEmpty)
            {
                increaseList.Items.Clear();
                depositList.Items.Clear();
            }

            decimal sum, percent;
            decimal[] increaseArray, depositArray;
            uint months;

            try
            {
                sum = decimal.Parse(deposTextBox.Text);
                percent = decimal.Parse(percentTextBox.Text);
                months = uint.Parse(upDownControl.Text);

                increaseArray = Task1.IncreaseAmount(sum, percent, months);
                depositArray = Task1.DepositAmount(sum, percent, months);
            }
            catch
            {
                MessageBox.Show("Wrong data!", "Error!", MessageBoxButton.OK, MessageBoxImage.Warning);
                deposTextBox.Text = percentTextBox.Text = string.Empty;
                return;
            }

            // вывод в списки
            for(var i = 0; i < months; i++)
            {
                increaseList.Items.Add(i + 1 + "  " + increaseArray[i].ToString());
                depositList.Items.Add(i + 3 + " " + depositArray[i].ToString());
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

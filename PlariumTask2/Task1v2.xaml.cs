using System;
using System.Windows;
using PlariumTasks;

namespace PlariumTask2
{
    /// <summary>
    /// Логика взаимодействия для Task1v2.xaml
    /// </summary>
    public partial class Task1v2 : Window
    {
        public Task1v2()
        {
            InitializeComponent();
            // add by delegats
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!increaseList.Items.IsEmpty)
            {
                increaseList.Items.Clear();
                depositList.Items.Clear();
            }

            decimal sum, percent;
            int months;

            try
            {
                sum = Convert.ToDecimal(deposTextBox.Text);
                percent = Convert.ToDecimal(percentTextBox.Text);
                months = int.Parse(upDownControl.Text);
            }
            catch
            {
                MessageBox.Show("Not valid data!");
                deposTextBox.Text = percentTextBox.Text = string.Empty;
                return;
            }

            decimal[] increaseArray = Task1.IncreaseAmount(sum, percent, months);
            decimal[] depositArray = Task1.DepositAmount(sum, percent, months);

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

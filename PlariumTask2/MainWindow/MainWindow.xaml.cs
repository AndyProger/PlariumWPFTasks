using System;
using System.Windows;
using PlariumTask2.DialogWindows;

namespace PlariumTask2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            bthTask1.Click += ClickedBtnTask1;
            bthTask2.Click += ClickedBtnTask2;
        }

        public void ClickedBtnTask1(object sender, EventArgs args)
        {
            Task1v1 modalWindow = new Task1v1();
            modalWindow.ShowDialog();
        }

        public void ClickedBtnTask2(object sender, EventArgs args)
        {
            Task1v2 modalWindow = new Task1v2();
            modalWindow.ShowDialog();
        }
    }
}

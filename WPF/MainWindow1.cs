using System;
using System.Windows;

namespace WpfApp1
{
    public  partial class MainWindow 
    {
        internal void Show()
        {
            Console.WriteLine(" hello");
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(e))
            {
                Console.WriteLine("Successfuly");
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
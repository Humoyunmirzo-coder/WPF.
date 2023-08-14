using System;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using WpfApp1;

namespace WpfApp1

{
    public partial class MaiWindow : Window
    {
        public TextBox LoginTextBox { get; private set; }
        public PasswordBox PasswordBox { get; }
        public PasswordBox RepeatPasswordBox { get; }
        public CheckBox AgreeCheckBox { get; }

        private bool _contentLoaded;

        public  MaiWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public MaiWindow (TextBox loginTextBox, PasswordBox passwordBox, PasswordBox repeatPasswordBox, CheckBox agreeCheckBox, bool contentLoaded)
        {
            LoginTextBox = loginTextBox;
            PasswordBox = passwordBox;
            RepeatPasswordBox = repeatPasswordBox;
            AgreeCheckBox = agreeCheckBox;
            _contentLoaded = contentLoaded;
        }

        public MaiWindow(TextBox loginTextBox)
        {
            this.LoginTextBox = loginTextBox;
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            // Check if login and password are valid
            if (LoginTextBox.Text.Length < 8 || !Regex.IsMatch(LoginTextBox.Text, "^[a-zA-Z0-9]*$") ||
                PasswordBox.Password.Length < 8 || !Regex.IsMatch(PasswordBox.Password, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]*$") ||
                PasswordBox.Password != RepeatPasswordBox.Password || AgreeCheckBox.IsChecked != true)
            {
                MessageBox.Show("Invalid login or password.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("ww", "hellp");
                MessageBox.Show("ww", "hellp");
                MessageBox.Show("ww", "hellp");
                // Store hashed password in database
                //Record login and password in application settings property
                Properties.Settings = LoginTextBox.Text;
                Properties.Settings = LoginTextBox.Text;
                Properties.Settings = PasswordBox.Password;
                Properties.Settings.ToString().ToLower();
                // Close registration window
                Close();
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            // Close registration window
            Close();
        }
    }
}

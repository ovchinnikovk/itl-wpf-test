using itl_wpf_test.Helper;
using itl_wpf_test.ViewModel;
using System.Windows;
using System.Windows.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace itl_wpf_test.Pages
{
    public partial class FormPage : Page
    {
        public FormPage()
        {
            InitializeComponent();
        }

        private async void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            if (FormPageViewModel.CanGo()) Ioc.NavigationService.Navigate(new VerificationPage());
            else await Task.Run(() =>
            {
                    Dispatcher.Invoke(() => CorrFields.Visibility = Visibility.Visible);
                    Task.Delay(3000)
                    .ContinueWith(t =>
                    {
                        Dispatcher.Invoke(() => CorrFields.Visibility = Visibility.Hidden);
                    });
                });
        }

        private void FullnameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FormPageViewModel.IsValidFullname(FullnameTextBox.Text.ToString());
        }

        private void TnumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FormPageViewModel.IsValidNumber(TnumberTextBox.Text.ToString());
        }

        private void EmailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FormPageViewModel.IsValidMail(EmailTextBox.Text.ToString());
        }
    }
}

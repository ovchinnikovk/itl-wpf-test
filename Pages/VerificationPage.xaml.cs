using itl_wpf_test.Helper;
using System.Windows;
using System.Windows.Controls;

namespace itl_wpf_test.Pages
{
    public partial class VerificationPage : Page
    {
        public VerificationPage()
        {
            InitializeComponent();
        }

        private async void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CodeTextBox1.Text.ToString())
                && !string.IsNullOrWhiteSpace(CodeTextBox2.Text.ToString())
                && !string.IsNullOrWhiteSpace(CodeTextBox3.Text.ToString()))
                await Task.Run(() =>
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        Ioc.NavigationService.Navigate(new CatalogPage());
                    });
                    Task.Delay(20000)
                    .ContinueWith(t =>
                    {
                        Application.Current.Dispatcher.Invoke(() =>
                        {
                            Ioc.NavigationService.Navigate(new MainPage());
                        });
                    });
                });
            else await Task.Run(() =>
            {
                Dispatcher.Invoke(() => CorrTextBlock.Visibility = Visibility.Visible);
                Task.Delay(3000)
                .ContinueWith(t =>
                {
                    Dispatcher.Invoke(() => CorrTextBlock.Visibility = Visibility.Hidden);
                });
            });
        }
    }
}

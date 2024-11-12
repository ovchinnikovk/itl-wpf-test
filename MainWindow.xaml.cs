using System.Windows;
using System.Windows.Controls;
using itl_wpf_test.Helper;
using itl_wpf_test.Pages;

namespace itl_wpf_test;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        Loaded += Window_Loaded;
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        MainFrame.Content = new MainPage();
        Ioc.Init(MainFrame);
    }
}
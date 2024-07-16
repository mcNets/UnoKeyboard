namespace UnoKeyboardDemo;

public sealed partial class SecondPage : Page
{
    public SecondPage()
    {
        InitializeComponent();
        SystemThemeHelper.SetApplicationTheme(McWindowEx.RootFrame.XamlRoot, ElementTheme.Light);
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        McWindowEx.RootFrame.Navigate(typeof(MainPage));
    }
}

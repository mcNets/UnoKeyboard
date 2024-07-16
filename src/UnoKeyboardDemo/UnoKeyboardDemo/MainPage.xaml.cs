using UnoKeyboard;

namespace UnoKeyboardDemo;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        InitializeComponent();

        SystemThemeHelper.SetApplicationTheme(McWindowEx.RootFrame.XamlRoot, ElementTheme.Dark);
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        McWindowEx.RootFrame.Navigate(typeof(SecondPage), null);
    }
}

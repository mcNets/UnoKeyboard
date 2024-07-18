using UnoKeyboard;

namespace UnoKeyboardDemo;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        InitializeComponent();

        SystemThemeHelper.SetApplicationTheme(McWindowEx.RootFrame.XamlRoot, ElementTheme.Dark);

        //var path = new PathGeometry();
        //path.Figures.Add(KeyPathGeometry.Shift);

        //this.boto.Content = new Viewbox()
        //{
        //    Height = 20,
        //    Child = new PathIcon()
        //    {
        //        Data = path,
        //    }
        //};

        Loaded += MainPage_Loaded;
    }

    private void MainPage_Loaded(object sender, RoutedEventArgs e)
    {
        //boto.UpdateLayout();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        McWindowEx.RootFrame.Navigate(typeof(SecondPage), null);
    }
}

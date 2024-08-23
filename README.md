# UnoKeyboard

![Latest Release](https://img.shields.io/github/v/release/mcNets/UnoKeyboard?label=Latest%20Release&color=green) 
[![NuGet](https://img.shields.io/nuget/v/UnoKeyboard)](https://www.nuget.org/packages/UnoKeyboard/)

UnoKeyboard is an on-screen keyboard control designed to run on Desktop, WASM, and Windows platforms. It's primarily intended for touch-screen devices.

![UnoKeyboardDark](https://github.com/mcNets/UnoKeyboard/blob/main/UnoKeyboardLight.jpg) ![UnoKeyboardDark](https://github.com/mcNets/UnoKeyboard/blob/main/UnoKeyboardDark.jpg)

## Features

- Cross-platform.
- Customizable design.
- Theming support.
- Custom appearance.

## Adding the Control to Your Project.

The control is available as a NuGet package [Nuget package](https://www.nuget.org/packages/UnoKeyboard) or can be integrated from the [Github source code](https://github.com/mcNets/UnoKeyboard).

### How should I use the Control?

The keyboard can be used in two different ways:

- Using the AddKeyboard extension method.
- Using a XAML control.

If your project uses the default frame navigation, I would recommend using the AddKeyboard extension method. This method automatically shows and hides the keyboard when a TextBox gains or loses focus. On the other hand, if you prefer more control over the keyboard or if you are using other navigation methods, use the XAML control instead.

### Using the AddKeyboard Extension Method

The library provides an extension method for the Window class to automatically add the control to your project.

The `AddKeyboard` method injects a two-row grid. The first row contains a `ScrollViewer`, and the second row displays the virtual keyboard. The content of the `ScrollViewer` is assigned to the `RootFrame` property of the `McWindowEx` class.

- Add a reference to `McWindowEx.RootFrame` in your `App.xaml.cs` file:

```csharp
    public static Frame RootFrame => McWindowEx.RootFrame;
```

- Comment out the code that creates the main `Frame` in the `OnLaunched` method:

```csharp
    // Do not repeat app initialization when the Window already has content,
    // just ensure that the window is active
    //if (MainWindow.Content is not Frame rootFrame)
    //{
    //    // Create a Frame to act as the navigation context and navigate to the first page
    //    rootFrame = new Frame();

    //    // Place the frame in the current Window
    //    MainWindow.Content = rootFrame;
    //    rootFrame.NavigationFailed += OnNavigationFailed;
    //}

    //if (rootFrame.Content == null)
    //{
    //    // When the navigation stack isn't restored navigate to the first page,
    //    // configuring the new page by passing required information as a navigation
    //    // parameter
    //    rootFrame.Navigate(typeof(MainPage), args.Arguments);
    //}
```

- Call the `AddKeyboard` method and navigate to the main page:

```csharp
    // Add UnoKeyboard to the Window
    MainWindow.AddKeyboard(height: 300);

    // Navigate using McWindowEx.RootFrame
    if (RootFrame.Content == null)
    {
        RootFrame.Navigate(typeof(MainPage), args.Arguments);
        RootFrame.NavigationFailed += OnNavigationFailed;
    }
```

From this point on, the virtual keyboard will automatically appear whenever a `TextBox` gains focus.

### Using an XAML Control:

Add a reference to the `xmlns:ukc="using:UnoKeyboard.Controls"` namespace and then add a new control to your file:

```xml
<ukc:UnoKeyboard x:Name="MyKeyboard"
                 Height="300"
                 Visibility="Collapsed"
                 HandleFocusManager="True" />
```

## Properties

Here are some of the properties. For a complete list, refer to the control's [documentation](https://github.com/mcNets/UnoKeyboard/blob/main/Properties.md).

### Height

This property defines the height of the virtual keyboard. **It's important to note that the height of each key depends on the keyboard's height**. For example, if the keyboard is 300px high and has 4 rows, each row will be::

```
(300 - (Padding.Top + Padding.Bottom)) / 4
```

Similarly, the width of each key is calculated based on the number of keys per row.

### HandleFocusManager

If the `HandleFocusManager` property is set to True, the control will automatically show and hide the virtual keyboard when a TextBox gains or loses focus. Otherwise, the keyboard must be shown and hidden manually.

## Keyboard Type

The `McWindowEx` extension class introduces a new attached property: `KeyboardType`, which allows for keyboard selection. Two default keyboards are available, but you can add more custom keyboards:

- en-alfa
- numeric

To use a specific keyboard, set the `KeyboardType` attached property on your `TextBox` control. The default keyboard is `en-alfa`:

```xml
<Page 
    xmlns:mck="using:UnoKeyboard" />

<TextBox Width="200"
         VerticalAlignment="Center"
         FontSize="30"
         mck:McWindowEx.KeyboardType="numeric" />
```

## Customization

Two static dictionaries are used to define the keyboard and its keys. You can add more keys and keyboard layouts by adding new entries to these dictionaries.

### VirtualKeys

The [VirtualKeys.Key](https://github.com/mcNets/UnoKeyboard/blob/main/src/UnoKeyboard/VirtualKeys.cs) dictionary dictionary defines the keys that will be displayed on the keyboard. Each key is defined by a [VirtualKeyModel](https://github.com/mcNets/UnoKeyboard/blob/main/src/UnoKeyboard/Models/VirtualKeyModel.cs).

That is a reduced version of the dictionary:

```csharp
public static class VirtualKeys
{
    public static Dictionary<string, VirtualKeyModel> Key = new()
    {
        { "N1", new VirtualKeyModel("N1", KeyType.Text, "1", "1", 0x0031, 0x0031, null) },
        { "N2", new VirtualKeyModel("N2", KeyType.Text, "2", "2", 0x0032, 0x0032, null) },
    }
}
```

For example, to add the `|` key to your custom keyboard layout:

```csharp
VirtualKeys.Key.Add("|",                // Dictionary key
    new VirtualKeyModel("|",            // Key ID
                        KeyType.Text,   // Type
                        "|",            // Uppercase
                        "|",            // Lowercase
                        0x007C,         // Unicode uppercase
                        0x007C,         // Unicode lowercase
                        null));         // A Func<Microsoft.UI.Xaml.Shapes.Path>? that returns a Path
                                        // used to draw special keys.
```

### Keyboards

The [Keyboards.Keyboard](https://github.com/mcNets/UnoKeyboard/blob/main/src/UnoKeyboard/Keyboards.cs) dictionary defines the keyboard layouts. Each keyboard is defined by a [KeyboardModel](https://github.com/mcNets/UnoKeyboard/blob/main/src/UnoKeyboard/Models/KeyboardModel.cs).

Let's add the new key to the keyboard layout:

```csharp
Keyboards.Keyboard.Add("my_keyboard",   // Dictionary key
    new KeyboardModel("my_keyboard"     // Keyboard Id
                      "1",              // Number of pages.
                      "3",              // Number of rows.
                      "10",             // Max. keys per row.
                      [
                        new KeyModel(0,                     // Page 0
                                     0,                     // Row 0
                                     1,                     // Column 1
                                     1,                     // Column span
                                     VirtualKeys.Get("|")), // Key
                      ]));
```
For any questions or suggestions, feel free to contact me in the [Discusiones](https://github.com/mcNets/UnoKeyboard/discussions) section or open an [Issue](https://github.com/mcNets/UnoKeyboard/issues) on the GitHub repository.

Everyone is welcome to contribute to the project. Thank you for your interest!

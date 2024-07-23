# UnoKeyboard

On screen virtual keyboard for Desktop, WASM and Windows platform.

## Features

- Multi-platform support.
- Customizable layout.
- Theme support.
- Customizable appearance. (Font and size)

## Usage

This library adds an extension method to `Window` class to show the keyboard. 

This method generates a scafold with the keyboard layout and adds it to the `Window` content. Then you can use the new RootFrame to publish your (actual) content.

Add the next line to you `App.xaml.cs` file before to activate the main window.

```csharp
MainWindow.AddKeyboard(height: 300);
```

The control manages focus events using FocusManager, so every time a control gets focus, the keyboard will be shown.

## Customization

The extension class McWindowEx, adds a new attached property to allow customization of the keyboard layout. There are two keyboards supplied by default:

- alfa-en
- numeric

```xaml
<TextBox Width="200"
         VerticalAlignment="Center"
         FontSize="30"
         mck:McWindowEx.KeyboardType="numeric" />
```

![UnoKeyboardDark](UnoKeyboardDark.png)
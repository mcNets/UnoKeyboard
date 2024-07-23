# UnoKeyboard

UnoKeyboard is an on-screen virtual keyboard designed for Desktop, WASM, and Windows platforms.

![UnoKeyboardDark](UnoKeyboardLight.png) ![UnoKeyboardDark](UnoKeyboardDark.png) 

## Features

- Multi-platform support.
- Customizable layout.
- Theme support.
- Customizable appearance (font and size).

## Usage

This library provides an extension method for the `Window` class to display the virtual keyboard. 

The method generates a scaffold with the keyboard layout and adds it to the `Window` content. You can then use the new RootFrame to publish your actual content.

To activate the main window, add the following line to your `App.xaml.cs` file:The control manages focus events using the FocusManager, so the keyboard will be shown whenever a control receives focus.

```csharp
MainWindow.AddKeyboard(height: 300);
```

## Customization

The extension class `McWindowEx` introduces a new attached property `KeyboardType` that allows keyboard customization. Two default keyboards are provided:

- alfa-en
- numeric

To use a specific keyboard, add the  attached property to your XAML code:

```xaml
<TextBox Width="200"
         VerticalAlignment="Center"
         FontSize="30"
         mck:McWindowEx.KeyboardType="numeric" />
```


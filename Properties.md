# UnoKeyboard 

## KeyboardControl properties

**TextControl**

- TextBox assigned to the keyboard.

**Keyboard**

- [KeyboardModel](src/UnoKeyboard/Models/KeyboardModel.cs) assigned to the keyboard.


**IsShiftActive**

- Boolean property that indicates if the shift key is active.

**KeyBackground**

- Brush property that indicates the background color of the keys.

**KeyForeground**

- Brush property that indicates the foreground color of the keys.

**KeyBorderBrush**

- Brush property that indicates the border color of the keys.

**KeyBorderThickness**

- Thickness property that indicates the border thickness of the keys.

**KeyMargin**

- Thickness property that indicates the margin of the keys

**KeyFontFamily**

- FontFamily property that indicates the font family of the keys.

**KeyFontSize**

- Double property that indicates the font size of the keys.

**Padding**

- Thickness property that indicates the padding of the keyboard.

**KeySpecialKeyBackground**

- Brush property that indicates the background color of the special keys.

**HandleFocusManager**

- Boolean property that indicates if the focus manager is handled.

## KeyboardControl events

**KeyPressed**

- Event that is triggered when a key is pressed and before the key is processed. This event can be canceled.
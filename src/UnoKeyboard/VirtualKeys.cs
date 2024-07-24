namespace UnoKeyboard.Models;

public static class VirtualKeys
{
    public static Dictionary<string, VirtualKeyModel> Key = new()
    {
        { "N1",             new VirtualKeyModel("N1",           KeyType.Text,       "1",    "1",    0x0031, 0x0031, null, 0, 0) },
        { "N2",             new VirtualKeyModel("N2",           KeyType.Text,       "2",    "2",    0x0032, 0x0032, null, 0, 0) },
        { "N3",             new VirtualKeyModel("N3",           KeyType.Text,       "3",    "3",    0x0033, 0x0033, null, 0, 0) },
        { "N4",             new VirtualKeyModel("N4",           KeyType.Text,       "4",    "4",    0x0034, 0x0034, null, 0, 0) },
        { "N5",             new VirtualKeyModel("N5",           KeyType.Text,       "5",    "5",    0x0035, 0x0035, null, 0, 0) },
        { "N6",             new VirtualKeyModel("N6",           KeyType.Text,       "6",    "6",    0x0036, 0x0036, null, 0, 0) },
        { "N7",             new VirtualKeyModel("N7",           KeyType.Text,       "7",    "7",    0x0037, 0x0037, null, 0, 0) },
        { "N8",             new VirtualKeyModel("N8",           KeyType.Text,       "8",    "8",    0x0038, 0x0038, null, 0, 0) },
        { "N9",             new VirtualKeyModel("N9",           KeyType.Text,       "9",    "9",    0x0039, 0x0039, null, 0, 0) },
        { "N0",             new VirtualKeyModel("N0",           KeyType.Text,       "0",    "0",    0x0030, 0x0030, null, 0, 0) },
        { "A",              new VirtualKeyModel("A",            KeyType.Text,       "A",    "a",    0x0041, 0x0061, null, 0, 0) },
        { "B",              new VirtualKeyModel("B",            KeyType.Text,       "B",    "b",    0x0042, 0x0062, null, 0, 0) },
        { "C",              new VirtualKeyModel("C",            KeyType.Text,       "C",    "c",    0x0043, 0x0063, null, 0, 0) },
        { "D",              new VirtualKeyModel("D",            KeyType.Text,       "D",    "d",    0x0044, 0x0064, null, 0, 0) },
        { "E",              new VirtualKeyModel("E",            KeyType.Text,       "E",    "e",    0x0045, 0x0065, null, 0, 0) },
        { "F",              new VirtualKeyModel("F",            KeyType.Text,       "F",    "f",    0x0046, 0x0066, null, 0, 0) },
        { "G",              new VirtualKeyModel("G",            KeyType.Text,       "G",    "g",    0x0047, 0x0067, null, 0, 0) },
        { "H",              new VirtualKeyModel("H",            KeyType.Text,       "H",    "h",    0x0048, 0x0068, null, 0, 0) },
        { "I",              new VirtualKeyModel("I",            KeyType.Text,       "I",    "i",    0x0049, 0x0069, null, 0, 0) },
        { "J",              new VirtualKeyModel("J",            KeyType.Text,       "J",    "j",    0x004A, 0x006A, null, 0, 0) },
        { "K",              new VirtualKeyModel("K",            KeyType.Text,       "K",    "k",    0x004B, 0x006B, null, 0, 0) },
        { "L",              new VirtualKeyModel("L",            KeyType.Text,       "L",    "l",    0x004C, 0x006C, null, 0, 0) },
        { "M",              new VirtualKeyModel("M",            KeyType.Text,       "M",    "m",    0x004D, 0x006D, null, 0, 0) },
        { "N",              new VirtualKeyModel("N",            KeyType.Text,       "N",    "n",    0x004E, 0x006E, null, 0, 0) },
        { "O",              new VirtualKeyModel("O",            KeyType.Text,       "O",    "o",    0x004F, 0x006F, null, 0, 0) },
        { "P",              new VirtualKeyModel("P",            KeyType.Text,       "P",    "p",    0x0050, 0x0070, null, 0, 0) },
        { "Q",              new VirtualKeyModel("Q",            KeyType.Text,       "Q",    "q",    0x0051, 0x0071, null, 0, 0) },
        { "R",              new VirtualKeyModel("R",            KeyType.Text,       "R",    "r",    0x0052, 0x0072, null, 0, 0) },
        { "S",              new VirtualKeyModel("S",            KeyType.Text,       "S",    "s",    0x0053, 0x0073, null, 0, 0) },
        { "T",              new VirtualKeyModel("T",            KeyType.Text,       "T",    "t",    0x0054, 0x0074, null, 0, 0) },
        { "U",              new VirtualKeyModel("U",            KeyType.Text,       "U",    "u",    0x0055, 0x0075, null, 0, 0) },
        { "V",              new VirtualKeyModel("V",            KeyType.Text,       "V",    "v",    0x0056, 0x0076, null, 0, 0) },
        { "W",              new VirtualKeyModel("W",            KeyType.Text,       "W",    "w",    0x0057, 0x0077, null, 0, 0) },
        { "X",              new VirtualKeyModel("X",            KeyType.Text,       "X",    "x",    0x0058, 0x0078, null, 0, 0) },
        { "Y",              new VirtualKeyModel("Y",            KeyType.Text,       "Y",    "y",    0x0059, 0x0079, null, 0, 0) },
        { "Z",              new VirtualKeyModel("Z",            KeyType.Text,       "Z",    "z",    0x005A, 0x007A, null, 0, 0) },
        { "Point",          new VirtualKeyModel("Point",        KeyType.Text,       ".",    ".",    0x002E, 0x002E, null, 0, 0) },
        { "Comma",          new VirtualKeyModel("Comma",        KeyType.Text,       ",",    ",",    0x002C, 0x002C, null, 0, 0) },
        { "Plus",           new VirtualKeyModel("Plus",         KeyType.Text,       "+",    "+",    0x002B, 0x002B, null, 0, 0) },
        { "Dash",           new VirtualKeyModel("Dash",         KeyType.Text,       "-",    "-",    0x002D, 0x002D, null, 0, 0) },
        { "Asterisk",       new VirtualKeyModel("Asterisk",     KeyType.Text,       "*",    "*",    0x002A, 0x002A, null, 0, 0) },
        { "Slash",          new VirtualKeyModel("Slash",        KeyType.Text,       "/",    "/",    0x002F, 0x002F, null, 0, 0) },
        { "At",             new VirtualKeyModel("At",           KeyType.Text,       "@",    "@",    0x0040, 0x0040, null, 0, 0) },
        { "Hash",           new VirtualKeyModel("Hash",         KeyType.Text,       "#",    "#",    0x0023, 0x0023, null, 0, 0) },
        { "Dollar",         new VirtualKeyModel("Dollar",       KeyType.Text,       "$",    "$",    0x0024, 0x0024, null, 0, 0) },
        { "Euro",           new VirtualKeyModel("Euro",         KeyType.Text,       "€",    "€",    0x20AC, 0x20AC, null, 0, 0) },
        { "Underscore",     new VirtualKeyModel("Underscore",   KeyType.Text,       "_",    "_",    0x005F, 0x005F, null, 0, 0) },
        { "Ampersand",      new VirtualKeyModel("Ampersand",    KeyType.Text,       "&",    "&",    0x0026, 0x0026, null, 0, 0) },
        { "LParenthesis",   new VirtualKeyModel("LParenthesis", KeyType.Text,       "(",    "(",    0x0028, 0x0028, null, 0, 0) },
        { "RParenthesis",   new VirtualKeyModel("RParenthesis", KeyType.Text,       ")",    ")",    0x0029, 0x0029, null, 0, 0) },
        { "SingleQuote",    new VirtualKeyModel("SingleQuote",  KeyType.Text,       "'",    "'",    0x0027, 0x0027, null, 0, 0) },
        { "Colon",          new VirtualKeyModel("Colon",        KeyType.Text,       ":",    ":",    0x003A, 0x003A, null, 0, 0) },
        { "Semicolon",      new VirtualKeyModel("Semicolon",    KeyType.Text,       ";",    ";",    0x003B, 0x003B, null, 0, 0) },
        { "Exclamation",    new VirtualKeyModel("Exclamation",  KeyType.Text,       "!",    "!",    0x0021, 0x0021, null, 0, 0) },
        { "Question",       new VirtualKeyModel("Question",     KeyType.Text,       "?",    "?",    0x003F, 0x003F, null, 0, 0) },
        { "Percent",        new VirtualKeyModel("Percent",      KeyType.Text,       "%",    "%",    0x0025, 0x0025, null, 0, 0) },
        { "Equal",          new VirtualKeyModel("Equal",        KeyType.Text,       "=",    "=",    0x003D, 0x003D, null, 0, 0) },
        { "LessThan",       new VirtualKeyModel("LessThan",     KeyType.Text,       "<",    "<",    0x003C, 0x003C, null, 0, 0) },
        { "GreatThan",      new VirtualKeyModel("GreatThan",    KeyType.Text,       ">",    ">",    0x003E, 0x003E, null, 0, 0) },
        { "LSquare",        new VirtualKeyModel("LSquare",      KeyType.Text,       "[",    "[",    0x005B, 0x005B, null, 0, 0) },
        { "RSquare",        new VirtualKeyModel("RSquare",      KeyType.Text,       "]",    "]",    0x005D, 0x005D, null, 0, 0) },
        { "LCurly",         new VirtualKeyModel("LCurly",       KeyType.Text,       "{",    "{",    0x007B, 0x007B, null, 0, 0) },
        { "RCurly",         new VirtualKeyModel("RCurly",       KeyType.Text,       "}",    "}",    0x007D, 0x007D, null, 0, 0) },
        { "Backslash",      new VirtualKeyModel("Backslash",    KeyType.Text,       "\\",   "\\",   0x005C, 0x005C, null, 0, 0) },
        { "Quote",          new VirtualKeyModel("Quote",        KeyType.Text,       "\"",   "\"",   0x002A, 0x002A, null, 0, 0) },
        { "Space",          new VirtualKeyModel("Space",        KeyType.Space,      " ",    " ",    0x0000, 0x0000, KeyPathGeometry.Space, 13, 7) },
        { "Enter",          new VirtualKeyModel("Enter",        KeyType.Enter,      "",     "",     0x0000, 0x0000, KeyPathGeometry.Enter, 13, 9) },
        { "Shift",          new VirtualKeyModel("Shift",        KeyType.Shift,      "",     "",     0x0000, 0x0000, KeyPathGeometry.Shift, 9, 10) }, 
        { "Back",           new VirtualKeyModel("Back",         KeyType.Back,       "",     "",     0x0000, 0x0000, KeyPathGeometry.Back,  14, 9) },
        { "Symbols",        new VirtualKeyModel("Symbols",      KeyType.Symbols,    "&123", "&123", 0x0002, 0x0002, null, 0, 0) },
        { "Alfa",           new VirtualKeyModel("Alfa",         KeyType.Alfa,       "ABC",  "ABC",  0x0001, 0x0001, null, 1, 4) }
    };

    public static VirtualKeyModel Get(string key)
    {
        if (Key.TryGetValue(key, out VirtualKeyModel? value))
        {
            return value;
        }

        throw new KeyNotFoundException($"Key '{key}' not found.");
    }
}
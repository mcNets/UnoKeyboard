namespace UnoKeyboard.Models;

public static class VirtualKeys
{
    public static VirtualKeyModel N1 = new ("N1", KeyType.Text, "1", "1", 0x0031, 0x0031, null, 0, 0);
    public static VirtualKeyModel N2 = new ("N2", KeyType.Text, "2", "2", 0x0032, 0x0032, null, 0, 0);
    public static VirtualKeyModel N3 = new ("N3", KeyType.Text, "3", "3", 0x0033, 0x0033, null, 0, 0);
    public static VirtualKeyModel N4 = new ("N4", KeyType.Text, "4", "4", 0x0034, 0x0034, null, 0, 0);
    public static VirtualKeyModel N5 = new ("N5", KeyType.Text, "5", "5", 0x0035, 0x0035, null, 0, 0);
    public static VirtualKeyModel N6 = new ("N6", KeyType.Text, "6", "6", 0x0036, 0x0036, null, 0, 0);
    public static VirtualKeyModel N7 = new ("N7", KeyType.Text, "7", "7", 0x0037, 0x0037, null, 0, 0);
    public static VirtualKeyModel N8 = new ("N8", KeyType.Text, "8", "8", 0x0038, 0x0038, null, 0, 0);
    public static VirtualKeyModel N9 = new ("N9", KeyType.Text, "9", "9", 0x0039, 0x0039, null, 0, 0);
    public static VirtualKeyModel N0 = new ("N0", KeyType.Text, "0", "0", 0x0030, 0x0030, null, 0, 0);

    public static VirtualKeyModel A = new ("A", KeyType.Text, "A", "a", 0x0041, 0x0061, null, 0, 0);
    public static VirtualKeyModel B = new ("B", KeyType.Text, "B", "b", 0x0042, 0x0062, null, 0, 0);
    public static VirtualKeyModel C = new ("C", KeyType.Text, "C", "c", 0x0043, 0x0063, null, 0, 0);
    public static VirtualKeyModel D = new ("D", KeyType.Text, "D", "d", 0x0044, 0x0064, null, 0, 0);
    public static VirtualKeyModel E = new ("E", KeyType.Text, "E", "e", 0x0045, 0x0065, null, 0, 0);
    public static VirtualKeyModel F = new ("F", KeyType.Text, "F", "f", 0x0046, 0x0066, null, 0, 0);
    public static VirtualKeyModel G = new ("G", KeyType.Text, "G", "g", 0x0047, 0x0067, null, 0, 0);
    public static VirtualKeyModel H = new ("H", KeyType.Text, "H", "h", 0x0048, 0x0068, null, 0, 0);
    public static VirtualKeyModel I = new ("I", KeyType.Text, "I", "i", 0x0049, 0x0069, null, 0, 0);
    public static VirtualKeyModel J = new ("J", KeyType.Text, "J", "j", 0x004A, 0x006A, null, 0, 0);
    public static VirtualKeyModel K = new ("K", KeyType.Text, "K", "k", 0x004B, 0x006B, null, 0, 0);
    public static VirtualKeyModel L = new ("L", KeyType.Text, "L", "l", 0x004C, 0x006C, null, 0, 0);
    public static VirtualKeyModel M = new ("M", KeyType.Text, "M", "m", 0x004D, 0x006D, null, 0, 0);
    public static VirtualKeyModel N = new ("N", KeyType.Text, "N", "n", 0x004E, 0x006E, null, 0, 0);
    public static VirtualKeyModel O = new ("O", KeyType.Text, "O", "o", 0x004F, 0x006F, null, 0, 0);
    public static VirtualKeyModel P = new ("P", KeyType.Text, "P", "p", 0x0050, 0x0070, null, 0, 0);
    public static VirtualKeyModel Q = new ("Q", KeyType.Text, "Q", "q", 0x0051, 0x0071, null, 0, 0);
    public static VirtualKeyModel R = new ("R", KeyType.Text, "R", "r", 0x0052, 0x0072, null, 0, 0);
    public static VirtualKeyModel S = new ("S", KeyType.Text, "S", "s", 0x0053, 0x0073, null, 0, 0);
    public static VirtualKeyModel T = new ("T", KeyType.Text, "T", "t", 0x0054, 0x0074, null, 0, 0);
    public static VirtualKeyModel U = new ("U", KeyType.Text, "U", "u", 0x0055, 0x0075, null, 0, 0);
    public static VirtualKeyModel V = new ("V", KeyType.Text, "V", "v", 0x0056, 0x0076, null, 0, 0);
    public static VirtualKeyModel W = new ("W", KeyType.Text, "W", "w", 0x0057, 0x0077, null, 0, 0);
    public static VirtualKeyModel X = new ("X", KeyType.Text, "X", "x", 0x0058, 0x0078, null, 0, 0);
    public static VirtualKeyModel Y = new ("Y", KeyType.Text, "Y", "y", 0x0059, 0x0079, null, 0, 0);
    public static VirtualKeyModel Z = new ("Z", KeyType.Text, "Z", "z", 0x005A, 0x007A, null, 0, 0);

    public static VirtualKeyModel Point = new ("Point", KeyType.Text, ".", ".", 0x002E, 0x002E, null, 0, 0);
    public static VirtualKeyModel Comma = new ("Comma", KeyType.Text, ",", ",", 0x002C, 0x002C, null, 0, 0);
    public static VirtualKeyModel Plus = new ("Plus", KeyType.Text, "+", "+", 0x002B, 0x002B, null, 0, 0);
    public static VirtualKeyModel Dash = new ("Dash", KeyType.Text, "-", "-", 0x002D, 0x002D, null, 0, 0);
    public static VirtualKeyModel Asterisk = new ("Asterisk", KeyType.Text, "*", "*", 0x002A, 0x002A, null, 0, 0);
    public static VirtualKeyModel Slash = new ("Slash", KeyType.Text, "/", "/", 0x002F, 0x002F, null, 0, 0);
    public static VirtualKeyModel At = new ("At", KeyType.Text, "@", "@", 0x0040, 0x0040, null, 0, 0);
    public static VirtualKeyModel Hash = new ("Hash", KeyType.Text, "#", "#", 0x0023, 0x0023, null, 0, 0);
    public static VirtualKeyModel Dollar = new ("Dollar", KeyType.Text, "$", "$", 0x0024, 0x0024, null, 0, 0);
    public static VirtualKeyModel Euro = new ("Euro", KeyType.Text, "€", "€", 0x20AC, 0x20AC, null, 0, 0);
    public static VirtualKeyModel Underscore = new ("Underscore", KeyType.Text, "_", "_", 0x005F, 0x005F, null, 0, 0);
    public static VirtualKeyModel Ampersand = new ("Ampersand", KeyType.Text, "&", "&", 0x0026, 0x0026, null, 0, 0);
    public static VirtualKeyModel LParenthesis = new ("LParenthesis", KeyType.Text, "(", "(", 0x0028, 0x0028, null, 0, 0);
    public static VirtualKeyModel RPArenthesis = new ("RParenthesis", KeyType.Text, ")", ")", 0x0029, 0x0029, null, 0, 0);
    public static VirtualKeyModel SingleQuote = new ("SingleQuote", KeyType.Text, "'", "'", 0x0027, 0x0027, null, 0, 0);
    public static VirtualKeyModel Colon = new ("Colon", KeyType.Text, ":", ":", 0x003A, 0x003A, null, 0, 0);
    public static VirtualKeyModel Semicolon = new ("Semicolon", KeyType.Text, ";", ";", 0x003B, 0x003B, null, 0, 0);
    public static VirtualKeyModel Exclamation = new ("Exclamation", KeyType.Text, "!", "!", 0x0021, 0x0021, null, 0, 0);
    public static VirtualKeyModel Question = new ("Question", KeyType.Text, "?", "?", 0x003F, 0x003F, null, 0, 0);
    public static VirtualKeyModel Percent = new ("Percent", KeyType.Text, "%", "%", 0x0025, 0x0025, null, 0, 0);
    public static VirtualKeyModel Equal = new ("Equal", KeyType.Text, "=", "=", 0x003D, 0x003D, null, 0, 0);
    public static VirtualKeyModel LessThan = new ("LessThan", KeyType.Text, "<", "<", 0x003C, 0x003C, null, 0, 0);
    public static VirtualKeyModel GreatThan = new ("GreatThan", KeyType.Text, ">", ">", 0x003E, 0x003E, null, 0, 0);
    public static VirtualKeyModel LSquare = new ("LSquare", KeyType.Text, "[", "[", 0x005B, 0x005B, null, 0, 0);
    public static VirtualKeyModel RSquare = new ("RSquare", KeyType.Text, "]", "]", 0x005D, 0x005D, null, 0, 0);
    public static VirtualKeyModel LCurly = new ("LCurly", KeyType.Text, "{", "{", 0x007B, 0x007B, null, 0, 0);
    public static VirtualKeyModel RCurly = new ("RCurly", KeyType.Text, "}", "}", 0x007D, 0x007D, null, 0, 0);
    public static VirtualKeyModel Backslash = new ("Backslash", KeyType.Text, "\\",  "\\",  0x005C, 0x005C, null, 0, 0);
    public static VirtualKeyModel Quote = new ("Quote", KeyType.Text, "\"",  "\"",  0x002A, 0x002A, null, 0, 0);
    public static VirtualKeyModel Space = new ("Space", KeyType.Space, " ", " ", 0x0020, 0x0020, KeyPathGeometry.Space, 10,  10);
    public static VirtualKeyModel Enter = new ("Enter", KeyType.Enter, "", "", 0x0000, 0x0000, KeyPathGeometry.Enter, 10, 12);
    public static VirtualKeyModel Shift = new ("Shift", KeyType.Shift, "", "", 0x0000, 0x0000, KeyPathGeometry.Shift, 10, 10);
    public static VirtualKeyModel Back = new ("Back", KeyType.Back, "", "", 0x0000, 0x0000, KeyPathGeometry.Back, 12, 10);
    public static VirtualKeyModel Symbols = new ("Sybols", KeyType.Symbols, "&123", "&123", 0x0002, 0x0002, null, 0, 0);
    public static VirtualKeyModel Alfa = new ("Alfa", KeyType.Alfa, "ABC", "ABC", 0x0001, 0x0001, null,1, 4);

}
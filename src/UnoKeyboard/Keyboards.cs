using UnoKeyboard.Models;

namespace UnoKeyboard;

public static class Keyboards
{
    public static Dictionary<string, KeyboardModel> Keyboard = new()
    {
        {
            "en-alfa",
            new KeyboardModel(
                "en-alfa",
                KeyboardType.Alphanumeric,
                2,  // Pages
                5,  // Max. lines per page
                10, // Max. keys per line
                [
                    new KeyModel(KeyType.Text, 0, 0, 0, 1, "1", "1", 0x0031, 0x0031),
                    new KeyModel(KeyType.Text, 0, 0, 1, 1, "2", "2", 0x0032, 0x0032),
                    new KeyModel(KeyType.Text, 0, 0, 2, 1, "3", "3", 0x0033, 0x0033),
                    new KeyModel(KeyType.Text, 0, 0, 3, 1, "4", "4", 0x0034, 0x0034),
                    new KeyModel(KeyType.Text, 0, 0, 4, 1, "5", "5", 0x0035, 0x0035),
                    new KeyModel(KeyType.Text, 0, 0, 5, 1, "6", "6", 0x0036, 0x0036),
                    new KeyModel(KeyType.Text, 0, 0, 6, 1, "7", "7", 0x0037, 0x0037),
                    new KeyModel(KeyType.Text, 0, 0, 7, 1, "8", "8", 0x0038, 0x0038),
                    new KeyModel(KeyType.Text, 0, 0, 8, 1, "9", "9", 0x0039, 0x0039),
                    new KeyModel(KeyType.Text, 0, 0, 9, 1, "0", "0", 0x0030, 0x0030),

                    new KeyModel(KeyType.Text, 0, 1, 0, 1, "Q", "q", 0x0051, 0x0071),
                    new KeyModel(KeyType.Text, 0, 1, 1, 1, "W", "w", 0x0057, 0x0077),
                    new KeyModel(KeyType.Text, 0, 1, 2, 1, "E", "e", 0x0045, 0x0065),
                    new KeyModel(KeyType.Text, 0, 1, 3, 1, "R", "r", 0x0052, 0x0072),
                    new KeyModel(KeyType.Text, 0, 1, 4, 1, "T", "t", 0x0054, 0x0074),
                    new KeyModel(KeyType.Text, 0, 1, 5, 1, "Y", "y", 0x0059, 0x0079),
                    new KeyModel(KeyType.Text, 0, 1, 6, 1, "U", "u", 0x0055, 0x0075),
                    new KeyModel(KeyType.Text, 0, 1, 7, 1, "I", "i", 0x0049, 0x0069),
                    new KeyModel(KeyType.Text, 0, 1, 8, 1, "O", "o", 0x004F, 0x006F),
                    new KeyModel(KeyType.Text, 0, 1, 9, 1, "P", "p", 0x0050, 0x0070),

                    new KeyModel(KeyType.Text, 0, 2, 0, 1, "A", "a", 0x0041, 0x0061),
                    new KeyModel(KeyType.Text, 0, 2, 1, 1, "S", "s", 0x0053, 0x0073),
                    new KeyModel(KeyType.Text, 0, 2, 2, 1, "D", "d", 0x0044, 0x0064),
                    new KeyModel(KeyType.Text, 0, 2, 3, 1, "F", "f", 0x0046, 0x0066),
                    new KeyModel(KeyType.Text, 0, 2, 4, 1, "G", "g", 0x0047, 0x0067),
                    new KeyModel(KeyType.Text, 0, 2, 5, 1, "H", "h", 0x0048, 0x0068),
                    new KeyModel(KeyType.Text, 0, 2, 6, 1, "J", "j", 0x004A, 0x006A),
                    new KeyModel(KeyType.Text, 0, 2, 7, 1, "K", "k", 0x004B, 0x006B),
                    new KeyModel(KeyType.Text, 0, 2, 8, 1, "L", "l", 0x004C, 0x006C),

                    new KeyModel(KeyType.Shift,     0, 3, 0, 1, "",  "",  0x0000, 0x0000),
                    new KeyModel(KeyType.Text,      0, 3, 1, 1, "Z", "z", 0x005A, 0x007A),
                    new KeyModel(KeyType.Text,      0, 3, 2, 1, "X", "x", 0x0058, 0x0078),
                    new KeyModel(KeyType.Text,      0, 3, 3, 1, "C", "c", 0x0043, 0x0063),
                    new KeyModel(KeyType.Text,      0, 3, 4, 1, "V", "v", 0x0056, 0x0076),
                    new KeyModel(KeyType.Text,      0, 3, 5, 1, "B", "b", 0x0042, 0x0062),
                    new KeyModel(KeyType.Text,      0, 3, 6, 1, "N", "n", 0x004E, 0x006E),
                    new KeyModel(KeyType.Text,      0, 3, 7, 1, "M", "m", 0x004D, 0x006D),
                    new KeyModel(KeyType.Text,      0, 3, 8, 1, ".", ".", 0x002E, 0x002E),
                    new KeyModel(KeyType.Backspace, 0, 3, 9, 1, "",  "",  0x0000, 0x0000),

                    new KeyModel(KeyType.NextPage, 0, 4, 0, 2, "&123", "&123", 0x0002, 0x0002),
                    new KeyModel(KeyType.Text,     0, 4, 1, 5, " ",     " ",   0x0020, 0x0020),
                    new KeyModel(KeyType.Text,     0, 4, 2, 1, ",",    ",",    0x002C, 0x002C),
                    new KeyModel(KeyType.Enter,    0, 4, 3, 2, "",     "",     0x0000, 0x0000),

                    new KeyModel(KeyType.Text, 1, 0, 0, 1, "1", "1", 0x0031, 0x0031),
                    new KeyModel(KeyType.Text, 1, 0, 1, 1, "2", "2", 0x0032, 0x0032),
                    new KeyModel(KeyType.Text, 1, 0, 2, 1, "3", "3", 0x0033, 0x0033),
                    new KeyModel(KeyType.Text, 1, 0, 3, 1, "4", "4", 0x0034, 0x0034),
                    new KeyModel(KeyType.Text, 1, 0, 4, 1, "5", "5", 0x0035, 0x0035),
                    new KeyModel(KeyType.Text, 1, 0, 5, 1, "6", "6", 0x0036, 0x0036),
                    new KeyModel(KeyType.Text, 1, 0, 6, 1, "7", "7", 0x0037, 0x0037),
                    new KeyModel(KeyType.Text, 1, 0, 7, 1, "8", "8", 0x0038, 0x0038),
                    new KeyModel(KeyType.Text, 1, 0, 8, 1, "9", "9", 0x0039, 0x0039),
                    new KeyModel(KeyType.Text, 1, 0, 9, 1, "0", "0", 0x0030, 0x0030),

                    new KeyModel(KeyType.Text, 1, 1, 0, 1, "@", "@", 0x0040, 0x0040),
                    new KeyModel(KeyType.Text, 1, 1, 1, 1, "#", "#", 0x0023, 0x0023),
                    new KeyModel(KeyType.Text, 1, 1, 2, 1, "$", "$", 0x0024, 0x0024),
                    new KeyModel(KeyType.Text, 1, 1, 3, 1, "_", "_", 0x005F, 0x005F),
                    new KeyModel(KeyType.Text, 1, 1, 4, 1, "&", "&", 0x0026, 0x0026),
                    new KeyModel(KeyType.Text, 1, 1, 5, 1, "-", "-", 0x002D, 0x002D),
                    new KeyModel(KeyType.Text, 1, 1, 6, 1, "+", "+", 0x002B, 0x002B),
                    new KeyModel(KeyType.Text, 1, 1, 7, 1, "(", "(", 0x0028, 0x0028),
                    new KeyModel(KeyType.Text, 1, 1, 8, 1, ")", ")", 0x0029, 0x0029),
                    new KeyModel(KeyType.Text, 1, 1, 9, 1, "/", "/", 0x002F, 0x002F),

                    new KeyModel(KeyType.Text, 1, 2, 0, 1, "*",  "*",  0x002A, 0x002A),
                    new KeyModel(KeyType.Text, 1, 2, 1, 1, "\"", "\"", 0x0022, 0x0022),
                    new KeyModel(KeyType.Text, 1, 2, 2, 1, "$",  "$",  0x0024, 0x0024),
                    new KeyModel(KeyType.Text, 1, 2, 3, 1, "'",  "'",  0x0027, 0x0027),
                    new KeyModel(KeyType.Text, 1, 2, 4, 1, "&",  "&",  0x0026, 0x0026),
                    new KeyModel(KeyType.Text, 1, 2, 5, 1, "-",  "-",  0x002D, 0x002D),
                    new KeyModel(KeyType.Text, 1, 2, 6, 1, ":",  ":",  0x003A, 0x003A),
                    new KeyModel(KeyType.Text, 1, 2, 7, 1, ";",  ";",  0x003B, 0x003B),
                    new KeyModel(KeyType.Text, 1, 2, 8, 1, "?",  "?",  0x003F, 0x003F), 

                    new KeyModel(KeyType.Text, 1, 3, 0, 1, "=", "=", 0x003D, 0x003D),
                    new KeyModel(KeyType.Text, 1, 3, 1, 1, "{", "{", 0x007B, 0x007B),
                    new KeyModel(KeyType.Text, 1, 3, 2, 1, "}", "}", 0x007D, 0x007D),
                    new KeyModel(KeyType.Text, 1, 3, 3, 1, "[", "[", 0x005B, 0x005B),
                    new KeyModel(KeyType.Text, 1, 3, 4, 1, "]", "]", 0x005D, 0x005D),
                    new KeyModel(KeyType.Text, 1, 3, 5, 1, "%", "%", 0x0025, 0x0025),
                    new KeyModel(KeyType.Text, 1, 3, 6, 1, "º", "º", 0x00BA, 0x00BA),
                    new KeyModel(KeyType.Text, 1, 3, 7, 1, "ª", "ª", 0x00AA, 0x00AA),
                    new KeyModel(KeyType.Text, 1, 3, 8, 1, "€", "€", 0x20AC, 0x20AC),

                    new KeyModel(KeyType.PrevPage, 1, 4, 0, 2, "ABC", "ANC", 0x0002, 0x0002),
                    new KeyModel(KeyType.Text,     1, 4, 1, 5, " ",   " ",   0x0020, 0x0020),
                    new KeyModel(KeyType.Text,     1, 4, 2, 1, ",",   ",",   0x002C, 0x002C),
                    new KeyModel(KeyType.Enter,    1, 4, 3, 2, "",    "",    0x0000, 0x0000),
                ]
            )
        }
    };
}

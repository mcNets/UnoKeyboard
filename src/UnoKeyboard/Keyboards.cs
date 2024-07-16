using UnoKeyboard.Models;

namespace UnoKeyboard;

public static class Keyboards
{
    public static Dictionary<string, List<KeyboardModel>> Keyboard = new()
    {
        {
            "en",
            [
                new KeyboardModel(
                    "en-alfa",
                    KeyboardType.Alphanumeric,
                    3,  // Max Pages
                    3,  // Max lines per page
                    10, // Max keys per line
                    [
                        new KeyModel(KeyType.Text, 0, 0, 0, "Q", "q", 0x0051, 0x0071),
                        new KeyModel(KeyType.Text, 0, 0, 1, "W", "w", 0x0057, 0x0077),
                        new KeyModel(KeyType.Text, 0, 0, 2, "E", "e", 0x0045, 0x0065),
                        new KeyModel(KeyType.Text, 0, 0, 3, "R", "r", 0x0052, 0x0072),
                        new KeyModel(KeyType.Text, 0, 0, 4, "T", "t", 0x0054, 0x0074),
                        new KeyModel(KeyType.Text, 0, 0, 5, "Y", "y", 0x0059, 0x0079),
                        new KeyModel(KeyType.Text, 0, 0, 6, "U", "u", 0x0055, 0x0075),
                        new KeyModel(KeyType.Text, 0, 0, 7, "I", "i", 0x0049, 0x0069),
                        new KeyModel(KeyType.Text, 0, 0, 8, "O", "o", 0x004F, 0x006F),
                        new KeyModel(KeyType.Text, 0, 0, 9, "P", "p", 0x0050, 0x0070),

                        new KeyModel(KeyType.Text, 0, 1, 0, "A", "s", 0x0041, 0x0061),
                        new KeyModel(KeyType.Text, 0, 1, 1, "S", "s", 0x0053, 0x0073),
                        new KeyModel(KeyType.Text, 0, 1, 2, "D", "d", 0x0044, 0x0064),
                        new KeyModel(KeyType.Text, 0, 1, 3, "F", "f", 0x0046, 0x0066),
                        new KeyModel(KeyType.Text, 0, 1, 4, "G", "g", 0x0047, 0x0067),
                        new KeyModel(KeyType.Text, 0, 1, 5, "H", "h", 0x0048, 0x0068),
                        new KeyModel(KeyType.Text, 0, 1, 6, "J", "j", 0x004A, 0x006A),
                        new KeyModel(KeyType.Text, 0, 1, 7, "K", "k", 0x004B, 0x006B),
                        new KeyModel(KeyType.Text, 0, 1, 8, "L", "l", 0x004C, 0x006C),

                        new KeyModel(KeyType.Text, 0, 2, 0, "Z", "s", 0x005A, 0x007A),
                        new KeyModel(KeyType.Text, 0, 2, 1, "X", "s", 0x0058, 0x0078),
                        new KeyModel(KeyType.Text, 0, 2, 2, "C", "s", 0x0043, 0x0063),
                        new KeyModel(KeyType.Text, 0, 2, 3, "V", "s", 0x0056, 0x0076),
                        new KeyModel(KeyType.Text, 0, 2, 4, "B", "s", 0x0042, 0x0062),
                        new KeyModel(KeyType.Text, 0, 2, 5, "N", "s", 0x004E, 0x006E),
                        new KeyModel(KeyType.Text, 0, 2, 6, "M", "s", 0x004D, 0x006D),
                        new KeyModel(KeyType.Text, 0, 2, 7, ".", ",", 0x002E, 0x002C),

                        new KeyModel(KeyType.Text, 1, 0, 0, "1", "1", 0x0031, 0x0031),
                        new KeyModel(KeyType.Text, 1, 0, 1, "2", "2", 0x0032, 0x0032),
                        new KeyModel(KeyType.Text, 1, 0, 2, "3", "3", 0x0033, 0x0033),
                        new KeyModel(KeyType.Text, 1, 0, 3, "4", "4", 0x0034, 0x0034),
                        new KeyModel(KeyType.Text, 1, 0, 4, "5", "5", 0x0035, 0x0035),
                        new KeyModel(KeyType.Text, 1, 0, 5, "6", "6", 0x0036, 0x0036),
                        new KeyModel(KeyType.Text, 1, 0, 6, "7", "7", 0x0037, 0x0037),
                        new KeyModel(KeyType.Text, 1, 0, 7, "8", "8", 0x0038, 0x0038),
                        new KeyModel(KeyType.Text, 1, 0, 8, "9", "9", 0x0039, 0x0039),
                        new KeyModel(KeyType.Text, 1, 0, 9, "0", "0", 0x0030, 0x0030),
                    ]
                )
            ]
        }
    };
}

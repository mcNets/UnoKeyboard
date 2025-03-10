namespace UnoKeyboard;

/// <summary>
/// Represents a whole keyboard.
/// </summary>
/// <param name="Id">KeyId must be unique</param>
/// <param name="Pages">Number of pages of the Keyboard</param>
/// <param name="Rows">Max. number of rows per page.</param>
/// <param name="MaxKeys">Max. number of keys per row</param>
/// <param name="Keys">List of keys</param>
public record KeyboardModel(string Id, 
                            int Pages, 
                            int Rows, 
                            int MaxKeys, 
                            List<KeyModel> Keys);

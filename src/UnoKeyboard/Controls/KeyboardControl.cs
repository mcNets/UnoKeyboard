using Windows.Foundation;

namespace UnoKeyboard.Controls;

public sealed class KeyboardControl : Panel
{
    public KeyboardControl()
    {
    }

    protected override Size MeasureOverride(Size availableSize)
    {
        return base.MeasureOverride(availableSize);
    }

    protected override Size ArrangeOverride(Size finalSize)
    {
        return base.ArrangeOverride(finalSize);
    }
}

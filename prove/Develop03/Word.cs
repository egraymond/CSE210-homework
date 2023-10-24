class Word
{
    public string Text { get; set; }
    public bool Hidden { get; set; }

    public Word(string text)
    {
        Text = text;
        Hidden = false;
    }

    public void Hide()
    {
        Hidden = true;
    }

    public void Show()
    {
        Hidden = false;
    }

    public string GetRenderedText()
    {
        if (Hidden)
        {
            return "*****";
        }
        else
        {
            return Text;
        }
    }

    public bool IsHidden()
    {
        return Hidden;
    }
}

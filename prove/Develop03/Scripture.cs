class Scripture
{
    private bool isVisible;
    public string Reference { get; }
    private List<Word> Words;
    private List<int> HiddenWordTracker;

    public Scripture(string reference)
    {
        isVisible = true;
        Reference = reference;
        Words = new List<Word>();
        HiddenWordTracker = new List<int>();
    }

    public Scripture(string reference, string text) : this(reference)
    {
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            Words.Add(new Word(word));
        }
    }

    public void HideWords(int count)
    {
        int hiddenCount = 0;
        for (int i = 0; i < Words.Count; i++)
        {
            if (!Words[i].IsHidden())
            {
                Words[i].Hide();
                HiddenWordTracker.Add(i);
                hiddenCount++;
            }

            if (hiddenCount >= count)
            {
                break;
            }
        }

        if (hiddenCount == 0)
        {
            isVisible = false;
        }
    }

    public string DisplayText()
    {
        if (isVisible)
        {
            string displayedText = "";
            foreach (Word word in Words)
            {
                displayedText += word.GetRenderedText() + " ";
            }
            return displayedText;
        }
        else
        {
            return "This scripture is completely hidden.";
        }
    }

    public bool IsCompletelyHidden()
    {
        return !isVisible;
    }
}

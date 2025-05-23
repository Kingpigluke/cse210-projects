public class Reference
{
    private string _bookName;
    private int _chapter;
    private int _startVerse;
    private string _endVerse;
    public string GetReference()
    {
        return $"{_bookName} {_chapter}:{_startVerse}-{_endVerse}";
    }
    public string GetText()
    {
        string displayedText = _text;
        foreach (string word in _hiddenWords)
        {
            displayedText = displayedText.Replace(word, "____");
        }
        return displayedText;
    }
    public bool IsCompletelyHidden()
    {
        string[] words = _text.Split(' ');
        foreach (string word in words)
        {
            if (!_hiddenWords.Contains(word))
            {
                return false;
            }
        }
        return true;
    }
    public void ShowReference()
    {
        Console.WriteLine($"Reference: {_reference}");
    }
    public void ShowText()
    {
        Console.WriteLine("Scripture:");
        Console.WriteLine(_text);
    }
}
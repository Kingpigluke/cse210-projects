using System.Runtime.CompilerServices;

namespace Scripture

{
    public class Scripture
    {
        private Reference _reference;
        private string _text;
        private List<string> _hiddenWords;

        public Scripture(string reference, string text)
        {
            _reference = reference;
            _text = text;
            _hiddenWords = new List<string>();
        }

        public void ShowScripture()
        {
            Console.WriteLine($"Reference: {_reference}");
            Console.WriteLine("Scripture:");
            Console.WriteLine(GetText());
        }
        public void ShowFullScripture()
        {
            Console.WriteLine($"Reference: {_reference}");
            Console.WriteLine("Full Scripture:");
            Console.WriteLine(_text);
        }
    }
}



private class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        Word = new List<string>();
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
{
    public void ShowHiddenWordsCount()
    {
        Console.WriteLine($"Number of hidden words: {_hiddenWords.Count}");
    }
    public void ShowHiddenWordsList()
    {
        Console.WriteLine("Hidden words:");
        foreach (string word in _hiddenWords)
        {
            Console.WriteLine(word);
        }
    }
    public void HideRandomWords(int numberOfWords)
    {
        string[] words = _text.Split(' ');
        Random random = new Random();
        for (int i = 0; i < numberOfWords; i++)
        {
            int index = random.Next(words.Length);
            if (!_hiddenWords.Contains(words[index]))
            {
                _hiddenWords.Add(words[index]);
            }
        }
    }
    public void ShowHiddenWords()
    {
        Console.WriteLine("Hidden words:");
        foreach (string word in _hiddenWords)
        {
            Console.WriteLine(word);
        }
    }
}
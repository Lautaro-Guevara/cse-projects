public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(" ");

        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int visibleWords = _words.Count(w => !w.IsHidden());

        numberToHide = Math.Min(numberToHide, visibleWords);
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int randomNumber;

            do
            {
                randomNumber = random.Next(0, _words.Count);
            } while (_words[randomNumber].IsHidden());

            _words[randomNumber].Hide();
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));

        return $"{_reference.GetDisplayText()} {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        
        return true;
    }
}
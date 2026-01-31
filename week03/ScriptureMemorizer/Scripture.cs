using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] splitWords = text.Split(' ');
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numbertoHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numbertoHide && !IsCompletelyHidden())
        {
            int index = random.Next(_words.Count);
            if (!_words[index].isHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }

        }
    }

    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()} {scriptureText.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.isHidden()) return false;
        }
        return true;
    }
}
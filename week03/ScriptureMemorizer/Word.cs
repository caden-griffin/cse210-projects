public class Word
{
    private string _text;
    private bool _IsHidden;

    public Word(string text)
    {
        _text = text;
        _IsHidden = false;
    }

    public void Hide()
    {
        _IsHidden = true;
    }

    public void Show()
    {
        _IsHidden = false;
    }
    
    public string GetDisplayText()
    {
        if (_IsHidden == false)
        {
            return _text;
        }

        else
        {
            return new string('_', _text.Length);
        }
    }
}

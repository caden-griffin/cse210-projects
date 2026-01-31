using System;
using System.Collections.Generic;

public class Word
{
    private string _text;
    public bool _IsHidden;
    public Word(string text)
    {
        _text = text;
        _IsHidden = false;
    }

    public void Hide() => _IsHidden = true;

    public bool isHidden() => _IsHidden;

    public string GetDisplayText()
    {
        if (_IsHidden)
        {
            return new string('_', _text.Length);
        }
        return _text;
    }
}
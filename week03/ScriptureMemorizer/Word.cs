public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Returns true if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Returns the word or underscores
    public string GetDisplayText()
    {
        if (_isHidden)
            return new string('_', _text.Length);
        else
            return _text;
    }
}

public class Word
{
    private string _text;
    private bool _isHidden;

    // CONSTRUCTORS
    public Word()
    {
        _text = "Unknown Text";
        _isHidden = false;
    }
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public Word(string text, bool isHidden = false)
    {
        _text = text;
        _isHidden = isHidden;
    }

    // GETTERS AND SETTERS
    public string GetText()
    {
        return _text;
    }

    public void SetText(string value)
    {
        _text = value;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public void SetIsHidden(bool value)
    {
        _isHidden = value;
    }

    // METHODS
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? "_____" : _text;
    }
}
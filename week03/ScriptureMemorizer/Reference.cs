public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // CONSTRUCTORS
    public Reference()
    {
        _book = "Unknown Book";
        _chapter = 0;
        _verse = 0;
        _endVerse = 0;
    }
    public Reference(string book)
    {
        _book = book;
        _chapter = 0;
        _verse = 0;
        _endVerse = 0;
    }
    public Reference(string book, int chapter)
    {
        _book = book;
        _chapter = chapter;
        _verse = 0;      // meaning no specific verse, same as those above
        _endVerse = 0;   // meaning no range, same as those above
    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // GETTERS AND SETTERS
    public string GetBook()
    {
        return _book;
    }

    public void SetBook(string book)
    {
        _book = book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }

    public int GetVerse()
    {
        return _verse;
    }

    public void SetVerse(int verse)
    {
        _verse = verse;
    }

    public int GetEndVerse()
    {
        return _endVerse;
    }

    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }
    // METHODS
    public string GetDisplayText()
    {
        if (_verse == _endVerse)
            return $"{_book} {_chapter}:{_verse}";
        else
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}
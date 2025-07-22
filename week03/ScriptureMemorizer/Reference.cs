public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    // One constructor is going to be with more 
    // than one verse and other one just one verse.
    // for example 1Nefi 3:7 
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    // for example 1Nefi 3:7 
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }
    public string Display()
    //two different display in case the 
    //console shows one verse or more than one.
    {
        if (_verse == _endVerse)
        {
            // example 1Nefi 3:7
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            // example 1Nefi 3:7-8
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}
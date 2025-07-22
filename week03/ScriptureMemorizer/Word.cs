public class Word
{
    private string _text;
    private bool _hidden = false;

    public Word(string text)
    {
        _text = text;
    }

    // Used to hide a word by setting it to true.
    // If we use word.ToString() while hidden, it will print "__".
    public void Hide()
    {
        _hidden = true;
    }

    // Returns true if the word is hidden, and false if it is visible.
    // It's important not to hide words that are already hidden.
    public bool Hidden()
    {
        return _hidden;
    }

    // Determines how the word should appear in the text.
    // If hidden is false, it shows the word normally.
    // If hidden is true, it displays underscores for each character in the word.
    public string Display()
    {
        // If the word is hidden, show "_" for each character,
        // using the Length of the word to build the string.
        if (_hidden)
        {
            return new String('_', _text.Length);
        }
        // Otherwise, return the word itself.
        else
        {
            return _text;
        }
    }
}
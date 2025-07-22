public class Scripture
{
    // The Scripture class will hold a reference object
    private List<Word> _wordList = new List<Word>();
    private Reference _reference;

    public Scripture(Reference reference, string text)
    // Example usage: scripture('book', chapter, verse, 'scripture text...')
    {
        _reference = reference;
        // Split the input text into an array of words based on spaces.
        // Then, iterate through each word to create Word objects.
        // This allows us to know each word's length for hiding purposes.
        string[] parts = text.Split(' ');
        for (int i = 0; i < parts.Length; i++)
        {
            Word word = new Word(parts[i]);
            _wordList.Add(word);
        }
    }

    // This method randomly hides words based on the given count.
    public void HideRandom(int hidding)
    {
        Random random = new Random();
        int hiddenCount = 0;
        // Use a while loop to continue hiding words until the requested number is reached
        // or until all words are hidden.

        while (hidding > hiddenCount)
        {
            // Make sure a word isn't hidden more than once.
            // Select a random word from the list and check its hidden state.
            int index = random.Next(_wordList.Count);
            Word word = _wordList[index];
            if (!word.Hidden())
            {
                word.Hide();
                hiddenCount++;
            }
            // Stop the loop if all words are hidden.
            if (IsAllHidden())
            {
                break;
            }
        }
    }

    // Checks if every word in the list is currently hidden.
    // Returns false if any word is still visible; otherwise, returns true.
    public bool IsAllHidden()
    {
        for (int i = 0; i < _wordList.Count; i++)
        {
            if (!_wordList[i].Hidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplay()
    {
        // Start by getting the full reference display string.
        string refe = _reference.Display() + "\n";
        // Loop through all words, appending each word's display form (hidden or visible)
        // with a space after it.
        for (int i = 0; i < _wordList.Count; i++)
        {
            refe += _wordList[i].Display() + " ";
        }
        return refe;
    }
}
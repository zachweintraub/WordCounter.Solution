namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _target;
    private string _phrase;
    private bool _isCaseSensitive;

    public RepeatCounter(string Target, string Phrase, bool IsCaseSensitive)
    {
      _target = Target;
      _phrase = Phrase;
      _isCaseSensitive = IsCaseSensitive;
    }

    public string GetPhrase()
    {
      return _phrase;
    }

    public string GetTarget()
    {
      return _target;
    }


    public int CalculateCount()
    {
      int counter = 0;
      string target = _target;
      string phrase = _phrase;
      if(!_isCaseSensitive)
      {
        phrase = phrase.ToLower();
        target = target.ToLower();
      }
      string[] wordsInPhrase = phrase.Split(" ");
      foreach (string word in wordsInPhrase)
      {
        if(word == target)
        {
          counter++;
        }
      }
      return counter;
    }
  }
}

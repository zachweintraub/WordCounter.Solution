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
  }
}

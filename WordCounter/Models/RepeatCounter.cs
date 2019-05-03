using System;
using System.Text.RegularExpressions; //sorry but i couldn't resist
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _target;
    private string _phrase;
    private bool _isCaseSensitive;
    private int _id;
    private DateTime _searchTime;
    private static List<RepeatCounter> _allSearches = new List<RepeatCounter>{};

    public RepeatCounter(string Target, string Phrase, bool IsCaseSensitive)
    {
      _target = Target;
      _phrase = Phrase;
      _isCaseSensitive = IsCaseSensitive;
      _searchTime = DateTime.Now;
      _allSearches.Add(this);
      _id = _allSearches.Count;
    }

    public string GetPhrase()
    {
      return _phrase;
    }

    public string GetTarget()
    {
      return _target;
    }

    public DateTime GetSearchTime()
    {
      return _searchTime;
    }

    public int GetId()
    {
      return _id;
    }

    public bool GetCaseSensitive()
    {
      return _isCaseSensitive;
    }

    public static List<RepeatCounter> GetAllSearches()
    {
      return _allSearches;
    }

    public static RepeatCounter Find(int id)
    {
      return _allSearches[id-1];
    }

    public static void ClearHistory()
    {
      _allSearches.Clear();
    }

    public int CalculateCount()
    {
      int counter = 0;
      if(_phrase == "")
      {
        return counter;
      }
      string target = _target;
      string phrase = Regex.Replace(_phrase, @"\p{P}", "");
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

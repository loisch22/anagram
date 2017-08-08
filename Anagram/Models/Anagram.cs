using System;
using System.Collections.Generic;

namespace Anagrams.Models
{
  public class Anagram
  {
    private string _wordInput;
    private string _possibleAnagramInput;

    private static List<string> _wordInputList= new List<string> {};
    private static List<string> _inputPossibleAnagramList= new List<string> {};
    private static List<string> _outputIsAnagramList= new List<string> {};

    public Anagram(string wordInput, string possibleAnagramInput)
    {
      _wordInput = wordInput;
      _possibleAnagramInput = possibleAnagramInput;
      _wordInputList.Add(_wordInput);
      _inputPossibleAnagramList.Add(_possibleAnagramInput);
    }

    public string GetWordInput()
    {
      return _wordInput;
    }
    public string GetPossibleAnagramInput()
    {
      return _possibleAnagramInput;
    }
    public List<string> CheckAnagram()
    {
      char[] wordArray = _wordInputList[0].ToCharArray();
      char[] possibleAnagramArray = _inputPossibleAnagramList[0].ToCharArray();

      for(int i = 0; i < wordArray.Length; i++)
      {
        for(int j = 0; j < possibleAnagramArray.Length; j++)
        {
          if (wordArray[i] != possibleAnagramArray[j])
          {
            _outputIsAnagramList.Add("not an anagram");
            return _outputIsAnagramList;
          }
        }
      }
      return _outputIsAnagramList;
    }

    public static void ClearAll()
    {
      _inputPossibleAnagramList.Clear();
      _outputIsAnagramList.Clear();
    }
  }
}

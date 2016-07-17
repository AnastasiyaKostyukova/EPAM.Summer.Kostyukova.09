using System;
using System.Collections.Generic;
using System.IO;

namespace Task3Logic
{
  /// <summary>
  /// class for count words in text
  /// </summary>
  public class WordCounter
  {
    /// <summary>
    /// method Counter
    /// </summary>
    /// <param name="filePath">Path to text file</param>
    /// <returns>method returns Dictionary<string, int></returns>
    public Dictionary<string, int> Counter(string filePath)
    {
      if (string.IsNullOrEmpty(filePath))
      {
        return new Dictionary<string, int>();
      }

      string text = File.ReadAllText(filePath);

      var splittedText = text.Split(' ', ',', '.', '!', '?', '\r', '\n', ':', ';');
      var dictionary = new Dictionary<string, int>();

      for (int i = 0; i < splittedText.Length; i++)
      {
        if (splittedText[i] == "")
        {
          continue;
        }

        string currentWord = splittedText[i].ToLower();
 
        if (dictionary.ContainsKey(currentWord))
        {
          dictionary[currentWord] = dictionary[currentWord] + 1;
        }
        else
        {
          dictionary.Add(currentWord, 1);
        }
      }

      return dictionary;
    }
  }
}

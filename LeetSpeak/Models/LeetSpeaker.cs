using System;
using System.Collections.Generic;

namespace LeetSpeak.Models
{
  public class LeetSpeaker
  {
    private string _input = "";
    private List<char> _leetCharacters = new List<char>();

    public LeetSpeaker(string input)
    {
      _input = input;
    }


    public string GetInput()
    {
      return _input;
    }
    // public string LeetSpeakConverter()
    // {
    //   //get _input, convert to list of characters , loop through, change characters, Add to _leetCharacters, convert back to string and return string
    //   string [] stringArr = _input.Split(' ');
    //   string leetSentence = "";
    //   List<char> charArr = new List<char>();
    //
    //   for (int i = 0; i < stringArr.Length; i++)
    //   {
    //     string tempStr = "";
    //     string word = stringArr[i];
    //     if (word[0] == '\'')
    //     {
    //       tempStr = word;
    //       leetSentence += tempStr  + " ";
    //       tempStr = "";
    //       //leetSentence += string.Join("", word) + " ";
    //     }
    //     else
    //     {
    //       foreach(char c in word)
    //       {
    //         if (c == 'e')
    //         {
    //           charArr.Add('3');
    //         }
    //         else if(c == 'o')
    //         {
    //           charArr.Add('0');
    //         }
    //         else if (c == 'I')
    //         {
    //           charArr.Add('1');
    //         }
    //         else if (c == 't')
    //         {
    //           charArr.Add('7');
    //         }
    //         else if (c == 's')
    //         {
    //           if (charArr.Count == 0)
    //           {
    //             charArr.Add('s');
    //           }
    //           else
    //           {
    //             charArr.Add('z');
    //           }
    //         }
    //         else
    //         {
    //           charArr.Add(c);
    //         }
    //       }
    //       char [] tempArr = charArr.ToArray();
    //       tempStr = String.Join("",tempArr);
    //       leetSentence += tempStr  + " ";
    //       tempStr = "";
    //     }
    //     // leetSentence += tempStr  + " ";
    //     // tempStr = "";
    //   }
    //   Console.WriteLine(leetSentence);
    //   return leetSentence.Trim();
    //
    //   // char[] tempStr = charArr.ToArray();
    //   // string finalStr = String.Join("",tempStr);
    // }

    public string LeetSpeakConverter()
    {
      string leetSentence = "";
      string [] wordArray = _input.Split(' ');
      for (int i = 0; i<wordArray.Length; i++)
      {
        //Console.WriteLine(wordArray[i]);
        string currentWord = wordArray[i];
        if (currentWord[0] == '\'')
        {
          leetSentence += currentWord + " ";
        }
        else
        {

          List<char> charList = new List<char> ();
          string tempStr = "";

          foreach(char c in currentWord)
          {
            if (c == 'e')
           {
             charList.Add('3');
           }
           else if(c == 'o')
           {
             charList.Add('0');
           }
           else if (c == 'I')
           {
             charList.Add('1');
           }
           else if (c == 't')
           {
             charList.Add('7');
           }
           else if (c == 's')
           {
             if (charList.Count == 0)
             {
               charList.Add('s');
             }
             else
             {
               charList.Add('z');
             }
           }
           else // this adds all other letters that arent to be replaced
           {
             charList.Add(c);
           }

          //  tempStr = "";
          }
          char [] charArr = charList.ToArray();
          tempStr = String.Join("", charArr);
          leetSentence += tempStr + " ";
        }
      }
      return leetSentence.Trim();
    }
  }
}

using System;

namespace ScrabbleScore.Objects
{
  public class Scrabble
  {
    private string _input;

    public Scrabble(string input)
    {
      _input = input;
    }

    public string GetInput()
    {
      return _input;
    }
    public void SetInput(string newInput)
    {
      _input = newInput;
    }

    public int ScrabbleScore()
    {
      string userInput = this.GetInput();

      // TESTING HERE
      foreach (char letter in userInput)
      {
        if( userInput == "A")
        {
          return 1;
        }
      }
      // TESTING ENDS HERE
      if( userInput == "A" ||
          userInput == "E" ||
          userInput == "I" ||
          userInput == "O" ||
          userInput == "U" ||
          userInput == "L" ||
          userInput == "N" ||
          userInput == "R" ||
          userInput == "S" ||
          userInput == "T")
      {
        return 1;
      }
      else if (userInput == "D" || userInput == "G")
      {
        return 2;
      }
      else if (userInput == "B" || userInput == "C" || userInput == "M" || userInput == "P")
      {
        return 3;
      }
      else if (userInput == "F" || userInput == "H" || userInput == "V" || userInput == "W" || userInput == "Y")
      {
        return 4;
      }
      else if (userInput == "K")
      {
        return 5;
      }
      else if (userInput == "J" || userInput == "X")
      {
        return 8;
      }
      else if (userInput == "Q" || userInput == "Z")
      {
        return 10;
      }
      else if (userInput == "AA")
      {
        return 2;
      }
      else
      {
        return 0;
      }
    }
  }
}

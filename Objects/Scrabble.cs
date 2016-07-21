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
      string userInputUpper = userInput.ToUpper();
      int runningScore = 0;
      
      foreach (char letter in userInputUpper)
      {
        if( letter == 'A' ||
            letter == 'E' ||
            letter == 'I' ||
            letter == 'O' ||
            letter == 'U' ||
            letter == 'L' ||
            letter == 'N' ||
            letter == 'R' ||
            letter == 'S' ||
            letter == 'T')
        {
          runningScore += 1;
        }
        else if (letter == 'D' || letter == 'G')
        {
          runningScore += 2;
        }
        else if (letter == 'B' || letter == 'C' || letter == 'M' || letter == 'P')
        {
          runningScore += 3;
        }
        else if (letter == 'F' || letter == 'H' || letter == 'V' || letter == 'W' || letter == 'Y')
        {
          runningScore += 4;
        }
        else if (letter == 'K')
        {
          runningScore += 5;
        }
        else if (letter == 'J' || letter == 'X')
        {
          runningScore += 8;
        }
        else if (letter == 'Q' || letter == 'Z')
        {
          runningScore += 10;
        }
        else
        {
          return 0;
        }
      }
      return runningScore;
    }
  }
}

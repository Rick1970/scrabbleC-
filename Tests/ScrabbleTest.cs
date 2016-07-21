using System.Collections.Generic;
using Xunit;

namespace ScrabbleScore.Objects
{
  public class ScrabbleTest
  {
    [Fact]
    public void T1_ScrabbleScore_InputAScore1_1()
    {
      Scrabble testScrabble = new Scrabble("A");
      Assert.Equal(1, testScrabble.ScrabbleScore());
    }
    [Fact]
    public void T2_ScrabbleScore_InputScoreNotA_0()
    {
      Scrabble testScrabble = new Scrabble("Totally irrelevant!");
      Assert.Equal(0, testScrabble.ScrabbleScore());
    }
    [Fact]
    public void T3_ScrabbleScore_InputVowelsPlusScore1_1()
    {
      Scrabble testScrabble = new Scrabble("E");
      Assert.Equal(1, testScrabble.ScrabbleScore());
    }
    [Fact]
    public void T4_ScrabbleScore_InputHigherValuesScore2_2()
    {
      Scrabble testScrabble = new Scrabble("D");
      Assert.Equal(2, testScrabble.ScrabbleScore());
    }
    [Fact]
    public void T5_ScrabbleScore_InputHigherValuesScore3_3()
    {
      Scrabble testScrabble = new Scrabble("B");
      Assert.Equal(3, testScrabble.ScrabbleScore());
    }
    [Fact]
    public void T6_ScrabbleScore_InputHigherValuesScore4_4()
    {
      Scrabble testScrabble = new Scrabble("F");
      Assert.Equal(4, testScrabble.ScrabbleScore());
    }
    [Fact]
    public void T7_ScrabbleScore_InputHigherValuesScore5_5()
    {
      Scrabble testScrabble = new Scrabble("K");
      Assert.Equal(5, testScrabble.ScrabbleScore());
    }
    [Fact]
    public void T8_ScrabbleScore_InputHigherValuesScore8_8()
    {
      Scrabble testScrabble = new Scrabble("J");
      Assert.Equal(8, testScrabble.ScrabbleScore());
    }
    [Fact]
    public void T9_ScrabbleScore_InputHigherValuesScore10_10()
    {
      Scrabble testScrabble = new Scrabble("Q");
      Assert.Equal(10, testScrabble.ScrabbleScore());
    }
    [Fact]
    public void T10_ScrabbleScore_InputTwoLetterA_2()
    {
      Scrabble testScrabble = new Scrabble("AA");
      Assert.Equal(2, testScrabble.ScrabbleScore());
    }
  }
}

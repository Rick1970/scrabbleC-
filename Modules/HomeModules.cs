using Nancy;
using System;
using System.Collections.Generic;
using ScrabbleScore.Objects;

namespace ScrabbleScore
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/results"] = _ => {
        Scrabble newScrabble = new Scrabble(Request.Form["user-word"]);
        return View["results.cshtml", newScrabble];
      };
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace deck_of_cards
{
  class Program
  {
    static void Main(string[] args)
    {
      // List of Suits
      Random rnd = new Random();
      var suits = new List<string>() {"Spades", "Clubs", "Diamonds", "Hearts",};
      // List of Ranks
      var ranks = new List<string>() {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};

      int ranksIndex = rnd.Next(ranks.Count);
      Console.Write("");
      Console.Write(ranks[ranksIndex]);

      int suitsIndex = rnd.Next(suits.Count);
      Console.Write(" of ");
      Console.Write(suits[suitsIndex]);

      Console.Write(" and ");
      int ranksIndexTwo = rnd.Next(ranks.Count);
      Console.Write("");
      Console.Write(ranks[ranksIndexTwo]);

      int suitsIndexTwo = rnd.Next(suits.Count);
      Console.Write(" of ");
      Console.Write(suits[suitsIndexTwo]);

      
     // var n = 52
     //  var n = deck.count ?
      
    




      // make n = 52 since we are dealing with 52 elements
      // var n = 52;
      // for firstIndex from n - 1 down to 1 do:
      //  secondIndex = random integer that is greater than or equal to 0 and LESS than firstIndex
      //  Now swap the values at firstIndex and secondIndex by doing this:
      //  firstValue = the value from items[firstIndex]
      //  secondValue = the value from items[secondIndex]
      //  items[firstIndex] = secondValue
      //  items[secondIndex] = firstValue
 
 
 
 
 
 
 
 
 
    }
  }
}


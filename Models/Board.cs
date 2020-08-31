using System.Collections.Generic;

namespace QueenAttack.Models
{
  public class Board
  {
    private static string[] _validString = {"a", "b", "c", "d", "e", "f", "g", "h"};
    private static int[] _validInt = {1, 2, 3, 4, 5, 6, 7, 8};
    
    public static bool ValidateX(string newX)
    {
      foreach(string letter in _validString)
      {
        if (letter == newX)
        {
          return true;
        }
      }
      return false;
    }

    public static bool ValidateY(int newY)
    {
      foreach(int num in _validInt)
      {
        if (num == newY)
        {
          return true;
        }
      }
      return false;
    }

    public static int XConvert(string xStr)
    {
      Dictionary<string, int> complements = new Dictionary<string, int>() {{"a", 1}, {"b", 2}, {"c", 3}, {"d", 4}, {"e", 5}, {"f", 6}, {"g", 7}, {"h", 8}};
      return complements[xStr];
    }
  }
}
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
  }
}
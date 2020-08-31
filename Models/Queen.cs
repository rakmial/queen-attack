using System;

namespace QueenAttack.Models
{
  public class Queen 
  {
    private string _xPosition;
    private int _yPosition;
    public bool SetError { get; set; }
    public string XPosition 
    { 
      get
      { return _xPosition; }
      set
      {
        while (!(Board.ValidateX(value)))
        {
          Console.WriteLine("Please enter a letter from the following: a, b, c, d, e, f, g, h");
        }
        _xPosition = value;
      }
    }
    public int YPosition 
    { 
      get
      { return _yPosition; }
      set
      {
        while (!(Board.ValidateY(value)))
        {
          Console.WriteLine("Please enter a number from the following: 1, 2, 3, 4, 5, 6, 7, 8");
        }
        _yPosition = value;
      }
    }
  }
}
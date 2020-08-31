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
        if (Board.ValidateX(value))
        {
          _xPosition = value;
        }
        else
        {
          Console.WriteLine("Please enter a letter from the following: a, b, c, d, e, f, g, h");
          SetError = true;
        }
      }
    }
    public int YPosition { get; set; }
  }
}
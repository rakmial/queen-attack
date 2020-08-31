using System;
using QueenAttack.Models;

class Program
{
  public static void Main() 
  {
    Queen queen = new Queen();
    
    Console.WriteLine("Welcome to Queen Attack, a program that checks chessboard coordinates to determine whether a Queen may attack another piece.");
    Console.WriteLine("Enter an X-axis coordinate letter from the following: a, b, c, d, e, f, g, h");
    queen.XPosition = (Console.ReadLine());
  }
}

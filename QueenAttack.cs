using System;
using QueenAttack.Models;

class Program
{
  public static void Main() 
  {
    Queen queen = new Queen();
    
    Console.WriteLine("Welcome to Queen Attack, a program that checks chessboard coordinates to determine whether a Queen may attack another piece.");
    
    Console.WriteLine("Enter an X-axis coordinate letter from the following: a, b, c, d, e, f, g, h");
    queen.XPosition = Console.ReadLine();
    
    Console.WriteLine("Enter a Y-axis coordinate number from the following: 1, 2, 3, 4, 5, 6, 7, 8");
    queen.YPosition = (int.Parse(Console.ReadLine()));

    Console.WriteLine("Your Queen is placed at " + queen.XPosition + queen.YPosition.ToString());
    Console.WriteLine("Now, where shall we place her quarry?");

    Console.WriteLine("Enter an X-axis coordinate letter from the following: a, b, c, d, e, f, g, h");
    string victimX = Console.ReadLine();

    Console.WriteLine("Enter a Y-axis coordinate number from the following: 1, 2, 3, 4, 5, 6, 7, 8");
    int victimY = int.Parse(Console.ReadLine());

    Console.WriteLine("Your Queen's quarry is placed at " + victimX + victimY.ToString());

    if (queen.Attack(victimX, victimY))
    {
      Console.WriteLine("Queen " + queen.XPosition + queen.YPosition.ToString() + " can attack quarry " + victimX + victimY.ToString());
    }
    else
    {
        Console.WriteLine("Queen " + queen.XPosition + queen.YPosition.ToString() + " cannot attack quarry " + victimX + victimY.ToString());
    }
  }
}

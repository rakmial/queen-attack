# English Specification

_Requirements_: 
Queen Attack
In chess, a queen can move horizontally, vertically, and diagonally, making it the most powerful piece on the board. If another piece is within its line of sight along these three lines, the queen may attack it.

Create a console application where the user can enter X and Y coordinates for both a queen and another chess piece. The program should return whether the queen is capable of 'attacking' the other chess piece.

Hints
When the user submits coordinates, the program should create an instance of a Queen class, with properties for its X and Y coordinates.
The Queen class should have a method that takes X and a Y coordinate as arguments, and returns true if the queen can attack the given space, and false if it cannot.
A message should be displayed to inform the user of the results.

### _Tests & Functions_

Queen.cs & Board.cs
* Queen class has private string attribute _xPosition public string property for X-axis position XPosition with get, set.
* Queen class has integer property for Y-axis position YPosition with get, set.
* Board class has private array attributes _validString, _validInt = ["a"-"h"], [1-8].
* Board class has public static bool method ValidateX, called when Queen.XPosition set. ValidateX checks whether input is in _validString, returns true or false. If false, XPosition.set writes error message to console with valid options again, then prompts again for input.
* Board class has public static bool method ValidateY, called when Queen.YPosition set. ValidateY checks whether input is in _validInt, returns true or false. If false, YPosition.set writes error message to console with valid options again, then prompts again for input.
* Board has public static int method XConvert that converts XPosition strings into their complementary integer representation according to a Dictionary defined therein. {{"a", 1}, ...}
* Queen class has private integer attribute for X-axis position _xIntPosition. When XPosition is set, it calls XConvert to update _xIntPosition to a number.
* Queen class has public bool method Attack(str victimX, int victimY). If either victimX == Xposition or victimY == YPosition, return true. 
Else if, private int _victimX = Xconvert(victimX), then private int _xDiff = _xIntPosition - _victimX and private int _yDiff = Yposition - victimY. If _xDiff % _yDiff == 0, return true, else return false.


QueenAttack.cs

* Welcomes user and prompts user input for X and Y, calling Console.ReadLine to set XPosition and YPosition.

* Prompts user for and stores victimX and victimY, passing them through Validate directly before calling Queen.Attack(victimX, victimY).

* Displays message "Queen at X/Y can/not attack X/Y"

* Give option to start over or not
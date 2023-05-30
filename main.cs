/*
  using (keyword)- add namespaces in code
                        Outside or in class files

  System (namespace)
    Normally you type System.Console.Write, but this allows us to just use Console.Write
*/

/*
******************************************************************************
*/

/*
  Variables:
    int
      4 bytes
      Stores whole numbers up to ~ +-2 billion

    long
      8 bytes
      Stores whole numbers up to ~ +-9 quintillion

    float
      4 bytes
      Fractional/whole numbers for up to 6 decimal digits
      Must have F at the end of your number (1.23F)

    double
      8 bytes
      Fractional/whole numbers for up to 15 decimal digits
      Must have D at the end of your number (1.23D)

    bool
      1 bit
      true/false (conditional testing)

    string
      2 bytes per character

    char
      2 bytes
      a single character, which must use '', not "" (ex: 'A')
      
*/

/*
******************************************************************************
*/

using System;

class Program
{
    /*
    Access level modifiers:
      Public
        Allows the type or member to be accessed  by any other code in the same assembly, or another assembly that references it.
      Private
        Can only be accessed by code in the same class or struct
      Protected
        Can only be accessed by code in the same class, or in a class that is derived from that class (children).
    */

    // Static allows the function to run without creating an object previously (through the class instead of object).
    public static void Main(string[] args)
    {
        // Since the class Player in Player.cs is not static, an object needs to be created before it can be called.
        Player playerObject = new Player();
        // If the Player class was static, you would just use Player.Name
        Console.WriteLine(playerObject.Name);

        Player enemyObject = new Player("The Enemy");
        enemyObject.Level = 100;
        Console.WriteLine(enemyObject.CreatePlayerDescription());

        // Using Builders to instatiate
        PlayerBuilder playerBuilder = new PlayerBuilder();

        Player playerBuilt = playerBuilder.BuildPlayer();

        Console.WriteLine(playerBuilt.CreatePlayerDescription());

        playerBuilder.JoinGame(); // Will not set the joinedGame status to True, since it is called after the builder created the Player already.

        Console.WriteLine("*****************\nJoined Game will remain \"False\" \n" + playerBuilt.CreatePlayerDescription());

        Player playerBuilt1 = playerBuilder.BuildPlayer(); // Will show true, as it is called after JoinGame() has run.

        Console.WriteLine("*****************\nJoined Game will show \"True\" \n" + playerBuilt1.CreatePlayerDescription());
    }
}
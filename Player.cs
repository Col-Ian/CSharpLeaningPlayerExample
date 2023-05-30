class Player {
  public string Name;

  // Default is 0
  public int Level;

  // Default is false, if you don't assign a value
  public bool JoinedGame = false;

  //Constructors
  public Player (){
    Name = "Player";
    Level = 1;
  }

  public Player (string _Name){
    Name = _Name;
  }

  // Playerbuilder constructor
  public Player(PlayerBuilder builder){
    Name = builder.Name;
    Level = builder.Level;
    JoinedGame = builder.JoinedGame;
  }

  // String method
  public string CreatePlayerDescription(){
    string description = "Your player name is: " + Name + ". \nYour level is: " + Level + ". \nJoined game status: " + JoinedGame;
    return description;
  }
}
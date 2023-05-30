class PlayerBuilder{

  // Set variables that we want to change

  public string Name;
  public int Level;
  public bool JoinedGame = false;

  public PlayerBuilder(){
    Name = "Archer";
    Level = 1;
  }

  // Directly set the name
  // public Player BuildPlayer(){
  //   return new Player();
  // }

  // Set name through our constructor
  public Player  BuildPlayer(){
    return new Player(this);
  } 

  public void JoinGame(){
    JoinedGame = true;
  }
}
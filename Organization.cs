namespace knightmoves;

public class Organization{
   private string Name;

   public Organization(string name){
      Name = name;
   }

   public string GetName(){
      return Name;
   }

   public void SetName(string name){
      Name = name;
   }
}
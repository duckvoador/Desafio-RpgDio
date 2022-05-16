namespace RpgDio.src.entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            
        }
       
        public override string Attack(){
            return this.Name + "Atacou com sua Shuriken";
        }
       
       public string Attack(int Bonus){
            
           
           if(Bonus > 6){
            return this.Name + " Atacou com sua Shuriken de forma super Efetiva com bonus de ataque  " + Bonus;
            }else{
                return this.Name + " Atacou com sua Shuriken de forma Fraca com bonus de ataque  " + Bonus;
            }
         }
        
        
    }
}
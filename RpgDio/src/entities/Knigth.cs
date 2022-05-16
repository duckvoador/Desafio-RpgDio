namespace RpgDio.src.entities
{
    public class Knigth : Hero
    {
        
        public Knigth(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            
        }
        public override string Attack(){
            return this.Name + "Atacou com sua Espada";
        }
         public string Attack(int Bonus){
            
           
           if(Bonus > 6){
            return this.Name + " Atacou com sua Espada de forma super Efetiva com bonus de ataque  " + Bonus;
            }else{
                return this.Name + " Atacou com sua Espada de forma Fraca com bonus de ataque  " + Bonus;
            }
         }
       
    }
}
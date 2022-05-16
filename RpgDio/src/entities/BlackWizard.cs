namespace RpgDio.src.entities
{
    public class BlackWizard : Hero
    { 
        public BlackWizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            
        }
       
        public override string Attack(){
            return this.Name + "Atacou com sua Magia";
        }
       public  string Attack(int Bonus){
            
           
           if(Bonus > 6){
            return this.Name + " Atacou com sua Magia super Efetiva com bonus de ataque  " + Bonus;
            }else{
                return this.Name + " Atacou com sua Magia Fraca com bonus de ataque  " + Bonus;
            }
         }
   
       
       
        
        
            
        
        
    }
}
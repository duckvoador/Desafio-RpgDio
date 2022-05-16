namespace RpgDio.src.entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
           
        }

        public string Name;
        public int Level;
        public string HeroType;

        public Hero()
        {
            
        }

        public override string ToString() => this.Name + " " + this.Level + " " + this.HeroType;

        public virtual string Attack (){
            return this.Name + "atacou como podia";
        }
         


    }
}
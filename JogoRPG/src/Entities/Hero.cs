namespace JogoRPG.src.Entities
{
    public abstract class Hero
    {
        public Hero()
        {
            
        }
       public Hero(string Name, int Level, string HeroType, int HPInicial, int HPFinal, int MPInicial, int MPFinal)
       {
           this.Name = Name;
           this.Level = Level;
           this.HeroType = HeroType;
           this.HPInicial = HPInicial;
           this.HPFinal = HPFinal;
           this.MPInicial = MPInicial;
           this.MPFinal = MPFinal;
       } 

       public string Name { get; set; }
       public int Level { get; set; }
       public string HeroType { get; set; }

       public int HPInicial { get; set; }
       public int HPFinal { get; set; }

       public int MPInicial { get; set; }
       public int MPFinal { get; set; }
  

        public override string ToString()
        {
            return "Nome: " + 
            this.Name + " Level: " + 
            this.Level + " Tipo do Heroi: " + 
            this.HeroType + " HP Inicial: " + 
            this.HPInicial + " HP Final: " + 
            this.HPFinal + " MP Inicial: " + 
            MPInicial + " MP Final: " + 
            MPFinal;
        }

        public virtual string Attack()
        {
            return null;
        }

    }

}
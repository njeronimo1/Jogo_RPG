namespace JogoRPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HPInicial, int HPFinal, int MPInicial, int MPFinal)
       {
           this.Name = Name;
           this.Level = Level;
           this.HeroType = HeroType;
           this.HPInicial = HPInicial;
           this.HPFinal = HPFinal;
           this.MPInicial = MPInicial;
           this.MPFinal = MPFinal;
       } 

        public string Attack(int bonus)
        {
            if(bonus > 6)
            {
                return this.Name + " Atacou com sua Xuriken giratória do naruto e teve dano crítico de " + bonus;
            }else{
                return this.Name + " Atacou com sua Xuriken giratória do naruto e teve dano normal de " + bonus;
            }
            
        }
    }
}
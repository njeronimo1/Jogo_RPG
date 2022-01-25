namespace JogoRPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HPInicial, int HPFinal, int MPInicial, int MPFinal)
       {
           this.Name = Name;
           this.Level = Level;
           this.HeroType = HeroType;
           this.HPInicial = HPInicial;
           this.HPFinal = HPFinal;
           this.MPInicial = MPInicial;
           this.MPFinal = MPFinal;
       }  
        public override string Attack()
        {
            return this.Name + " Lançou sua Magia WOWW";
        }

        public string Attack(int bonus)
        {
            if(bonus > 6)
            {
                return this.Name + " Lançou sua Magia WOWW FOI MUITO FORTE, com bonus de " + bonus;
            }else{
                return this.Name + " Lançou sua Magia, está precisando melhorar sua força, teve bonus de " + bonus;
            }
            
        }
    }
}
using WarMachinesFromScratch.Interfaces;

namespace WarMachinesFromScratch.Models
{
    public class Fighter : Machine,IFighter,IMachine
    {
        public const int FighterHealt = 200;
        public Fighter(string name, double attackPonts, double defencePoints, double healtPoints) : base(name, attackPonts, defencePoints, FighterHealt)
        {
            this.ToggleStealthMode();
        }

        public bool StealthMode { get; private set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }
    }

}

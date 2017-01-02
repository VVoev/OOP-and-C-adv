namespace Homework_Defining_Classes_Part1_StudentProject
{
    internal class Sword
    {
        private int damage = 100;
        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                this.damage = value;
            }
        }
        public Sword()
            :this(100)
        {

        }

        public Sword(int damage)
        {
            this.Damage = damage;
        }
    }
}
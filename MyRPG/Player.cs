namespace MyRPG
{
    public class Player
    {
        private int xp;
        private float health;

        public string Name {get; }

        public int XP
        {
            get =>xp;
            set =>xp = value;
        }

        public int Level
        {
            get
            {
                return 1+XP/1000;
            }
        }

        public float Health
        {
            get =>health;
            set
            {
                if (0> health)
                {
                    health = 0;
                }
                if (health> MaxHealth)
                {
                    health = MaxHealth;
                }    
                else health = value;
            }   
        }

         public float MaxHealth
        {
            get
            {
                return 100 + (Level -1)*20;
            }
        }
    }
}
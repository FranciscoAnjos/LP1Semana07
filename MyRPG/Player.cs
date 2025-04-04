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
        

    }
}
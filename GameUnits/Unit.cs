namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;
        public virtual int Health { get; set; }

        public virtual  float Cost { get; }

        protected Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public int Move()
        {
            return movement;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: HP={Health} COST={Cost.ToString("0.00")}";
        }
    }
}

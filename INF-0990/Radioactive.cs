
    public class Radioactive : ItemMap
    {
        public Radioactive() : base("!! "){}

        public void DecreaseEnergyOut(Robot r)
        {
            r.energy-=10;
        }

        public void DecreaseEnergyIn(Robot r)
        {
            r.energy-=30;
        }
    }

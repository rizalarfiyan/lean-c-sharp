namespace coffe_machine
{
    class CoffeMachine
    {
        private CoffePowder coffePowder;
        private WaterGalon waterGalon;

        public CoffeMachine(CoffePowder coffePowder, WaterGalon waterGalon)
        {
            this.coffePowder = coffePowder;
            this.waterGalon = waterGalon;
        }

        public String makeEsspresso()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "Sorry, the water is empty";
            }

            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }

            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            return "Yeay! your coffe is ready";
        }

        public String checkAvailability()
        {
            return $"the water :{this.waterGalon.getVolume()} and the coffe powder: {this.coffePowder.getNetto()}";
        } 
    }
}

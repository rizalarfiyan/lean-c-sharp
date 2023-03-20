namespace super_computer
{
    internal class Vga
    {
        private string brand;
        private int graphicsClock;
        private int memoryClock;

        public Vga(string brand, int graphicsClock, int memoryClock)
        {
            this.brand = brand;
            this.graphicsClock = graphicsClock;
            this.memoryClock = memoryClock;
        }

        public string getBrand()
        {
            return brand;
        }

        public int getGraphicsClock()
        {
            return graphicsClock;
        }

        public int getMemoryClock()
        {
            return memoryClock;
        }

        public override string ToString()
        {
            return $"Vga brand: {brand}; Vga clock graphics: {graphicsClock}; Vga CLock memory: {memoryClock};";
        }
    }
}

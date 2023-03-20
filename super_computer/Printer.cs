namespace super_computer
{
    class Printer
    {
        private string brand;
        private string series;
        private int ppm;

        public Printer(string brand, string series, int ppm)
        {
            this.brand = brand;
            this.series = series;
            this.ppm = ppm;
        }

        public string getBrand()
        {
            return brand;
        }

        public string getSeries()
        {
            return series;
        }

        public int getPpm()
        {
            return ppm;
        }

        public override string ToString()
        {
            return $"Printer brand: {brand}; Printer series: {series}; Printer paper per minute (ppm): {ppm}";
        }
    }
}

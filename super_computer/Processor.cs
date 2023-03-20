namespace super_computer
{
    class Processor
    {
        private string series;
        private int core;
        private int cache;

        public Processor()
        {

        }

        public void setSeries(string series)
        {
            this.series = series;
        }

        public string getSeries()
        {
            return series;
        }

        public void setCore(int core)
        {
            this.core = core;
        }

        public int getCore()
        {
            return core;
        }

        public void setCache(int cache)
        {
            this.cache = cache;
        }
        public int getCache()
        {
            return cache;
        }

        public override string ToString()
        {
            return $"Processor series: {series}; Processor code: {core}; Processor cache: {cache}";
        }
    }
}

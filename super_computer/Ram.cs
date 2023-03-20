namespace super_computer
{
    class Ram
    {
        private string type;
        private int speed;
        private int memorySize;

        public Ram(string type, int speed, int memorySize)
        {
            this.type = type;
            this.speed = speed;
            this.memorySize = memorySize;
        }

        public string getType()
        {
            return type;
        }

        public int getSpeed()
        {
            return speed;
        }

        public int getMemorySize()
        {
            return memorySize;
        }

        public override string ToString()
        {
            return $"Ram type: {type}; Ram speed: {speed}; Ram size: {memorySize}";
        }
    }
}

namespace super_computer
{
    class Monitor
    {
        private string resolution;
        private bool supportHDMI;
        private double size;

        public Monitor(string resolution, bool supportHDMI, double size)
        {
            this.resolution = resolution;
            this.supportHDMI = supportHDMI;
            this.size = size;
        }

        private string getResolution()
        {
            return resolution;
        }

        private bool getSupportHDMI()
        {
            return supportHDMI;
        }

        private double getSize()
        {
            return size;
        }

        public override string ToString()
        {
            return $"Monitor resolution: {resolution}; Monitor support HDMI: {supportHDMI}; Monitor dimensi: {size} inch;";
        }
    }
}

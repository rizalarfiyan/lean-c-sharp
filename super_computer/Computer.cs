namespace super_computer
{
    class Computer
    {
        private Monitor monitor;
        private Printer printer;
        private Processor processor;
        private Ram ram;
        private Vga vga;

        private Computer(Builder builder)
        {
            monitor = builder.monitor;
            processor = builder.processor;
            printer = builder.printer;
            ram = builder.ram;
            vga = builder.vga;
        }

        public override string ToString()
        {
            return $"Monitor spec: {monitor} \n" +
            $"Processor spec: {processor} \n" +
            $"Printer spec: {printer} \n" +
            $"Vga spec: {ram} \n" +
            $"Ram spec: {vga}";
        }

        public class Builder
        {
            public Monitor monitor;
            public Printer printer;
            public Processor processor;
            public Ram ram;
            public Vga vga;

            public Builder(Ram ram, Vga vga, Processor processor)
            {
                this.ram = ram;
                this.vga = vga;
                this.processor = processor;
            }

            public Builder withMonitor(Monitor monitor)
            {
                this.monitor = monitor;
                return this;
            }

            public Builder withPrinter(Printer printer)
            {
                this.printer = printer;
                return this;
            }

            public Computer build()
            {
                return new Computer(this);
            }
        }
    }
}

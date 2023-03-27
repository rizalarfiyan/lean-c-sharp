namespace coffe_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------ Coffe Machine ------------------");

            CoffePowder coffe = new CoffePowder(100);
            WaterGalon water = new WaterGalon(1000);
            CoffeMachine yummyCoffe = new CoffeMachine(coffe, water);

            // 1nd cup coffe
            Console.WriteLine("Check " + yummyCoffe.checkAvailability());
            String result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result: " + result);

            // 2nd cup coffe
            Console.WriteLine("Check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result: " + result);

            // 3nd cup coffe
            Console.WriteLine("Check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result: " + result);

            // 4nd cup coffe
            Console.WriteLine("Check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result: " + result);

            // 5nd cup coffe
            Console.WriteLine("Check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result: " + result);

            // add water
            Console.WriteLine("---------------------------------------------------");
            int addWaterVolume = 1000;
            Console.WriteLine($"Add {addWaterVolume} water");
            water.addWater(addWaterVolume);
            Console.WriteLine("---------------------------------------------------");

            // 6nd cup coffe
            Console.WriteLine("Check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result: " + result);

            // add powder
            Console.WriteLine("---------------------------------------------------");
            int addPowderValue = 100;
            Console.WriteLine($"Add {addPowderValue} coffe powder");
            coffe.addPowder(addPowderValue);
            Console.WriteLine("---------------------------------------------------");

            // 7nd cup coffe
            Console.WriteLine("Check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result: " + result);
            Console.WriteLine("Check " + yummyCoffe.checkAvailability());

        }
    }
}

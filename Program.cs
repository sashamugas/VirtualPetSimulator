using static System.Console;

namespace VirtualPetSimulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //title on console window
            Title ="Virtual Pet Simulator";
                       

            WriteLine(@"
 _     _  ____  _____  _     ____  _       ____  __________    ____  _  _     _     _    ____  _____  ____  ____ 
/ \ |\/ \/  __\/__ __\/ \ /\/  _ \/ \     /  __\/  __/__ __\  / ___\/ \/ \__// \ /\/ \  /  _ \/__ __\/  _ \/  __\
| | //| ||  \/|  / \  | | ||| / \|| |     |  \/||  \   / \    |    \| || |\/|| | ||| |  | / \|  / \  | / \||  \/|
| \// | ||    /  | |  | \_/|| |-||| |_/\  |  __/|  /_  | |    \___ || || |  || \_/|| |_/\ |-||  | |  | \_/||    /
\__/  \_/\_/\_\  \_/  \____/\_/ \|\____/  \_/   \____\ \_/    \____/\_/\_/  \\____/\____|_/ \|  \_/  \____/\_/\_\                                                                                                                 
");


            WriteLine();

            // variable declarations
                     

            

            //create objects from virtualpets class
            VirtualPet leoTheCat = new VirtualPet("Leo", 12, "Cat", true);
            WriteLine("> PET 1:");
            leoTheCat.Greet();
            leoTheCat.Eat("fish");

            WriteLine();

            //create objects from virtualpets class
            VirtualPet juniorTheParrot = new VirtualPet("Junior", 50, "Parrot", false);
            WriteLine(">PET 2");
            juniorTheParrot.Greet();
            juniorTheParrot.Sleep();
            juniorTheParrot.Eat("sunflower seeds");

            WriteLine();

            WriteLine("Press any key to exit...");
            ReadKey();
        }
    }
}
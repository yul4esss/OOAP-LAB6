namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CostumesFactory costumeFactory = new CostumesFactory();

            // Creating two scenes
            Scene scene1 = new Scene();
            Scene scene2 = new Scene();

            // Group of actors for 1st scene
            Console.WriteLine("Enter the number of actors in Scene 1:");
            int numActorsScene1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < numActorsScene1; i++)
            {
                scene1.AddActor(new Actor(i + 1));
            }

            // Group of actors for 1nd scene
            Console.WriteLine("Choose a costume for Scene 1: 1. Soldier, 2. Prisoner");
            int costumeChoice1 = int.Parse(Console.ReadLine());
            string costumeType1 = costumeChoice1 == 1 ? "Soldier" : "Prisoner";
            scene1.SetCostume(costumeType1, costumeFactory);

            // Performing scene 1
            Console.WriteLine("Performing Scene 1:");
            scene1.PerformScene();

            // Scene 2
            Console.WriteLine("Enter the number of actors in Scene 2:");
            int numActorsScene2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < numActorsScene2; i++)
            {
                scene2.AddActor(new Actor(i + 1));
            }

            // Group of actors for scene 2
            Console.WriteLine("Choose a costume for Scene 2: 1. Soldier, 2. Prisoner");
            int costumeChoice2 = int.Parse(Console.ReadLine());
            string costumeType2 = costumeChoice2 == 1 ? "Soldier" : "Prisoner";
            scene2.SetCostume(costumeType2, costumeFactory);

            // Performing scene 2
            Console.WriteLine("Performing Scene 2:");
            scene2.PerformScene();
        }
    }
}

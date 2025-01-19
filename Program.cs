
namespace ConsoleApp2_Tile_Cost_Calculation

{
    internal class Program
    {
        static void Main()


        {
            Console.WriteLine("Tutorial on tile cost calculation! ");
            Console.WriteLine("Enter the shape of the room(rectangle/cirle): ");

            string? shape = Console.ReadLine()!.ToLower();

            double area;

            if (shape == "rectangle")
            {
                Console.WriteLine("Enter the width of the room (in feet): ");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the length of the room (in feet): ");
                double length = Convert.ToDouble(Console.ReadLine());
                area = width * length;

            }
            else if (shape == "circle")
            {
                Console.Write("Enter the radius of the room (in feet): ");
                double radius = Convert.ToDouble(Console.ReadLine());

                area = Math.PI * Math.Pow(radius, 2);
            }

            else
            {
                Console.WriteLine("Undefined shape. Please restart the program and choose either rectangle or circle.");
                return;
            }
            //   Get cost per unit of floor tile

            Console.Write("Enter the cost per square foot of flooring tile: ");
            double costPerUnit = Convert.ToDouble(Console.ReadLine());

            // Calculate flooring tile cost
            double flooringTileCost = area * costPerUnit;

            // Calculate labor cost
            double laborHours = Math.Ceiling(area / 20); // 20 square feet per hour
            double laborCost = laborHours * 86; // $86 per hour

            // Total cost
            double totalCost = flooringTileCost + laborCost;

            // Display results
            Console.WriteLine("Flooring tile cost estimate");



            Console.WriteLine("Area to be covered: {0:F2} square feet", area);
            Console.WriteLine("Cost of flooring tile: ${0:F2}", flooringTileCost);
            Console.WriteLine("Labor cost: ${0:F2}", laborCost);
            Console.WriteLine("Total cost: ${0:F2}", totalCost);
        }
    }
}

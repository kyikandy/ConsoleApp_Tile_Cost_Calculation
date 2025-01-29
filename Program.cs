
namespace ConsoleAppTileCostCalculation
{ 
public class Program
{
    // Constants defined at the class level
    private const double SQUARE_FEET_PER_HOUR = 20;
    private const double LABOR_COST_PER_HOUR = 86;
    
        static void Main()
        {
            Console.WriteLine("Tutorial on tile cost calculation! ");
            Console.WriteLine("Enter the shape of the room(1:rectangle/2:cirle): ");
            
            Console.WriteLine("Select the shape of the room:");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Circle");

            string? shape = Console.ReadLine()!.Trim().ToLower();

            double area;

            if (shape == "1" || shape == "rectangle")
            {
                Console.WriteLine("Enter the width of the room (in feet): ");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the length of the room (in feet): ");
                double length = Convert.ToDouble(Console.ReadLine());
                area = width * length;

            }
            else if (shape == "2" || shape == "circle")
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
            double laborHours = Math.Ceiling(area / SQUARE_FEET_PER_HOUR); // 20 square feet per hour
            double laborCost = laborHours * LABOR_COST_PER_HOUR; // $86 per hour

            // Total cost
            double totalCost = flooringTileCost + laborCost;

            // Display results
            Console.WriteLine("\nFlooring tile cost estimate\"");

            Console.WriteLine("Area to be covered: {0:F2} square feet", area);
            Console.WriteLine("Cost of flooring tile: ${0:F2}", flooringTileCost);
            Console.WriteLine("Labor cost: ${0:F2}", laborCost);
            Console.WriteLine("Total cost: ${0:F2}", totalCost);
        }
    }
}

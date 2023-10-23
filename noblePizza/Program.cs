public class Program
{
    public static void Main(string[] args)
    {
        const double PI = 3.14;
        const double SLICE_AREA = 14.13;

        double radius;
        int numberOfSlices;

        Console.WriteLine("Enter the Radius of the Pizza");
        radius = double.Parse(Console.ReadLine());

        numberOfSlices = (int)((PI * radius * radius) / SLICE_AREA);

        Console.WriteLine($"{numberOfSlices} is the total slices of the Pizza");
    }
}
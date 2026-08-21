internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("first dance");
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Em nghịch đặt theo tên bạn, thật ra em tên là Minh Hưng nha thầy =))");

        //1.to Add / Sum Two Numbers.
        int a = 5;
        int b = 10;
        int sum = a + b;
        Console.WriteLine($"Sum of {a} and {b} is {sum}");
        //2.to Swap Values of Two Variables.
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"After swapping: a = {a}, b = {b}");
        //3. to Multiply two Floating Point Numbers
        float x = 2.5f;
        float y = 3.5f;
        float product = x * y;
        Console.WriteLine($"Product of {x} and {y} is {product}");
        //4. to convert feet to meter
        float feet = 6.3f;
        const float rate = 0.3048f;
        float metter = feet * rate;
        Console.WriteLine($"{feet} feet = {metter} metter");
        //5. to convert Celsius to Fahrenheit and vice versa
        float cels = 30f;
        float fah = cels * 1.8f + 32;
        Console.WriteLine($"{cels}C = {fah}F");
        //6. to find the Size of data types
        Console.WriteLine($"Size of double data types is {sizeof(double)}");
        Console.WriteLine($"Size of int data types is {sizeof(int)}");
        //7. to Print ASCII Value (tip: read character, print number of this char)
        Console.Write("Enter a character:");
        int c = Console.Read();
        Console.WriteLine($"ASCII code of {(char)c} is {c}");
        //8. to Calculate Area of Circle
        float detrimetter = 3f;
        double area = detrimetter * detrimetter * Math.PI;
        Console.WriteLine($"Area of the circle is: {area}");
        //9. to Calculate Area of Square
        float edge = 5f;
        float sq_area = edge * edge;
        Console.WriteLine($"Area of the square is: {sq_area}");
        //10. to convert days to years, weeks and days
        Console.ReadKey();
    }
}


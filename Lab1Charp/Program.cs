
static void task1()
{
    Console.WriteLine("Task1");
    Console.WriteLine("Square side: ");
    float.TryParse(Console.ReadLine(), out float a);
    float square = a * a;
    Console.WriteLine($"Square with side {a}: {square}");
}

static void task2() {
    Console.WriteLine("Task2");
    Console.WriteLine("a: ");
    float.TryParse(Console.ReadLine(), out float a);
    Console.WriteLine("b: ");
    float.TryParse(Console.ReadLine(), out float b);
    if(a > b) Console.WriteLine($"Max number is {a}"); else Console.WriteLine($"Max number is {b}");
}

static void task3() {
    Console.WriteLine("Task3");
    Console.WriteLine("x: ");
    float.TryParse(Console.ReadLine(), out float x);
    Console.WriteLine("y: ");
    float.TryParse(Console.ReadLine(), out float y);
    float radius = 12;
    bool isInsideFigure = x*x + y*y < radius * radius && y + x < 0;
    bool isOnEdge = (x*x + y*y == radius * radius && y + x <= 0) || (x*x + y*y <= radius * radius && y + x == 0);
    if(isInsideFigure) {
        Console.WriteLine("Yes");
    }
    if(isOnEdge) {
        Console.WriteLine("On edge");
    }
    if(!isInsideFigure && !isOnEdge) 
    {
        Console.WriteLine("No");
    }
}

static void task4() {
    Console.WriteLine("Task4");
    int[] monthDays = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

    Console.WriteLine("Month: number");
    int.TryParse(Console.ReadLine(), out int monthId);
    monthId = Math.Clamp(monthId, 1, 12);
    Console.WriteLine("Day: number");
    int.TryParse(Console.ReadLine(), out int dayId);
    monthId--;
    Console.WriteLine($"Days left: {monthDays[monthId] - dayId}");
}

static void task5() 
{
    Console.WriteLine("Task5");
    static float ToCube(int numerator, int denominator) 
    {
        return MathF.Pow((float)numerator/(float)denominator, 3);
    }
    Console.WriteLine("Numerator");
    int.TryParse(Console.ReadLine(), out int numerator);
    Console.WriteLine("Denominator");
    int.TryParse(Console.ReadLine(), out int denominator);
    Console.WriteLine($"Result: {ToCube(numerator, denominator)}");
}

static void task6() 
{
    static float Funct(float x, float y) 
    {
        return (x * y + (x + y * y + 3)/(x * x + 5));
    }
    Console.WriteLine("x");
    float.TryParse(Console.ReadLine(), out float x);
    Console.WriteLine("y");
    float.TryParse(Console.ReadLine(), out float y);
    Console.WriteLine($"Result: " + Funct(x,y));
}

Console.WriteLine("Lab 1 !");
task1();
task2();
task3();
task4();
task5();
task6();



static void Hello32()
{
    for (int i = 0; i < 32; i++) 
    {
        Console.WriteLine("Hello World");
    }
}

static int Kvadrat(int a)
{
    int result = a * a;
    return result;
}

static float Multi()
{
    float result = 3.43f * 3.23f;
    return result;
}

static float RightTriangleArea()
{
    float result = 4.5f*5.4f/2f;
    return result;
}

static float RightCircleArea()
{
    float result = MathF.PI * MathF.Pow(5f, 2f); 
    return result;
}

static void GetNumberInput()
{
    
}

Hello32();

int area = Kvadrat(3);
Console.WriteLine($"\n{area}\n");

float answer = Multi();
Console.WriteLine($"{answer}\n");

answer = RightTriangleArea();
Console.WriteLine($"{answer}\n");

answer = RightCircleArea();
Console.WriteLine($"{answer}\n");

Console.ReadLine();
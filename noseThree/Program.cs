
static void Hello32()
{
    for (int i = 0; i < 32; i++) 
    {
        Console.WriteLine("Hello World");
    }
}

static int Kvadrat(int a)
{
    int result = (int)Math.Pow(a, 2);
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

static int GetNumberInput()
{
    string answer;

    int num;

    bool success;

    Console.WriteLine("Skriv in bara en siffra: ");
    answer = Console.ReadLine();
    success = int.TryParse(answer, out num);

    while (success == false)
    {

        Console.WriteLine("Är inte bara en siffra, försök igen.");
        answer = Console.ReadLine();
        success = int.TryParse(answer, out num);

    }
    return num;

}

static string GetChoice()
{
    string answer;
    string result;

    int num;

    bool success;

    Console.WriteLine("Välj ett av orden: \n 1. Bil \n 2. Kakor \n 3. Matematik ");
    answer = Console.ReadLine();
    success = int.TryParse(answer, out num);

    while (success == false || num > 3 || num < 1)
    {

        if (success == false)
        {
            Console.WriteLine("Är inte bara en siffra, försök igen");
        }
        else if (num < 1)
        {
            Console.WriteLine("Är lägre en 1, försök igen");
        }
        else if (num > 3)
        {
            Console.WriteLine("Är högre en 3, försök igen");
        }

        answer = Console.ReadLine();
        success = int.TryParse(answer, out num);
        
    }

    if (num == 1)
    {
        result = "Bil";
    }
    else if (num == 2)
    {
        result = "Kakor";
    }
    else
    {
        result = "Matematik";
    }

    return result;

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

answer = GetNumberInput();
Console.WriteLine($"Siffran var {answer}\n");

string answers = GetChoice();
Console.WriteLine($"Ordet är {answers}\n");

Console.ReadLine();
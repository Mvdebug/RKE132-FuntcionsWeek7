Console.WriteLine("a = Teisenda Celsius Fahrenheitiks, b = teisenda Fahrenheit Celsiuseks.");

string valik = Console.ReadLine();

if (valik == "a")
{
    Console.Write("Sisesta temperatuur Celsiuses: ");
    double celsius =Int32.Parse(Console.ReadLine());
    ConvertToFahrenheit(celsius);
}
else if (valik == "b")
{
    Console.Write("Sisesta temperatuur Fahrenheitis: ");
    double fahrenheit =Int32.Parse(Console.ReadLine());
    ConvertToCelsius(fahrenheit);
}
else
{
    Console.WriteLine("Proovi uuesti. Sisesta a või b.");
}
    

    static void ConvertToCelsius(double fahrenheit)
{
    double celsius = (fahrenheit - 32) * 5 / 9;
    Console.WriteLine($"{fahrenheit} kraadi Fahrenheiti = {celsius} kraadi Celsiust.");
}

static void ConvertToFahrenheit(double celsius)
{
    double fahrenheit = (celsius * 9) / 5 + 32;
    Console.WriteLine($"{celsius} kraadi Celsiust = {fahrenheit} kraadi Fahrenheiti.");
}

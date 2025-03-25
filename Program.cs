Console.Clear();
string cebolinha;


Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Vou esperar você melhorar para poder provocar você");
Console.ResetColor();
Console.WriteLine();
cebolinha = Console.ReadLine()! .Replace("r","l") .ToUpper();
Console.WriteLine();
Console.WriteLine($"// {cebolinha} //");
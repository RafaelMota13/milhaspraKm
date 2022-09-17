Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("\n--- Equivalência ---");
Console.ResetColor();

Console.Write("Entre com a medida (em milhas): ");
double milhas = Convert.ToDouble(Console.ReadLine());


double km = milhas * 1.609;

Console.WriteLine($"{km:N3} Km");
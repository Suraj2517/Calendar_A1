Console.WriteLine("Enter No. of Robbers: ");
int num = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter The Robber with whom Sam will start shooting: ");
int start = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter the gap between the robbers: ");
int gap = Convert.ToInt16(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    for (int j = start; j <= num; j += gap)
    {
        Console.WriteLine($"Target = {j}, {i} Shots Completed");
    }
    Console.WriteLine();
}
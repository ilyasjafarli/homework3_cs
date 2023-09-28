// See https://aka.ms/new-console-template for more information
Console.WriteLine("Homework A");

/*
Console.WriteLine("Iki eded daxil edin:");

int eded1 = Convert.ToInt32(Console.ReadLine());
int eded2 = Convert.ToInt32(Console.ReadLine());

    int eded3 = 0;
if (eded1 > eded2)
{
    Console.WriteLine("Birinci eded ikinci ededden kicik olmalidir");
}
else
{
    int[] nums = new int[eded3];
    int sum = 0;
    for (int i = eded1; i < eded2; i++)
    {
        sum += nums[i];
    }
        Console.WriteLine($"{sum}");
} */

Console.WriteLine("Homework B");

Console.WriteLine("Nece ededin ortalamasini tapmaq isteyirsiniz?");

int b = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int j = 0; j < b; j++)
{

    Console.WriteLine($"{j + 1}-ci ededi daxil edin: ");
    sum += Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Cavab: {sum/=b}");

Console.WriteLine("Homework C");


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Homework A"); //1


Console.WriteLine("Iki eded daxil edin:"); //1
int eded1 = Convert.ToInt32(Console.ReadLine()); //1
int eded2 = Convert.ToInt32(Console.ReadLine()); //1

while (eded1 > eded2) // n
{
    Console.WriteLine("Birinci eded ikinci ededden kicik olmalidir"); //n
    Console.Write("Birinci ededi yazin: "); //n
    eded1 = Convert.ToInt32(Console.ReadLine()); //n
    Console.WriteLine("Ikinci ededi yazin: "); //n
    eded2 = Convert.ToInt32(Console.ReadLine());    //n
} 

    int sum = 0; //1
while (eded1 <= eded2) //n
{
    sum += eded1; // n
    eded1++; //n
} 
//On
        Console.WriteLine("Cavab: " + sum); //1

/*
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
*/

using NetMentor.Model;

for (int i = 0; i < 4; i++)
{
    Console.WriteLine("ingresa un numero");
    var num = int.Parse(Console.ReadLine());

    if (num % 2 == 0)
    {
        Console.WriteLine($"{num} es par");
        var x = Test.Multiplicar(num);
        Console.WriteLine($"num x num es {x}");
    }

}

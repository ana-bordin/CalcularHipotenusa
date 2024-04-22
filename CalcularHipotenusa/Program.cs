//4. faça um programa que leia 2 valores de cateto e calcule a hipotenusa;

int res = 0;

Console.WriteLine("-Calcule a hipotenusa-\n");
do
{
    double cat1 = 0, cat2 = 0, hip = 0;
    
    while (cat1 <= 0)
    {
        Console.WriteLine("Digite o tamanho do primeiro cateto:");
        cat1 = double.Parse(Console.ReadLine());
    }

    while (cat2 <= 0)
    {
        Console.WriteLine("Digite o tamanho do segundo cateto:");
        cat2 = double.Parse(Console.ReadLine());
    }
    // com biblioteca math
    hip = (cat1 * cat1) + (cat2 * cat2);
    hip = Math.Pow(cat1, 2) + Math.Pow(cat2, 2);
    hip = Math.Sqrt(hip);

    Console.WriteLine($"\nA hipotenusa é:\n{hip}\n");
    Console.WriteLine("Deseja continuar?\nDigite 0, se não, digite outro número:");
    res = int.Parse(Console.ReadLine());

} while (res == 0);
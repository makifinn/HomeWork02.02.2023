bool IsWork = true;

while (IsWork)

{
    Console.WriteLine("Для завершения работы введите: -1");
    Console.Write("Введите номер задачи ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch(i)
        {
            case 1:
            {
                Console.WriteLine("Программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом");
                Console.Write("введите пятизначное число: ");
                int.TryParse(Console.ReadLine(), out int number);

                if (number > 9999 && number <= 99999)
                {
                    int[] array = new int[5];
                    int count = 0;
                    int num = number;

                    while (count < 5)
                    {
                        int result = num % 10;
                        num = num / 10;
                        array[count] = result;
                        count++;
                    }

                    if (array[0] == array[4] && array[1] == array[3])
                    {
                        Console.WriteLine($"число {number} является полиндромом");
                    }
                    else Console.WriteLine($"число {number} не является полиндромом");
                }
                else Console.WriteLine("вы ввели не пятизначное число");
                break;
            }
            case 2:
            {
                Console.WriteLine("Программа принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве");
                Console.WriteLine("Введите координаты точек: x1, y1, z1");
                int.TryParse(Console.ReadLine(), out int x1);
                int.TryParse(Console.ReadLine(), out int y1);
                int.TryParse(Console.ReadLine(), out int z1);
                Console.WriteLine("Введите координаты точек: x2, y2, z2");
                int.TryParse(Console.ReadLine(), out int x2);
                int.TryParse(Console.ReadLine(), out int y2);
                int.TryParse(Console.ReadLine(), out int z2);

                double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
                Console.WriteLine($"расстоянеи между точками в 3D пространстве = {result}");
                break;
            }
            case 3:
            {
                Console.WriteLine("Программа принимает на вход число N и выдаёт таблицу кубов чисел от 1 до N");
                Console.Write("Введите число: ");
                int number = Convert.ToInt32(Console.ReadLine());
                int count = 1;

                while (count <= number)
                {
                    int result = Convert.ToInt32(Math.Pow(count, 3));
                    Console.WriteLine(result);
                    count++;
                }
                break;
            }
            case -1: IsWork = false; break;
        }
    }
}
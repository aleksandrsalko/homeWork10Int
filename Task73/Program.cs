/*Задача 73: Есть число N. Сколько групп M, 
  можно получить при разбиении всех чисел на группы, 
  так чтобы в одной группе все числа в группе друг на друга не делились? 
  Найдите M при заданном N и получите одно из разбиений на группы N ≤ 10²⁰.
  Например, для N = 50, M получается 6
  Группа 1: 1
  Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47
  Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
  Группа 4: 8 12 18 20 27 28 30 42 44 45 50
  Группа 5: 7 16 24 36 40
  Группа 6: 5 32 48
*/

int n = Input("Введите число элементов N: ");
int[] number = new int[n];
int count = 1;

FillArray(number);

int Input(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = i + 1;
    }
}

for (int i = 0; i < number.Length; i++)
{
    if (number[i] != 0)
    {
        int index = 0;
        int[] num2 = new int[number.Length];
        for (int k = i; k < number.Length; k++)
        {
            if (number[k] % number[i] != 0 || number[k] / number[i] == 1)
            {
                num2[index] = number[k];
                index++;
            }
        }
        for (int j = 1; j < num2.Length; j++)
        {
            for (int l = j + 1; l < num2.Length; l++)
            {
                if (num2[j] != 0 && num2[l] % num2[j] == 0)
                {
                    num2[l] = 0;
                }
            }
        }
        for (int f = 0; f < number.Length; f++)
        {
            for (int m = 0; m < num2.Length; m++)
            {
                if (num2[m] == number[f])
                {
                    number[f] = 0;
                }
            }
        }
        Console.Write($"группа {count++}: " );
        for (int k = 0; k < num2.Length; k++)
        {
            if (num2[k] != 0)
            {
                Console.Write(num2[k] + " ");
            }
        }
        Console.WriteLine();
    }
}





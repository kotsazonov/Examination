// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//  либо задать на старте выполнения алгоритма

     Console.WriteLine("Введите элементы массива строк (через пробел):");
        string input = Console.ReadLine();
        
        string[] words = input.Split(' ');

        string[] result = FilterWords(words);

        Console.WriteLine("Результат:");
        foreach (string word in result)
        {
            Console.WriteLine(word);
        }
    

    static string[] FilterWords(string[] words)
    {
        int count = 0;

        foreach (string word in words)
        {
            if (word.Length <= 3)
            {
                count++;
            }
        }

        string[] result = new string[count];
        int index = 0;

        foreach (string word in words)
        {
            if (word.Length <= 3)
            {
                result[index] = word;
                index++;
            }
        }

        return result;
    }

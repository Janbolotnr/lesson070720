using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace lesson070720
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new string[] { "A", "B", "J", "I", "K", "L", "B", "B", "I", "K" };

            CountGrades(grades);
        }

        //Time complexity: N + N * N (HashSet + foreach +Where)
        //Time complexity: N (foreach + ContainsKey) + N (foreach + Console.WriteLine) ~> N + N = 2N
        static void CountGrades(IEnumerable<string> grades)
        {
            var dictionary = new Dictionary<string, int>(); // associative array, map, dictionary

            foreach (var grade in grades)
            {
                dictionary[grade] = dictionary.ContainsKey(grade)
                    ? dictionary[grade] + 1
                    : 1;
              /*  if (dictionary.ContainsKey(grade)) dictionary[grade] += 1;
                else dictionary[grade] = 1;*/ // можно и так писать код
            }

            foreach (var entry in dictionary)
            {
                Console.WriteLine($"Grade '{entry.Key}' : {entry.Value} student(s)");
            }

            // foreach (var grade in dictionary.Keys) Console.WriteLine(grade);
            //Получение список ключей
            // foreach (var count in dictionary.Values) Console.WriteLine(count);
            //Получение список ключей
            //Dictionary() считывание оценки
        }
    }
 }

/*  var grades = new int[] {10, 3, 5, 2, 6, 8, 9, 3, 5, 4, 1, 4};

        var counts = new int[10];

        for (int i = 0; i < grades.Length; i++)
        {
            var grade = grades[i];

            counts[grade - 1] += 1;
        }

        for (int i = 0; i < counts.Length; i++)
        {
            if(counts[i] != 0)
            {
                Console.WriteLine($"Grade: '{i + 1}' : {counts[i]} student(s)");
            }
        } считать оценки

*/

/* var grades = new string[] {"A", "B", "J", "I", "K", "L", "B", "B", "I", "K"};

        var uniqueGrades = new HashSet<string>(grades);

        foreach (var uniqueGrade in uniqueGrades)  //считать оценки
        {
            var gradeCount = grades.Where(grade => grade == uniqueGrade).Count();
            Console.WriteLine($"Grade '{uniqueGrade}' : {gradeCount} student(s)");
        }*/

/* var grades = new string[] { "A", "B", "J", "I", "K", "L", "B", "B", "I", "K" };

        CountGrades(grades);
    }

    //Time complexity: N + N * N (HashSet + foreach +Where)
    //Time complexity: ??? (Dictionary)
    static void CountGrades(IEnumerable<string> grades) // if grades length is N
    {
        var uniqueGrades = new HashSet<string>(grades); // 1 * N == N

        foreach (var uniqueGrade in uniqueGrades) // <= (1 * N)
        {
            var gradeCount = grades.Where(grade => grade == uniqueGrade).Count();
            Console.WriteLine($"Grade '{uniqueGrade}' : {gradeCount} student(s)");
        }
    }*/

/* int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4};

        int n = numbers.Length;  // инверсия массива, то есть переворот его в обратном порядке
        int k = n / 2;
        int temp;

        for (int i = 0; i < k; i++)
        {
            temp = numbers[i];
            numbers[i] = numbers[n - i - 1];
            numbers[n - i - 1] = temp;
        }
        foreach (int i in numbers)
        {
            Console.Write($"{i} \t");
        }*/

/* int[] numbers = { -1, -2, -4, -3, 0, 2, 3, 4, 7, 8, 9, 1 };
      int result = 0;
      foreach (int number in numbers) // Найдем количество положительных чисел в массиве
      {
          if (num ber > 0)
          {
              result++;
          }
      }
      Console.WriteLine($"Число элементов больше нуля: {result}");*/

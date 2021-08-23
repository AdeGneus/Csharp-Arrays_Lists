using System;
using System.Collections.Generic;

namespace Csharp_Arrays_Lists
{
    class Program
    {
        /// <summary>When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information. If no one likes your post, it doesn't display anything. If only one person likes your post, it displays: [Friend's Name] likes your post. If two people like your post, it displays: [Friend 1] and [Friend 2] like your post. If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post. Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.</summary>

        static void GetNamesOfFriendsThatLikesPost()
        {
            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a name or hit enter key to exit: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                names.Add(input);
            }

            if (names.Count == 1)
            {
                Console.WriteLine($"{names[0]} likes your post");
            } else if (names.Count == 2)
            {
                Console.WriteLine($"{names[0]} and {names[1]} like your post");
            } else if (names.Count > 2)
            {
                Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} other friends like your post");
            } else
            {
                Console.WriteLine();
            }
        }

        /// <summary>Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console</summary>

        static void ReverseName()
        {
            Console.WriteLine("Enter your name: ");
            var userName = Console.ReadLine();

            var names = new char[userName.Length];
            for (var i = userName.Length; i > 0; i--)
            {
                names[userName.Length - i] = userName[i - 1];
            }

            var reversedName = new string(names);
            Console.WriteLine($"Your name in reverse is {reversedName}");
        }

        /// <summary>Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console</summary>

        static void SortNumbers()
        {
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                Console.WriteLine("Enter any number: ");
                var number = Convert.ToInt32(Console.ReadLine());

                if(numbers.Contains(number))
                {
                    Console.WriteLine("You have previously entered this number. Try again.");
                    continue;
                }
                numbers.Add(number);
            }
            numbers.Sort();

            foreach (var number in numbers)
            {
                Console.WriteLine("The numbers in ascending order: ");
                Console.WriteLine(number);
            }
        }

        /// <summary>Write a program that continuously ask the user to enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered</summary>

        static void DisplayUniqueNumbers()
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine($"Enter any number or type \"Quit\" to exit ");
                var number = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(number))
                {
                    continue;
                }

                if (number.ToLower() == "quit")
                {
                    break;
                }

                numbers.Add(Convert.ToInt32(number));
            }

            var uniqueNumbers = new List<int>();
            for (var i = 0; i < numbers.Count; i++)
            {
                if(!uniqueNumbers.Contains(numbers[i]))
                {
                    uniqueNumbers.Add(numbers[i]);
                }
            }

            Console.WriteLine("Unique numbers are: ");
            foreach (var number in uniqueNumbers)
            {
                Console.WriteLine(number);  
            }
        }

        /// <summary>Write a program and ask the user to supply a list of comma separated numbers (e.g 9, 4, 5, 1, 2). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise display the 3 smallest numbers in the list</summary>

        static void DisplaySmallestNumbers()
        {
            string[] num;

            while (true)
            {
                Console.WriteLine("Enter a list of comma-separated numbers: ");
                var userNum =  Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(userNum))
                {
                    num = userNum.Split(",");
                    if (num.Length >= 5)
                    {
                        break;
                    }
                }
                Console.WriteLine("Invalid List. Please try again");
            }

            var numbers = new List<int>();
            foreach (var element in num)
            {
                numbers.Add(Convert.ToInt32(element));
            }

            var smallestNum = new List<int>();
            while (smallestNum.Count < 3)
            {
                var min = numbers[numbers.Count - 1];
                // foreach (var number in numbers)
                // {
                //     if (number < min)
                //     {
                //         min = number;
                //     }
                // }
                for (var i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                }
                smallestNum.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallestNum)
            {
                Console.WriteLine(number);
            }
        }
         static void Main(string[] args)
        {
            DisplaySmallestNumbers();
        }
    }
}

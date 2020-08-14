using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Maskify("0415357444"));
            //Console.WriteLine(HighAndLow("9 4 6 7 8 4 2"));
            //Console.WriteLine(ToJadenCase("everything is as real as in your mind"));
            Console.WriteLine(LivBirthdayCode(26));
        }
        //        Usually when you buy something, you're asked whether your credit card number, phone number or answer to your most secret question is still correct. However, since someone could look over your shoulder, you don't want that shown on your screen.Instead, we mask it.

        //Your task is to write a function maskify, which changes all but the last four characters into '#'.
        public static string Maskify(string cc)
        {
            int workingIndex = (cc.Length - 4);
            var sb = new StringBuilder();
            for (int i = 0; i < workingIndex; i++)
            {
                sb.Append("#");
            }

            var masked = sb.Append(cc.Substring(workingIndex));
            Console.WriteLine(masked);
            return masked.ToString();
        }


        //takes a string of numbers with spaces and returns highest and lowest
        //passes code wars, altered return to:
        //return $"{maxNum} {minNum}"
        //https://www.codewars.com/kata/554b4ac871d6813a03000035/train/csharp

        public static string HighAndLow(string numbers)
        {
            var newNums = numbers.Split(" ");
            int minNum = Int32.Parse(newNums[0]);
            int maxNum = Int32.Parse(newNums[0]);
            int count = 0;

            foreach (string element in newNums)
            {
                count++;
                int num = Int32.Parse(element);
                if (num > maxNum)
                {
                    maxNum = num;
                }
                else if (num < minNum)
                {
                    minNum = num;
                }
            }
            string minMax = $"Min: {minNum}  Max: {maxNum}";
            return minMax;
        }

        public static string ToJadenCase(string phrase)
        {
            var phraseLength = phrase.Length;

            var theIndex = phrase.IndexOf(" ") + 1;
            //for (int i = 0; i < workingIndex; i++)
            //{
            //    var newPhrase = phrase.Replace(phrase[theIndex], char.ToUpper(phrase[theIndex]));

            //}

            //Console.WriteLine(phrase[theIndex]);

            //    Console.WriteLine(newPhrase);

            return theIndex.ToString();
        }

        //this public static function takes an integer as an argument
        public static int LivBirthdayCode(int years)
        {
            //count is 0 you were a baby
            int count = 0;
            //for loop while i is less than years input execute below
            for (int i = 0; i < years; i++)
            {
                //count is incremented by 1
                count++;
                var birthdayMessage = $"you were {count} years old";
                Console.WriteLine(birthdayMessage);
                //when we get to how old we are birthdaymessage reassigned
                if (count == years)
                {
                    birthdayMessage = $"BUT now you are {years}! Happy Birthday Liv!!!! Here's to many more years of learning and friendship";
                    Console.WriteLine(birthdayMessage);
                }
            }
            //returns years, can this function only return an int? how does
            //this work with types/returning ?
            return years;
        }

    }
}



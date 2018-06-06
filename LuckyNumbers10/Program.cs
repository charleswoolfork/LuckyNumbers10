using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers10
{
        class Program
        {
            static void Main(string[] args)
            {
                string userResp = " ";
                Console.WriteLine("Would you like to play");
                Console.WriteLine("Please enter Yes to play.");
                userResp = Console.ReadLine().ToLower();

                while (userResp.Equals("yes"))
                {
                    int jackPot = 100000;
                    int numMatches = 0;
                    Console.WriteLine("Please enter a starting number");
                    int minNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter a ending number");
                    int maxNumber = int.Parse(Console.ReadLine());

                    //Console.WriteLine(minNumber + " " + maxNumber);

                    int[] userNum = new int[6];

                    Console.WriteLine("Please enter six numbers");

                    for (int i = 0; i < userNum.Length; i++)
                    {
                        int inputTest = int.Parse(Console.ReadLine());

                        while (inputTest < minNumber || inputTest >= maxNumber)
                        {
                            Console.WriteLine("Please enter a value greater than {0} and less than the  {1}", minNumber, maxNumber);
                            inputTest = int.Parse(Console.ReadLine());
                        }
                        userNum[i] = inputTest;
                    }

                    //Console.WriteLine(userNum[i]);
                    int[] ranArray = new int[6];
                    Random r = new Random();

                    for (int j = 0; j < ranArray.Length; j++)
                    {
                        ranArray[j] = r.Next(minNumber, maxNumber);
                        Console.WriteLine("Lucky Number: {0}", ranArray[j]);
                    }

                    Console.WriteLine("Jackpot amount is {0}", jackPot);

                    for (int k = 0; k < userNum.Length; k++)
                    {
                        for (int l = 0; l < ranArray.Length; l++)
                        {
                            if (userNum[k] == ranArray[l])
                            {
                                numMatches++;
                                break;
                            }
                        }
                    }
                    Console.WriteLine("You guess {0} numbers correctly", numMatches);
                    Console.WriteLine("You won {0} dollars", jackPot / numMatches);
                    Console.WriteLine("Type Yes Play again?.");
                    userResp = Console.ReadLine().ToLower();
                }
            }
        }
    }
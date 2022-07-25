using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = String.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] com = input.Split();
                
                if (com[0] == "exchange")
                {

                    int index = int.Parse(com[1]);
                    if (index < 0 || index > nums.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    ExchangesThePlacesOfTwoNum(nums, index);
                }
                else if(com[0] == "max")
                {
                    if(com[1] == "odd")
                    {
                        MaxOdd(nums);
                    }
                    else if(com[1] == "even")
                    {
                        MaxEven(nums);
                    }
                }
                else if(com[0] == "min")
                {
                    if(com[1] == "odd")
                    {
                        MinOdd(nums);
                    }
                    else if(com[1] == "even")
                    {
                        MinEven(nums);
                    }
                }
                else if(com[0] == "first")
                {
                    int count = int.Parse(com[1]);
                    if(count > nums.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    if(com[2] == "odd")
                    {
                        FirstOdd(nums, count);
                    }
                    else if(com[2] == "even")
                    {
                        FirstEven(nums, count);
                    }
                }
                else if(com[0] == "last")
                {
                    int count = int.Parse(com[1]);
                    if (count > nums.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    if (com[2] == "odd")
                    {
                        LastOdd(nums, count);
                    }
                    else if(com[2] == "even")
                    {
                        LastEven(nums, count);
                    }
                }
            }
            Console.WriteLine("[" + String.Join(", ", nums) + "]");
        }

        static void ExchangesThePlacesOfTwoNum (int[] nums, int index)
        {
            int[] one = new int[nums.Length - index - 1];
            int[] two = new int[index + 1];
            int count = 0;
            for (int i = index + 1; i < nums.Length; i++)
            {
                one[count] = nums[i];
                count++;
            }
            count = 0;
            for (int i = 0; i <= index; i++)
            {
                two[count] = nums[i];
                count++;
            }
            
            for (int i = 0; i < one.Length; i++)
            {
                nums[i] = one[i];
            }

            for (int i = 0; i < two.Length; i++)
            {
                nums[one.Length + i] = two[i];
            }
        }
        static void MaxOdd(int[] nums)
        {
            int maxNum = int.MinValue;
            int index = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                if(nums[i] % 2 == 1)
                {
                    if(nums[i] >= maxNum)
                    {
                        maxNum = nums[i];
                        index = i;
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
        static void MaxEven(int[] nums)
        {
            int maxNum = int.MinValue;
            int index = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] % 2 == 0)
                {
                    if (nums[i] >= maxNum)
                    {
                        maxNum = nums[i];
                        index = i;
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
        static void MinOdd(int[] nums)
        {
            int minNum = int.MaxValue;
            int index = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] % 2 == 1)
                {
                    if (nums[i] <= minNum)
                    {
                        minNum = nums[i];
                        index = i;
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
        static void MinEven(int[] nums)
        {
            int minNum = int.MaxValue;
            int index = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] % 2 == 0)
                {
                    if (nums[i] <= minNum)
                    {
                        minNum = nums[i];
                        index = i;
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
        static void FirstOdd(int[] nums, int count)
        {
            string odd = String.Empty;
            int countOdd = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 1)
                {
                    countOdd++;
                    if (countOdd > count)
                    {
                        break;
                    }
                    odd += nums[i] + " ";
                }
            }
            var result = odd.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("[" + String.Join(", ", result) + "]");
        }
        static void FirstEven(int[] nums, int count)
        {
            string even = String.Empty;
            int countEven = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    countEven++;
                    if (countEven > count)
                    {
                        break;
                    }
                    even += nums[i] + " ";
                }
            }
            var result = even.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("[" + String.Join(", ", result) + "]");
        }
        static void LastOdd(int[] nums, int count)
        {
            string odd = String.Empty;
            int countOdd = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] % 2 == 1)
                {
                    countOdd++;
                    odd += nums[i] + " ";
                    if (countOdd == count)
                    {
                        break;
                    }
                }
            }
            if(countOdd == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                var result = odd.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();
                Console.WriteLine("[" + String.Join(", ", result) + "]");
            }
            
        }

        static void LastEven(int[] nums, int count)
        {
            string even = String.Empty;
            int countEven = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] % 2 == 0)
                {
                    countEven++;
                    even += nums[i] + " ";
                    if (countEven == count)
                    {
                        break;
                    }
                }
            }
            if (countEven == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                var result = even.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();
                Console.WriteLine("[" + String.Join(", ", result) + "]");
            }

        }
    }
}

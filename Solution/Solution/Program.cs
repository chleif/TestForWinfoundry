using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        //20分
        public int[] Question1(int[] nums, int target)
        {
            int[] output = new int[2];
            output[0] = 0;
            output[1] = 0;
            int length = nums.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length - 1; j++)
                {
                    int sum = nums[i] + nums[j];
                    if (sum == target)
                    {
                        output[0] = i;
                        output[1] = j;
                    }
                }
            }
            return output;
        }

        //20分
        public int Question2(string s)
        {
            //使用字典比對羅馬數字與阿拉伯數字
            //並使用 % 於數方式計算個羅馬數字的次數
            return 0;
        }

        //20分
        public ListNode Question3(ListNode l1, ListNode l2)
        {
            //List<int> result = l1.Concat(l2).OrderBy(x => x).ToList();

            return new ListNode();
        }

        //20分
        public string Question4(int num)
        {
            //類似Q2
            return "";
        }

        //30分
        public void Question5(int[] nums)
        {
            //使用foreach取出每個數字並組成新的3個僅包含"0"或"1"或"2"的int[]，
            //將新的三個int[]作合併
        }
        //20分
        public bool Question6(int n)
        {
            if (n == 0) return false;
            else
            {
                while (n != 1)
                {
                    if (n % 2 == 0)
                    {
                        n = n / 2;
                    }
                    else if (n % 3 == 0)
                    {
                        n = n / 3;
                    }
                    else if (n % 5 == 0)
                    {
                        n = n / 5;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        //20分
        public bool Question7(int num)
        {
            if (num == 1) return true;
            if (num < 1) return false;
            if (num % 4 == 0) return true;
            else return false;
        }

    }


    /// <summary>
    /// Q3定義
    /// </summary>
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenCode
{
    public class Algorithems
    {
       
        public void CalMeanMedianMdeRange(string s)
        {
            Console.WriteLine(s);
            int[] nums = Array.ConvertAll(s.Split(' ', '\n'), int.Parse);

            var mean = 0; var median = 0; var mode = 0; var range = 0; var mid = 0;
            var sum = 0;
            mid = (nums.Length + 1) / 2;

            Array.Sort(nums);
            Dictionary<int, int> trace = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {

                if (trace.Count != 0 && trace.Keys.Contains(nums[i]))
                {

                    trace[nums[i]] += 1;
                }
                else
                {
                    trace.Add(nums[i], 1);
                }
                sum += i;
            }
            mode = trace.Values.Max() == 1 ? 0 : trace.OrderByDescending(l => l.Value).Select(l => l.Key).FirstOrDefault();
            mean = sum / nums.Length;
            range = nums[nums.Length - 1] - nums[0];
            median = nums[mid];
            Console.WriteLine("mean:" + mean + " median:" + median + " range:" + range + " Mode:" + mode);

        }
        public void ReadString(string s)
        {
            char[] charArr = s.ToCharArray();
            Array.Sort(charArr);
            Dictionary<char, int> lookupBychar = new Dictionary<char, int>();
            for (int i = 0; i < charArr.Length; i++)
            {
                if (lookupBychar.Keys.Contains(charArr[i]))
                {
                    lookupBychar[charArr[i]] += 1;
                }
                else
                {
                    lookupBychar.Add(charArr[i], 1);
                }
            }
            //using Linq you can read and sort values
            // Dictionary<char, int> lookupBychar = s.GroupBy(g => g).OrderBy(c => c.Key).ToDictionary(k => k.Key, k => k.Count());
            Console.WriteLine("Output:");
            foreach (var c in lookupBychar)
            {
                Console.Write(c.Key.ToString() + ":");
                Console.WriteLine(c.Value);

            }

        }
    }
}

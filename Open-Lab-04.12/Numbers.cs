    using System;
    using System.Linq;
namespace Open_Lab_04._12
{
    public class Numbers
    {
        public int MissingNum(int[] nums)
        {
            var temp =nums.OrderBy(p => p).ToList();
            return Enumerable.Range(1, temp[temp.Count - 1]+1).Except(temp).ToList()[0];
        }
    }
}

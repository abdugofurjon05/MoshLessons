namespace System
{


    //extension method for string.
    public static class StringExtension
    {
        public static string PutBounder(this string str, int nums)
        {
            if(nums<0) throw new ArgumentOutOfRangeException(nameof(nums));

            if(nums == 0) return string.Empty;

            if(str.Length <= nums) return str;


            var str1 = str.Split(' ');
            return string.Join(" ", str1.Take(nums));

        }
    }
}
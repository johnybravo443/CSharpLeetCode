using System;

namespace seriesone.StringsTest
{
    class CheckAStringIsRotationOfAnotherString
    {
        public void CheckStringIsRotationOfAnotherString()
        {
            string str = "abcd";
            //string fin = "dabc"; // noOfRotation = 1 
            string fin = "cdab";    //noOfRotation = 2
            var noOfRotation = 2;

            var flag = false;
            for (int i = 0; i < str.Length; i++)
            {
                var j = (i + noOfRotation) % str.Length;

                if (str[i] == fin[j])
                    flag = true;
                else
                    break;
            }

            if (flag)
                Console.WriteLine(flag);
            else
                Console.WriteLine(flag);
        }

        public static bool CheckStringIsRotationOfAnotherStringOne()
        {
            string str = "abcd";
            string fin = "dwbc"; // noOfRotation = 1 
            //string fin = "cdab";    //noOfRotation = 2

            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(fin))
                return false;

            return (str.Length == fin.Length && (str + str).Contains(fin));
        }
    }
}

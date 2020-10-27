using System;

namespace Open_Lab_04._13
{
    public class StringTools
    {
        public string GetLongestCommonSequence(string str1, string str2)
        {
            int[,] i = new int[str1.Length + 1, str2.Length + 1];
            int t = 0;    
            int n = 0;    

            for (var v = 0; v < str1.Length; v++)
                for (var r = 0; r < str2.Length; r++)
                    if (str1[v] == str2[r])
                    {
                        int idk = i[v + 1, r + 1] = i[v, r] + 1;
                        if (idk > i[t, n])
                        {
                            t = v + 1;
                            n = r + 1;
                        }
                    }

            return str1.Substring(t - i[t, n], i[t, n]);
        }
    }
}

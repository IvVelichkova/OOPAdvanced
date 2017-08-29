using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class RandomList : ArrayList
{
    public static string RandomElement(RandomList randomList)
    {
        Random ranrom = new Random();
        int num = ranrom.Next(0, randomList.Count);
        int result = (int)randomList[num];
        randomList.RemoveAt(num);
        return num.ToString();
    }
}


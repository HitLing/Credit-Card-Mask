using System;
public static class Kata
{
    // return masked string
    public static string Maskify(string cc)
    {
        int length = cc.Length;
        if (length>4) {
            char[] str = cc.ToCharArray();
            for (int i = 0; i < length-4; i++) {
                str[i] = Convert.ToChar("#");
            }
            cc = new string(str);
        }

        return cc;
    }

}




namespace Маска_кредитной_карты_ката_2
{
    class Program
    {
        static void Main(string[] args)
        {
           string test = Kata.Maskify("");
            Console.WriteLine(test);
        }
    }
}

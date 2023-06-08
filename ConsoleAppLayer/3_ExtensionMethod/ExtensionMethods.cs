namespace ConsoleAppLayer._3_ExtensionMethod
{
    public class ExtensionMethods
    {
    }

    public static class StringExtensions // 1- public static class olmalı.
    {
        public static string FirstCharacterToUpper(this string str, int a) // 2- public static method olmalı.
                                                                           // 3- İlk parametre olarak "this" anahtar kelimesiyle
                                                                           // genişletmek istediğiniz türü belirtin.
        {
            if (string.IsNullOrEmpty(str))
                return str;

            char firstChar = char.ToUpper(str[0]);
            return firstChar + str.Substring(1) + a;
        }
    }

    public static class IntExtensions // 1- public static class olmalı.
    {
        public static double karesiniAl(this int x) // 2- public static method olmalı.
                                                    // 3- İlk parametre olarak "this" anahtar kelimesiyle
                                                    // genişletmek istediğiniz türü belirtin.
        {
            return Math.Sqrt(x);
        }
    }


    public class ExtensionMethod
    {
        //static void Main(string[] args)
        //{
        //    string text = "hello";
        //   // string modifiedText = StringExtensions.FirstCharacterToUpper(text); // this kaldırılırsa statik metot olur extension değil
        //    string modifiedText1 = text.FirstCharacterToUpper(3); // EXTENSİON METHOTDA this OLMAZSA OLMAZ

        //    Console.WriteLine(modifiedText1);  // "çıktı : hello --> Hello"

        //    int sayi = 81;
        //    double modifiedSayi = sayi.karesiniAl();
        //    Console.WriteLine(modifiedSayi); // 81-->9

        //}
    }

}

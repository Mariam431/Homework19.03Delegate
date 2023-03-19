using static Homework19._03.MyClass;
namespace Homework19._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyDelegate myDelegate = new MyDelegate(myClass.MethA);
            myDelegate += myClass.MethB;
            myDelegate += myClass.MethC;
            myDelegate += myClass.MethD;
            myDelegate += myClass.MethE;
            myDelegate(5);
            Console.WriteLine(myClass.MethA(5));// vonc kanchem MethA-n? inchi delegate-y arjeqavoreluc inqy chi arjeqavorvum u petqa arancin cw-i mej iran arjeqavorel?




        }
    }
}
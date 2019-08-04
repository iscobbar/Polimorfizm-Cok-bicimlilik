using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    // Polimorfizm: Çok biçimlilik
    class Program
    {
        public static void Sesçikar(hayvan hyvn)
        {
            hyvn.Sesçikar();
        }
        static void Main(string[] args)
        {
            kopek k1 = new kopek();
            k1.Sesçikar();
            kedi ked1 = new kedi();
            ked1.Sesçikar();
            hayvan h1 = new hayvan();
            h1 = k1;
            h1.Sesçikar();
            k1.Uluma();
            Console.WriteLine("\n\n");

            Sesçikar(k1);
            Sesçikar(ked1);


            Console.Read();
        }
    }
    class hayvan
    {
        virtual public void Sesçikar()
        {
            Console.WriteLine("Hayvan sesleri farklılık gösterir!");
        }
    }
    /* 1'den fazla override üst class için geçerli sayılmıyor. 
     * sanal (virtual= metotlar sayesinde; temel sınıf nesnelerine yüteyen sınıf nesneleri atandığında 
     * türeyen sınıf metotlarını kullanmaya devam edebiliriz.
     * virtual ifadesi ana sınıftaki bir metotun çalışma zamanında devre dışı bırakılabileceğini belirtir(late binding)
     * türeyen sınıftaki override edilmiş olan aynı isiml imetot bu metotu devre dışı bırakabilir.
     * türeyen sınıfta override edilmemişse temel sınıf metotu çalışır.*/

    class kopek : hayvan
    {
        //bu classta 1 tane override bulunmaktadır.
        override public void Sesçikar()
        {
            Console.WriteLine("hav hav hav");
        }
        // ikincisinde yazmaya kalkarsam "main" metodunda çalıştırılınca hata verecektir. 
        public void Uluma()
        {
            Console.WriteLine("auuuuuuuu");
        }
    }
    class kedi : hayvan
    {
        override public void Sesçikar()
        {
            Console.WriteLine("miyav miyav");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Diagnostics;


namespace test
{
    public class ICovariant<in T>
    {
        //T Method1();
        //void Method2(T param);
    }

    enum TypeName : int
    {
    }

    struct structName
    {

    }


public class Sharp : ICovariant<Sharp>
    {
    }

    public class Rectange : Sharp, ICovariant<Rectange>
    {
    }

    class Program
    {
       
        static void Main(string[] args)
        {

            ICovariant<Sharp> isharp = new Sharp();
            ICovariant<Rectange> irect = new Rectange();

            isharp = irect;
            //irect = isharp;

            Sharp testShape = isharp.Method1();

            int? testNull=null;
            testNull = 6;

            string strTest = "aaaaaa aaaaa";
            strTest.Split(' ');

        }

    }
}

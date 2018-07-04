using System;

namespace ConsoleApp1
{

    enum ShippingMethod
    {
        aVar = 8,
        anotherVar = 9
    }

    class EnumsDemo
    {



        public void ShippingClass()
        {

            Console.WriteLine((int)ShippingMethod.anotherVar + (int)ShippingMethod.aVar);

            var methodId = 9;
            Console.WriteLine((ShippingMethod)methodId);

            int method = (int)ShippingMethod.aVar;

            Console.WriteLine(method.ToString() + "\n" + ShippingMethod.anotherVar.ToString());

            var methodName = "anotherVar";
            var aThirdVar = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            Console.WriteLine("aThirdVar = " + aThirdVar);
        }
            

    }
}

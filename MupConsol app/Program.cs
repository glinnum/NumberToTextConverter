using System;
using System.Reflection;

namespace NumConsol_app
{

    class Program
    {
        static void Main(string[] args)
        {
            // Load the assemby which defines the MyType interface.
            Assembly InterfaceAssembly = Assembly.LoadFrom("C:\\source\\repos\\NumberToTextConverter\\NumberToTextConverter\\bin\\Debug\\netcoreapp3.1\\NumberToTextConverter.dll");
            // Obtain the MyType interface.
            Type InterfaceType = InterfaceAssembly.GetType("C:\\source\\repos\\NumberToTextConverter\\NumberToTextConverter\\bin\\Debug\\netcoreapp3.1\\NumberToTextConverter.IMyConverter");


            // Create an instance of MyClass.
            var Instance = Activator.CreateInstance(InterfaceType);

            // Invoke the Method01() method. Note that we only call methods of the MyType interface.
            object[] doubleArgs = new object[] { 9923d };
            object member = InterfaceType.InvokeMember("ConvertToWords", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, Instance, doubleArgs);


            Console.WriteLine("Hello World!");
            var result1 = member.ToString();
            //var result = ConvertToWords(9923);
            //result = ConvertToWords(523);
            //result = ConvertToWords(89);
            //result = ConvertToWords(8989);
        }
    }
}

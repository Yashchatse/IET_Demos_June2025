using _35MyCustomAttribute;
using System.Reflection;
using System.Text.Json.Serialization;

namespace _33CustomAttributes1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string assemblyPath = @"D:\Personal\IETCDAC\June25\CSharpDemos25\31CMathLib\bin\Debug\net8.0\31CMathLib.dll";

            Assembly asm = Assembly.LoadFrom(assemblyPath);
            Type[] types = asm.GetTypes();
            for (int i = 0; i < types.Length; i++)
            {
                Type type = types[i];

                Attribute[] allAttributes = type.GetCustomAttributes().ToArray();

                for (int j = 0; j < allAttributes.Length; j++)
                {
                    Attribute currentAttribute = allAttributes[j];
                    if (currentAttribute is SerializableAttribute)
                    {
                        Attribute attr = allAttributes[j];
                        Console.WriteLine($"Type: {type.Name}, Attribute: {attr.GetType().Name} \n{type.Name} is Serializable");
                    }
                    if(currentAttribute is BVS)
                    {
                        BVS bvs = currentAttribute as BVS;
                        Console.WriteLine($"Type : {type.Name} is developed by {bvs.DeveloperName} and is belongs to (c){bvs.CompanyName} company!!!");
                    }
                }
            }
        }
    }
}

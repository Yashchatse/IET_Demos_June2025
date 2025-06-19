using System.Reflection;

namespace _32Reflection1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string assemblyPath = @"D:\Personal\IETCDAC\June25\CSharpDemos25\31CMathLib\bin\Debug\net8.0\31CMathLib.dll";

            // Load the assembly
            Assembly asm = Assembly.LoadFrom(assemblyPath);

            Type [] types = asm.GetTypes();

            for (int i = 0; i < types.Length; i++)
            {
                Type type = types[i];

                object dynamicallyCreatedObject = asm.CreateInstance(type.FullName);

                #region FullName, Name , Namespace
                //Console.WriteLine(type.FullName);
                //Console.WriteLine(type.Name);
                //Console.WriteLine(type.Namespace); 
                #endregion

                MethodInfo[] allMethods = type.GetMethods();

                string methodSignature = string.Empty; // ""

                for (int j = 0; j < allMethods.Length; j++) 
                {
                    MethodInfo method = allMethods[j];
                    //System.Int32 
                    methodSignature = method.ReturnType.ToString()+" ";
                    #region int - System.Int32
                    //if(method.ReturnType.ToString() == "System.Int32")
                    //{
                    //    methodSignature = "int";
                    //} 
                    #endregion

                    //System.Int32 Add/Sub ( 
                    methodSignature = methodSignature + method.Name + " ( ";
                    ParameterInfo[] allParameters =  method.GetParameters();

                    //This code generates method Signature output:
                    for (int k = 0; k < allParameters.Length; k++)
                    {
                        ParameterInfo parameter = allParameters[k];

                        //System.Int32 Add/Sub ( System.Int32 x, System.Int32 y, 
                        methodSignature = methodSignature + parameter.ParameterType.ToString() + " "+ parameter.Name + ",";
                    }
                    //System.Int32 Add/Sub ( System.Int32 x, System.Int32 y )
                    methodSignature = methodSignature.TrimEnd(',') + " )";
                    Console.WriteLine(methodSignature);

                    //This code accepts user input and Converts it into respective paramater types dynamically. for e.g: if ParamaeterType is int, it will convert the input value to System.Int32.
                    object[] inputParameters = new object[allParameters.Length];
                    for (int k = 0; k < allParameters.Length; k++)
                    {
                        ParameterInfo para = allParameters[k];
                        Console.WriteLine($"Enter value for {para.Name} of type = {para.ParameterType.ToString()}");

                       object inputVal = Convert.ChangeType(Console.ReadLine(), para.ParameterType);

                        inputParameters[k] = inputVal;
                    }

                    object? result = type.InvokeMember(
                        method.Name,
                        BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod,
                        null,
                        dynamicallyCreatedObject,
                        inputParameters
                    );
                    Console.WriteLine($"{method.Name} result = {result}");
                    Console.WriteLine("-------------------------------");

                    #region fixed input values 
                    //object[] inputVals = new object[2];
                    //inputVals[0] = 30;
                    //inputVals[1] = 10;
                    //object? result  =type.InvokeMember(
                    //    method.Name,
                    //    BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod,
                    //    null,
                    //    dynamicallyCreatedObject,
                    //    inputVals
                    //);
                    //Console.WriteLine($"{method.Name} result = {result}");
                    //Console.WriteLine("-------------------------------"); 
                    #endregion
                }

            }
        }
    }
    // int Add(int x, int y)
    // System.Int32 Add(System.Int32 x, System.Int32 y)
}

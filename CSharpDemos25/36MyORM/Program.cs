using _35MyAttributeLib;
using System.Reflection;

namespace _36MyORM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string assemblyPath = @"D:\Personal\IETCDAC\June25\CSharpDemos25\36EmpLib\bin\Debug\net8.0\36EmpLib.dll";

            Assembly asm = Assembly.LoadFrom(assemblyPath);
            Type[] types = asm.GetTypes();
            for (int i = 0; i < types.Length; i++)
            {
                Type type = types[i];

                string createTableQuery = "";

                Attribute[] allAttributes = type.GetCustomAttributes().ToArray();
                for (int j = 0; j < allAttributes.Length; j++)
                {
                    Attribute currentAttribute = allAttributes[j];
                    if (currentAttribute is Table table)
                    {
                        //Table table = (Table)currentAttribute;
                        createTableQuery = $"CREATE TABLE {table.TableName} (";
                    }
                }

                //Console.WriteLine(createTableQuery);

                PropertyInfo[] properties = type.GetProperties();
                for (int j = 0; j < properties.Length; j++)
                {
                    PropertyInfo currentProperty = properties[j];
                    Attribute[] propAttr = currentProperty.GetCustomAttributes().ToArray();
                    for (int k = 0; k < propAttr.Length; k++)
                    {
                        Attribute currentPropAttribute = propAttr[k];
                        if (currentPropAttribute is Column col)
                        {
                            //Column column = (Column)currentPropAttribute;
                            createTableQuery += $"{col.ColumnName} {col.ColumnType},";
                        }
                    }
                }

                //Console.WriteLine(createTableQuery);
                createTableQuery = createTableQuery.TrimEnd(',') + ")";
                //Console.WriteLine(createTableQuery);
                string filePath = @"D:\Personal\IETCDAC\June25\CSharpDemos25\36MyORM\File\EmpTableQuery.sql";
                File.WriteAllText(filePath, createTableQuery);
                Console.WriteLine("Done");
            }
        }
    }
    
}

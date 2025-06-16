using System.Runtime.CompilerServices;

namespace _22Events_Deleagtes
{
    public delegate void ResultHandler(int marks);
    internal class Program
    {
        static void Main(string[] args)
        {
            //Button btn1 = new Button();
            //btn1.Txt = "Cleck Me";
            //this.Controls.Add(btn1);
            //btn1.Click += new EventHandler(btn1_Click);


            Student student = new Student();

            // Coupling Events with a delegate
            student._Pass += new ResultHandler(student.stud_Pass);
            student._Fail += new ResultHandler(student.stud_Fail);

            Console.WriteLine("Enter your Marks : ");
            student.Marks = Convert.ToInt32(Console.ReadLine());
            //int marks = Convert.ToInt32(Console.ReadLine());

            
            //ResultHandler delPass = new ResultHandler(student.stud_Pass);
            //ResultHandler delFail = new ResultHandler(student.stud_Fail);

            

            //// Invoking Event from within the class
            //student.GetResult(marks); // Using event to call the method

            //if (marks > 40)
            //{
            //    //stud_Pass(marks);
            //    //student.stud_Pass(marks);
            //    //delPass(marks); // Using delegate to call the method
            //    //student._Pass(marks); // Using event to call the method // Error
            //}
            //else
            //{
            //    //stud_Fail(marks);
            //    //student.stud_Fail(marks);
            //    //delFail(marks); // Using delegate to call the method
            //}
        }

        //public static void stud_Pass(int mrks)
        //{
        //    Console.WriteLine($"Congratulation !!! You Passed with {mrks} marks !!!");
        //}
        //public static void stud_Fail(int mrks)
        //{
        //    Console.WriteLine($"Congratulation !!! You Failed with {mrks} marks !!!");
        //}

        //public static void btn1_Click(object sender, EventArgs e)
        //{
        //   MessageBox.Show("Button Clicked");
        //}
    }

    public class Student
    {
        //Events are always member of a class
        //Events are always associated with deleagtes.
        // Means you can not declare event without delegate.
        public event ResultHandler _Pass; // AccessModifer event DelegateName EventName;

        public event ResultHandler _Fail; // AccessModifer event DelegateName EventName;

        private int _Marks;
        public int Marks
        {
            set
            {
                _Marks = value;
                if (_Marks > 40)
                {
                    _Pass(_Marks); // Using event to call the method 
                }
                else
                {
                    _Fail.Invoke(_Marks); // Using event to call the method
                }
            }
            get
            {
                return _Marks;
            }
        }
        //public void GetResult(int marks)
        //{
        //    if (marks > 40)
        //    {
        //        _Pass(marks); // Using event to call the method 
        //    }
        //    else
        //    {
        //        _Fail(marks); // Using event to call the method
        //    }
        //}
        public void stud_Pass(int mrks)
        {
            Console.WriteLine($"Congratulation !!! You Passed with {mrks} marks !!!");
        }
        public void stud_Fail(int mrks)
        {
            Console.WriteLine($"Congratulation !!! You Failed with {mrks} marks !!!");
        }
    }
}

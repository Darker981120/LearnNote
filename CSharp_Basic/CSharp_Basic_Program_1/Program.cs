using System;

namespace CSharp_Basic_Program_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("***** Fun with Methods *****\n");

            // 按值传入两个变量
            //int x = 9, y = 10;
            //Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
            //Console.WriteLine("Answer is: {0}", Add(x, y));
            //Console.WriteLine("After call: X: {0}, Y: {1}", x, y);

            // 不需要给作为输出参数的本地变量赋初值，假设第一次使用它们时是将其作为输出参数的
            //int ans;
            //Add(90, 90, out ans);
            //Console.WriteLine("90 + 90 = {0}", ans);

            //int i; string str; bool b;
            //FillTheseValues(out i, out str, out b);
            //Console.WriteLine("Int is: {0}", i);
            //Console.WriteLine("String is: {0}", str);
            //Console.WriteLine("Boolean is: {0}", b);

            //************************ Fun with Methods **************************

            //string s1 = "Flip";
            //string s2 = "Flop";
            //Console.WriteLine("Before: {0}, {1}", s1, s2);
            //SwapStrings(ref s1, ref s2);
            //Console.WriteLine("After: {0}, {1}", s1, s2);

            // ************************ Fun with Methods **************************
            // 传递进一个以逗号分隔的double型数的列表
            //double average;
            //average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            //Console.WriteLine("Average of data is: {0}", average);

            // ……传递一个double型的数组
            //double[] data = { 4.0, 3.2, 5.7 };
            //average = CalculateAverage(data);
            //Console.WriteLine("Average of data is {0}", average);

            // 0的平均值是0
            //Console.WriteLine("Average of data is {0}", CalculateAverage());

            // ************************ Fun with Methods **************************
            //EnterLogData("Oh no! Grid can't find data");
            //EnterLogData("Oh no! I can't find the payroll data", "CFO");

            // ************************ Fun with Methods **************************
            //DisplayFancyMessage(message: "Wow! Very Fancy indeed!",
            //    textColor:ConsoleColor.DarkRed,backgroundColor
            //    :ConsoleColor.White);
            //DisplayFancyMessage(backgroundColor: ConsoleColor.Green,
            //    message: "Testing...",
            //    textColor: ConsoleColor.DarkBlue);

            // 没有问题，因为位置参数在命名参数之前。
            //DisplayFancyMessage(ConsoleColor.Blue, message: "Testing...", backgroundColor: ConsoleColor.White);

            // 错误，因为设置参数在命名参数之后
            //DisplayFancyMessage(message: "Testing...", backgroundColor: ConsoleColor.White, ConsoleColor.Blue);

            //DisplayFancyMessage(message: "Hello");
            //DisplayFancyMessage(backgroundColor: ConsoleColor.Green);

            //Console.WriteLine("***** Fun with Method Overloading *****\n");

            // 调用int版本的Add()
            //Console.WriteLine(Add(10, 10));

            // 调用long版本的Add()
            //Console.WriteLine(Add(90000000000, 90000000000));

            // 调用double版本的Add()
            //Console.WriteLine(Add(4.3, 4.4));

            Console.WriteLine("***** Fun with Arrays *****\n");
            //SimpleArrays();
            //ArrayOfObjects();
            RectMultidimensionalArray();
            JaggedMultidimensionalArray();

            Console.ReadLine();
        }

        #region Default
        // 静态方法可以被直接调用，无需创建类的实例
        // static 返回值 方法名(参数) {…}
        // 默认情况下参数会按值传递
        //static int Add(int x, int y)
        //{
        //    int ans = x + y;

        //    // 由于我们修改的是原始数据的副本，调用者不会看到这些改变
        //    x = 10000;
        //    y = 88888;
        //    return ans;
        //}
        #endregion

        #region out 输出参数
        // 输出参数由被调用的方法赋值
        static void Add(int x , int y, out int ans)
        {
            ans = x + y;
        }

        // 返回多个输出参数
        static void FillTheseValues(out int a, out string b,out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }

        // 输出参数没有方法在方法域中被赋值，如下方法会导致编译器错误
        //static void ThisWontCompile(out int a)
        //{
        //    Console.WriteLine("Error! Forget to assign output arg!");
        //}
        #endregion

        #region ref 引用参数
        // 引用参数
        public static void SwapStrings(ref string s1,ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }
        #endregion

        #region params 参数数组
        // 返回一些double型的平均值
        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);

            double sum = 0;
            if (values.Length == 0)
                return sum;

            for(int i = 0; i < values.Length; i++)
                sum += values[i];
            return (sum / values.Length);
        }
        #endregion

        #region 定义可选参数
        static void EnterLogData(string message, string owner = "Programmer")
        {
            Console.Beep();
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of Error: {0}", owner);
        }

        // 错误！可选参数的默认值必须在编译时确定
        //static void EnterLogData(string message, string owner = "Programmer", DateTime timeStamp = DateTime.Now)
        //{
        //    Console.Beep();
        //    Console.WriteLine("Error: {0}", message);
        //    Console.WriteLine("Owner of Error: {0}", owner);
        //    Console.WriteLine("Time of Error: {0}", timeStamp);
        //}

        #endregion

        #region 使用命名参数调用方法
        //static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor,string message)
        //{
        //    // 在消息打印前保存就的颜色
        //    ConsoleColor oldTextColor = Console.ForegroundColor;
        //    ConsoleColor oldbackgroundColor = Console.BackgroundColor;

        //    // 设置新的颜色并打印消息
        //    Console.ForegroundColor = textColor;
        //    Console.BackgroundColor = backgroundColor;

        //    Console.WriteLine(message);

        //    // 恢复原来的颜色
        //    Console.ForegroundColor = oldTextColor;
        //    Console.BackgroundColor = oldbackgroundColor;
        //}


        // 没有问题，命名参数设置了合适的默认值
        static void DisplayFancyMessage(ConsoleColor textColor = ConsoleColor.Blue, 
            ConsoleColor backgroundColor = ConsoleColor.White, 
             string message = "Test Message")
        {
            // ...
        }
        #endregion

        #region 成员重载
        // 重载的Add()方法
        static int Add (int x,int y) { return x + y; }

        static double Add(double x, double y) { return x + y; }

        static long Add(long x, long y) { return x + y; }
        #endregion

        #region 数组操作
        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation.");
            // 赋值一个包含3个元素的整数数组{0，1，2}
            // 创建数组并且填充3个整数
            int[] myInts = new int[3];

            // 初始化一个100项的字符串数组，编号0-99
            //string[] booksOnDotNet = new string[100];

            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            // 现在输出每一个值
            foreach (int i in myInts)
                Console.WriteLine(i);
            Console.WriteLine();
        }

        // 数组初始化
        static void ArrayInitialization()
        {
            Console.WriteLine("=> Array Initialization.");

            // 使用new关键字的数组初始化语法
            string[] stringArray = new string[] { "one","two","three" };
            Console.WriteLine("StringArray has {0} elements", stringArray.Length);

            // 不使用new关键字的数组初始化语法
            bool[] boolArray = { false, false, false };
            Console.WriteLine("BoolArray has {0} elements", boolArray.Length);

            // 使用new关键字和大小的数组初始化
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("IntArray has {0} elements", intArray.Length);

            // 哦！大小和元素不匹配
            //int[] intArray = new int[2] { 20, 22, 23, 0 };
        }

        // 隐式类型本地数组
        static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization.");

            // a实际上是int[]
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());

            // b实际上是double[]
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is a: {0}", b.ToString());

            // c实际上是string[]
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is a: {0}", c.ToString());
            Console.WriteLine();

            // 错误！混合类型
            //var d = new[] { 1, "one", 2, "two", false };
        }

        // 定义object数组
        static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of Objects.");

            // 对象数组可以是任何东西
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";

            foreach(object obj in myObjects)
            {
                // 输出数组中每一项的类型和值
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }
            Console.WriteLine();
        }

        // 使用多维数组
        static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array.");
            // 矩阵多维数组
            int[,] myMatrix;
            myMatrix = new int[6, 6];

            // 填充6*6数组
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                    myMatrix[i, j] = i * j;

            // 输出6*6数组
            for(int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                    Console.Write(myMatrix[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 使用交错数组
        static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array.");
            // 交错多维数组（也就是数组的数组）
            // 声明一个具有5个不同数组的数组
            int[][] myJagArray = new int[5][];

            // 创建交错数组
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];

            // 输出每一行（记住，每一个元素都默认为0）
            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        #endregion
    }
}
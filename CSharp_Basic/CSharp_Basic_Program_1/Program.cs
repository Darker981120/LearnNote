using System;

namespace CSharp_Basic_Program_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
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

            //Console.WriteLine("***** Fun with Arrays *****\n");
            //SimpleArrays();
            //ArrayOfObjects();
            //RectMultidimensionalArray();
            //JaggedMultidimensionalArray();
            //PassAndReceiveArrays();
            //SystemArrayFunctionality();

            //Console.WriteLine("***** Fun with Enums *****\n");
            // 创建职员的类型
            //EmpType emp = EmpType.Contractor;
            //AskForBonus(emp);

            // 输出枚举的存储
            //Console.WriteLine("EmpType uses a {0} for storage",
            //    Enum.GetUnderlyingType(emp.GetType()));

            // 输出“emp is a Contractor”
            //Console.WriteLine("emp is a {0}.", emp.ToString());

            // 输出“Contractor = 100”
            //Console.WriteLine("{0} = {1}", emp.ToString(), (byte)emp);

            //EmpType e2 = EmpType.Contractor;

            // 这些类型为System命名空间中的枚举值
            //DayOfWeek day = DayOfWeek.Monday;
            //ConsoleColor cc = ConsoleColor.Gray;

            //EvaluateEnum(e2);
            //EvaluateEnum(day);
            //EvaluateEnum(cc);

            //Console.WriteLine("***** A First Look at Strustures *****\n");
            // 创建初始Point
            //Point myPoint;
            //myPoint.X = 349;
            //myPoint.Y = 76;
            //myPoint.Display();

            // 调整X和Y的值
            //myPoint.Increment();
            //myPoint.Display();

            // 错误！没有为Y赋值
            //Point p1;
            //p1.X = 10;
            //p1.Display();

            // 正确！在使用前两个字段都赋值了
            //Point p2;
            //p2.X = 10;
            //p2.Y = 10;
            //p2.Display();

            // 使用默认构造函数将所有字段设置成默认值
            //Point p1 = new Point();

            // 输出X=0，Y=0
            //p1.Display();

            // 调用自定义构造函数
            //Point p2 = new Point(50, 60);

            // 输出X=10，Y=60
            //p2.Display();

            //ValueTypeAssignment();
            //ValueTypeContainingRefType();

            // 按值传递引用类型
            //Console.WriteLine("***** Pssing Person object by value *****");
            //Person fred = new Person("Fred", 12);
            //Console.WriteLine("\nBefore by value call, Person is:");
            //fred.Display();

            //SendPersonByValue(fred);
            //Console.WriteLine("\nAfter by value call, Person is:");
            //fred.Display();

            //Person mel = new Person("Mel", 23);
            //Console.WriteLine("Before by value call, Person is:");
            //mel.Display();

            //SendAPersonByReference(ref mel);
            //Console.WriteLine("After by ref call, Person is:");
            //mel.Display();
            #endregion

            // 编译器错误
            // 值类型不能设置为null
            //bool myBool = null;
            //int myInt = null;

            // 没错！字符串是引用类型
            //string myString = null;

            Console.WriteLine("***** Fun with Nullable Data *****\n");
            DatabaseReader dr = new DatabaseReader();

            //  从“数据库”获取int
            //int? i = dr.GetIntFromDatabase();
            //if (i.HasValue)
            //    Console.WriteLine("Value of 'i' is {0}", i.Value);
            //else
            //    Console.WriteLine("Value of 'i' is undefined.");

            //  从“数据库”获取bool
            //bool? b = dr.GetBoolFromDatabase();
            //if (b.HasValue)
            //    Console.WriteLine("Value of 'b' is {0}", b.Value);
            //else
            //    Console.WriteLine("Value of 'b' is undefined.");

            // 从GetIntFromDatabase()返回值为null时，将本地变量赋值为100
            int myData = dr.GetIntFromDatabase() ?? 100;
            Console.WriteLine("Value of myData: {0}", myData);

            // 使用？：？？语法的长阪本
            int? moreData = dr.GetIntFromDatabase();
            if (!moreData.HasValue)
                moreData = 100;
            Console.WriteLine("Value of moreData: {0}", moreData);

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
        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }

        // 返回多个输出参数
        static void FillTheseValues(out int a, out string b, out bool c)
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
        public static void SwapStrings(ref string s1, ref string s2)
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

            for (int i = 0; i < values.Length; i++)
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
        static int Add(int x, int y) { return x + y; }

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
            string[] stringArray = new string[] { "one", "two", "three" };
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

            foreach (object obj in myObjects)
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
            for (int i = 0; i < 6; i++)
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
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 数组作为参数（和返回值）
        static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
        }

        static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray" };
            return theStrings;
        }

        static void PassAndReceiveArrays()
        {
            Console.WriteLine("=> Arrays as params and return values.");
            // 传递数组作为参数
            int[] ages = { 10, 22, 23, 0 };
            PrintArray(ages);

            // 获取数组作为返回值
            string[] strs = GetStringArray();
            foreach (string s in strs)
                Console.WriteLine(s);

            Console.WriteLine();
        }

        // System.Array基类
        static void SystemArrayFunctionality()
        {
            Console.WriteLine("=> Working with System.Array.");
            // 初始化起始项
            string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sistera of Mercy" };

            // 按声明的次序输出名字
            Console.WriteLine("-> Here is the array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                // 输出一个名字
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");

            // 反转它们
            Array.Reverse(gothicBands);
            Console.WriteLine("-> The reversed array");
            // 输出它们
            for (int i = 0; i < gothicBands.Length; i++)
            {
                // 输出一个名字
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");

            // 清除除了最后成员之外的所有项
            Console.WriteLine("-> Cleared out all but one...");
            Array.Clear(gothicBands, 1, 2);
            for (int i = 0; i < gothicBands.Length; i++)
            {
                // 输出一个名字
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine();
        }
        #endregion

        #region 枚举
        // 自定义枚举
        //enum EmpType
        //{
        //    //Default
        //    //Manager,      // = 0
        //    //Grunt,        // = 1
        //    //Contractor,   // = 2
        //    //VicePresident // = 3

        //    // 从102开始
        //    //Manager = 102,
        //    //Grunt,        // = 103
        //    //Contractor,   // = 104
        //    //VicePresident // = 105

        //    // 枚举的元素不需要是连续的
        //    Manager = 10,
        //    Grunt = 1,
        //    Contractor = 100,
        //    VicePresident = 9
        //}

        // 这次，EmpType对应实际的byte
        enum EmpType : byte
        {
            Manager = 10,
            Grunt = 1,
            Contractor = 100,
            VicePresident = 9
        }

        // 编译器错误！999所占的空间大于一个字节
        //enum EmpType : byte
        //{
        //    Manager = 10,
        //    Grunt = 1,
        //    Contractor = 100,
        //    VicePresident = 999
        //}
        
        // 声明枚举变量
        static void AskForBonus(EmpType e)
        {
            switch (e) 
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD, Siri!");
                    break;
            }
        }

        static void ThisMethodWillNotCompile()
        {
            // 错误！SalesManager不在EmpType枚举中
            //EmpType emp = EmpType.SalesManager;

            // 错误！忘记设定 Grunt值为EmpType美剧
            //emp = Grunt;
        }

        // 这个方法会输出枚举的细节
        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("=> Information about {0}", e.GetType().Name);

            Console.WriteLine("Underlying storage type: {0}",
                Enum.GetUnderlyingType(e.GetType()));

            // 获取传入参数的名称/值对
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members.", enumData.Length);
            // 现在使用D格式标志显示字符串名和关联的值
            for(int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, value: {0:D}", 
                    enumData.GetValue(i));
            }
            Console.WriteLine();
        }
        #endregion

        #region 结构体
        struct Point
        {
            // 结构的字段
            public int X;
            public int Y;

            // 自定义的构造函数
            public Point(int XPos, int YPos)
            {
                X = XPos;
                Y = YPos;
            }

            // 将(X, Y)坐标增加1
            public void Increment()
            {
                X++;
                Y++;
            }

            // 将(X, Y)坐标减去1
            public void Decrement()
            {
                X--;
                Y--;
            }

            // 显示当前坐标
            public void Display()
            {
                Console.WriteLine("X = {0}, Y = {1}", X, Y);
            }
        }

        // 本地变量在方法返回时弹出栈
        static void LocalValueType()
        {
            // “int”其实是System.Int32结构
            int i = 0;

            // Point是结构类型
            Point p = new Point();
        } // "i" 和 "p" 在这里弹出栈
        #endregion

        #region 值类型与引用类型
        // 为两个内建的值类型赋值会在栈上产生两个独立变量
        static void ValueTypeAssignment()
        {
            Console.WriteLine("Assigning value types\n");

            Point p1 = new Point(10, 10);
            Point p2 = p1;

            // 输出两个Pointref
            p1.Display();
            p2.Display();

            // 改变p1.x并且再次输出
            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();
        }

        // 包含引用类型的值类型
        static void ValueTypeContainingRefType()
        {
            // 创建第一个Rctangle
            Console.WriteLine("-> Creating r1");
            Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);

            // 现在将一个新的Rectangle赋值给r1
            Console.WriteLine("-> Assigning r2 to r1");
            Rectangle r2 = r1;

            // 改变r2的值
            Console.WriteLine("-> Changing values to r2");
            r2.rectInfo.infoString = "This is new info!";
            r2.rectBottom = 4444;

            // 输出两个rectangle的值
            r1.Display();
            r2.Display();
        }

        static void SendPersonByValue(Person p)
        {
            // 改变‘p’的年龄
            p.personAge = 99;

            // 调用者能看到这个重新赋值吗
            p = new Person("Nikki", 99);
        }

        static void SendAPersonByReference(ref Person p)
        {
            // 改变‘p‘的一些数据
            p.personAge = 555;

            // 'p’现在指向了堆上的一个新对象
            p = new Person("Nikki", 999);
        }
        #endregion

        #region 空类型
        static void LocalNullableVariables()
        {
            // 定义一些布局可空类型
            int? nullableInt = 10;
            double? nullableDouble = 3.14;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrayOfNullableInts = new int?[10];

            // 错误！字符串是引用类型
            //string? s = "oops";
        }

        static void LocalNullableVariablesUsingNullable()
        {
            // 使用Nullable<T>定义一些局部可空变量
            Nullable<int> nullableInt = 10;
            Nullable<double> nullableDouble = 3.14;
            Nullable<bool> nullableBool = null;
            Nullable<Char> nullableChar = 'a';
            Nullable<int>[] arrayOfNullableInts = new int?[10];
        }
        #endregion
    }

    struct Rectangle
    {
        // Rectangle结构包含一个引用类型成员
        public ShapeInfo rectInfo;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       

        public int rectTop, rectLeft, rectBottom, rectRight;

        public Rectangle(string info,int top,int left,int bottom,int right)
        {
            rectInfo = new ShapeInfo(info);
            rectTop = top;
            rectBottom = bottom;
            rectLeft = left;
            rectRight = right;  
        } 

        public void Display()
        {
            Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, Left = {3}, Right = {4}",
                rectInfo.infoString, rectTop, rectBottom, rectLeft, rectRight);
        }
    }

    class ShapeInfo 
    {
        public string infoString;
        public ShapeInfo(string info)
        {
            infoString = info;
        }
    }

    class Person
    {
        public string personName;
        public int personAge;

        // 构造函数
        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }

        public Person() { }

        public void Display()
        {
            Console.WriteLine("Name: {0}, Age: {1}", personName, personAge);
        }
    }

    class DatabaseReader
    {
        // 可控数据字段
        public int? numericValue = null;
        public bool? boolValue = true;

        // 注意可空返回类型
        public int? GetIntFromDatabase()
        {
            return numericValue;
        }

        // 注意可空返回类型
        public bool? GetBoolFromDatabase()
        {
            return boolValue;
        }
    }
}
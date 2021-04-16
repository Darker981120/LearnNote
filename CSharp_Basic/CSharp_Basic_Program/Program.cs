using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// BigInteger在这里面引用
using System.Numerics;
// StringBuilder在这里引用
using System.Text;

namespace CSharp_Basic_Program
{
    class Program
    {
        // 主函数
        // ===================================================================
        static void Main(string[] args)
        {
            // 显示信息
            //Console.WriteLine("Hello World!");

            //NewingDataTypes();
            //ObjectFunctionality();
            //CharFunctionality();
            //ParseFromStrings();
            //UseDatasAndTimes();
            //UseBigInteger();
            //BasicStringFunctionality();
            //StringConcatenation();
            //EscapeChars();
            //VerbatimStrings();
            //StringEquality();
            //StringAreImmutable();
            //FunWithStringBuilder();
            //TypeConversions();
            //ProcessBytes();
            //NarrowWithConvert();
            //DeclareExplicitVars();
            //QueryOverInts();
            ForAndEachLoop();

            // 按下 Enter 键以后关闭
            Console.ReadLine();
        }

        // 内建数据类型的新操作符
        // ===================================================================
        static void NewingDataTypes()
        {
            Console.WriteLine("=> Using new to create variables: ");
            bool b = new bool();          // 设置为false
            int i = new int();            // 设置为0
            double d = new double();      // 设置为0
            DateTime dt = new DateTime(); // 设置为0001/1/1 0:00:00
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();
        }

        // 数据类型的层次结构
        // ===================================================================
        static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality: ");

            // C# int是System.Int32的简化，它继承了System.Object的如下成员
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Squals(23) = {0}", 12.Equals(23));
            Console.WriteLine("l2.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());

            // System.Boolean
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
            Console.WriteLine();
        }

        // System.Char
        // ===================================================================
        static void CharFunctionality()
        {
            Console.WriteLine("=> Char Type Functionality: ");

            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsFunctuation('?'): {0}", char.IsPunctuation('?'));     
            Console.WriteLine();
        }

        // 从字符串数据中解析数值
        // ===================================================================
        static void ParseFromStrings()
        {
            Console.WriteLine("=> Data type parsing: ");

            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);
            double d = double.Parse("99.884");
            Console.WriteLine("Value of d: {0}", d);
            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);
            char c = Char.Parse("w");
            Console.WriteLine("Value of c: {0}", c);   
            Console.WriteLine();
        }

        // System.DataTime 和 System.TimeSpan
        // ===================================================================
        static void UseDatasAndTimes()
        {
            Console.WriteLine("=> Date and Times: ");

            // 这个构造函数接受年、月、日
            DateTime dt = new DateTime(2021, 4, 15);

            // 它是一个月中的哪一天
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

            // 月份现在是12月
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight saving: {0}", dt.IsDaylightSavingTime());

            // 构造函数接受小时、分钟和秒
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);

            // 从当前TimeSpan减去15分钟并且输出结果
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
        }

        // System.Numerics
        // ===================================================================
        static void UseBigInteger()
        {
            Console.WriteLine("=> Use BigInteger: ");
            BigInteger biggy = BigInteger.Parse("99999999999999999999999999999999999999999999999999999");
            Console.WriteLine("Value of biggy is {0}", biggy);
            Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
            Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
            BigInteger reallyBig = BigInteger.Multiply(biggy,
                BigInteger.Parse("888888888888888888888888888888888888888"));
            Console.WriteLine("Value of reallyBig is {0}", reallyBig);
            BigInteger reallyBig2 = biggy * reallyBig;
            Console.WriteLine("Value of reallyBig2 is {0}", reallyBig2);
        }

        //  基本的字符串操作
        // ===================================================================
        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality: ");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y ?: {0}", firstName.Contains("y"));
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));

            Console.WriteLine();
        }

        //  字符串拼接
        // ===================================================================
        static void StringConcatenation()
        {
            Console.WriteLine("=> String concatenation: ");
            string s1 = "Programming the ";
            string s2 = "psychoDrill (PTP) ";
            string s3 = s1 + s2;

            // 使用System.concat()方法
            string s4 = String.Concat(s1, s2);

            Console.WriteLine(s3);
            Console.WriteLine(s4);

            Console.WriteLine();
        }

        //  转义字符
        // ===================================================================
        static void EscapeChars()
        {
            Console.WriteLine("=> Escape characters:\a");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a";
            Console.WriteLine(strWithTabs);

            Console.WriteLine("Everyone loves \"Hello world\"\a ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");

            // 添加四个空格发出一声蜂鸣
            Console.WriteLine("All finished.\n\n\n\a");
            Console.WriteLine();
        }

        // 逐字字符串
        // ===================================================================
        static void VerbatimStrings()
        {
            // 下面的字符串被逐字输出，所有的转义字符都被显示出来了
            Console.WriteLine(@"C:\MyApp\bin\Debug");

            // 使用逐字字符串，空格被保留了
            string myLongString = @"This is a very
                 very
                       very
                              long string";
            Console.WriteLine(myLongString);

            // 可以通过重复标记""向一个字面量字符串插入一个双引号
            Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets"" ");
        }

        // 字符串和相等性
        // ===================================================================
        static void StringEquality()
        {
            Console.WriteLine("=> String equality: ");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            // 测试这些字符串的相等性
            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
            Console.WriteLine();
        }

        // 字符串是不可变的
        // ===================================================================
        static void StringAreImmutable()
        {
            // 设置初始字符串值
            string s1 = "This is my string.";
            Console.WriteLine("s1 = {0}", s1);

            // 大写的s1
            string upperString = s1.ToUpper();
            Console.WriteLine("upperString = {0}", upperString);

            // 不！s1还是同样的格式
            Console.WriteLine("s1 = {0}", s1);
        }

        // System.Text.StringBuilder类型
        // ===================================================================
        static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder: ");
            //StringBuilder sb = new StringBuilder("**** Fantastic Games ****");

            // 创建一个初始大小为256的StringBuilder
            StringBuilder sb = new StringBuilder("**** Fantastic Games ****", 256);

            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Beyond Good and Evil");
            sb.AppendLine("Deus Ex 2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());

            sb.Replace("2", "Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
            Console.WriteLine();
        }

        // 数据类型转换
        // ===================================================================
        static void TypeConversions()
        {
            Console.WriteLine("***** Fun with type conversions *****");

            // 把两个short数据相加并输出结果
            // 隐式宽化
            //short numb1 = 9, numb2 = 10;
            //Console.WriteLine("{0} + {1} = {2}", numb1, numb2, Add(numb1, numb2));

            // 窄化
            // 下面会有编辑器报错
            short numb1 = 30000, numb2 = 30000;
            //short answer = Add(numb1, numb2);
            //Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);

            // 另一个编译器错误
            //byte myByte = 0;
            //int myInt = 200;
            //myByte = myInt;
            //Console.WriteLine("Value of myByte: {0}", myByte);

            // 显示强制转化 int 为 short（平且允许数据丢失）
            short answer = (short)Add(numb1, numb2);

            Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);

            NarrowingAttempt();

            Console.WriteLine();
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 200;

            // 显示强制转化 int 为 byte（没有数据丢失）
            myByte = (byte)myInt;
            Console.WriteLine("Value of myByte: {0}", myByte);
        }

        // 捕捉窄化数据转换中的错误
        // ===================================================================
        static void ProcessBytes()
        {
            byte b1 = 100;
            byte b2 = 250;

            // sum应该保存值350。然而，我们得到了值94
            //byte sum = (byte)Add(b1, b2);
            //Console.WriteLine("sum = {0}", sum);

            // 这次告诉编译器增加CIL代码，如果发生上溢或下溢就抛出异常
            try
            {           
                // 强制溢出检测
                //checked
                //{
                //    byte sum = checked((byte)Add(b1, b2));
                //    Console.WriteLine("sum = {0}", sum);
                //}

                // 假设启用了checked，这段代码不会触发运行时异常
                unchecked
                {
                    byte sum = checked((byte)Add(b1, b2));
                    Console.WriteLine("sum = {0}", sum);
                }
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // System.Convert
        // ===================================================================
        static void NarrowWithConvert()
        {
            byte myByte = 0;
            int myInt = 200;
            myByte = Convert.ToByte(myInt);
            Console.WriteLine("Value of myByte: {0}", myByte);
        }

        // 隐式类型本地变量
        // ===================================================================
        static void DeclareExplicitVars()
        {
            // 显式类型本地变量的声明如下
            // dataType variableName = initialValue;
            //int myInt = 0;
            //bool myBool = true;
            //string myString = "Time, marches on ...";

            // 隐形类型本地变量的声明如下
            // var variableName = initialValue;
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on ...";

            // 输出实际类型
            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);
        }

        // 隐形类型变量的限制
        // ===================================================================
        static void VarRestrictions()
        {
            // 错误！必须分配值
            //var myData;

            // 错误！必须在声明时分配值
            //var myInt;
            //myInt = 0;

            // 错误！不能分配null作为初始值
            //var myObj = null;

            // 没问题，SportsCar是一个引用类型
            var myCar = new SportsCar();
            myCar = null;

            // 同样没问题
            var myInt = 0;
            var anotherInt = myInt;

            string myString = "Wake up!";
            var myData = myString;

            // 不能定义可空的隐式变量，因为隐式变量的初始值不能设置为null
            //var? nope = new SportsCar();
            //var? stillNo = 12;
            //var? noWay = null;
        }

        static int GetAnInt()
        {
            var retVal = 9;
            return retVal;
        }

        // 隐式类型数据是强类型数据
        // ===================================================================
        static void ImplicitTypingIsStrongTyping()
        {
            // 编译器知道“s”是一个System.String
            var s = "This variable can only hold string data!";
            s = "This is fine...";

            // 可以调用实际类型的所有成员
            string upper = s.ToUpper();

            // 错误！不能将数值数据分配给字符串
            //s = 44;
        }

        // 隐式类型本地变量的用途
        // ===================================================================
        static void QueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            // LINQ查询
            var subset = from i in numbers
                         where i < 10
                         select i;
            Console.Write("Values in subset: ");
            foreach(var i in subset)
            {
                Console.Write("{0}", i);
            }
            Console.WriteLine();

            // en......subset是什么类型呢
            Console.WriteLine("subset is a: {0}", subset.GetType().Name);
            Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
        }

        // 基本循环
        // ===================================================================
        static void ForAndEachLoop()
        {
            // 注意！“i”只在for循环域内可见
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Number is: {0}", i);
            }
            // “i”在这里不可见

            // 使用foreach迭代数组项
            string[] carTypes = { "Ford", "BWM", "Yugo", "Honda" };
            foreach(string c in carTypes)
            {
                Console.WriteLine(c);
            }

            int[] myInts = { 10, 20, 30, 40 };
            foreach(int i in myInts)
            {
                Console.WriteLine(i);
            }
        }

        // 在foreach结构中使用var
        // ===================================================================
        static void VarInForeachLoop()
        {
            int[] myInts = { 10, 20, 30, 40 };

            // 在标准foreach循环中使用“var”
            foreach(var item in myInts)
            {
                Console.WriteLine("Item value: {0}", item);
            }
        }
    }

    class ThisWillNeverCompile
    {
        // 错误！var不能用于字段数据
        //private var myInt = 10;

        // 错误！var不能用于返回值或参数类型
        //public var MyMethod(var x, var y) { }
    }

    class SportsCar { }
}

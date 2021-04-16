# C#基础

## Main()方法
```ruby
class Program
{
    static void Main(string[] args)
    {
        // 显示信息
        Console.WriteLine("Hello World!");
        
        // 按下 Enter 键以后关闭
        Console.ReadLine();
    }
}
```
每一个可执行的C#应用程序必须包含一个定义了Main()方法的类，这个方法来表示应用程序的入口点。
* Main()的签名具有 **static** 关键字。
* C#是一种 **区分大小写** 的程序设计语言。
* **string[] args** 字符串数组，这个参数可以包含任意数量的命令行输入参数。
* **void** 返回值，也就是说我们不需要在退出方法域之前使用 **return** 关键字来显示定义一个返回值。
* **System.Console.WriteLine()** 能够将一个文本字符串和回车符输送到标准输出端。
*  **System.Console.ReadLine()** 保证命令提示符在调试的会话期间保持可见，直到按下 Enter 键。
* Main() 默认定义为 **public**（共有的）。

怎么样构造 Main() 的两个问题：
1. 当 Main() 完成并且程序终止时，是否要想系统返回一个值？
	* 如果是，需要返回一个 int 数据类型而不是 void。
2. 是否需要处理用户提供的命令行参数？
	* 如果是，他们将被保存string数组中。

## System.Console 类
Console类封装了基于控制台应用程序的输入、输出和错误流操作。

## 格式化数值数据
.NET 数值格式字符
string.Format()

## 系统数据类型
### 内建数据类型
默认情况下，浮点数被当作double类型。
每一个数值类型都对应System命名空间中的一个**结构**。
**结构**是分配在**栈**上的**值类型**。
string和object是**引用类型**，也就是说变量是分配在托管堆上的。

## 变量声明和初始化
 声明本地变量
 ```
 <数据类型> <变量名>;
 ```
 如果在分配初始化之前使用本地变量，会收到一个编译器错误。
 因此，声明使为局部数据赋一个初始值
 声明并初始化变量。
 ```
 <数据类型> <变量名> = <初始值>;
 ```

## 内建数据类型的新操作符
所有的内建数据类型都支持**默认构造函数**。
使用**new**关键字来创建变量，它将变量自动设置为其默认值。
```ruby
static void NewingDataTypes()
{
    Console.WriteLine("=> Using new to create variables: ");
    bool b = new bool();          // 设置为false
    int i = new int();            // 设置为0
    double d = new double();      // 设置为0
    DateTime dt = new DateTime(); // 设置为1/1/0001 12:00:00 AM
    Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
    Console.WriteLine();
}
```

## 数据类型的层次结构
.NET的基本数据类型都有一个类层次结构。
所有这些类型都派生自**System.Object**。
很多数值类型都派生自**System.ValueType**。
```ruby
static void ObjectFunctionality()
{
    Console.WriteLine("=> System.Object Functionality: ");

    // C# int是System.Int32的简化，它继承了System.Object的如下成员
    Console.WirteLine("12.GetHashCode() = {0}", 12.GetHashCode());
    Console.WriteLine("12.Squals(23) = {0}", 12.Squals(23));
    Console.WriteLine("l2.ToString() = {0}', 12.ToString());
    Console.WriteLine("12.GetType() = {0}", 12.GetType());
    Console.WriteLine();
}
```

## 数值数据类型的成员
.Net的数值类型支持**MaxValue**和**MinValue**属性。
```ruby
static void DataTypeFunctionality()
{
    Console.WriteLine("=> Data Type Functionality: ");

    Console.WriteLine("Max of int: {0}", int.MaxValue);
    Console.WriteLine("Min of int: {0}", int.MinValue);
    Console.WriteLine("Max of double: {0}", double.MaxValue);
    Console.WriteLine("Min of double: {0}", double.MinValue);
    Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
    Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
    Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
    Console.WriteLine();
}
```

## System.Boolean
C#的bool类型的值只能来自集合（true|false）。
所以，应该明确System.Boolean不支持 MinValue/MaxValue 属性集合，但是支持 **TrueString/FalseString**属性集合。
```ruby
Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
```

## System.Char的成员
C#的文本数据是由string和char关键字表示的，它们是**System.String**和**System.Char**的简化符号，二者都是基于Unicode的。
```ruby
static void CharFunctionality()
{
    Console.WriteLine("=> Char Type Functionality: ");
    
    char myChar = 'a';
    Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
    Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
    Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace('Hello There', 5));
    Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace('Hello There', 6));
    Console.WriteLine("char.IsFunctuation('?'): {0}", char.IsFunctuation('?'));
    Console.WriteLine();
}
```

## 从字符串数据中解析数值
```ruby
static void ParseFromStrings()
{
    Console.WriteLine("=> Data type parsing: ");
    
    bool b = bool.Parse("True");
    Console.WriteLine("Value of b: (0)", b);
    double d = double.Parse("99.884");
    Console.WriteLine("Value of d: (0)", d);
    int i = int.Parse("8");
    Console.WriteLine("Value of i: (0)", i);
    char c = Char.Parse("w");
    Console.WriteLine(“Value of c: {0}", c);
    Console.WriteLine();
}
```

## System.DataTime 和 System.TimeSpan
DataTime 类型包含了表示某个日期（月，日，年）的数据，及时间值，可以使用指定的成员以各种形式将他们格式化。
TimeSpan 结构允许你方便地使用各个成员定义和转换时间单位。
```ruby
static void UseDatasAndTimes()
{
    Console.WriteLine("=> Date and Times: ");

    // 这个构造函数接受年、月、日
    DateTime dt = new DataTime(2021, 4, 15);

    // 它是一个月中的哪一天
    Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

    // 月份现在是12月
    dt = dt.Addmouths(2)
    Console.WriteLine("Daylight saving: {0}", dt.IsDayLightSavingTime());

    // 构造函数接受小时、分钟和秒
    TimeSpan ts = new TimeSpan(4, 30, 0);
    Console.WriteLine(ts);

    // 从当前TimeSpan减去15分钟并且输出结果
    Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
}
```

## System.Numerics命名空间
```ruby
// BigInteger在这里面
using System.Numerics;

static void UseBigInteger()
{
    Console.WriteLine("=> Use BigInteger: ");
    BigInteger biggy = BigInteger.Parse("99999999999999999999999999999999999999999999999999999");
    Console.WriteLine("Value of biggy is {0}", biggy);
    Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
    Console.Writeline("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
    BigInteger reallyBig = BigInteger.Multiply(biggy,
        BigInteger.Parse("888888888888888888888888888888888888888"));
    Console.WriteLine("Value of reallyBig is {0}", reallyBig);
    BigInteger reallyBig2 = biggy * reallyBig;
    Console.WriteLine("Value of reallyBig2 is {0}", reallyBig2);
}
``` 
 
## 使用字符串数据

### 基本的字符串操作
```ruby
static void BasicStringFunctionality()
{
    Console.WriteLine("=> Basic String functionality: ");
    string firstName = "Freddy";
    Console.WriteLine("Value of firstName: {0}", firstName);
    Console.WriteLine("firstName has {0} characters.", firstName.Length);
    Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper);
}
```


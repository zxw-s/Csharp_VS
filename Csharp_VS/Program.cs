using System;

// 定义结构体
struct Student
{
    public int id;
    public string name;
    public double score;
}

class Program
{
    // ref：引用参数，可以修改外部传入的结构体
    static void SetScore(ref Student s, double newSc)
    {
        s.score = newSc;
    }

    // 求数组平均值
    static double GetAverage(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return (double)sum / arr.Length;
    }

    static void Main(string[] args)
    {
        int[] nums = { 75, 88, 91, 66 };
        Student stu;
        stu.id = 2001;
        stu.name = "李四";
        stu.score = 79.5;

        Console.WriteLine("=== Visual Studio C# 测试程序 ===");

        Console.Write("数组元素：");
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i] + " ");
        }
        double avg = GetAverage(nums);
        Console.WriteLine($"\n数组平均值：{avg:F2}");

        Console.WriteLine($"\n修改前学生：id={stu.id} 姓名={stu.name} 分数={stu.score:F1}");
        SetScore(ref stu, 93.0);
        Console.WriteLine($"ref修改后分数：{stu.score:F1}");

        Console.Write("\n请输入一个整数：");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"你输入的数字：{num}");

        Console.WriteLine("\n按任意键退出...");
        Console.ReadKey();
    }
}
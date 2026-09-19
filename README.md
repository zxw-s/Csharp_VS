> README.md 模板（C#项目，GitHub）
> 
> 适配 Visual Studio / Rider / VSCode，控制台、WinForm、WPF、ASP.NET Core 通用

# 项目名称

> 一句话简介：本项目实现XX功能

## 项目简介

简单描述项目用途、技术栈。
示例：基于C#的控制台学生管理系统，实现学生信息的增删改查。

## 环境要求

- .NET SDK：>= 6.0 / 7.0 / 8.0（自行修改）
- IDE：Visual Studio 2022 / Rider / VSCode
- Git（版本控制）

## 项目目录结构

```plaintext
ProjectName/
├── ProjectName.csproj # C#项目配置文件
├── Program.cs # 程序入口
├── Models/ # 实体类
├── Services/ # 业务逻辑
├── .gitignore # Git忽略配置
└── README.md # 项目说明文档
```

## 快速开始

### 1. 克隆仓库

## 快速开始

### 1. 克隆仓库

```bash
git clone https://github.com/你的用户名/仓库名.git
cd ProjectName
```

### 2. 还原项目依赖

```bash
dotnet restore
```

### 3. 编译项目

```bash
dotnet build
```

### 4. 运行程序

```bash
dotnet run
```

## 功能列表

- 已完成功能1
- 已完成功能2
- 待开发功能3

## 开发说明

1. 使用 Visual Studio：直接打开 `.sln` 解决方案文件
2. 使用 VSCode：安装 C# Dev Kit 插件，在项目目录打开
3. 新增NuGet包后，`dotnet restore` 会自动管理依赖，无需手动维护依赖文本
4. Git提交规范：
   - `feat:` 新增功能
   - `fix:` 修复bug
   - `docs:` 修改文档
   - `refactor:` 代码重构
   - `style:` 代码格式调整

## 常见问题

- Q：提示找不到 .NET SDK？
  A：安装对应版本.NET SDK，配置环境变量，终端输入 `dotnet --version` 验证。
- Q：中文控制台乱码？
  A：在代码开头设置控制台编码 `Console.OutputEncoding = System.Text.Encoding.UTF8;`

## 许可证

MIT

# C# 控制台演示代码（适合熟悉 Visual Studio）

文件名：`Program.cs` 功能：变量、数组、方法、引用参数(ref)、结构体，体验 VS 的编辑、运行、断点调试。

> C#没有C语言的指针，使用 `ref` 实现修改外部变量；结构体`struct`，控制台程序。

```csharp
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
```

运行输出：

```plaintext
=== Visual Studio C# 测试程序 ===
数组元素：75 88 91 66
数组平均值：80.00

修改前学生：id=2001 姓名=李四 分数=79.5
ref修改后分数：93.0

请输入一个整数：100
你输入的数字：100

按任意键退出...
```

## Visual Studio C# 操作步骤

1. **新建项目** 创建新项目 → 选择 **控制台应用(.NET Framework / .NET)** → 下一步，创建。
   把默认 `Program.cs` 的全部内容替换为上面代码。

2. **运行**
- `F5`：启动调试

- `Ctrl+F5`：不调试直接运行，控制台不会闪退
3. **断点调试（核心）**

代码行号左侧灰色处点击，出现**红色圆点**设置断点。
推荐断点：

- `double avg = GetAverage(nums);`

- `SetScore(ref stu, 93.0);`

F5启动调试

### VS C#调试快捷键

| 快捷键       | 功能          |
| --------- | ----------- |
| F10       | 逐过程（不进入方法）  |
| F11       | 逐语句（跳进方法内部） |
| Shift+F11 | 跳出当前方法      |
| F5        | 继续运行到下一个断点  |
| Ctrl+F10  | 运行到光标处      |

调试窗口：

- **自动/局部变量窗口**：自动展开数组、结构体，可以看到成员的值。
- **监视窗口**：输入表达式：`stu`、`nums[1]`，查看数据。
- **调用堆栈**：查看当前在哪个方法（Main / GetAverage / SetScore）。

> 练习：F11跳进 `SetScore`，观察 `ref` 参数直接修改 Main 里的 stu 结构体。

## C# 和 C语言简单对照

| C语言        | C#                                   |
| ---------- | ------------------------------------ |
| `printf`   | `Console.WriteLine()`                |
| `scanf`    | `Console.ReadLine()` + `int.Parse()` |
| 指针`*`、`&`  | `ref` / `out` 引用参数                   |
| struct 结构体 | struct 结构体                           |
| 函数         | 方法 static                            |
| 数组`arr[]`  | 数组`arr[]`，自带`.Length`获取长度            |

## 常见坑

1. 结构体是**值类型**，不传`ref`，方法内只是拷贝副本，外部不会改变。
2. `Console.ReadLine()`读取字符串；输入数字必须手动`int.Parse()`转换。
3. `Console.ReadKey()`用来暂停控制台，防止窗口闪退。

# C# 简易学生管理控制台程序

功能：菜单交互，添加、显示、修改分数、删除学生、计算平均分；结构体（值类型），`ref`引用参数，VS可断点调试。

```csharp
using System;

// 学生结构体：值类型
struct Student
{
    public int id;
    public string name;
    public double score;
}

class Program
{
    // 最大学生数量
    const int MaxCount = 6;

    // 添加学生
    static void AddStudent(Student[] stuArr, ref int count)
    {
        if (count >= MaxCount)
        {
            Console.WriteLine("学生已满，无法添加！");
            return;
        }
        Student s;
        Console.Write("请输入id 姓名 分数：");
        string[] input = Console.ReadLine().Split();
        s.id = int.Parse(input[0]);
        s.name = input[1];
        s.score = double.Parse(input[2]);

        stuArr[count] = s;
        count++;
    }

    // 打印全部学生
    static void ShowAll(Student[] stuArr, int count)
    {
        if (count <= 0)
        {
            Console.WriteLine("暂无学生数据");
            return;
        }
        Console.WriteLine("\n====学生列表====");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"id:{stuArr[i].id} 姓名:{stuArr[i].name} 分数:{stuArr[i].score:F1}");
        }
    }

    // ref 修改结构体分数
    static void ModifyScore(ref Student s, double newScore)
    {
        s.score = newScore;
    }

    // 根据id删除学生
    static bool DeleteById(Student[] stuArr, ref int count, int delId)
    {
        int pos = -1;
        for (int i = 0; i < count; i++)
        {
            if (stuArr[i].id == delId)
            {
                pos = i;
                break;
            }
        }
        if (pos == -1)
            return false;

        // 元素向前覆盖
        for (int i = pos; i < count - 1; i++)
        {
            stuArr[i] = stuArr[i + 1];
        }
        count--;
        return true;
    }

    // 计算平均分
    static double GetAvg(Student[] stuArr, int count)
    {
        if (count <= 0) return 0;
        double sum = 0;
        for (int i = 0; i < count; i++)
        {
            sum += stuArr[i].score;
        }
        return sum / count;
    }

    static void Main(string[] args)
    {
        Student[] stuArray = new Student[MaxCount];
        int stuCount = 0;
        int op;

        while (true)
        {
            Console.WriteLine("\n====菜单====");
            Console.WriteLine("1.添加学生   2.显示全部   3.修改分数   4.删除学生   5.查看平均分   0.退出");
            Console.Write("请选择操作：");
            op = int.Parse(Console.ReadLine());

            if (op == 0)
            {
                break;
            }
            else if (op == 1)
            {
                AddStudent(stuArray, ref stuCount);
            }
            else if (op == 2)
            {
                ShowAll(stuArray, stuCount);
            }
            else if (op == 3)
            {
                Console.Write("输入要修改的id 和新分数：");
                string[] parts = Console.ReadLine().Split();
                int targetId = int.Parse(parts[0]);
                double newSc = double.Parse(parts[1]);

                int findIndex = -1;
                for (int i = 0; i < stuCount; i++)
                {
                    if (stuArray[i].id == targetId)
                    {
                        findIndex = i;
                        break;
                    }
                }
                if (findIndex != -1)
                {
                    ModifyScore(ref stuArray[findIndex], newSc);
                    Console.WriteLine("修改成功");
                }
                else
                {
                    Console.WriteLine("未找到该学生");
                }
            }
            else if (op == 4)
            {
                Console.Write("输入要删除学生id：");
                int delId = int.Parse(Console.ReadLine());
                bool ok = DeleteById(stuArray, ref stuCount, delId);
                Console.WriteLine(ok ? "删除成功" : "未找到学生");
            }
            else if (op == 5)
            {
                double avg = GetAvg(stuArray, stuCount);
                Console.WriteLine($"全体平均分：{avg:F2}");
            }
            else
            {
                Console.WriteLine("无效选项");
            }
        }
        Console.WriteLine("程序结束，按任意键退出...");
        Console.ReadKey();
    }
}
```

## 运行示例

```plaintext
====菜单====
1.添加学生   2.显示全部   3.修改分数   4.删除学生   5.查看平均分   0.退出
请选择操作：1
请输入id 姓名 分数：1 小明 88

====菜单====
请选择操作：2

====学生列表====
id:1 姓名:小明 分数:88.0
```

## Visual Studio C#调试练习

1. 设置断点：行号左侧点击出现**红色圆点** 建议断点：
- `AddStudent(stuArray, ref stuCount);`
- `ModifyScore(ref stuArray[findIndex], newSc);`
- `ModifyScore`方法内部第一行
2. 快捷键
- `F5`：启动调试
- `F11`：逐语句，跳进方法内部，观察 `ref` 对结构体的修改
- `F10`：逐过程
- 局部变量窗口：可以展开数组、结构体，查看每一个成员
- 监视窗口可以输入：`stuCount`、`stuArray[0]`

> C#重点概念：

1. `struct` 结构体是**值类型**，不传`ref`传入方法只是拷贝副本，修改不会影响外部。
2. `ref` 相当于C语言指针效果，可以修改原始数据。
3. 数组自带 `.Length` 属性；这里手动维护`stuCount`代表有效数据条数。

## C# ↔ C 对比回顾

| C语言        | C#                         |
| ---------- | -------------------------- |
| struct 结构体 | struct 结构体（值类型）            |
| 指针`* &`    | `ref` / `out`              |
| 函数         | static 方法                  |
| printf     | Console.WriteLine          |
| scanf      | Console.ReadLine()+Parse转换 |
| 数组传参       | 数组传参，自带`.Length`           |

如果你想，我可以对比：C#中 struct（值类型）和 class（引用类型）的小示例，帮你理解值类型与引用类型。

# C#：struct 值类型 vs class 引用类型

> 核心：
> 
> - **struct 结构体：值类型**，赋值时复制一份独立副本，互不影响；想要修改原始数据必须加 `ref`。
> - **class 类：引用类型**，赋值复制的是地址，多个变量指向同一块对象，改一个全部受影响，不需要 `ref`。

## 示例代码

```csharp
using System;

// 值类型：结构体 struct
struct PointStruct
{
    public int x;
    public int y;
}

// 引用类型：类 class
class PointClass
{
    public int x;
    public int y;
}

class Program
{
    // 修改结构体（值类型，不加ref，改的是副本）
    static void ChangeStruct(PointStruct p)
    {
        p.x = 999;
    }

    // 修改结构体，加 ref，操作原始变量
    static void ChangeStructRef(ref PointStruct p)
    {
        p.x = 999;
    }

    // 修改类对象（引用类型，不需要ref）
    static void ChangeClass(PointClass p)
    {
        p.x = 999;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("===== struct 值类型 =====");
        PointStruct s1;
        s1.x = 10;
        s1.y = 20;
        ChangeStruct(s1);
        Console.WriteLine($"不加ref调用后 s1.x = {s1.x}"); // 仍然 10，副本被修改，原始不变

        ChangeStructRef(ref s1);
        Console.WriteLine($"加ref调用后 s1.x = {s1.x}"); // 999，修改原始数据


        Console.WriteLine("\n===== class 引用类型 =====");
        PointClass c1 = new PointClass();
        c1.x = 10;
        c1.y = 20;
        ChangeClass(c1);
        Console.WriteLine($"类调用后 c1.x = {c1.x}"); // 999，直接修改原始对象，不需要ref


        Console.WriteLine("\n=====赋值对比=====");
        // struct 赋值：完整复制一份，两个独立
        PointStruct s2 = s1;
        s2.x = 0;
        Console.WriteLine($"s1.x={s1.x}  s2.x={s2.x}");

        // class 赋值：复制引用（地址），两个变量指向同一个对象
        PointClass c2 = c1;
        c2.x = 0;
        Console.WriteLine($"c1.x={c1.x}  c2.x={c2.x}");


        Console.ReadKey();
    }
}
```

### 输出结果

```plaintext
===== struct 值类型 =====
不加ref调用后 s1.x = 10
加ref调用后 s1.x = 999

===== class 引用类型 =====
类调用后 c1.x = 999

=====赋值对比=====
s1.x=999  s2.x=0
c1.x=0  c2.x=0
```

## 关键总结

1. **struct（值类型）**
- 存储在栈；赋值 = 拷贝完整数据，两个变量互相独立。
- 方法传参默认传副本；想要修改外面原始变量，必须加 `ref`。
- 适合小数据：点、坐标、分数这种简单数据。
2. **class（引用类型）**
- 对象本体存放在堆；变量只存地址。
- 赋值、传参复制的是地址；多个变量指向同一个对象，改一个全部变化。
- 不需要 `ref` 就可以修改对象内部成员。
- 适合复杂数据：学生、用户，业务实体，绝大多数业务用 class。

## 和C语言对照理解

| C语言              | C#              |
| ---------------- | --------------- |
| struct 结构体       | struct（值类型）     |
| 结构体指针 `Point* p` | class（引用类型）     |
| `*p` 修改原始        | 直接修改 class 对象成员 |
| `&`取地址           | `ref`           |

> VS调试练习：
> 断点打在各个方法调用处，F11跳进方法，看局部变量窗口：
> 
> - struct：传入后是一份新副本
> - class：传入的是同一个对象实例

## 思考题

把上面学生管理程序，把 `struct Student` 改成 `class Student`，思考：

1. 修改分数的方法还需要 `ref` 吗？
2. 删除、添加逻辑哪些地方不用改？

如果你需要，我可以给你改造完成的 class 版本学生管理系统。

# C# class版本学生管理系统

把 Student 从 `struct`（值类型）改成 `class`（引用类型）。
✅重点变化：class 是引用类型，方法传对象**不再需要 ref**，方法内直接修改对象成员就会影响外部。

```csharp
using System;

// class：引用类型，对象存堆中
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Score { get; set; }
}

class Program
{
    const int MaxCount = 6;

    // 添加学生
    static void AddStudent(Student[] stuArr, ref int count)
    {
        if (count >= MaxCount)
        {
            Console.WriteLine("学生已满，无法添加！");
            return;
        }
        Student s = new Student();
        Console.Write("请输入id 姓名 分数：");
        string[] input = Console.ReadLine().Split();
        s.Id = int.Parse(input[0]);
        s.Name = input[1];
        s.Score = double.Parse(input[2]);

        stuArr[count] = s;
        count++;
    }

    // 显示全部
    static void ShowAll(Student[] stuArr, int count)
    {
        if (count <= 0)
        {
            Console.WriteLine("暂无学生数据");
            return;
        }
        Console.WriteLine("\n====学生列表====");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"id:{stuArr[i].Id} 姓名:{stuArr[i].Name} 分数:{stuArr[i].Score:F1}");
        }
    }

    // class引用类型：不需要ref，直接修改对象成员
    static void ModifyScore(Student s, double newScore)
    {
        s.Score = newScore;
    }

    // 按id删除
    static bool DeleteById(Student[] stuArr, ref int count, int delId)
    {
        int pos = -1;
        for (int i = 0; i < count; i++)
        {
            if (stuArr[i].Id == delId)
            {
                pos = i;
                break;
            }
        }
        if (pos == -1)
            return false;

        // 数组元素向前覆盖
        for (int i = pos; i < count - 1; i++)
        {
            stuArr[i] = stuArr[i + 1];
        }
        count--;
        return true;
    }

    // 计算平均分
    static double GetAvg(Student[] stuArr, int count)
    {
        if (count <= 0) return 0;
        double sum = 0;
        for (int i = 0; i < count; i++)
        {
            sum += stuArr[i].Score;
        }
        return sum / count;
    }

    static void Main(string[] args)
    {
        Student[] stuArray = new Student[MaxCount];
        int stuCount = 0;
        int op;

        while (true)
        {
            Console.WriteLine("\n====菜单====");
            Console.WriteLine("1.添加学生   2.显示全部   3.修改分数   4.删除学生   5.查看平均分   0.退出");
            Console.Write("请选择操作：");
            op = int.Parse(Console.ReadLine());

            if (op == 0)
            {
                break;
            }
            else if (op == 1)
            {
                AddStudent(stuArray, ref stuCount);
            }
            else if (op == 2)
            {
                ShowAll(stuArray, stuCount);
            }
            else if (op == 3)
            {
                Console.Write("输入要修改的id 和新分数：");
                string[] parts = Console.ReadLine().Split();
                int targetId = int.Parse(parts[0]);
                double newSc = double.Parse(parts[1]);

                int findIndex = -1;
                for (int i = 0; i < stuCount; i++)
                {
                    if (stuArray[i].Id == targetId)
                    {
                        findIndex = i;
                        break;
                    }
                }
                if (findIndex != -1)
                {
                    ModifyScore(stuArray[findIndex], newSc);
                    Console.WriteLine("修改成功");
                }
                else
                {
                    Console.WriteLine("未找到该学生");
                }
            }
            else if (op == 4)
            {
                Console.Write("输入要删除学生id：");
                int delId = int.Parse(Console.ReadLine());
                bool ok = DeleteById(stuArray, ref stuCount, delId);
                Console.WriteLine(ok ? "删除成功" : "未找到学生");
            }
            else if (op == 5)
            {
                double avg = GetAvg(stuArray, stuCount);
                Console.WriteLine($"全体平均分：{avg:F2}");
            }
            else
            {
                Console.WriteLine("无效选项");
            }
        }
        Console.WriteLine("程序结束，按任意键退出...");
        Console.ReadKey();
    }
}
```

## 关键对比：struct vs class

1. **struct（值类型版本）**

```csharp
static void ModifyScore(ref Student s, double newScore)
{
    s.score = newScore;
}
//调用：ModifyScore(ref stuArray[findIndex], newSc);
```

2. **class（引用类型版本）**

```csharp
static void ModifyScore(Student s, double newScore)
{
    s.Score = newScore;
}
//调用：ModifyScore(stuArray[findIndex], newSc);
```

> class 对象传进去的是对象引用，直接修改成员，**不需要ref**。
> 只有修改数组有效数量 `stuCount`（int 值类型）的时候，才继续用 `ref`。

## VS调试练习

1. 断点打在 `ModifyScore(stuArray[findIndex], newSc);`
2. F11跳进方法，观察局部变量窗口：方法内的`s`和main数组里的元素指向**同一个对象**，修改`s.Score`外面一起变化。

## 重要知识点

- `class Student s = new Student();`：new 在堆上创建对象。
- 数组 `Student[] stuArray = new Student[6];`：数组存放的是对象引用，不是对象本身。
- 删除逻辑不变：数组元素向前覆盖，`stuCount--`。

# 和C语言类比记忆

- C# `class` ≈ C语言结构体指针
- C# `struct` ≈ C语言原生结构体（值拷贝）
- C# `ref` ≈ C语言 `&`取地址

如果你想继续，我可以简单介绍：C#中 List 泛型集合，代替固定长度数组，不用手动维护count。

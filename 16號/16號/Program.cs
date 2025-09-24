using System;

namespace _16號
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.Read();
            Console.WriteLine("歡迎使用公視BMI計算器");

            Console.Write("請輸入您的體重（公斤）：");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("請輸入您的身高（公分）：");
            double height = Convert.ToDouble(Console.ReadLine());

            // 根據你給的公式：BMI = W / (H * H)，不轉公尺
            double bmi = weight / (height * height);

            Console.WriteLine($"\n您的BMI值為：{bmi:F4}");

            // 若你要使用標準計算公式（建議這樣做），請改成：
            // double heightInMeter = height / 100;
            // double bmi = weight / (heightInMeter * heightInMeter);

            Console.WriteLine("\n感謝使用公視健康計算器，保持運動與健康飲食喔！");
        }
    }
}

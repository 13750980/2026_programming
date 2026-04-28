using System;
using System.IO;
using System.Text; // 需引用此命名空間

class Program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        string fileName = "mcuedutw.txt";

        using (StreamWriter sw = new StreamWriter(fileName))
        {
            Console.WriteLine("請輸入 10 筆資料 (格式：名字 分數，例如：火影忍者 87)：");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"第 {i} 筆: ");
                string input = Console.ReadLine();
                sw.WriteLine(input);
            }
        }

        Console.WriteLine($"\n檔案 {fileName} 已寫入完成並關閉。");
    }
}
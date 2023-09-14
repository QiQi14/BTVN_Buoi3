using System;

public class Program
{
    public static void Main()
    {
        // Bài 1
        string bai1 = "03:03:00PM";
        char a = bai1[8];
        if (a == 'P')
        {
            string c = bai1.Substring(0, 2);
            int gio = Convert.ToInt32(c) + 12;
            string gio24 = gio.ToString();
            string d = bai1.Remove(0, 2).Insert(0, gio24);

            Console.WriteLine("Kết quả bài 1: " + d.Substring(0, 8));
        }
        else
        {
            Console.WriteLine("Kết quả bài 1: " + bai1.Substring(0, 8));
        }

        // Bài 2
        string[] name = { "A", "B", "C", "D", "E" };
        float[] grade = { 3.8F, 7.9F, 6.0F, 2.8F, 5.0F };
        for (int i = 0; i < grade.Length; i++)
        {
            float value = grade[i];
            float diemnguyen = value + 1F;
            float diemlamtron = value + 0.2F;

            if (value < 3.5F)
            {
                String tenhocsinh = name[i];
                Console.WriteLine("Kết quả bài 2: " + tenhocsinh + " " + value + " Không đủ điểm");
            }
            else if (diemlamtron >= (int)diemnguyen)
            {
                String tenhocsinh = name[i];
                Console.WriteLine("Kết quả bài 2: " + tenhocsinh + " " + (int)diemnguyen);
            }
            else
            {
                String tenhocsinh = name[i];
                Console.WriteLine("Kết quả bài 2: " + tenhocsinh + " " + value);
            }
        }
    }
}
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

class BTVNBuoi3
{
    public static void Main()
    {
        Console.WriteLine("Ket qua bai 1: " + Bai1("03:03:00PM"));
        string[] name = { "A", "B", "C", "D", "E" };
        float[] grade = { 3.8F, 7.9F, 6.0F, 2.8F, 5.0F };
        Console.WriteLine("Ket qua bai 2: " + Bai2(name, grade));
    }

    public static string Bai1(string ampm)
    {
        return "";
        string result = "";
        string[] str = Regex.Split(ampm, @":");
        if (Int32.Parse(str[0]) > 12)
        {
            return "Input False";
        }
        else
        {
            if (str[2].Contains("PM"))
            {
                if (Int32.Parse(str[0]) == 12)
                {
                    result = str.ToString();
                }
                else
                {
                    int time = Int32.Parse(str[0]) + 12;
                    result = time.ToString() + ":" + str[1] + ":" + str[2].Remove(2);
                }
            }
            else if (str[2].Contains("AM"))
            {
                if (Int32.Parse(str[0]) == 12)
                {
                    str[0] = "00";
                    result = str[0] + ":" + str[1] + ":" + str[2].Remove(2);
                }
                else
                {
                    result = str[0] + ":" + str[1] + ":" + str[2].Remove(2);
                }
            }
        }

        return result;
    }
    public static string Bai2(string[] name, float[] grade)
    {
        string result = "";
        string str = "";
        float round = 0;
        Dictionary<string, float> Danhsach = new Dictionary<string, float>();
        for (int i = 0; i < name.Length; i++)
        {
            Danhsach.Add(name[i], grade[i]);
        }
        foreach (var hocsinh in Danhsach)
        {
            if (hocsinh.Value < 3.5f)
            {
                result = result +"\nHọc sinh: " + hocsinh.Key + "   Điểm số: " + hocsinh.Value + "+ 0.2 = " + round;
            }
            else
            {
                round = hocsinh.Value + 0.2f;
                result = result +"\nHọc sinh: " + hocsinh.Key + "   Điểm số: " + hocsinh.Value + "+ 0.2 = " + round;
            }
        }
        return result;
    }
}
    
    


    
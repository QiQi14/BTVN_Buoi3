using System.Text.RegularExpressions;

class BTVNBuoi3 {
    public static void Main() {
        Console.WriteLine("Ket qua bai 1: " + Bai1("05:30:00PM"));

        string[] name = {"A", "B", "C", "D", "E"};
        float[] grade = {3.8F, 7.9F, 6.0F, 2.8F, 5.0F};
        Console.WriteLine("Ket qua bai 2: " + Bai2(name, grade));
    }

    public static string Bai1(string ampm)
    {
        string result = "";
        string[] splitString = Regex.Split(ampm, @":");
        if (Int16.Parse(splitString[0]) > 12)
        {
            return "Loi nhap du lieu";
        }
        else
        {
            if (splitString[2].Contains("PM"))
            {
                if (Int16.Parse(splitString[0]) == 12)
                {
                    result = splitString.ToString();
                }
                else
                {
                    int time = Int16.Parse(splitString[0]) + 12;
                    result = time.ToString() + ":" + splitString[1] + ":" + splitString[2].Remove(2);
                }
            }
            else if (splitString[2].Contains("AM"))
            {
                if (Int16.Parse(splitString[0]) == 12)
                 {
                    splitString[0] = "00";
                    result = splitString[0] + ":" + splitString[1] + ":" + splitString[2].Remove(2);
                }
                else
                {
                    result = splitString[0] + ":" + splitString[1] + ":" + splitString[2].Remove(2);
                }
            }
        }
        
        return result;
    }

    public static string Bai2(string[] name, float[] grade)
    {
        string ketqua = "";
        for (int i = 0; i < grade.Length; i++)
        {
            string hocluc = "";
            if ((grade[i] + 0.2F >= Math.Ceiling(grade[i]) && grade[i] != Math.Ceiling(grade[i])))
            {
                grade[i] = Convert.ToInt32(Math.Ceiling(grade[i]));

            }
            if (grade[i] < 4)
            {
                hocluc = "Hoc lai";
            }
            else if (grade[i] >= 4 && grade[i] < 6)
            {
                hocluc = "Trung binh";
            }
            else if (grade[i] >= 6 && grade[i] < 8)
            {
                hocluc = "Kha";
            }
            else
            {
                hocluc = "Gioi";
            }
            ketqua += "Hoc vien: " + name[i] + ";" + " Diem: " +  grade[i] + ";" + " Hoc luc: "  + hocluc + "\n";
        }
        return ketqua;
    }
}
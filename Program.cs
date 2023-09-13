class BTVNBuoi3 {
    public static void Main() {
        Console.WriteLine("Ket qua bai 1: " + Bai1("03:03:00PM"));

        string[] name = {"A", "B", "C", "D", "E"};
        float[] grade = {3.8F, 7.9F, 6.0F, 2.8F, 5.0F};
        Console.WriteLine("Ket qua bai 2: " + Bai2(name, grade));
    }

    public static string Bai1(string ampm)
    {
        Console.Write("Enter the time you want to convert from 12hr to 24hr: ");
        string inputTime = Console.ReadLine();
        DateTime convertTime = DateTime.Parse(inputTime);
        Console.WriteLine(convertTime.ToString("HH:mm:ss"));

        return "";
    }

    public static string Bai2(string[] name, float[] grade)
    {
        string[] student = new string[5] { "A", "B", "C", "D", "E" };
        float[] point = new float[5] {3.8f, 3.5f, 6.5f, 7.9f, 7.8f };
        float[] newPoint1 = new float [5] { 4.0f, 3.7f, 6.7f, 8.1f, 8.0f };

        for (int i = 0; i < student.Length; i++)
        {
            for (int j = 0; j < student[i].Length; j++)
            {
                Console.WriteLine("The begin point of student " + student[i] + " is: " + point[i]);
            }
        }

        Console.WriteLine(" ");

        for (int i = 0; i < student.Length; i++){
         
            Console.WriteLine("The new point of student " + student[i] + " is: " + newPoint1[i]);

            float newPoint2 = Convert.ToSingle(newPoint1[i]);
            string student2 = Convert.ToString(student[i]);

         if (newPoint2 < 4.0f)
            {
                Console.WriteLine("=> " + student2 + " = " + newPoint2 + " < 4 " + "Giu nguyen diem " + point[1]);
                Console.WriteLine("Hoc vien co so diem duoi trung binh, can hoc lai!");
                Console.WriteLine("");
            } else if (newPoint2 >= 4.0f && newPoint2 < 6.0f)
            {
                Console.WriteLine("=> " + student2 + " = " + newPoint2);
                Console.WriteLine(student2 + " La hoc sinh trung binh");
                Console.WriteLine("");
            } else if (newPoint2 > 6.0f && newPoint2 < 8.0f)
            {
                Console.WriteLine("=> " + student2 + " = " + newPoint2 + " < 7 " + "Giu nguyen diem " + point[2]);
                Console.WriteLine(student2 + " La hoc sinh kha");
                Console.WriteLine("");
            } else if (newPoint2 >= 8.0f)
            {
                Console.WriteLine("=> " + student2 + " = " + newPoint2);
                Console.WriteLine(student2 + " La hoc sinh gioi");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("diem nay co van de, can xem lai!");
                Console.WriteLine("");
            }
        }
        return "";
    }
}
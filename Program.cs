using System.Data;

class BTVNBuoi3
{
    public static void Main()
    {

        int luachonbai = 0;

        string luachonlap = "no";
        do
        {
            Console.WriteLine("Moi Ban Lua Chon Bai Tap: ");
            Console.WriteLine("Bai 1: Ban nhap so 1  ");
            Console.WriteLine("Bai 2: Ban nhap so 2  ");
            luachonbai = int.Parse(Console.ReadLine());
            switch (luachonbai)
            {
                case 1:
                    Console.Write("Nhap Gio HH:mm:ss (AM or PM)= ");
                    DateTime dateTime = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Ket qua bai 1: " + Bai1(dateTime));
                    break;
                case 2:
                    //string[] name = { "A", "B", "C", "D", "E" };
                    //float[] grade = { 3.8F, 7.9F, 6.0F, 2.8F, 5.0F };
                    Console.Write("Nhap Mang Co n Phan Tu = ");
                    int n = int.Parse(Console.ReadLine());
                    string[] name = new string[n];
                    float[] grade = new float[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Nhap Ten = " + name[i] + " ");
                        name[i] = Console.ReadLine();
                        Console.Write("Nhap Diem = " + " ");
                        grade[i] = float.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Ket qua bai 2: " + Bai2(name, grade));
                    break;
                case 3:

                default:
                    Console.WriteLine("Ban da chon sai bai tap khong co ");
                    break;
            }
            Console.WriteLine("Ban Muon Chon Bai Lai De Test:");
            Console.Write("Ban Muon Chon lai nhap 'yes' khong thi nhap 'no':");
            luachonlap = Console.ReadLine();
        } while (luachonlap == "yes");
        {

        }

    }

    public static string Bai1(DateTime ampm)
    {

        return ampm.ToString("HH:mm:ss");
    }

    public static string Bai2(string[] name, float[] grade)
    {
        float[] new_grade = new float[grade.Length];
        float diem_new = 0;
        for (int i = 0; i < grade.Length; i++)
        {
            Console.Write(name[i] + ":" + grade[i] + " ");
            new_grade[i] = grade[i] + 0.2f;

            Console.Write(name[i] + ":" + new_grade[i] + " ");


            Console.WriteLine("\n---------------");
        }
        Console.WriteLine("Diem moi: ");
        for (int j = 0; j < new_grade.Length; j++)
        {
            diem_new = new_grade[j];
            //Console.Write(diem_new + " ");
            if (diem_new < 4)
            {
                Console.WriteLine("Hoc Vien " + name[j] + " co diem " + diem_new + " Hoc Lai" + " | " + name[j] + ":" + grade[j]);
            }
            else if (diem_new >= 4 )
            {
                Console.WriteLine("Hoc Vien " + name[j] + " co diem " + diem_new + " Trung binh" + " | " + name[j] + ":" + Convert.ToInt32(Math.Ceiling(grade[j])));
            }
            else if ( diem_new < 6)
            {
                Console.WriteLine("Hoc Vien " + name[j] + " co diem " + diem_new + " Trung binh" + " | " + name[j] + ":" + grade[j]);
            }
            else if (diem_new > 6 )
            {
                Console.WriteLine("Hoc Vien " + name[j] + " co diem " + diem_new + " Kha" + " | " + name[j] + ":" + Convert.ToInt32(Math.Ceiling(grade[j])));
            }
            else if ( diem_new < 8)
            {
                Console.WriteLine("Hoc Vien " + name[j] + " co diem " + diem_new + " Kha" + " | " + name[j] + ":" + grade[j]);
            }
            else if (diem_new >= 8 && diem_new <= 10)
            {
                Console.WriteLine("Hoc Vien " + name[j] + " co diem " + diem_new + " Gioi" + " | " + name[j] + ":" + Convert.ToInt32(Math.Ceiling(grade[j])));
            }
            else
            {
                Console.WriteLine("Ban Nhap Sai Diem");
            }
        }


        return "";
    }
}
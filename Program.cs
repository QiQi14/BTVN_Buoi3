using System;


public class BTVNBuoi3
{
    public static void bai1(String str)
    {
        /*  Console.WriteLine("Ket qua bai 1: " + Bai1("03:03:00PM"));
        */
        //  Console.WriteLine("Ket qua bai 2: " + Bai2(ten, diemso));


        int h1 = (int)str[1] - '0';
        int h2 = (int)str[0] - '0';
        int hh = (h2 * 10 + h1 % 10);

        if (str[8] == 'A')
        {
            if (hh == 12)
            {
                Console.Write("00");
                for (int i = 2; i <= 7; i++)
                    Console.Write(str[i]);
            }
            else
            {
                for (int i = 0; i <= 7; i++)
                    Console.Write(str[i]);
            }
        }

        else
        {
            if (hh == 12)
            {
                Console.Write("12");
                for (int i = 2; i <= 7; i++)
                    Console.Write(str[i]);
            }
            else
            {
                hh = hh + 12;
                Console.Write(hh);
                for (int i = 2; i <= 7; i++)
                    Console.Write(str[i]);
            }
        }




    }

    public static void bai2()
    {
        string[] ten = { "A", "B", "C", "D", "E" };
        float[] diemso = { 3.8F, 7.9F, 6.0F, 2.8F, 5.0F };

        Dictionary<string, float> ds = new Dictionary<string, float>();
        for (int i = 0; i < diemso.Length; i++)
        {
            ds.Add(ten[i], diemso[i]);
            foreach (KeyValuePair<string, float> item in ds)
            {
                if (diemso[i] > 3.5)
                {
                    double diemmoi = diemso[i] + 0.2f;
                    Math.Round(diemmoi);
                    if (diemmoi < 4)
                    {
                        Console.WriteLine("hoc lai  " + item.Key + "\t" + diemmoi);
                    }
                    else if (diemmoi >= 4 && diemmoi <= 6)
                    {
                        Console.WriteLine("trung binh  " + item.Key + "\t" + diemmoi);

                    }
                    else if (diemmoi > 6 && diemmoi < 8)
                    {
                        Console.WriteLine("kha  " + item.Key + "\t" + diemmoi);
                    }
                    else if (diemmoi > 8)
                    {
                        Console.WriteLine("gioi " + item.Key + "\t" + diemmoi);
                    }


                }
                else
                {
                    Console.WriteLine("hoc lai  " + item.Key + "\t" + item.Value);
                }
            }

        }
    }

    public static void Main(String[] args)
    {
        String str = "03:03:00PM";
        bai1(str);
        Console.WriteLine("\n\n");
        bai2();
        return;


    }
    /* public static string Bai2(string[] ten, float[] diemso)
     {


         return "";
     }*/




}





/* public static string Bai1(string ampm)
    {
        return "";
    }
*/

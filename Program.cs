class BTVNBuoi3 {
    public static void Main() {
        Console.WriteLine("Ket qua bai 1: " + Bai1("03:03:00PM"));

        string[] name = {"A", "B", "C", "D", "E"};
        float[] grade = {3.8F, 7.9F, 6.0F, 2.8F, 5.0F};
        Console.WriteLine("Ket qua bai 2: " + Bai2(name, grade));
    }

    public static string Bai1(string s)
    {
        string ampm = s.Substring(s.Length - 2, 2);
        int hour = Convert.ToInt32(s.Substring(0, 2));
        string body = s.Substring(2, s.Length - 4);
        if (ampm.Equals("PM"))
        {
            if (hour < 12)
                hour += 12;
        }
        else
        {
            if (hour == 12)
                hour = 0;
        }
        return "" + hour + body;
    }

    public static string Bai2(string[] names, float[] grades)
    {
        for (int i = 0; i < grades.Length; i++)
        {
            if (grades[i] < 3.8F)
                continue;

            float different = (grades[i] * 10 % 5) * 0.1F;
            if (different > 0.2)
            {
                float roundedGrade = grades[i] + 0.5F - different;
                grades[i] = (float)Math.Round(roundedGrade, 2);
            }
        }
        string result = string.Join(",", names) + "\n" + string.Join(",", grades);
        return result;
    }
}
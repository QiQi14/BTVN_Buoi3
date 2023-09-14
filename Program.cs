class BTVNBuoi3 {
    public static void Main() {
        Console.Write("Nhập thời gian theo định dạng hh:mm:ss tt (ví dụ: 03:03:00 PM): ");
        string ampm = Console.ReadLine();

        string result = Bai1(ampm);
        Console.WriteLine("Ket qua bai 1: " + result);

        string[] name = {"A", "B", "C", "D", "E"};
        float[] grade = {3.8F, 7.9F, 6.0F, 2.8F, 5.0F};
        Console.WriteLine("Ket qua bai 2: " + Bai2(name, grade));
    }

    public static string Bai1(string ampm)
    {
        try
        {
            DateTime dateTime = DateTime.ParseExact(ampm, "hh:mm:ss tt", null);
            string result = dateTime.ToString("HH:mm:ss");
            return result;
        }
        catch (FormatException)
        {
            return "Định dạng đầu vào không hợp lệ.";
        }
    }

    public static string Bai2(string[] name, float[] grade)
    {
        return "";
    }
}
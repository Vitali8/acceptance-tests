namespace AcceptanceTests
{
    class TaskTwo
    {
        public static string zipzap(int lastNumber)
        {
            string result = "";
            for (int i = 1; i <= lastNumber; i++)
            {
                //два тернарних оператора визначають справедливість двох тверджень про кратність
                result += i % 3 == 0 ? "zip" : i % 5 == 0 ? "zap" : i.ToString();
            }
            return result;
        }
    }
}

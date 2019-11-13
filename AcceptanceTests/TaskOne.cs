using System;

namespace AcceptanceTests
{
    class TaskOne
    {
        public static string decToHex(string input)
        {
            //намагається рядок input спершу конвертувати у цілочисельний тип 
            //а пототім у рядок з відповідним значенням у шістнадцятковій СЧ 
            try
            {
                return Convert.ToString(int.Parse(input), 16);
            }
            catch (Exception ex)
            {
                return "Помилка! " + ex.Message;
            }
        }
        public static string decToBin(string input)
        {
            //намагається рядок input спершу конвертувати у цілочисельний тип 
            //а пототім у рядок з відповідним значенням у двійковій СЧ 
            try
            {
                return Convert.ToString(int.Parse(input), 2);
            }
            catch (Exception ex)
            {
                return "Помилка! " + ex.Message;
            }
        }
        public static string hexToBin(string input)
        {
            //намагається рядок input спершу конвертувати у цілочисельний тип при шістнадцятковій СЧ
            //а пототім у рядок з відповідним значенням у двійковій СЧ 
            try
            {
                return Convert.ToString(Convert.ToInt32(input, 16), 2);
            }
            catch (Exception ex)
            {
                return "Помилка! " + ex.Message;
            }
        }
        public static string binToHex(string input)
        {
            //намагається рядок input спершу конвертувати у цілочисельний тип при двійковій СЧ
            //а пототім у рядок з відповідним значенням у шістнадцятковій СЧ 
            try
            {
                return Convert.ToString(Convert.ToInt32(input, 2), 16);
            }
            catch (Exception ex)
            {
                return "Помилка! " + ex.Message;
            }
        }
    }
}

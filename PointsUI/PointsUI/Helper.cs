using System.Text.RegularExpressions;

namespace PointsUI
{
    public class Helper
    {
        public static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]{2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)").Success;
        }
    }
}

namespace AGA___MOG___Calculator
{
    public class Check
    {
        //not use this code !!!
        public static bool IsNumber(object pValue, out int x)
        {
            x = 0;
            return pValue != null && int.TryParse((string) pValue, out x);
        }
    }
}

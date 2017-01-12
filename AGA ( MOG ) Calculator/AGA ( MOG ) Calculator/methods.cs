namespace AGA___MOG___Calculator
{
    public class methods
    {
        public static bool isNumber(object p_Value)
        {
            if (int.Parse(p_Value.ToString()).GetType().Equals(typeof(int)))
                return true;
            return false;

        }
    }
}

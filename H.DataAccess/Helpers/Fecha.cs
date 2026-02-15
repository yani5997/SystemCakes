namespace H.DataAccess.Helpers
{
    public class Fecha
    {
        public static DateTime Hoy
        {
            get
            {
                return DateTime.UtcNow.AddHours(-5);
            }
        }
    }
}

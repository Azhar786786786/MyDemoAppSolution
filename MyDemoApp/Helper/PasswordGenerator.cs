namespace MyDemoApp.Helper
{
    public class PasswordGenerator
    {
        public static string GetPassword()
        {
            String pass = "";
            Random random = new Random();
            char[] capitals = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] smalls = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] symbols = "@#$&*".ToCharArray();
            int index = random.Next(0, 25);
            pass += capitals[index];
            index = random.Next(0, 25);
            pass += smalls[index];
            index = random.Next(0, 4);
            pass += symbols[index];
            pass += random.Next(11111, 99999);
            return pass;
        }
    }
}

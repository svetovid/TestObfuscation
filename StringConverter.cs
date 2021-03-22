namespace TestObfuscation
{
    public static class StringConverter
    {
        public static string ChangeCase(string str)
        {
            var ln = str.Length;
            var ret = new char[ln];

            // Conversion according to ASCII values
            for (int i = 0; i < ln; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')

                    //Convert lowercase to uppercase
                    ret[i] = (char)(str[i] - 32);

                else if (str[i] >= 'A' && str[i] <= 'Z')

                    //Convert uppercase to lowercase
                    ret[i] = (char)(str[i] + 32);
            }

            return new string(ret);
        }

        public static string ChangeOrder(string str)
        {
            var ln = str.Length;
            var ret = new char[ln];

            for (int i = 1; i <= ln; i++)
            {
                ret[i - 1] = str[ln - i];
            }

            return new string(ret);
        }
    }
}

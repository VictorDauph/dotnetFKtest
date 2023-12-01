namespace FKTest.config
{
    public static class ConnectionString
    {
        private static bool Prod = false;
        
        private static string connStringProd = "";
        private static string connStringDev = "Server=localhost;User ID=FKTESTBDD;Password=FKTESTBDD;Database=FKTESTBDD;Trusted_Connection=true;TrustServerCertificate=true;";
        public static string GetString()
        {
            if (Prod)
            {
                return connStringProd;
            }
            else
            {
                return connStringDev;
            }

        }
    }
}

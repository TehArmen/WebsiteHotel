namespace HomePage
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new HomePage());

        }

        public static class CustID
        {
            public static int custID;
            public static int HotelroomID;
            public static int HotelReservationID;

        }
       
    }
}
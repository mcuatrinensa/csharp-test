namespace forms
{
    class User
    {
        int id = 0;
        bool permission1 = false;
        bool permission2 = false;
    }

    class DBParams
    {
        string host = "localhost";
        // ...
    }

    static class FormsCfg {
        static void initialize(DBParams db, User user)
        {
            // ...
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;

namespace sample_efcore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TestContext context = new TestContext())
            {
                Console.WriteLine(context.Database.CanConnect());
                // var data = context.tempViews.FromSqlRaw("select * from temp_view");
                var conn = context.Database.GetDbConnection();
                using(conn)
                {
                    conn.Open();
                    var comd = conn.CreateCommand();
                    comd.ExecuteReader();
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}

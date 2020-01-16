using System;
using System.Threading;
using System.Security.Permissions;
using System.Security.Principal;

namespace sample_security_test
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
            PrincipalPermission permission = new PrincipalPermission(null,"Administrators");
            permission.Demand();
            Console.WriteLine("Hello World!");
        }
    }
}

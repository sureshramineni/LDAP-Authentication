using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.Protocols;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LDAP_Connection
{
    class Program
    {
        static void Main(string[] args)
        {
            String employeeId = string.Empty;
            String password = string.Empty;
            try
            {
                LdapConnection connection = new LdapConnection("xxxx.xxx.xxx.com");
                NetworkCredential credential = new NetworkCredential(employeeId, password);
                connection.Credential = credential;
                connection.Bind();
                Console.WriteLine("logged in");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}

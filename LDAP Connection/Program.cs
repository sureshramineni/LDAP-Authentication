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
            String ldapConnection = string.Empty;
            try
            {
                var connection = new LdapConnection(ldapConnection)
                {
                    Credential = new NetworkCredential(employeeId, password)
                };
                connection.Bind();
                Console.WriteLine("logged in");
            }
            catch (LdapException exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }
    }
}

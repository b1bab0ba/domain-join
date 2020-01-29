using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace DomainJoiner {
    class Program {

        private static string domain, username, password;

        static void Main(string[] args) {


            if (args.Length == 0) {
                /* Ask user to input params */
                System.Console.WriteLine("Please enter parameter values.");
                Console.Read();
            } else if (args.Length > 3) {
                /* Too many params */
                System.Console.WriteLine("Arguments overloaded.");
                Console.Read();
            } else {
                /* loop args array */
                for (int i = 0; i < args.Length; i++) {
                    if (i == 0)
                        domain = args[i];
                    if (i == 1)
                        username = args[i];
                    if (i == 2)
                        password = args[i];
                }

                Console.WriteLine($"Domain: {domain} | Username: {username} | Password: {password}");


                
                /* keep window open for debugging */
                Console.Read();
            }

        }

        public static bool Connect(string domain, string username, string password) {
            using (ManagementObject wmiObject = new ManagementObject(new ManagementPath("Win32_ComputerSystem.Name='" + Environment.MachineName + "'"))) {
                try {
                    // Obtain in-parameters for the method
                    ManagementBaseObject inParams = wmiObject.GetMethodParameters("JoinDomainOrWorkgroup");
                    inParams["Name"] = domain;
                    inParams["Password"] = password;
                    inParams["UserName"] = username;
                    inParams["FJoinOptions"] = 3; // Magic number: 3 = join to domain and create computer account
                    // Execute the method and obtain the return values.
                    ManagementBaseObject joinParams = wmiObject.InvokeMethod("JoinDomainOrWorkgroup", inParams, null);

                    // Did it work?
                    if ((uint)(joinParams.Properties["ReturnValue"].Value) != 0) {
                        Console.WriteLine(string.Format("JoinDomainOrWorkgroup return code: '{0}'", joinParams["ReturnValue"]));
                        // Join to domain didn't work
                        Console.WriteLine(string.Format("JoinDomainOrWorkgroup failed with return code: '{0}', if '1355' there is no connection to the domain.", joinParams["ReturnValue"]));
                        return false;
                    }
                    return false;
                } catch {
                    return false;
                }
            }
        }
    }
}
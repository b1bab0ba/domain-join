using System;
using System.Collections.Generic;
using System.Linq;
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
            } else {
                /* loop args array */
                for (int i = 0; i < args.Length; i++) {
                    Console.Write(args[i] + Environment.NewLine);
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
    }
}

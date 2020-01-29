using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainJoiner {
    class Program {
        static void Main(string[] args) {

            if (args.Length == 0) {
                /* Ask user to input params */
                System.Console.WriteLine("Please enter parameter values.");
                Console.Read();
            } else {
                /* loop args array */
                for (int i = 0; i < args.Length; i++) {
                    Console.Write(args[i] + Environment.NewLine);

                }
                
                /* keep window open for debugging */
                Console.Read();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class CustomerManager 
    {
        //business classes
        public void Add(Client client)  //In this method we can add a cliient in different ways such as Cooppoarate and Individual.
        {                               //this method is also an example of poliformizm.   

            Console.WriteLine(client+ "Client added succesfully!");  //we can print something to on the console screen for prove that our app is working.
        
        }
    }
}

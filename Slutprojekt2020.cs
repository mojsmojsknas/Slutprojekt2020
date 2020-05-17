using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace Slutprojekt2020
{
    //Viktigt för högre betyg
    //Klasser - fler steg, utveckla basklassen (Har gjort lite)
    //komentarer (Laggt till en del)
    //fixa en try parse ()
    //Lägg in all text i en klass (Klart Går att hitta under Text.cs)
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            while (run == true)
            {
             

    
               Text.Begining();

                while (run == true)
                {
                    Text.Instructions();
                  
                    Dictionary<string, Action> events = new Dictionary<string, Action>();
                        events.Add("monster", SpawnM);
                        events.Add("person", SpawnH);
                        

                    string check = Console.ReadLine().ToLower();

                    if (events.ContainsKey(check))
                    {
                        events[check]();
                        Console.Clear();
                    }

                }



            }

        }

        //Jag är för lat att skriva ut ett mellanrum helatiden 
        //Utöver detta så är den ganska smidig och gör koden mer lätt läst 
        static void Space()
        {
            Console.ReadKey();
            Console.WriteLine("");
        }
     
        //Jag har nu flyttat Begining och Instructions till klassen Text
        
            //Det första som kommer att synas när spelet väl startat 
        
       /* static void Begining()
        {
            Console.WriteLine("Wow välkommen till spelet");
            Space();

        }
        


        //Den text som berättar vad man kan göra ish
        static void Instructions()
        {
            Console.WriteLine("Vill du gå till ett monster eller en person?");
            
            Console.WriteLine("Skriv 'monster' för att gå till monstret");
            Console.WriteLine("Skriv 'person' för att gå till personen");
            

        }
        */

       
        //spawnar in ett monster
        static void SpawnM()
        {
            Monster m = new Monster();
        }

        //spawnar in en människa 
        static void SpawnH()
        {
            Human h = new Human();
        }
       

    }
}

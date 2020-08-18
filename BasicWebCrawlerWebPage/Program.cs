using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace BasicWebCrawlerWebPage
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            Console.WriteLine("Please enter the webpage you would like to crawl starting with 'www':  ");
            var webAddress = Console.ReadLine();
            Console.WriteLine("Press enter to start your search.");
            var client = new WebClient();
            try
            {
                var text = client.DownloadString($"https://{webAddress}");
                Console.WriteLine(text);
            }
            catch (Exception)
            {
                try
                {
                    var text = client.DownloadString($"http://{webAddress}");
                    Console.WriteLine(text);
                }
                catch (Exception)
                {

                    Console.WriteLine("Hmmm... the website seems to not be secure. Would you like to try another website? y or n?");
                    string searchAgainResponse = Console.ReadLine().ToLower();
                    if (searchAgainResponse == "y" || searchAgainResponse == "yes" || searchAgainResponse == "yep" || searchAgainResponse == "yea" || searchAgainResponse == "yeppers")
                    {
                        runApp();
                    }
                    else if (searchAgainResponse == "n" || searchAgainResponse == "no" || searchAgainResponse == "nope" || searchAgainResponse == "nah" || searchAgainResponse == "no way")
                    {
                        Console.WriteLine("Sounds good. Try again later.");
                        Console.WriteLine("Press any key to quit.");
                        Console.ReadKey();
                     

                    }
                    else
                    {
                        Console.WriteLine("I didn't catch that, let's try another website just in case.");
                    }
                    
                }

            }
            
            
        }
    }
}

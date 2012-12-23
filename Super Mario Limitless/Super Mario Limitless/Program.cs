using System;

namespace SML
{
    
    static class Program
    {
        
        /* SML will initialize here. */
        static void Main(string[] args)
        {
            
            using (Game game = new Game())
            {
                game.Run();
            }

        }

    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPrototype
{
    class PrototypeMain
    {
        /*
         * 1 Print Menu
         * 2 Analyze menu choice
         * 3 Declare Players
         * 4 Declare AI thread/main loop thread
         * 5 Main Loop
         * 6    Get Player Pieces
         * 7    Calculate Score
         * 8    Calculate Time/Stats for last move
         * 9    Create potential move set
         * 10   Update board/player instances
         * 11   Create Board
         * 12   Get selection
         * 13   Apply Selection to collections
         * 14   goto Main Loop
         * 15 AI thread
         * 16   Init: Register for board state change *High Priority*
         * 17   Apply decision to heuristic algorithm (minmax as a fallback)
         * 
         * Two way communication will be required between the Board/Main thread and the AI thread, so this isn't quite an observer pattern.
         * Will need to investigate a good strucuture, this project is starting to grow fangs.
         * Maybe investigate shortcut for 8x8 for-loops
         *        
         */
        static void Main(string[] args)
        {
            //public static bool IS_DEBUG = args[0][0] == 'T';
        }
    }
}

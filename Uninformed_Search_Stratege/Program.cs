using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uninformed_Search_Stratege
{
    class Program
    {
        static void Main(string[] args)
        {


            //message to get goal from user
            Console.WriteLine("please enter goal stat");
            //store and get goal
            int Goal = int.Parse(Console.ReadLine());
            //make object to use algorithms
            UninformedSearch uis = new UninformedSearch();
            //uses algorithms
            /*uis.BFS(Goal);
            uis.DFS(Goal);
            uis.DLS(Goal, 3);
            uis.IDS(Goal);*/

            Console.ReadKey();
        }
    }
}

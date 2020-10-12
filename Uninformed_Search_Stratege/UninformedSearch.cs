using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uninformed_Search_Stratege
{
    //implement uninformed search algorithms
    class UninformedSearch
    {
        //Breadth_First_Search_Algorithm
        public void BFS(int GoalState)
        {
            //create empty Queue
            Queue<Node> BFS_Queue = new Queue<Node>();
            //creat initialstate from node
            Node InitialState = new Node();
            //insert intialstate in the queue
            BFS_Queue.Enqueue(InitialState);
            Console.WriteLine("trace for path");
            //loop on tree
            while (BFS_Queue .Count !=0)
            {
                //remove first node in the queue
                Node CurrentNode = BFS_Queue.Dequeue();
                Console.Write(CurrentNode .State +"\t");
                //check goal
                if (CurrentNode.State == GoalState)
                {
                    //return goal
                    //list to get parent or path
                    List<int> SolutionGoal = new List<int>();
                    //tn insert parent or path in list
                    while (CurrentNode !=null)
                    {
                        SolutionGoal.Insert(0,CurrentNode.State );
                        CurrentNode = CurrentNode.Parent;
                    }
                    //display parent or path
                    Console.WriteLine("\nSolution");
                    foreach (var item in SolutionGoal)
                    {
                        Console.Write(item+"\t");
                    }
                    //To stop loop
                    break;
                }
                //add children for removed node
                else
                {
                    foreach (var item in CurrentNode.GetChildren())
                    {
                        BFS_Queue.Enqueue(item);
                    }
                }
            }
        }
        //Depth_First_Search_Algorithm
        public void DFS(int GoalState)
        {
            //create empty Stack
            Stack<Node> DFS_Stack = new Stack<Node>();
            //creat initialstate from node
            Node InitialState = new Node();
            //insert intialstate in the stack
            DFS_Stack.Push(InitialState);
            Console.WriteLine("trace for path");
            while (DFS_Stack.Count != 0)
            {
                //remove top node in the stack
                Node CurrentNode = DFS_Stack.Pop();
                Console.Write(CurrentNode.State + "\t");
                //check goal
                if (CurrentNode.State == GoalState)
                {
                    //return goal
                    //list to get parent or path
                    List<int> SolutionGoal = new List<int>();
                    //tn insert parent or path in list
                    while (CurrentNode != null)
                    {
                        SolutionGoal.Insert(0, CurrentNode.State);
                        CurrentNode = CurrentNode.Parent;
                    }
                    //display parent or path
                    Console.WriteLine("\nSolution");
                    foreach (var item in SolutionGoal)
                    {
                        Console.Write(item + "\t");
                    }
                    //To stop loop
                    break;
                }
                //add children for removed node
                else
                {
                    foreach (var item in CurrentNode.GetChildrenReversed())
                    {
                        DFS_Stack.Push(item);
                    }
                }
            }
        }
        //Depth_Limit_Search_Algorithm
        public bool DLS(int GoalState, int Limit)
        {
            //create empty Stack
            Stack<Node> DLS_Stack = new Stack<Node>();
            //creat initialstate from node
            Node InitialState = new Node();
            //insert intialstate in the stack
            DLS_Stack.Push(InitialState);
            Console.WriteLine("\ntrace for path");
            while (DLS_Stack.Count != 0)
            {
                //remove top node in the stack
                Node CurrentNode = DLS_Stack.Pop();
                Console.Write(+CurrentNode.State + "\t");
                //check goal
                if (CurrentNode.State == GoalState)
                {
                    //return goal
                    //list to get parent or path
                    List<int> SolutionGoal = new List<int>();
                    //tn insert parent or path in list
                    while (CurrentNode != null)
                    {
                        SolutionGoal.Insert(0, CurrentNode.State);
                        CurrentNode = CurrentNode.Parent;
                    }
                    //display parent or path
                    Console.WriteLine("\nSolution");
                    foreach (var item in SolutionGoal)
                    {
                        Console.Write(item + "\t");
                    }
                    //To stop loop
                    return true;
                }
                //add children for removed node
                else
                {
                    //check level to stop add children
                    if (CurrentNode .Depth ==Limit)
                    {
                        continue;
                    }
                    //add
                    foreach (var item in CurrentNode.GetChildrenReversed())
                    {
                        DLS_Stack.Push(item);
                    }
                }
            }
            return false;
        }
        //Iterative_Deeping_Search
        public void IDS(int GoalState)
        {
            int Limit = 0;
            while (DLS(GoalState, Limit)==false)
            {
                Limit++;
            }
        }
    }
}

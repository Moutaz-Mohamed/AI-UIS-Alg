using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uninformed_Search_Stratege
{
    class Node
    {
        public int State { get; set; }
        public int Depth { get; set; }
        public int PathCost { get; set; }
        public Node Parent { get; set; }

        //constractor to root
        public Node()
        {
            this.State = 0;
            this.Depth = 0;
            this.PathCost = 0;
            this.Parent = null;
        }
        //constractor to root with changeable state
        public Node ( int State)
        {
            this.State = State;
            this.Depth = 0;
            this.PathCost = 0;
            this.Parent = null;
        }
        //constractor to children with constant costs
        public Node (Node Parent , int State)
        {
            this.State = State;
            this.Parent = Parent;
            this.Depth = Parent.Depth + 1;
            this.PathCost = Parent.PathCost++;
        }
        //constractor to children with changeable costs
        public Node(Node Parent, int State , int StepCost)
        {
            this.State = State;
            this.Parent = Parent;
            this.Depth = Parent.Depth + 1;
            this.PathCost = Parent.PathCost+StepCost ;
        }
        //method to get child node for BFS
        public Node [] GetChildren()
        {
            Node[] Children = new Node[2];
            //left child and using constractor
            Children[0] = new Node(this, (this.State * 2) + 1);
            //right child
            Children[1] = new Node(this, (this.State * 2) + 2);
            return Children;
        }
        //method to get child node for DFS
        public Node[] GetChildrenReversed()
        {
            Node[] Children = new Node[2];
            //left child
            Children[0] = new Node(this, (this.State * 2) + 2);
            //right child
            Children[1] = new Node(this, (this.State * 2) + 1);
            return Children;
        }
    }
}

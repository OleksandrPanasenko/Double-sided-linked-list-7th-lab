using System.Numerics;

namespace LinkedList{
    public class Node{
        public Double Data{get; set; }
        public Node Next {get; internal set;}
        public Node Previous { get; internal set;}
        public Node (double input){
            Data = input;
        }
    }
}
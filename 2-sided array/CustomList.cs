using System.Collections;
using System.Globalization;

namespace LinkedList{
    public class LinkedList:IEnumerable{
        public Node First{ get; internal set;}
        public Node Last{get; internal set;}
        public Node Max {
            get{
                Node current=First;
                Node max=First;
                do{
                    current=current.Next;
                    if((max.Data).CompareTo(current.Data)<0){
                        max=current;
                    }
                }while (current!=First);
                return max;
            }
        }
        public int Instance (Node thing){
            Node current=First;
            int position=0;
            do{
                if(current==thing){
                    return position;
                }
                position++;
            }while (current!=First);
            return -1;
        }
        public int Count{get;private set;}
        public LinkedList(){
            First=null;

            Last=null;
            Count=0;
        }
        private void LinkNodes(Node from, Node to){
            from.Next=to;
            to.Previous=from;
        }
        public LinkedList(Node first){
            First=first;
            Last=first;
            Count=1;
        }
        public void AddStart (Node node){
            if (First==null){
                First=node;
                Last=First;
                LinkNodes(node, node);
                Count=1;
            }
            else{
                LinkNodes(node, First);
                LinkNodes(Last, node);
                First=node;
                Count++;
            }
        }
        public void AddStart (double value){
            AddStart(new Node(value));
        }
        public double Sum { get{
            double sum=0;
            foreach(double node in this){
                sum+=node;
            }
            return sum;
        }}
        //This task
        public void DeleteBeforeMax(){
            Node MaxNode=Max;
            LinkNodes(Last,MaxNode);
            First=MaxNode;
        }
        //This Task
        public int LessThanAverage { get{
            int position=0;
            double average=Sum/Count;
            foreach(double node in this){
                if (node<average) return position;
                position++;
            }
            return -1;
        }}
        //This Task
        public double SumAfterMax{ get{
            Node FirstExcluded=First;
            Node LastExcluded=Max;
            LinkNodes(Last,LastExcluded.Next);
            First=LastExcluded.Next;
            double sum=Sum;
            LinkNodes(Last,FirstExcluded);
            LinkNodes(LastExcluded,LastExcluded.Next);
            First=FirstExcluded;
            return sum;
        }}

        IEnumerator IEnumerable.GetEnumerator(){
            return (IEnumerator)GetEnumerator();
        }
        public IEnumerator GetEnumerator(){
            Node current=First;
            do{
                yield return current.Data;
                current=current.Next;
            }while (current!=First);
        }
        //This task
        public LinkedList NewListMoreThanValue(double value){
            LinkedList list=new LinkedList();
            foreach(double node in this){
                if(node>value){
                    list.AddStart(new Node(node));
                }
            }
            return list;
        }
        public void WriteList(){
            foreach(double node in this){
                Console.Write(string.Format("{0} ",node));
            }
            Console.WriteLine();
        }

    }
}
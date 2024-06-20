
// See https://aka.ms/new-console-template for more information
using LinkedList;
static void WriteList(LinkedList.LinkedList list){
    foreach(double node in list){
                Console.Write(string.Format("{0} ",node));
            }
            Console.WriteLine();
}

Console.WriteLine("Hello, World!");
Console.WriteLine("Number of elements of the list?");
int num=Int32.Parse(Console.ReadLine());
LinkedList.LinkedList list=new LinkedList.LinkedList();
for(int i=0; i<num;i++){
    Console.WriteLine(String.Format("Element number {0}",i+1));
    list.AddStart(new Node(int.Parse(Console.ReadLine())));
}
list.WriteList();
Console.WriteLine(string.Format("The first element that is less than average has an index of {0}",list.LessThanAverage));
list.WriteList();
list.DeleteBeforeMax();
list.WriteList();

LinkedList.LinkedList list2 = new LinkedList.LinkedList();

// Add some nodes at the start
list2.AddStart(new Node(10));
list2.AddStart(new Node(20));
list2.AddStart(new Node(30));
list2.AddStart(new Node(40));

Console.WriteLine("Original List:");
list2.WriteList();

// Test NewListMoreThanValue
double value = 25;
LinkedList.LinkedList newList = list2.NewListMoreThanValue(value);
Console.WriteLine($"\nNew List with Nodes More Than {value}:");
newList.WriteList();

// Test SumAfterMax
Console.WriteLine($"\nSum After Maximum Node: {list2.SumAfterMax}");

// Test First Less Than Average
int firstLessThanAverageIndex = list2.LessThanAverage;
if (firstLessThanAverageIndex != -1) {
    Console.WriteLine($"\nFirst Node Less Than Average Found at Index: {firstLessThanAverageIndex}");
} else {
    Console.WriteLine("\nNo Node Found Less Than Average.");
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Solution06b solution06 = new Solution06b();

ListNode head1 = new ListNode();
ListNode head2 = new ListNode();

head1 = new ListNode(1, new ListNode(2, new ListNode(4, null)));
head2 = new ListNode(1, new ListNode(3, new ListNode(4, null)));

solution06.ReverseList(head1);

Console.WriteLine("Ok!");
*/

Node node1 = new Node(1);
IList<Node> firstGen = new List<Node>();
firstGen.Add(node1);

Node root = new Node(0, firstGen);

Solution11 solution11 = new Solution11();

IList<int> res = new List<int>();
res = solution11.Preorder(root);

Console.WriteLine("res: [{0}]", String.Join(",", res));

Console.WriteLine("Ok!");

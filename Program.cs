// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Solution06b solution06 = new Solution06b();

ListNode head1 = new ListNode();
ListNode head2 = new ListNode();

head1 = new ListNode(1, new ListNode(2, new ListNode(4, null)));
head2 = new ListNode(1, new ListNode(3, new ListNode(4, null)));

solution06.ReverseList(head1);

Console.WriteLine("Ok!");

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Solution05 solution05 = new Solution05();

ListNode head1 = new ListNode();
ListNode head2 = new ListNode();

head1 = new ListNode(1, new ListNode(2, new ListNode(4, null)));
head2 = new ListNode(1, new ListNode(3, new ListNode(4, null)));

solution05.MergeTwoLists(head1, head2);

Console.WriteLine("Ok!");

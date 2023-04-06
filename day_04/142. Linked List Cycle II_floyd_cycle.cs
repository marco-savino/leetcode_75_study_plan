public class Solution08b {
    public ListNode DetectCycle(ListNode head) {
        
        ListNode slowPoiner = head;
        ListNode fastPointer = head;

        while(fastPointer != null && fastPointer.next != null)
        {
            slowPoiner = slowPoiner.next;
            fastPointer = fastPointer.next.next;

            Console.WriteLine("Slow: {0}; Fast: {1}", slowPoiner.val, fastPointer.val);

            if(slowPoiner == fastPointer)
            {
                Console.WriteLine("Match!");
                slowPoiner = head;
                while(slowPoiner != fastPointer)
                {
                    slowPoiner = slowPoiner.next;
                    fastPointer = fastPointer.next;

                    Console.WriteLine("Slow: {0}; Fast: {1}", slowPoiner.val, fastPointer.val);
                }

                return fastPointer;
            }
        }

        return null;

    }
}
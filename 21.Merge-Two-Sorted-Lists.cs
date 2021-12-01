public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        list1.AddRange(list2);
        return list1.Sort();
    }
}
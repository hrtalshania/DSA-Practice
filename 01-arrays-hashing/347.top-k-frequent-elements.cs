// LeetCode 347. Top K Frequent Elements (Medium)
// https://leetcode.com/problems/top-k-frequent-elements/
//
// TASK: return the k most frequent elements. (nums.Length >= 1, k valid)
//
// Process: 1) count frequencies with a hash map  2) how to pick top k?
//   Option A: PriorityQueue min-heap of size k → O(n log k)
//   Option B: bucket sort by frequency → O(n) (frequency never exceeds n)
// Target: heap solution first, know bucket-sort exists as the O(n) follow-up.
public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        // Your solution here
        return null;
    }
}

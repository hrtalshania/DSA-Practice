# 01 — Arrays & Hashing

## Core idea
Trade **space for time**: store seen elements / counts in a hash structure for O(1) lookups instead of re-scanning (O(n²) → O(n)).

## Pattern recognition quick guide
| Problem says | Pattern |
|--------------|---------|
| "find pair/triplet matching X" | Hash map of seen values → O(n) |
| "any duplicates" | Hash set during iteration, or `set.Count < nums.Length` |
| "anagram / same letters / frequency" | Char frequency array `[26]` or `Dictionary<char,int>` |
| "first recurring / seen before" | Hash set of seen |
| "k most frequent" | Hash map count → heap (O(n log k)) or bucket sort (O(n)) |
| "count subarrays with sum == k" | Prefix sum + hash map of seen prefixes |

## Big-O of the C# toolbox
| Operation | Complexity | Notes |
|-----------|-----------|-------|
| `Dictionary<K,V>` get/set/contains | O(1) avg | the default interview tool |
| `HashSet<T>` contains/add | O(1) avg | dedupe + "have I seen X" |
| `Array.Sort` | O(n log n) | destroys indices for Two Sum; fine for sort-first patterns |
| `[26]` int array count | O(1) space, fastest | for lowercase a-z frequency |
| `PriorityQueue<T,P>` | O(log n) push/pop | .NET 6+; needed for Top K |

## C# interview notes
- `dict.TryGetValue(k, out var v)` beats `ContainsKey` + indexer (single hash lookup).
- Char count array `int[26]` is faster than `Dictionary<char,int>` for lowercase — and interviewers like knowing you can pick it.
- Avoid LINQ (`GroupBy`, `OrderBy`) for the core logic — fine for quick scripts, but interviews want explicit control; also know it adds allocations/overhead.
- Validate constraints first: "1 <= nums.length <= 10^4" tells you the edge cases (len 1, empty, all duplicates).

## Review notes (append after each solve)
*(format: pattern → why it worked → where else it applies → my mistake)*

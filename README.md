#NSequenceComparer
This library allows you to compare two sequences to find the differences. 
##Why?
I found many programs does this using recursion, but, you cannot rely on recursion when comparing large sequence.
This library uses [dynamic programming](http://en.wikipedia.org/wiki/Dynamic_programming) to avoid stack overflow exceptions.
##How?
This library is very simple to use. It exposes two public methods
* GetLongestCommonSubsequence()
* GetDifferences()

#### GetLongestCommonSubsequence()
This returns the longest common subsequence of input sequences.

```c#
var firstSequence = new List<int> {1, 2, 4, 5};
var secondSequence = new List<int> {1, 2, 3, 4}
var lcs = NComparer.GetLongestCommonSubseqeunce<int>(first, sequence); // using static method
var lcs = firstSequence.GetLongestCommonSubseqeunce(sequence); // using extension method
```
#### GetDifferences()
This returns the differences of input sequences.

```c#
var firstSequence = new List<int> {1, 2, 4, 5};
var secondSequence = new List<int> {1, 2, 3, 4}
var diff = NComparer.GetDifferences<int>(first, sequence); // using static method
var diff = firstSequence.GetDifferences(sequence); // using extension method
```
The differences list will have one for each unique items in two sequences. The differences kind will be as follows
* Unchanged - for items appearing in both sequences
* Added - for items only appering in the second sequence
* Deleted - for items only appearing in the first sequence
* Modified - not used for now

## What next?
1. Support for complex types
2. Implement AreSame method with various options like qignore order, casing, etc...
3. and more...

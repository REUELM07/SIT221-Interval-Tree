# Submitted by: REUEL MENPARA --> 2510994818
# SIT221 Task 1.3D - Interval Tree Tutorial

## System Overview
This project demonstrates an **Interval Tree**, a data structure used to efficiently find overlapping intervals.

The project explains how intervals are stored in a tree and how the `max` value helps the search algorithm skip unnecessary subtrees.

## Software Used
- C#
- Visual Studio Code
- .NET

## What is an Interval Tree?
An Interval Tree is a tree-based data structure used to find intervals that overlap with a given query interval.

Each node stores:
- Interval
- Maximum endpoint (`max`)
- Left child
- Right child

The `max` value helps determine whether the left subtree can contain an overlapping interval.

## System Working
The user provides a query interval.

The search algorithm:
1. Checks whether the current node overlaps with the query.
2. If an overlap is found, it returns the node.
3. Checks `left.max` to determine whether the left subtree can contain an overlap.
4. If not, the left subtree is skipped.
5. The search continues in the right subtree.

The system works as follows:

Query Interval --> Interval Tree --> Check Overlap --> Use max for Pruning --> Result

## Example

Stored intervals:
- [5, 12]
- [10, 20]
- [15, 30]

Query:
- [18, 22]

Result:
- [15, 30]

## Complexity
- Search: O(log n) for a balanced tree
- Space: O(n)

## Files Uploaded
1) C# Interval Tree implementation
2) C# project file
3) Interval Tree search pseudocode
4) Tutorial video

## Tutorial
YouTube Tutorial: https://youtu.be/u20S8daJKjI 

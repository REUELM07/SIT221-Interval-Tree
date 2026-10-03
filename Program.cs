class Interval
{
    public int Start;
    public int End;

    public Interval(int start, int end)
    {
        Start = start;
        End = end;
    }
}

class Node
{
    public Interval Interval;
    public int Max;

    public Node Left;
    public Node Right;

    public Node(Interval interval)
    {
        Interval = interval;
        Max = interval.End;
        Left = null;
        Right = null;
    }
}

class IntervalTree
{
    private Node root;

    //check whether two intervals overlap
    private bool DoOverlap(Interval a, Interval b)
    {
        return a.Start <= b.End &&
               b.Start <= a.End;
    }

    // search for one interval that overlaps the query
    private Node Search(Node node, Interval query)
    {
        //base case
        if (node == null)
            return null;

        //check the current interval
        if (DoOverlap(node.Interval, query))
            return node;

        // search left if the subtree can contain an overlap
        if (node.Left != null &&
            node.Left.Max >= query.Start)
        {
            return Search(node.Left, query);
        }

        // otherwise skip the left subtree and search right
        return Search(node.Right, query);
    }

    // update the maximum endpoint of a node
    private void UpdateMax(Node node)
    {
        if (node == null)
            return;

        node.Max = node.Interval.End;

        if (node.Left != null)
            node.Max = Math.Max(node.Max, node.Left.Max);

        if (node.Right != null)
            node.Max = Math.Max(node.Max, node.Right.Max);
    }
}
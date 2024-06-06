public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value == Data) return; // Problem 1: Ignore duplicates
        if (value < Data) {
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (value == Data) return true; // Base case
        if (value < Data) {
            return Left != null && Left.Contains(value); // Recursive call on left subtree
        }
        else {
            return Right != null && Right.Contains(value); // Recursive call on right subtree
        }
    }

    public int GetHeight() {
        // TODO Start Problem 4
        int leftHeight = Left?.GetHeight() ?? 0; // Height of left subtree
        int rightHeight = Right?.GetHeight() ?? 0; // Height of right subtree
        return 1 + Math.Max(leftHeight, rightHeight); // Height of the current node
    }
}
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue(); // This code will call the PriorityQueue file / class
        Console.WriteLine("Initial Queue: " + priorityQueue); // At first, the terminal will display an empty array

        // Test Cases

        // Test 1
        // Scenario: The purpose of this test is to check what will happen if there are two items with the same highest priority.
        // In this scenario, Item2 and Item4 have the same priority number (3). When we run the program, the terminal should display the
        // expected results. In addition, Item2 will be removed from the queue because it's closest to the front of the queue.
        // Expected Result after dequeue: [Item1 (Pri:1), Item3 (Pri:2), Item4 (Pri:3)]
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Item1", 1); // Add item 1 to the queue
        priorityQueue.Enqueue("Item2", 3);// Add item 2 to the queue
        priorityQueue.Enqueue("Item3", 2);// Add item 3 to the queue
        priorityQueue.Enqueue("Item4", 3); // Add item 4 to the queue and same priority as Item2
        Console.WriteLine("Queue After Enqueue: " + priorityQueue);
        Console.WriteLine("Dequeued: " + priorityQueue.Dequeue()); // Should dequeue Item2
        Console.WriteLine("Queue After Dequeue: " + priorityQueue);

        Console.WriteLine("---------");

        // Test 2
        // Scenario: The purpose of this test is to see if Item6 will be removed and it will only be the item with the highest priority.
        // Expected Result: Item1 (Pri:1), Item3 (Pri:2), Item4 (Pri:3), Item1 (Pri:4), Item2 (Pri:6), Item3 (Pri:3), Item4 (Pri:9), Item5 (Pri:4)
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("Item1", 4);
        priorityQueue.Enqueue("Item2", 6);
        priorityQueue.Enqueue("Item3", 3);
        priorityQueue.Enqueue("Item4", 9);
        priorityQueue.Enqueue("Item5", 4);
        priorityQueue.Enqueue("Item6", 10);
        Console.WriteLine("Queue After Enqueue: " + priorityQueue);
        Console.WriteLine("Dequeued: " + priorityQueue.Dequeue()); // Should dequeue Item6
        Console.WriteLine("Queue After Dequeue: " + priorityQueue);
        
        Console.WriteLine("---------");

        // Test 3
        // Scenario: The purpose of this line of code is to make sure that the program handles operations
        // under uncommon conditions such as an empty queue without crashing the program.
        // Expected Result: The queue is empty & Dequeued from empty queue:
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue(); // Resetting queue
        Console.WriteLine("Dequeued from empty queue: " + priorityQueue.Dequeue()); // Should show error

        Console.WriteLine("---------");

        // Test 3
        // Scenario: The purpose of this line of code is to make sure that the program will handle an operation
        // if there was an item in the queue.
        // Expected Result: Dequeued from empty queue: Item1
        Console.WriteLine("Test 4");
        priorityQueue = new PriorityQueue(); // Resetting queue
        priorityQueue.Enqueue("Item1", 5);
        Console.WriteLine("Dequeued from empty queue: " + priorityQueue.Dequeue()); // Should show error
    }
}
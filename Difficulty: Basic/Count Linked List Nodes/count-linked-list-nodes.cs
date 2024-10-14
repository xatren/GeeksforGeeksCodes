//{ Driver Code Starts
using System;
using System.Collections.Generic;

class Node {
    public int data;
    public Node next;

    public Node(int x) {
        data = x;
        next = null;
    }
}

// Position this line where user code will be pasted.

class Program {
    static void Main(string[] args) {
        int t = int.Parse(Console.ReadLine()); // Read number of test cases

        while (t-- > 0) {
            // Read input as a string and split into an array of integers
            string input = Console.ReadLine();
            string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            List<int> arr = new List<int>();

            // Convert the string tokens to integers
            foreach (var token in tokens) {
                arr.Add(int.Parse(token));
            }

            // Create the linked list from the array
            Node head = new Node(arr[0]);
            Node tail = head;

            for (int i = 1; i < arr.Count; i++) {
                tail.next = new Node(arr[i]);
                tail = tail.next;
            }

            Solution ob = new Solution();
            Console.WriteLine(ob.getCount(head)); // Output the count of nodes
        }
    }
}

// } Driver Code Ends


class Solution {
    // Function to count nodes of a linked list.
    public int getCount(Node head) {
        int count = 0;
        Node current = head;
        
        // Traverse the linked list and count the nodes.
        while (current != null) {
            count++;
            current = current.next;
        }
        
        return count;
    }
}

//{ Driver Code Starts
// Initial Template for C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode {

class GFG {
    static void Main(string[] args) {
        int testcases; // Taking testcase as input
        testcases = Convert.ToInt32(Console.ReadLine());
        while (testcases-- > 0) // Looping through all testcases
        {

            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            string elements = Console.ReadLine().Trim();
            elements = elements + " " + "0";
            int[] arr2 = Array.ConvertAll(elements.Split(), int.Parse);
            for (int i = 0; i < n; i++) {
                arr[i] = arr2[i];
            }
            Solution obj = new Solution();
            var A = obj.peakElement(arr, n);
            for (int i = 0; i < n; i++) {
                arr[i] = arr2[i];
            }
            if (A < 0 && A >= n)
                Console.WriteLine(0);
            else {
                int f = 0;
                if (n == 1 && A == 0)
                    f = 1;
                else if (A == 0 && arr[0] >= arr[1])
                    f = 1;
                else if (A == n - 1 && arr[n - 1] >= arr[n - 2])
                    f = 1;
                else if (arr[A] >= arr[A + 1] && arr[A] >= arr[A - 1])
                    f = 1;
                else
                    f = 0;
                Console.WriteLine(f);
            }
        }
    }
}

// Position this line where user code will be pasted.
// } Driver Code Ends


class Solution {
    public int peakElement(int[] arr, int n) {
        // Edge cases
        if (n == 1) return 0; // Only one element, it is the peak
        if (arr[0] >= arr[1]) return 0; // First element is the peak
        if (arr[n - 1] >= arr[n - 2]) return n - 1; // Last element is the peak
        
        // Apply binary search for peak
        return findPeak(arr, 0, n - 1);
    }

    private int findPeak(int[] arr, int low, int high) {
        // Base case: If the array has only one element
        if (low == high) {
            return low;
        }

        // Find the middle index
        int mid = low + (high - low) / 2;

        // Check if mid is a peak element
        if ((mid == 0 || arr[mid] >= arr[mid - 1]) &&
            (mid == high || arr[mid] >= arr[mid + 1])) {
            return mid;
        }

        // If the element at mid-1 is greater than mid, then there must be a peak in the left half
        if (mid > 0 && arr[mid - 1] > arr[mid]) {
            return findPeak(arr, low, mid - 1);
        }

        // Otherwise, there must be a peak in the right half
        return findPeak(arr, mid + 1, high);
    }
}


}
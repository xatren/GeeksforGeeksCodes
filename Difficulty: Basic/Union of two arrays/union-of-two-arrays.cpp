//{ Driver Code Starts
// Initial template for C++

#include <bits/stdc++.h>
using namespace std;


// } Driver Code Ends
// User function template in C++

#include <iostream>
#include <vector>
#include <unordered_set>
using namespace std;

class Solution {
public:
    // Function to return the count of number of elements in union of two arrays.
    int doUnion(vector<int>& arr1, vector<int>& arr2) {
        // Create a set to store distinct elements
        unordered_set<int> unionSet;
        
        // Insert all elements of arr1 into the set
        for (int num : arr1) {
            unionSet.insert(num);
        }
        
        // Insert all elements of arr2 into the set
        for (int num : arr2) {
            unionSet.insert(num);
        }
        
        // The size of the set is the number of distinct elements
        return unionSet.size();
    }
};




//{ Driver Code Starts.

int main() {
    int t;
    cin >> t;
    cin.ignore(); // Ignore the newline character after reading t

    while (t--) {
        vector<int> a;
        vector<int> b;

        string input;
        // For a
        getline(cin, input); // Read the entire line for the array elements
        stringstream ss(input);
        int number;
        while (ss >> number) {
            a.push_back(number);
        }

        // For b
        getline(cin, input); // Read the entire line for the array elements
        stringstream ss2(input);
        while (ss2 >> number) {
            b.push_back(number);
        }

        Solution ob;
        cout << ob.doUnion(a, b) << endl;
    }

    return 0;
}
// } Driver Code Ends
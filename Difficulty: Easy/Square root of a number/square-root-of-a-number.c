//{ Driver Code Starts
// Initial Template for C

#include <stdio.h>


// } Driver Code Ends
// User function Template for C

long long int floorSqrt(long long int n) {
    if (n < 2) {
        return n; 
    }

    long long int low = 0;
    long long int high = n;
    long long int result = 0;

    while (low <= high) {
        long long int mid = low + (high - low) / 2;
        long long int midSquared = mid * mid;

        if (midSquared == n) {
            return mid; 
        } else if (midSquared < n) {
            low = mid + 1;
            result = mid; 
        } else {
            high = mid - 1;
        }
    }

    return result; 
}




//{ Driver Code Starts.

int main() {
    int t;
    scanf("%d", &t);
    while (t--) {
        long long n;
        scanf("%ld", &n);

        printf("%ld\n", floorSqrt(n));
    }
    return 0;
}

// } Driver Code Ends
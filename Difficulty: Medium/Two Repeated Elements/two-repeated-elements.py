#User function Template for python3

class Solution:
    
    #Function to find two repeated elements.
    def twoRepeated(self, n, arr):
        #Your code here
        result = []
        for i in range(n + 2):
            index = abs(arr[i]) - 1
            if arr[index] < 0:
                result.append(abs(arr[i]))
                if len(result) == 2:
                    break
            arr[index] = -arr[index]
        return result

#{ 
 # Driver Code Starts
#Initial Template for Python 3

import math


def main():
    T = int(input())
    while (T > 0):

        n = int(input())

        arr = [int(x) for x in input().strip().split()]

        obj = Solution()
        ans = obj.twoRepeated(n, arr)
        print(ans[0], ans[1])

        T -= 1


if __name__ == "__main__":
    main()

# } Driver Code Ends
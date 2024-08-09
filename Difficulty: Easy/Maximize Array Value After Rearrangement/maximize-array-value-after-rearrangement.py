#User function Template for python3

class Solution:
    def Maximize(self, arr): 
        MOD = 10**9 + 7
        
        # Sort the array 
        arr.sort()
        
        # Calculate the maximum value 
        result = 0
        n = len(arr)
        for i in range(n):
            result = (result + arr[i] * i) % MOD
        
        return result



#{ 
 # Driver Code Starts
#Initial Template for Python 3

if __name__ == '__main__':
    t = int(input())

    for _ in range(t):
        A = list(map(int, input().strip().split()))
        # k = int(input())
        ob = Solution()
        print(ob.Maximize(A))

# } Driver Code Ends
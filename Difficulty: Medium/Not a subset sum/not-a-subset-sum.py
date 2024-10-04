#User function Template for python3

class Solution:
    def findSmallest(self, arr):
        # 1 is the smallest positive integer 
        result = 1
        
        for num in arr:
            
            if num > result:
                return result
            
            result += num
        
        return result



#{ 
 # Driver Code Starts
#Initial Template for Python 3


def main():
    t = int(input())
    for _ in range(t):
        arr = list(map(int, input().split()))
        ob = Solution()
        ans = ob.findSmallest(arr)
        print(ans)


if __name__ == "__main__":
    main()

# } Driver Code Ends
# User function Template for python3

from collections import Counter

class Solution:
    def check(self, arr1, arr2) -> bool:
        if len(arr1) != len(arr2):
            return False
        
        counter1 = Counter(arr1)
        counter2 = Counter(arr2)
        
        return counter1 == counter2





#{ 
 # Driver Code Starts
#Initial Template for Python 3

if __name__ == '__main__':
    t = int(input())
    for tc in range(t):
        arr1 = [int(x) for x in input().replace('  ', ' ').strip().split(' ')]
        arr2 = [int(x) for x in input().replace('  ', ' ').strip().split(' ')]
        ob = Solution()
        if ob.check(arr1, arr2):
            print("true")
        else:
            print("false")

# } Driver Code Ends
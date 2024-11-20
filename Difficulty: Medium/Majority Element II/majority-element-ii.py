class Solution:
    def findMajority(self, arr):
        # Step 1: Initialize two candidate variables and their counters
        candidate1, candidate2, count1, count2 = None, None, 0, 0
        
        # Step 2: Identify potential candidates
        for num in arr:
            if candidate1 == num:
                count1 += 1
            elif candidate2 == num:
                count2 += 1
            elif count1 == 0:
                candidate1, count1 = num, 1
            elif count2 == 0:
                candidate2, count2 = num, 1
            else:
                count1 -= 1
                count2 -= 1
        
        # Step 3: Verify if candidates appear more than n/3 times
        result = []
        n = len(arr)
        if arr.count(candidate1) > n // 3:
            result.append(candidate1)
        if candidate2 is not None and candidate2 != candidate1 and arr.count(candidate2) > n // 3:
            result.append(candidate2)
        
        # Return result in sorted order
        return sorted(result)




#{ 
 # Driver Code Starts
#Initial Template for Python 3


def main():
    t = int(input().strip())
    for _ in range(t):
        s = input().strip()
        nums = list(map(int, s.split()))
        ob = Solution()
        ans = ob.findMajority(nums)
        if not ans:
            print("[]")
        else:
            print(" ".join(map(str, ans)))


if __name__ == "__main__":
    main()

# } Driver Code Ends
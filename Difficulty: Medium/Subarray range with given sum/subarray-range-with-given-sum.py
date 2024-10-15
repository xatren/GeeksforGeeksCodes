#{ 
 # Driver Code Starts
#Initial Template for Python 3

# } Driver Code Ends
#User function Template for python3

class Solution:
    def subArraySum(self, arr, tar):
        count = 0
        curr_sum = 0
        sum_map = {0: 1}  # Initialize with 0 sum occurring once

        for num in arr:
            curr_sum += num
            
            # If (curr_sum - tar) exists in map, it means we've found a subarray with sum = tar
            if curr_sum - tar in sum_map:
                count += sum_map[curr_sum - tar]
            
            # Add current sum to the map or increase its count
            sum_map[curr_sum] = sum_map.get(curr_sum, 0) + 1

        return count
        

#{ 
 # Driver Code Starts.
#Initial Template for Python 3

if __name__ == "__main__":
    t = int(input())
    while t > 0:
        arr = list(map(int, input().split()))
        tar= int(input())
        ob = Solution()
        res = ob.subArraySum(arr,tar)
        print(res)
        # print("~")
        t -= 1


# } Driver Code Ends
#User function Template for python3
class Solution:
    def kthElement(self, k, arr1, arr2):
        if len(arr1) > len(arr2):
            arr1, arr2 = arr2, arr1
        
        low, high = 0, min(len(arr1), k)

        while low <= high:
            cut1 = (low + high) // 2
            cut2 = k - cut1

            if cut2 > len(arr2):
                low = cut1 + 1
                continue
            elif cut2 < 0:
                high = cut1 - 1
                continue

            left1 = arr1[cut1 - 1] if cut1 > 0 else float('-inf')
            left2 = arr2[cut2 - 1] if cut2 > 0 else float('-inf')
            right1 = arr1[cut1] if cut1 < len(arr1) else float('inf')
            right2 = arr2[cut2] if cut2 < len(arr2) else float('inf')

            if left1 <= right2 and left2 <= right1:
                return max(left1, left2)
            elif left1 > right2:
                high = cut1 - 1
            else:
                low = cut1 + 1

        return -1  




#{ 
 # Driver Code Starts
#Initial Template for Python 3


def main():

    T = int(input())

    while (T > 0):

        k = int(input())
        a = [int(x) for x in input().strip().split()]
        b = [int(x) for x in input().strip().split()]
        ob = Solution()
        print(ob.kthElement(k, a, b))

        T -= 1


if __name__ == "__main__":
    main()

# } Driver Code Ends
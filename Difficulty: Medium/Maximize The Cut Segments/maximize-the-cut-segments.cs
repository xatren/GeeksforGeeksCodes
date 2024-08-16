//{ Driver Code Starts
//Initial Template for C#


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode
{

    class GFG
    {
        static void Main(string[] args)
        {
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {
                int N = Convert.ToInt32(Console.ReadLine());

                int[] arr = new int[3];

                string elements = Console.ReadLine().Trim();
                elements = elements + " " + "0";
                arr = Array.ConvertAll(elements.Split(), int.Parse);

                Solution obj = new Solution();
                int res = obj.maximizeTheCuts(N, arr[0], arr[1], arr[2]);
                Console.Write(res+"\n");
          }

        }
    }
}

// } Driver Code Ends


//User function Template for C#

class Solution {
    public int maximizeTheCuts(int n, int x, int y, int z) {
        int[] dp = new int[n + 1];
        for (int i = 0; i <= n; i++) {
            dp[i] = -1;
        }

        dp[0] = 0;

        for (int i = 1; i <= n; i++) {
            if (i >= x && dp[i - x] != -1) {
                dp[i] = Math.Max(dp[i], 1 + dp[i - x]);
            }

            if (i >= y && dp[i - y] != -1) {
                dp[i] = Math.Max(dp[i], 1 + dp[i - y]);
            }

            if (i >= z && dp[i - z] != -1) {
                dp[i] = Math.Max(dp[i], 1 + dp[i - z]);
            }
        }

        return dp[n] == -1 ? 0 : dp[n];
    }
}


        

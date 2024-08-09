//{ Driver Code Starts
// C# code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DriverCode;

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
                var ip = Console.ReadLine().Trim().Split(' ');
                int n = int.Parse(ip[0]);
                int m = int.Parse(ip[1]);
                int[] arr = new int[n];
                ip = Console.ReadLine().Trim().Split(' ');
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(ip[i]);
                }
                ip = Console.ReadLine().Trim().Split(' ');
                int[] arr1 = new int[m];
                for (int i = 0; i < m; i++)
                {
                    arr1[i] = int.Parse(ip[i]);
                }
                Solution obj = new Solution();
                var res = obj.isSubset(arr, arr1, n, m);
                Console.WriteLine(res);
            }
        }
    }
}
// } Driver Code Ends


//User function Template for C#

//using System;
//using System.Collections.Generic;

class Solution
{
    public string isSubset(int[] a1, int[] a2, int n, int m)
    {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        
        foreach (int num in a1)
        {
            if (frequencyMap.ContainsKey(num))
            {
                frequencyMap[num]++;
            }
            else
            {
                frequencyMap[num] = 1;
            }
        }
        
        foreach (int num in a2)
        {
            if (!frequencyMap.ContainsKey(num) || frequencyMap[num] == 0)
            {
                return "No";
            }
            frequencyMap[num]--;
        }
        
        return "Yes";
    }
}

#User function Template for python3
'''
class Job:
    
    # Job class which stores profit and deadline.
    
    def __init__(self,profit=0,deadline=0):
        self.profit = profit
        self.deadline = deadline
        self.id = 0
'''        

class Solution:
    
    def JobScheduling(self,Jobs,n):
        
        Jobs.sort(key=lambda x: x.profit, reverse=True)
        
        max_deadline = max(job.deadline for job in Jobs)
        time_slots = [-1] * (max_deadline + 1)  
        max_profit = 0
        count_jobs = 0
        
        for job in Jobs:
            for t in range(min(job.deadline, max_deadline), 0, -1):
                if time_slots[t] == -1:  
                    time_slots[t] = job.id
                    max_profit += job.profit
                    count_jobs += 1
                    break
        
        return count_jobs, max_profit


#{ 
 # Driver Code Starts
#Initial Template for Python 3
import atexit
import io
import sys


#Contributed by : Nagendra Jha
class Job:
    '''
    Job class which stores profit and deadline.
    '''

    def __init__(self, profit=0, deadline=0):
        self.profit = profit
        self.deadline = deadline
        self.id = 0


if __name__ == '__main__':
    test_cases = int(input())
    for cases in range(test_cases):
        n = int(input())
        info = list(map(int, input().strip().split()))
        Jobs = [Job() for i in range(n)]
        for i in range(n):
            Jobs[i].id = info[3 * i]
            Jobs[i].deadline = info[3 * i + 1]
            Jobs[i].profit = info[3 * i + 2]
        ob = Solution()
        res = ob.JobScheduling(Jobs, n)
        print(res[0], end=" ")
        print(res[1])

# } Driver Code Ends
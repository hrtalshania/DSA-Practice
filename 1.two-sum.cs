/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var length=nums.Length;
        var solution = new int[2];
        var loopRestart =0;

        for (int i = loopRestart; i < length; i++)
        {
            if(nums[i+1]== lenght)
            {
                loopRestart=0;
            }

            if (nums[i] + nums[i + 1] == target)
            {
                solution[i]=nums[i];
                solution[i+1]=nums[i+1];

                return solution;
            }
            return new int[];
        }
    }
}

//
/*
nums =[3,2,4]  , target =6
length= 3 =nums of lenght

for i=0 ...it goes till i<lenght (i<3) = 2



*/



// @lc code=end


public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //解答用
        Dictionary<int, int> ans = new Dictionary<int, int>();

        for (int i=0; i<nums.Length; i++)
        {
            //差分
            int left_num = target - nums[i]; 
            
            //差分の検知
            if(ans.ContainsKey(left_num))
            {
                return new int[] {ans[left_num], i};
            }
            else if(!ans.ContainsKey(nums[i]))
            {
                ans.Add(nums[i], i);
            }

        }
        return null;
    }
}
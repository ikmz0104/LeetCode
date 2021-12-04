public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {
        
        //ソートします。
        nums = Array.Sort(nums);
        
        int [] ans = new int[];
        
        //targetに一致するnums[i]のindexを求めます。
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == target)
            {
                ans[i] = nums[i];
            }
        }
        
        return ans;
    }
}
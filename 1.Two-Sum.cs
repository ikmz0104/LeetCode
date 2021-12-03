public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        //空のキーバリューストアを宣言
        Dictionary<int, int> ans = new Dictionary<int, int>();

        for (int i=0; i<nums.Length; i++)
        {
            int diff = target - nums[i]; 
            
            if(ans.ContainsKey(diff)
            {
                return new int[] {ans[i], i};
            }
            //空のansにkeyvalueを追加
            else if(!ans.ContainsKey(nums[i]))
            {
                ans.Add(nums[i], i);
            }

        }
        return null;
    }
}
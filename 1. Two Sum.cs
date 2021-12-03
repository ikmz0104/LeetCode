public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        //空のキーバリューストアを宣言 {Key, Value} = {0, 0}
        Dictionary<int, int> ans = new Dictionary<int, int>();

        for (int i=0; i<nums.Length; i++)
        {
            int SearchKey = target - nums[i]; 
            
            if(ans.ContainsKey(SearchKey))
            {
                return new int[] {ans[SearchKey], i};
            }
            //空のansに{Key, Value}を追加
            else
            {
                ans.Add(nums[i], i);
            }
        }
        return null;
    }
}
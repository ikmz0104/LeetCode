public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //var オブジェクト名 = new Dictionary<Keyの型名, Valueの型名>()
        var ans = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length(); i++)
        {
            //nums[i], nums[i+1]
            var Diff = target - nums[i];
            
            //DictionaryでDiffを見つける
            if(ans.ContainsValue(Diff))
            {
                return new int[]();　//ここ書けるようにまた明日
            }
            else
            {
                ans.add(i, nums[i]);
            }
            return null;
        }
    }
}
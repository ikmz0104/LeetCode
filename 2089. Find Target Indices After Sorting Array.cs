public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {
        
        int[] ans = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            ans[i] = nums[i];
        }
        
        //ソートします。
        Array.Sort( ans );
        
        //sort_i
        int[] sort_i = new int[nums.Length];
        
        //targetに一致するnums[i]のindexを求めます。
        for(int i = 0; i < nums.Length; i++)
        {
            if(ans[i] == target)
            {
                sort_i[i] = i;
            }
        }
        
        return sort_i;

        //余計な配列要素の0を削除したいがうまくいかない
    }
}

// Wrong Answer
// Runtime: 146 ms
// Your input
// [1,2,5,2,3]
// 2
// Output
// [0,1,2,0,0]
// Expected
// [1,2]
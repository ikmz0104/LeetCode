public class Solution {
    public int MinimumDeletions(int[] nums) {
        if(nums.Length == 1)
        {
            return 1;
        }
        
        int minimum = 0;
        int maximum = 0;
        
        //最大値と最小値の場所を知る
        for (int i=0; i < nums.Length; i++)
        {
            if(i == 0)
            {
                minimum == nums[0];
                maximum == nums[0];
            }
            
            if(nums[i] >= maximum)
            {
                maximum = nums[i];
                maximum_i = i;
            }
            else if(minimum >= nums[i])
            {
                minimum = nums[i];
                minimum_i = i; 
            }
            else
            {
                break;
            }
        }
        
        //最大値と最小値を削除するための最小工数を出す
        
        //配列の前半分の長さに両方収まる
        if(minimum_i and maximum_i <= nums.Length)   
        {
            if (minimum_i < maximum_i)
            {
                return maximum_i;
            }
            else
            {
                return minimum_i;
            }
        }
        
        //配列の後半分の長さに両方収まる（配列の長さが偶数とは限らないと気づいて詰んだ）
        if(minimum_i and maximum_i <= nums.Length)   
        {
            if (minimum_i < maximum_i)
            {
                return maximum_i;
            }
            else
            {
                return minimum_i;
            }
        }
        
    }
}
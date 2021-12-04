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
        
        //最大値と最小値の配列の順番に対して、最大と最小を求める
        int[] numbers = { maximum_i, minimum_i }; 
        int max_order = (numbers.Max());
        int min_order = (numbers.Min());
        
        //max_orderが配列の長さの半分以下の場合
        if(max_order <= nums.Length / 2)
        {
            return max_order; 
        }
        
        //max_orderが配列の長さの半分より大きい場合
        else if(max_order > nums.Length / 2)
        {
            return min_order + (nums.Length - max_order);
        }
        else
        {
            return null;
        }
    }
}
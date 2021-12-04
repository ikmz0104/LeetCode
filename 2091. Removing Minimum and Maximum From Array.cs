public class Solution
{
        public int MinimumDeletions(int[] nums)
        {
            //例外を１番上にさらすのです。
            if(nums.Length <= 2)
            {
                return nums.Length;
            }
            
            //最大値と最小値のindexを知るのです。
            int Min_index = 0;
            int Max_index = 0;
            int Minimum_num = nums[minIndex];
            int Maximum_num = nums[maxIndex];
            
            for(int i=0; i<nums.Length; i++)
            {
                if(nums[i] < Minimum_num)
                {
                    Minimum_num = nums[i];
                    Min_index = i
                }
                else if(nums[i] > Maximum_num)
                {
                    Maximum_num = nums[i];
                    Max_index = i
                }
            }
            
            //得られたMin_indexとMax_indexの位置を比較するのです。
            //Min_indexがMax_indexよりも大きいとき（これはどっちが大きいとかは関係ない、大小による場合分けは一つでOK）
            if(Min_index > Max_index)
            {
                int Tmp_index = Min_index;
                Min_index = Max_index;
                Max_index = Tmp_index;
            }
            
            //最小値を一つ得る
            int minmin = ,,
        }
}

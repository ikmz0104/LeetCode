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
            int left_num = 0;
            int right_num = 0;
            
            for(int i=0; i<nums.Length; i++)
            {
                if(nums[i] < Minimum_num)
                {
                    Minimum_num = nums[i];
                    Min_index = i;
                }
                else if(nums[i] > Maximum_num)
                {
                    Maximum_num = nums[i];
                    Max_index = i;
                }
            }
            
            //Min_indexとMax_indexをシンプルに比較するのです。
            if(Min_index < Max_index)
            {
                left_num = Min_index;
                right_num = Max_index;
            }
            else if(Min_index > Max_index)
            {
                left_num = Max_index;
                right_num = Min_index;
            }
            
            //最小工数で最大値と最小値を省いていくのです。
            
        }
}

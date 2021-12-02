public class Solution {
    public int RomanToInt(string s) {
        int ans = 0;
        //3文字目まで各桁のValueの対応を見る
        for(int i=0; i<s.Length; i++)
        {
            if (s[i] == 'I')
            {
                ans += 1;
            }
            else
            {
                break;
            }
        }
        return ans;
    }
}
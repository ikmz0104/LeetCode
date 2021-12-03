public class Solution {
    public int RomanToInt(string s) {
        
        //ハッシュテーブルの宣言
        Dictionary<string, int> KeyValueData = new Dictionary<string, int>();
        
        //値のセット
        {'I', 1};
        {'V', 5};
        {'X', 10};
        {'L', 50};
        {'C', 100};
        {'D', 500};
        {'M', 1000};
        
        //値を取り出す
        int Value = KeyValueData["Key1"];
        
        //返却される値をansに加算していく
        int ans = 0;
        
        //1文字目と2文字目のValueを比較
        for (int i=0; i<s.Length; i++)
        {
            if(s[i] < s[i+1])
            {
                ans = V - I;
                return ans;
            }
        }
    }
}
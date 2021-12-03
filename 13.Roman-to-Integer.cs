public class Solution {
    //動的返却
    public int RomanToInt(string s) {
            int AnsValue = 0;
            int TmpValue = 0;

        //文字列の末尾から攻めるスタイル
            for(int i=1; i <= s.Length; i++)
            {
                if (StaticRomanToInt(s[s.Length - i]) >= TmpValue)
                {
                    AnsValue += StaticRomanToInt(s[s.Length - i]);
                }
                else
                {
                    AnsValue -= StaticRomanToInt(s[s.Length - i]);
                }
                TmpValue = StaticRomanToInt(s[s.Length - i]);
            }
        return AnsValue;
    }
    
    //静的返却
    static int StaticRomanToInt(char s) 
    {
            switch(s)
            {
                case 'I':
                    return 1;
                    break;
                case 'V':
                    return 5;
                    break;
                case 'X':
                    return 10;
                    break;
                case 'L':
                    return 50;
                    break;
                case 'C':
                    return 100;
                    break;
                case 'D':
                    return 500;
                    break;
                case 'M':
                    return 1000;
                    break;
                default:
                    Console.WriteLine("defaultが実行されました");
                    return 0;
                    break;
            }
    }
} 
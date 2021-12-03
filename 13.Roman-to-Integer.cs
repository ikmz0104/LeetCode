public class Solution {
    //動的返却
    public int RomanToInt(string s) {
            int InitialValue = 0;
            int AnsValue = 0;

            for(int i=1; i <= s.Length; i++)
            {
                //文字列のi番目のValue < i+1番目のValue　なら差
                if (StaticRomanToInt(s[s.Length - i]) >= AnsValue)
                {
                    InitialValue += StaticRomanToInt(s[s.Length - i]);
                }
                //文字列のi番目のValue > i+1番目のValue　なら和
                else
                {
                    InitialValue -= StaticRomanToInt(s[s.Length - i]);
                }

                AnsValue = StaticRomanToInt(s[s.Length - i]);
            }
        return InitialValue;
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
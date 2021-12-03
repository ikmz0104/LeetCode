public class Solution {
    //動的返却
    public int RomanToInt(char roman) {
        
        int ans1 = 0;
        int ans2 = 0;
        
        for(int i=0; i<roman.Length; i++)
        {
            //文字列のi番目のValue < i+1番目のValue　なら差
            if (roman[i] < roman[i+1])
            {
                
            }
            //文字列のi番目のValue > i+1番目のValue　なら和
            else
            {

            }
        }        

    }
    
    //静的返却
    static int StaticRomanToInt(char roman) {
        switch(roman)
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
                break;
        }
    }
} 
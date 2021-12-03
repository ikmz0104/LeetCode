public class Solution {
    public bool IsPalindrome(int num) {
        
        //例外を先に除く
        if ()
        {
            return false;
        }
        
        int reverse = 0;
        int addnum;
        int tmp;
        
        //動的変数にインプットのnumを代入
        tmp = num;
        
        //121
        while(tmp != 0)
        {
            addnum = tmp % 10;
            reverse = reverse * 10 + addnum;
            tmp = tmp / 10;
        }
        
        if (reverse == num)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
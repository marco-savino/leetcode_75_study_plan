public class Solution10 {
    public int LongestPalindrome(string s) 
    {
        int maxLength, oddCount; 

        int[] charCount = new int[256];

        for(int i=0; i<s.Length; i++)
        {
            charCount[s[i]]++;
        }

        oddCount = 0;
        maxLength = 0;
        for(int i=0; i<charCount.Length; i++)
        {
            if(charCount[i] % 2 != 0)
                oddCount++;
                
            maxLength = maxLength + charCount[i];             
        }

        if(oddCount != 0)
            maxLength = maxLength - oddCount + 1;

        return maxLength;
    }
}
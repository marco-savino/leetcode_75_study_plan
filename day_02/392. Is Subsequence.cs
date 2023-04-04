/*
Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters 
without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

 

Example 1:

Input: s = "abc", t = "ahbgdc"
Output: true

Example 2:

Input: s = "axc", t = "ahbgdc"
Output: false

 

Constraints:

    0 <= s.length <= 100
    0 <= t.length <= 104
    s and t consist only of lowercase English letters.

 
Follow up: Suppose there are lots of incoming s, say s1, s2, ..., sk where k >= 109, and you want to check one by one to see if t has its subsequence. 
In this scenario, how would you change your code?
*/

// this versione seems faster even if It has two innested For... maybe because the outer For Is based on the shorter string?

public class Solution04 {
    public bool IsSubsequence(string s, string t) {

        bool match = false;
        int nextIndex = 0, matchCount = 0;

        for(int i=0; i<s.Length; i++)
        {
            match = false;
            for(int j=nextIndex; j<t.Length && !match; j++)
            {
                if(s[i] == t[j])
                {
                    nextIndex = j+1;
                    match = true;
                    matchCount++;
                }
            }

            if(!match)
                return false;
        }

        if(matchCount < s.Length)
            return false;

        return true;
    }
}
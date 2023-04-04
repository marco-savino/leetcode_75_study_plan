/*
Given two strings s and t, determine if they are isomorphic.

Two strings s and t are isomorphic if the characters in s can be replaced to get t.

All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, 
but a character may map to itself.

 

Example 1:

Input: s = "egg", t = "add"
Output: true

Example 2:

Input: s = "foo", t = "bar"
Output: false

Example 3:

Input: s = "paper", t = "title"
Output: true

 

Constraints:

    1 <= s.length <= 5 * 104
    t.length == s.length
    s and t consist of any valid ascii character.

*/

// this does not work *sad face*

public class Solution03b {
    public bool IsIsomorphic(string s, string t) {

        Dictionary<char, int> sDict = new Dictionary<char, int>();
        Dictionary<char, int> tDict = new Dictionary<char, int>();

        for(int i=0; i<s.Length; i++)
        {
            if(sDict.ContainsKey(s[i]))
                sDict[s[i]]++;
            else
                sDict.Add(s[i], 1);

            if(tDict.ContainsKey(t[i]))
                tDict[t[i]]++;
            else
                tDict.Add(t[i], 1);
        }

        for(int i=0; i<s.Length; i++)
        {
            sDict[s[i]]--;
            tDict[t[i]]--;

            if(sDict[s[i]] != tDict[t[i]])
                return false;
        }
        

        return true;

    }
}

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


public class Solution03 {
    public bool IsIsomorphic(string s, string t) {

        for(int i=0; i<s.Length; i++)
            for(int j=i; j<s.Length; j++)
                if(s[j] == s[i] && t[j] != t[i] || s[j] != s[i] && t[j] == t[i])
                        return false;

        return true;
    }
}


/* notes:

egg, add;
s[0] = 'e', t[0]='a';
search other 'e' in s: not present;
search other 'a' in t: not present;
==> Ok, 'e' can be replaced with 'a';

s[1] = 'g', t[1] = 'd';
search other 'g' in s: found at i=2, save position;
search other 'd' in t: found at i=2, save position;
Does each index correspond to the other? True;
==> Ok, 'g' can be replaced with 'd'

==> s and t are isometric

*/


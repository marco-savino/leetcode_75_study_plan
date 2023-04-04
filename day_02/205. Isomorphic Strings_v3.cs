public class Solution03c {

    // "Isometric" means that all the occurrences of a specifc character from a word can be replaced with another certain character, 
    // for all characters of the word, to obtain another word.
    // This means finding a unique link from each character of the first word to each character of the second word.
    public bool IsIsomorphic(string s, string t) {

        int[] sCharCount = new int[256]; // one cell for each ASCII character
        int[] tCharCount = new int[256];

        int sCharAsciiIndex, tCharAsciiIndex;
        
        for(int i=0; i<s.Length; i++)
        {
            sCharAsciiIndex = (int) s[i];
            tCharAsciiIndex = (int) t[i];

            // if the value of the occurrences does not match, then a match has already happened before for one of the two characters,
            // so that specific character is already linked to another one
            if(sCharCount[sCharAsciiIndex] != tCharCount[tCharAsciiIndex])
                return false;

            sCharCount[sCharAsciiIndex] = i + 1; // a specific character assumes values of the index plus one
            tCharCount[tCharAsciiIndex] = i + 1; // plus one is necessary to distinguish the first case i=0 from the starting condition (count[x]=0)
            // this means linking two characters to each other by the index of their most recent occurrence
        }

        return true;

    }
}
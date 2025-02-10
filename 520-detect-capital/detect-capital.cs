public class Solution {
    public bool DetectCapitalUse(string word) {
        for (int i = 1; i < word.Length; ++i)
        {
            if (char.IsUpper(word[1]) != char.IsUpper(word[i]) ||
                char.IsLower(word[0]) && char.IsUpper(word[i]))
            {
                return false;
            }
        }
        return true;
    }        
}
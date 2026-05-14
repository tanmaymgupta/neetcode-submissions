public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0, right = s.Length - 1;

        while (left < right)
        {
            // Skip non-alphanumeric characters
            while (left < right && !Char.IsLetterOrDigit(s[left]))
                left++;
            while (left < right && !Char.IsLetterOrDigit(s[right]))
                right--;

            // Compare ignoring case
             if (Char.ToLower(s[left]) != Char.ToLower(s[right]))
                return false;

            left++;
            right--;
        }

        return true;
    }
}

public class Solution {

    // Encode a list of strings to a single string
    public string Encode(List<string> strs)
    {
        var sb = new StringBuilder();
        foreach (var s in strs)
        {
            // Format: length#string
            sb.Append(s.Length).Append('#').Append(s);
        }
        return sb.ToString();
    }

    // Decode a single string back to a list of strings
    public List<string> Decode(string s)
    {
        var result = new List<string>();
        int i = 0;

        while (i < s.Length)
        {
            // Find the separator '#'
            int j = i;
            while (s[j] != '#') j++;
            
            // Extract length
            int length = int.Parse(s.Substring(i, j - i));
            
            // Extract the string of that length
            string str = s.Substring(j + 1, length);
            result.Add(str);

            // Move pointer forward
            i = j + 1 + length;
        }

        return result;
    }
}

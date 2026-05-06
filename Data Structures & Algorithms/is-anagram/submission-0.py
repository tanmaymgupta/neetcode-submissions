class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if(len(s) != len(t)):
            return False
        s_dict:Dict[str, int]={}
        t_dict:Dict[str, int]={}
        for index, char in enumerate(s):
            if char in s_dict:
                s_dict[char]=s_dict[char]+1
            else:
                s_dict[char]=1
            
            t_char = t[index]
            if t_char in t_dict:
                t_dict[t_char]=t_dict[t_char]+1
            else:
                t_dict[t_char]=1
        
        if s_dict == t_dict:
            return True

        return False


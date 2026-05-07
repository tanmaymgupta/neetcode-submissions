class Solution:
    def getCharDict(self, s:str) -> frozenset:
        s_dict: Dict = defaultdict(int)
        for index, char in enumerate(s):
            if char in s_dict:
                s_dict[char]=s_dict[char]+1
            else:
                s_dict[char]=1

        return frozenset(s_dict.items())

    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        group_dict: Dict[frozenset, List[str]] = {}
        for string in strs:
            char_dict=self.getCharDict(string)
            if char_dict in group_dict:
                group_dict[char_dict].append(string)
            else:
                group_dict[char_dict] = [string]

        return list(group_dict.values())

        
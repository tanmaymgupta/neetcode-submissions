class Solution:

    def counter (self, nums: List[int]) -> Dict[int,int]:
        counter_dict: Dict[int,int]={}
        for num in nums:
            if num in counter_dict:
                counter_dict[num]=counter_dict[num]+1
            else:
                counter_dict[num]=1

        return counter_dict

    
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        freq = self.counter(nums)
        freq_bucket:List[List[int]] = [[] for _ in range(len(nums) + 1)]
        
        #putting the frequency in buckets
        for key,value in freq.items():
            freq_bucket[value].append(key)
        
        result_list: List[int] = []
        for freq_key in range(len(freq_bucket) - 1, 0, -1):
            for num in freq_bucket[freq_key]:
                result_list.append(num)
                if len(result_list) == k:
                    return result_list
        return result_list
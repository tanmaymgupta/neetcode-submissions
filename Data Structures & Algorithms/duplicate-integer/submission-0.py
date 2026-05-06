class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        numbers:Set[int]= set()
        for num in nums:
            if(num in numbers):
                return True
            else:
                numbers.add(num)

        return False


        
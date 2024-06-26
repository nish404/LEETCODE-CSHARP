/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.
 
Example 1:
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

Example 2:
Input: nums = [3,2,4], target = 6
Output: [1,2]

Example 3:
Input: nums = [3,3], target = 6
Output: [0,1]
 
Constraints:
	• 2 <= nums.length <= 104
	• -109 <= nums[i] <= 109
	• -109 <= target <= 109
	• Only one valid answer exists.
 
Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
*/

public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(dictionary.ContainsKey(nums[i]))
            {
                return new int[]{dictionary[nums[i]], i};               
            }
            else if(!dictionary.ContainsKey(target - nums[i]))
            {
                dictionary.Add(target -nums[i], i);                  
            }          
        }        
        return new int[]{0, nums.Length};
    }
}

public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
       Dictionary<int, int> map = new Dictionary<int, int>();
        
        // Create the map
        for(int i = 0 ; i < nums.Length; i++)
        {
            map.Add(nums[i], i);
        }
        foreach(var kvPair in map)
        {
            Console.WriteLine($"{kvPair.Key}:{kvPair.Value}");
        }
        
        for(int i = 0; i < nums.Length; i++){
            int number = nums[i];
            int x = target - number;
            
            if (number != x && map.ContainsKey(x)){
                return new int[]{i, map[x]};
            }
        }
        return null;
           
      }
}


public int[] TwoSum(int[] nums, int target) {
    Dictionary<int, int> map = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++) {
        int complement = target - nums[i];
        if (map.ContainsKey(complement)) {
            return new int[] { map[complement], i };
        }
        map[nums[i]] = i;
    }
    throw new ArgumentException("No two sum solution");
}

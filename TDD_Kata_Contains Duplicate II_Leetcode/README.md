# TDD Kata:Contains Duplicate II　

From: <a href="https://leetcode.com/problems/contains-duplicate-ii/">Leet code 219:Contains Duplicate II </a>


<h3>Description:</h3>
<p>
Given an array of integers and an integer k, 
find out whether there are two distinct indices i 
and j in the array such that nums[i] = nums[j] and 
the absolute difference between i and j is at most k.
</p>

<h3>Scenario:</h3>
<hr/>
<p>
Given int[] nums</br> 
And int k<br/>
When  nums[i] == nums[j] exists</br>
And |j-i| <= k</br>
Then return true
</p>
<hr/>

<p>
Given int[] nums</br> 
And int k<br/>
When  nums[i] == nums[j] doesn't exist</br>
Then return false
</p>
<hr/>
<p>
Given int[] nums</br> 
And int k<br/>
When  nums[i] == nums[j] exists</br>
And |j-i| > k</br>
Then return false
</p>
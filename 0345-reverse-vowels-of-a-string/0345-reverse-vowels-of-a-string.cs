public class Solution {
    public string ReverseVowels(string s)
 {
     
         char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
         char[]arr = s.ToCharArray();
         int left = 0;
         int right = s.Length - 1;

         while (left<right)
         {
             if (!vowels.Contains(arr[left]))
             {
                 left++;
             }
             else if (!vowels.Contains(arr[right]))
             {
                 right--;
             }
             else
             {
                 (arr[left], arr[right]) = (arr[right], arr[left]); 
                 left++;
                 right--;

             }
         }
     
     return new string(arr); 
 }
}
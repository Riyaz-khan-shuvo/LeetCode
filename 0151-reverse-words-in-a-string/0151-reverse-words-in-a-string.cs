public class Solution {
     public string ReverseWords(string s)
   {
       string[] words = s.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
       string newString = "";

       for (int i = 0; i < words.Length; i++)
       {
           //newString += words[words.Length - i - 1]+" ";
           newString += words[words.Length - i - 1] + (i < words.Length - 1 ? " " : "");
       }

       return newString;
   }
}
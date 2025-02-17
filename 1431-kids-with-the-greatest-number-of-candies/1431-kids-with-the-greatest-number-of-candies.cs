public class Solution {
  public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
 {

     int maxCandie = 0;

     for (int i = 0; i < candies.Length; i++)
     {
         if (candies[i] > maxCandie)
         {
             maxCandie = candies[i];
         }
     }
     IList<bool> result = new List<bool>();
     foreach (int i in candies)
     {
         if (i + extraCandies >= maxCandie)
         {
             result.Add(true);
         }
         else
         {
             result.Add(false);
         }
     }

     return result;
 }



}
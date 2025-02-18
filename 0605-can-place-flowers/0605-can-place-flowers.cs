public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n)
{
    int length = flowerbed.Length;
 
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (flowerbed[i] == 0)
        {
            bool isEmptyLeft = (i == 0) || (flowerbed[i - 1] == 0);
            bool isEmptyRight = (i == length - 1) || (flowerbed[i + 1] == 0);

            if (isEmptyLeft && isEmptyRight)
            {
                flowerbed[i] = 1; 
                count++; 
            }
        }

        if (count >= n)
        {
            return true;
        }
    }
    return count >= n;

}
}
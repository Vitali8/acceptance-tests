namespace AcceptanceTests
{
    class TaskFour
    {
        public static int getWaterAmount(int[] asphaltHeights)
        {
            int result = 0;
            int left = 0;
            int right = asphaltHeights.Length - 1;//останній елемент послідовності
            int leftMax = 0, rightMax = 0;
            while (left <= right)
            {
                if (leftMax < rightMax)
                {
                    int height = asphaltHeights[left++];
                    if(leftMax < height)
                        leftMax = height;
                    result += leftMax - height;
                }
                else
                {
                    int height = asphaltHeights[right--];
                    if(rightMax < height)
                        rightMax = height;
                    result += rightMax - height;
                }
            }
            return result;
        }
    }
}

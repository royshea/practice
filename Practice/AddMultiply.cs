namespace Practice
{
    public class AddMultiply
    {
        public static int[] makeExpression(int y)
        {
            var x = new int[] { 0, 0, 0 };
            if (y % 2 == 0)
            {
                x[2] = 2;
                
            }
            else
            {
                x[2] = 3;
            }
            x[1] = 2;
            x[0] = (y - x[2]) / x[1];

            while (x[0] == 1 || x[0] == 0)
            {
                x[2] += 2;
                x[0] = (y - x[2]) / x[1];
            }
            x[0] = (y - x[2]) / x[1];
            return x;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellsTriangle
{
    public class HellsTriangleProcessor
    {
        public long GetMaxTotal(int[][] triangle)
        {
            if (triangle == null)
                throw new ArgumentNullException(nameof(triangle));

            long result = 0;
            long?[] triangleSum = new long?[triangle.Length];
            for (int i = triangle.Length-1; i >= 0; i--)
            {
                if (triangle[i].Length != i + 1)
                    throw new InvalidOperationException();

                if (i == 0)
                {
                    result = triangleSum[0] ?? triangle[0][0];
                }
                else
                {
                    for(int j = 0; j < i; j++)
                    {
                        long left = triangleSum[j] ?? triangle[i][j];
                        long right = triangleSum[j + 1] ?? triangle[i][j + 1];
                        long maxNode = Math.Max(left, right);

                        triangleSum[j] = maxNode + triangle[i - 1][j];
                    }
                }

            }
            return result;
        }
    }
}

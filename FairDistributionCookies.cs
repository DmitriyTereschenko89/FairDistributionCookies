namespace FairDistributionCookies
{
	internal class FairDistributionCookies
	{
		private int DFS(int[] distributions, int[] cookies, int i, int k, int zeroCount)
		{
			if (cookies.Length - i < zeroCount)
			{
				return int.MaxValue;
			}
			if (i == cookies.Length)
			{
				int unfairless = int.MinValue;
				foreach(int distribution in distributions)
				{
					unfairless = Math.Max(unfairless, distribution);
				}
				return unfairless;
			}
			int answer = int.MaxValue;
			for (int j = 0; j < k; ++j)
			{
				zeroCount -= distributions[j] == 0 ? 1 : 0;
				distributions[j] += cookies[i];
				answer = Math.Min(answer, DFS(distributions, cookies, i + 1, k, zeroCount));
				distributions[j] -= cookies[i];
				zeroCount += distributions[j] == 0 ? 1 : 0;
			}
			return answer;
		}

		public int DistributeCookies(int[] cookies, int k)
		{
			int[] distributions = new int[k];
			return DFS(distributions, cookies, 0, k, k);
		}
	}
}

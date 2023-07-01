namespace FairDistributionCookies
{
	internal class Program
	{
		static void Main(string[] args)
		{
			FairDistributionCookies fairDistributionCookies = new();
            Console.WriteLine(fairDistributionCookies.DistributeCookies(new int[] { 8, 15, 10, 20, 8 }, 2));
			Console.WriteLine(fairDistributionCookies.DistributeCookies(new int[] { 6, 1, 3, 2, 2, 4, 1, 2 }, 3));
		}
	}
}
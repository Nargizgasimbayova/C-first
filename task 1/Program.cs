using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            int month =8;

			switch (month)
			{
				case 1:
				case 3:
				case 5:
				case 7:
				case 8:
				case 10:
				case 12:
					Console.Write("Month have 31 days.");
					break;
				case 2:
					Console.Write("Month have 28 or 29 days.");
					break;
				case 4:
				case 6:
				case 9:
				case 11:
					Console.Write("Month have 30 days.");
					break;
				default:
					Console.Write("invalid month number.");
					break;
			}
            #endregion
        }
    }
}

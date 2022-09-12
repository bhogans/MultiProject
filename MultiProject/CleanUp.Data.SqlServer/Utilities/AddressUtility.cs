using System;

namespace CleanUp.Data.SqlServer.Utilities
{
	public static class AddressUtility
	{
		public static string[] GenerateAddressArray(string lineOne, string lineTwo = null, string lineThree = null)
		{
			if (!string.IsNullOrWhiteSpace(lineTwo))
			{
				if (!string.IsNullOrWhiteSpace(lineThree))
				{
					return new string[3] { lineOne, lineTwo, lineThree };
				}
				return new string[2] { lineOne, lineTwo };
			}
			return new string[1] { lineOne };
		}

		public static string TrimZipToFirstFive(string inputZip)
		{
			if (StringHelper.DoesNotExist(inputZip))
			{
				return string.Empty;
			}
			if (inputZip.Length > 4)
			{
				return inputZip.Trim().Substring(0, 5);
			}
			else
			{
				return inputZip;
			}
		}

		public static string TrimZipToFirstThree(string inputZip)
		{
			if (StringHelper.DoesNotExist(inputZip))
			{
				return string.Empty;
			}
			if (inputZip.Length > 2)
			{
				return inputZip.Trim().Substring(0, 3);
			}
			else
			{
				return inputZip;
			}
		}

		public static (string City, string State, string FullZip) ParseCityStateZip(string csvToParse)
		{
			var city = string.Empty;
			var state = string.Empty;
			var zip = string.Empty;
			var csvArray = csvToParse.Split(' ');

			if (csvArray.Length == 3)
			{
				city = csvArray[0];
				state = csvArray[1];
				zip = csvArray[2];
			}
			else
			{
				var cityBackwards = string.Empty;
				Array.Reverse(csvArray);
				for (int i = 0; i < csvArray.Length; i++)
				{
					if (i == 0)
					{
						zip = csvArray[i];
					}
					else if (i == 1)
					{
						state = csvArray[i];
					}
					else
					{
						cityBackwards += $"{csvArray[i]} ";
					}
				}

				var cityArray = cityBackwards.Split(' ');
				Array.Reverse(cityArray);

				for (int i = 0; i < cityArray.Length; i++)
				{
					city += $"{cityArray[i]} ";
				}
			}

			return (city.Trim(), state.Trim(), zip.Trim());
		}
	}
}

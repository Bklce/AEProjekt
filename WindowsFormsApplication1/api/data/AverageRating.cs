using System;

namespace WindowsFormsApplication1.api.data
{
	public class AverageRating
	{
		public AverageRating(int idSeries, int averageRating, int numberOfRatings)
		{
			IdSeries = idSeries;
			AverageRatingValue = averageRating;
			NumberOfRatings = numberOfRatings;
		}
		
		public int IdSeries
		{ get; private set; }
		
		public int AverageRatingValue 
		{  get; private set; }
		
		public int NumberOfRatings
		{ get; private set; }
	}
}

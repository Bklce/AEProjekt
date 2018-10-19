using System;

namespace WindowsFormsApplication1.api.data
{
	public class Season
	{
		public Season(int idSeries, int idSeason, int numberOfEpisodes)
		{
			IdSeries = idSeries;
			IdSeason = idSeason;
			NumberOfEpisodes = numberOfEpisodes;
		}
		
		public int IdSeries
		{ get; private set; }
		
		public int IdSeason
		{ get; private set; }
		
		public int NumberOfEpisodes
		{ get; private set; }
	}
}

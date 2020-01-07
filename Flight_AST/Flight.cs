using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_AST
{
    class Flight
    {
		private String airLineName;
		private City originCity;
		private City destinationCity;
		private String flightNumber;

		/// <summary>
		/// empty argument constructor 
		/// </summary>
		public Flight()
		{
			airLineName = null;
			originCity = null;
			destinationCity = null;
			flightNumber = null;
		}//end constructor

		/// <summary>
		/// preferred constructor for flight
		/// </summary>
		/// <param name="aln">airline number</param>
		/// <param name="fn">flight number</param>
		/// <param name="o">origin city</param>
		/// <param name="d">destination city</param>
		public Flight(String aln, String fn, City o, City d)
		{

			setAirLineName(aln);
			setFlightNumber(fn);
			setOriginCity(o);
			setDestinationCity(d);

		}//end constructor

		/// <summary>
		/// This method uses the haversine formula to calculate the distance around the globe
		/// from one city to another
		/// </summary>
		/// <returns>distance in miles</returns>
		public double calcDistanceToFly()
		{

			double R = 6371000;
			double lat1 = originCity.getLatitude();
			double lat2 = destinationCity.getLatitude();
			double lon1 = originCity.getLongitude();
			double lon2 = destinationCity.getLongitude();

			double lat1Radians = ToRadians(lat1);
			double lat2Radians = ToRadians(lat2);
			double lon1Radians = ToRadians(lon1);
			double lon2Radians = ToRadians(lon2);

			double deltaLat = ToRadians(lat2 - lat1);
			double deltaLon = ToRadians(lon2 - lon1);

			double a = Math.Pow(Math.Sin(deltaLat / 2), 2) + Math.Cos(lat1Radians) * Math.Cos(lat2Radians) * Math.Pow(Math.Sin(deltaLon / 2), 2);

			double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

			double distance = R * c;

			return distance * 0.000621371;
		}//end 

		/// <summary>
		/// This method will return all of the flight details including the airline,
		/// flight number, and distance between two city objects.
		/// </summary>
		/// <returns>flight details</returns>
		public String printFlightDetails()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(airLineName + " " + flightNumber + "\n");
			sb.Append(originCity.getName() + " to " + destinationCity.getName() + "\n");
			sb.Append("Distance: " + this.calcDistanceToFly().ToString("#,##0") + " miles.\n");

			return sb.ToString();
		}//end printFlightDetails

		/// <summary>
		/// This class converts degrees to radians
		/// </summary>
		/// <param name="degree">the input degrees</param>
		/// <returns>the converted radians</returns>
		public double ToRadians(double degree)
		{
			return Math.PI * degree / 180.0;
		}

		/// <summary>
		/// Getter for aitline name
		/// </summary>
		/// <returns>airline name</returns>
		public String getAirLineName()
		{
			return airLineName;
		}//end getAirline

		/// <summary>
		/// setter for airline name
		/// </summary>
		/// <param name="airLineName">value to set airline name to</param>
		public void setAirLineName(String airLineName)
		{
			this.airLineName = airLineName;
		}//end setAirLineName

		/// <summary>
		/// getter for flight number
		/// </summary>
		/// <returns>flight number</returns>
		public String getFlightNumber()
		{
			return flightNumber;
		}//end getFlightNumber

		/// <summary>
		/// setter for flight number
		/// </summary>
		/// <param name="flightNumber">flight number</param>
		public void setFlightNumber(String flightNumber)
		{
			this.flightNumber = flightNumber;
		}//end setFlightNumber

		/// <summary>
		/// getter for origin city
		/// </summary>
		/// <returns>origin city</returns>
		public City getOriginCity()
		{
			return originCity;
		}//end getOriginCity

		/// <summary>
		/// setter for origin city
		/// </summary>
		/// <param name="originCity">origin city</param>
		public void setOriginCity(City originCity)
		{
			this.originCity = originCity;
		}//end setOriginCity

		/// <summary>
		/// getter for destination city
		/// </summary>
		/// <returns>destination city</returns>
		public City getDestinationCity()
		{
			return destinationCity;
		}//end getDestinationCity

		/// <summary>
		/// setter for destination city
		/// </summary>
		/// <param name="destinationCity">destination city</param>
		public void setDestinationCity(City destinationCity)
		{
			this.destinationCity = destinationCity;
		}//end setDestinationCity

		/// <summary>
		/// override for ToString method
		/// </summary>
		/// <returns>ToString output</returns>
		public String toString()
		{
			return "Flight [airLineName=" + airLineName + ", originCity=" + originCity + ", destinationCity="
					+ destinationCity + ", flightNumber=" + flightNumber + "]";
		}//end toString
	}
}

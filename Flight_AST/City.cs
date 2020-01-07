using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_AST
{
	/// <summary>
	/// This class represents a city with a name, long and lat
	/// Converted from Java to C# by Andrew Tanner
	/// Author: Dr. Rob Kelley
	/// </summary>
    class City
    {
		private readonly String name;
		private readonly double latitude;
		private readonly double longitude;

		/// <summary>
		/// empty argument constructor
		/// </summary>
		private City()
		{
			name = "";
			latitude = 0.0;
			longitude = 0.0;
		}//end constructor

		/// <summary>
		/// preferred constructor for city
		/// </summary>
		/// <param name="name">city name</param>
		/// <param name="latitude">city latitude</param>
		/// <param name="longitude">city longitude</param>
		public City(String name, double latitude, double longitude)
		{
			this.name = name;
			this.latitude = latitude;
			this.longitude = longitude;
		}//end constructor

		/// <summary>
		/// getter for city name
		/// </summary>
		/// <returns>city name</returns>
		public String getName()
		{
			return name;
		}//end getName

		/// <summary>
		/// getter for latitude
		/// </summary>
		/// <returns>latitude</returns>
		public double getLatitude()
		{
			return latitude;
		}//end getName

		/// <summary>
		/// getter for longitude
		/// </summary>
		/// <returns>longitude</returns>
		public double getLongitude()
		{
			return longitude;
		}
		public String toString()
		{
			return "City [name=" + name + ", latitude=" + latitude + ", longitude=" + longitude + "]";
		}
	}
}

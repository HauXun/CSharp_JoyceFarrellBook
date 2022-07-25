/*
Create a program for Smalltown Regional Airport Flights that accepts either an
integer flight number or string airport code from the options in Figure 8-33. Pass the
user’s entry to one of two overloaded GetFlightInfo() methods, and then display a
returned string with all the flight details. The method version that accepts an integer
looks up the airport code, name, and time of flight; the version that accepts a string
description looks up the flight number, airport name, and time. The methods return
an appropriate message if the flight is not found.

Flight number		Airport code		Airport name			Time
	201					AUS					Austin				0710
	321					CRP					Corpus Christi		0830
	510					DFW					Dallas Fort Worth	0915
	633					HOU					Houston				1140
 */




using System;
using static System.Console;

namespace Exercise_8_3
{
	class Control
	{
		public int[] flightNumbers = { 201, 321, 510, 633 };
		public string[] airportCodes = { "AUS", "CRP", "DFW", "HOU" };
		public string[] airportNames = { "Austin", "Corpus Christi", "Dallas Fort Worth", "Houston" };
		public string[] times = { "0710", "0830", "0915", "1140" };

		public string request;
		public int flightNum;
		public string output;


		public string GetFlightInfo(int flight, int[] flightNumbers, string[] codes, string[] names, string[] times)
		{
			string output = "Flight #" + flight + " was not found";
			for (int i = 0; i < flightNumbers.Length; i++)
				if (flight == flightNumbers[i])
					output = "Flight #" + flight + " " + codes[i] + " " + names[i] + " Scheduled at: " + times[i];
			return output;
		}


		public string GetFlightInfo(string code, int[] flightNumbers, string[] codes, string[] names, string[] times)
		{
			string output = "Flight #" + code + " was not found";
			for (int i = 0; i < flightNumbers.Length; i++)
				if (code.Equals(codes[i]))
					output = "Flight #" + flightNumbers[i] + " " + codes[i] + " " + names[i] + " Scheduled at: " + times[i];
			return output;
		}
	}
	class Flights
	{
		static void Main(string[] args)
		{
			Control a = new Control();

			Write("Please enter flight number or airpod code >> ");
			a.request = ReadLine();

			if (int.TryParse(a.request, out a.flightNum))
				a.output = a.GetFlightInfo(a.flightNum, a.flightNumbers, a.airportCodes, a.airportNames, a.times);
			else
				a.output = a.GetFlightInfo(a.request, a.flightNumbers, a.airportCodes, a.airportNames, a.times);

			WriteLine(a.output);
		}
	}
}

/*
Create a program named Auction that allows a user to enter an amount bid on an online
auction item. Include three overloaded methods that accept an int, double, or string
bid. Each method should display the bid and indicate whether it is over the minimum
acceptable bid of $10. If the bid is a string, accept it only if one of the following is true:
it is numeric and preceded with a dollar sign, or it is numeric and followed by the word
dollars. Otherwise, display a message that indicates the format was incorrect.
 */




using System;
using static System.Console;

namespace Exercise_8_4
{
	class ProcessAuction
	{
		public const int MIN = 10;

		public string strBid;
		public int intBid;
		public double dblBid;

		public void AcceptBid(int bid, int min)
		{
			if (bid >= min)
				WriteLine("Bid Accept!");
			else
				WriteLine("Bid not high enough!");
		}

		public void AcceptBid(double bid, int min)
		{
			if (bid >= min)
				WriteLine("Bid Accept!");
			else
				WriteLine("Bid not high enough!");
		}
		public void AcceptBid(string bid, int min)
		{
			double dblBid;
			string dollarsString = "$";
			if (bid.Substring(0, 1).Equals("$"))
			{
				if (double.TryParse(bid.Substring(1, bid.Length - 1), out dblBid))
					AcceptBid(dblBid, min);
				else
					WriteLine("Bid was not in correcr format");
			}
			else
			{
				if (bid.Substring(bid.Length - dollarsString.Length, dollarsString.Length).Equals(dollarsString))
				{
					if (double.TryParse(bid.Substring(0, bid.Length - dollarsString.Length), out dblBid))
						AcceptBid(dblBid, min);
					else
						WriteLine("Bid was not in correct format");
				}
				else
					WriteLine("Bid was not in correct format");
			}
		}
	}
	class Auction
	{
		static void Main(string[] args)
		{
			ProcessAuction a = new ProcessAuction();

			Write("Please enter your bid >> ");
			a.strBid = ReadLine();
			if (int.TryParse(a.strBid, out a.intBid))
				a.AcceptBid(a.intBid, ProcessAuction.MIN);
			else if (double.TryParse(a.strBid, out a.dblBid))
				a.AcceptBid(a.dblBid, ProcessAuction.MIN);
			else
				a.AcceptBid(a.strBid, ProcessAuction.MIN);
		}
	}
}

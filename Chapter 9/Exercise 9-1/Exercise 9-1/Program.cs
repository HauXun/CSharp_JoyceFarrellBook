/*
Create an application named TestSoccerPlayer that instantiates and displays a
SoccerPlayer object. The SoccerPlayer class contains properties that hold a
player’s name (a string), jersey number (an integer), goals scored (an integer), and
assists (an integer).
 */




using System;
using static System.Console;

namespace Exercise_9_1
{
	class TestSoccerPlayer
	{
		static void Main(string[] args)
		{
			SoccerPlayer myPlayer = new SoccerPlayer();
			myPlayer.name = "Tran Dan";
			myPlayer.jerseyNumber = 10;
			myPlayer.goals = 23;
			myPlayer.assists = 4;
			WriteLine("The soccer player is {0}. Jersey is #{1} ", myPlayer.name, myPlayer.jerseyNumber);
			WriteLine("Goals: {0}, Assists: {1}", myPlayer.goals, myPlayer.assists);
		}
	}
}

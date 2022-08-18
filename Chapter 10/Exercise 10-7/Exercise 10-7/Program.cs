/*
Create an application named RecoveringDemo that declares objects of three
types: Patient, Upholsterer, and FootballPlayer. Create an interface named
IRecoverable that contains a single method named Recover(). Create the classes
named Patient, Upholsterer, and FootballPlayer so that each implements
IRecoverable. Create each class’s Recover() method to display an appropriate
message. For example, the Patient’s Recover() method might display “I am getting
better.”
 */





using System;
using static System.Console;

namespace Exercise_10_7
{
	class RecoveringDemo
	{
		static void Main(string[] args)
		{
			Patient patient = new Patient();
			Upholsterer upholsterer = new Upholsterer();
			FootballPlayer footballPlayer = new FootballPlayer();
			Write("The patient say: ");
			patient.Recover();
			Write("The upholsterer say: ");
			upholsterer.Recover();
			Write("The football player say: ");
			footballPlayer.Recover();
		}
	}
}

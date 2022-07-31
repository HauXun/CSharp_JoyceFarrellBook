using System;

namespace Exercise_9_6A
{
	class Sale
	{
		string inventoryNumber;
		double amount;
		double tax;

		public string InventoryNumber
		{
			get => inventoryNumber;
			set
			{
				inventoryNumber = value;
			}
		}

		public double Amount 
		{
			get => amount;
			set
			{
				amount = value;
				CalculateTax();
			}
		}

		public double GetTax
		{
			get => tax;
		}

		void CalculateTax()
		{
			if (amount > 100.0)
				tax = 0.08 * 100 + 0.06 * (amount - 100.0);
			else
				tax = 0.08 * amount;
		}
	}
}


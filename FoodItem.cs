public class FoodItem {

	
	public string foodName;
	public double foodCalories;
	public DateTime timestamp;
	public string mealTime;

	public FoodItem() {

		DateTime currentTime = DateTime.Now;
		timestamp = currentTime;

		int timestampHour = Convert.ToInt32(currentTime.ToString("HH"));

		if (5<=timestampHour && timestampHour<10) { mealTime = "Breakfast"; }
		else if (10<=timestampHour && timestampHour<16) { mealTime = "Lunch"; }
		else if ((16<=timestampHour && timestampHour<24) || (0<=timestampHour && timestampHour<5)) { mealTime = "Dinner"; };
	}

	public static FoodItem CreateItem(FoodItem newItem) {

		Console.Clear();

		// Use Get/UseCursorPosition to have character limit underline
		Console.Write("Enter food name: ");
		newItem.foodName = Console.ReadLine();

		Console.Write("Enter food calories: ");
		newItem.foodCalories = Convert.ToDouble(Console.ReadLine());

		return newItem;
	}

}
public class FoodItem {

	
	public string foodName = "";
	public double foodCalories = 0.0;
	public DateTime timestamp;

	public FoodItem() {

		DateTime currentTime = DateTime.Now;
		timestamp = currentTime;
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
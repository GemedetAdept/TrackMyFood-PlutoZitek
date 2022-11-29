public class FoodItem {

	
	public string foodName = "";
	public double foodCalories = 0.0;
	public DateTime timestamp;

	public FoodItem(string name, double calories) {

		foodName = name;
		foodCalories = calories;
		DateTime currentTime = DateTime.Now;
		timestamp = currentTime;
	}


}
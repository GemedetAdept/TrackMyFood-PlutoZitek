using menudriver;
using filesaver;
// Saves the time the food was entered and determines if it is most likely breakfast, lunch, or dinner. 

// Displays the requested data by day.

// Save all of this info and load the info to a file.

string outputFile = FileSaver.InitalizeFile("\\saved", "savedFoodItems.csv", "Date,Time,Name,Calories");
List<FoodItem> savedFoodItems = new List<FoodItem>();

MenuDriver selectionMenu = new MenuDriver();
string[] options = new string[] {

	"Add New Food Item",
	"Load Cached Items",
};
selectionMenu.AddOptions(options);

void mainMenu() {
	while (selectionMenu.menuLoop){

		Console.Clear();
		selectionMenu.DisplayMenu();
		selectionMenu.SetMenuCursor();

		switch(selectionMenu.selectedItem) {

			case 0:
				FoodItem newItem = new FoodItem();
				FoodItem.CreateItem(newItem);
				savedFoodItems.Add(newItem);
				FileSaver.SaveData(outputFile, newItem);
				continue;
			case 1: 
				displayItems(savedFoodItems);
				break;
			default:
				break;
		}
	}
}

mainMenu();

void displayItems(List<FoodItem> saved) {

	for (int i = 0; i < saved.Count; i++) {

		Console.WriteLine($"[{i+1}] - {saved[i].foodName}");
		Console.WriteLine($"\tCalories: {saved[i].foodCalories}");
		Snippet.LineBreak();
	}

	Console.ReadKey();
}
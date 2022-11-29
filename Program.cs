using menudriver;
// Saves the time the food was entered and determines if it is most likely breakfast, lunch, or dinner. 

// Displays the requested data by day.

// Save all of this info and load the info to a file.

List<FoodItem> cachedFoodItems = new List<FoodItem>();

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
				cachedFoodItems.Add(FoodItem.CreateItem(newItem));
				continue;
			case 1: 
				displayItems(cachedFoodItems);
				break;
			default:
				break;
		}
	}
}

mainMenu();

void displayItems(List<FoodItem> cached) {

	for (int i = 0; i < cached.Count; i++) {

		Console.WriteLine($"[{i+1}] - {cached[i].foodName}");
		Console.WriteLine($"\tCalories: {cached[i].foodCalories}");
		Snippet.LineBreak();
	}

	Console.ReadKey();
}
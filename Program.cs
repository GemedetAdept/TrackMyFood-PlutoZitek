using menudriver;
using filesaver;
using Microsoft.VisualBasic.FileIO;
// Saves the time the food was entered and determines if it is most likely breakfast, lunch, or dinner. 

// Displays the requested data by day.

// Save all of this info and load the info to a file.

string fieldTypes = "Date,Time,Name,Calories";
string outputFile = FileSaver.InitalizeFile("\\saved", "savedFoodItems.csv", fieldTypes);

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
				FileSaver.SaveData(outputFile, newItem);
				continue;
			case 1: 
				displayItems();
				break;
			default:
				break;
		}
	}
}

mainMenu();

void displayItems() {

	string[] fieldLabels = fieldTypes.Split(",");
	Console.WriteLine("tEst");

	using (TextFieldParser parseCSV = new TextFieldParser(outputFile)) {

		parseCSV.SetDelimiters(",");

		while(parseCSV.EndOfData != true) {

			string[] parsedFields = parseCSV.ReadFields();
			for (int i = 0; i < parsedFields.Length-1; i++) {

				if (i+1 % 1 == 0) Console.WriteLine($"{fieldLabels[0]}: {parsedFields[i]}");
				else if (i % 2 == 0) Console.WriteLine($"{fieldLabels[1]}: {parsedFields[i]}");
				else if (i % 3 == 0) Console.WriteLine($"{fieldLabels[2]}: {parsedFields[i]}");
				else if (i % 4 == 0) {
					Console.WriteLine($"{fieldLabels[0]}: {parsedFields[i]}");
					Snippet.LineBreak();
				}
			}
		}
	}

	Console.ReadKey();
}
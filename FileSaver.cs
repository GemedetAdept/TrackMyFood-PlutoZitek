namespace filesaver {
	public class FileSaver {

		public static string InitalizeFile(string saveFolder, string fileName, string dataFields) { 

			string workingDirectory = Directory.GetCurrentDirectory();
			string savedFoodItems = workingDirectory + saveFolder;
			string outputFile = savedFoodItems + "\\" + fileName;

			if (File.Exists(outputFile)) return outputFile;
			else {

				File.WriteAllText(outputFile, dataFields + Environment.NewLine);
				return outputFile;
			}
		}

		public static void SaveData(string outputFile, FoodItem item) {

			File.AppendAllText(outputFile, $"{item.timestamp},{item.mealTime},{item.foodName},{item.foodCalories}" + Environment.NewLine);

		}
	}
}
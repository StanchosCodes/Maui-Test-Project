namespace MauiAppTest.Views;

[QueryProperty(nameof(ItemId), nameof(ItemId))]
public partial class NotePage : ContentPage
{
	public NotePage()
	{
		InitializeComponent();

		string appDataPath = FileSystem.AppDataDirectory;
		string randomFileName = $"{ Path.GetRandomFileName() }.notes.txt";

		LoadNote(Path.Combine(appDataPath, randomFileName));
	}

	public string ItemId
	{
		set { LoadNote(value); }
	}

	private void LoadNote(string fileName)
	{
		Models.Note newNoteModel = new Models.Note();
		newNoteModel.FileName = fileName;

		if (File.Exists(fileName))
		{
			newNoteModel.Date = File.GetCreationTime(fileName);
			newNoteModel.Text = File.ReadAllText(fileName);
		}

		BindingContext = newNoteModel;
	}

	private async void SaveButton_Clicked(object sender, EventArgs e)
	{
		if (BindingContext is Models.Note note)
		{
			File.WriteAllText(note.FileName, TextEditor.Text);
		}

		await Shell.Current.GoToAsync("..");
	}

	private async void DeleteButton_Clicked(object sender, EventArgs e)
	{
		if (BindingContext is Models.Note note)
		{
			if (File.Exists(note.FileName))
			{
				File.Delete(note.FileName);
			}
		}

		await Shell.Current.GoToAsync("..");
	}
}
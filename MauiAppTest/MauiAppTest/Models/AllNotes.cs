using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTest.Models
{
    public class AllNotes
    {
        public ObservableCollection<Note> Notes { get; set; } = new ObservableCollection<Note>();

        public AllNotes() => LoadNotes();

        public void LoadNotes()
        {
            Notes.Clear();

            string appDataPath = FileSystem.AppDataDirectory;

            IEnumerable<Note> currentNotes = Directory
                .EnumerateFiles(appDataPath, "*.notes.txt")
                .Select(file => new Note()
                {
                    FileName = file,
                    Text = File.ReadAllText(file),
                    Date = File.GetLastWriteTime(file)
                })
                .OrderBy(note => note.Date);

            foreach (Note note in currentNotes)
            {
                Notes.Add(note);
            }
        }
    }
}

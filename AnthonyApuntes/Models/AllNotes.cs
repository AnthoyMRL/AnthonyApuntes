﻿using System.Collections.ObjectModel;

namespace AnthonyApuntes.Models;

internal class AllNotes
{
    public ObservableCollection<Note> Notes { get; set; } = new ObservableCollection<Note>();

    public AllNotes() =>
        LoadNotes();

    public void LoadNotes()
    {
        Notes.Clear();

        string appDataPath = FileSystem.AppDataDirectory;

        IEnumerable<Note> notes = Directory
            .EnumerateFiles(appDataPath, "*.notes.txt")
            .Select(filename => new Note()
            {
                Filename = filename,
                Text = File.ReadAllText(filename),
                Date = File.GetLastWriteTime(filename)
            })
            .OrderByDescending(note => note.Date);

        foreach (Note note in notes)
            Notes.Add(note);
    }
}
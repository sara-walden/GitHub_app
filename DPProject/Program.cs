// See https://aka.ms/new-console-template for more information
using DPProject;
using DPProject.Composite;
using DPProject.State;
using File = DPProject.Composite.File;

Console.WriteLine("Hello, World!");

User user = new User();
#region state

Folder Folder1 = new Folder("Folder1");
Folder Folder2 = new Folder("Folder2");
File File1 = new File("File1");
File File2 = new File("File2");
File File3 = new File("File3");
File FileToCopy = new File("FileToCopy");
Folder1.Add(Folder2);
Folder2.Add(File2);
Folder2.Add(File3);
List<ItemContext> list1 = new List<ItemContext>() { Folder1, File1, File2 };
List<ItemContext> list2 = new List<ItemContext>() { File1, File2, File3};
ItemsState itemsState1 = new DraftState();
ItemsState itemsState2 = new StagedState();
Branch branch1 = new Branch("FileSystem1",itemsState1,list1);
Console.WriteLine(branch1.BranchDetails());
Console.WriteLine(branch1.Staged());
Console.WriteLine(File1.State.Staged(File1));
//Console.WriteLine(branch1.BranchDetails());
//Console.WriteLine(branch2.Staged());
string name = FileToCopy.Clone().Name;
Console.WriteLine(name);
//Console.WriteLine(branch.State.Merged(Folder1, Folder2));
//Console.WriteLine(branch.ReadyToMerge(branch,branch));
//Console.WriteLine(branch.ReadyToMerge(branch,branch));
//Console.WriteLine(branch.Commited());
//Folder1.Add(File1);
//Console.WriteLine(branch.Clone(branch));
#endregion

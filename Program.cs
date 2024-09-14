 //1 
//
// string path =@"C:\Users\Ibrohim\Desktop\test.txt";
//
// DirectoryInfo dir = new DirectoryInfo(path);
//
// if (!dir.Exists)
// {
//     try
//     {
//         dir.Create();
//         File.WriteAllText(path, "Hello, World!");
//         Console.WriteLine("Text created successfully");
//         File.Delete(path);
//     }
//     catch (Exception e)
//     {
//         Console.WriteLine(e);
//     }
//     
// }   
 

//3
// string path =@"C:\Users\Ibrohim\Desktop\io";
// string file = @"C:\Users\Ibrohim\Desktop\io\files";
// string file2 = @"C:\Users\Ibrohim\Desktop\io\files2";
// string file3 = @"C:\Users\Ibrohim\Desktop\io\files3";
//
// DirectoryInfo dir = new DirectoryInfo(path);
//
// if (!dir.Exists)
// {
//     try
//     {
//         dir.Create();
//         File.Create(file);
//         File.Create(file2);
//         File.Create(file3);
//         Console.WriteLine("Directory created successfully");
//         FileInfo[] files = dir.GetFiles();
//         foreach (var VARIABLE in files)
//         {
//             Console.WriteLine(VARIABLE.Name);
//         }
//
//     }
//     catch (Exception e)
//     {
//         Console.WriteLine(e);
//     }
// }

//4

 using System.IO.Compression;
//
//  string path =@"C:\Users\Ibrohim\Desktop\io";
//  string zipPath = @"C:\Users\Ibrohim\Desktop\backup.zip";
//  ZipFile.CreateFromDirectory(path,zipPath);

//5

 // string path =@"C:\Users\Ibrohim\Desktop\io";
 // string fileName = "files";
 // DirectoryInfo dir = new DirectoryInfo(path);
 // FileInfo[] files = dir.GetFiles(fileName, SearchOption.AllDirectories);
 // foreach (var file in files)
 // {
 //     Console.WriteLine(file.FullName);
 // }

//6

  // string path =@"C:\Users\Ibrohim\Desktop\io";
  // string file1 = @"C:\Users\Ibrohim\Desktop\io\files";
  // string file2 = @"C:\Users\Ibrohim\Desktop\io\files2";
  // byte[] file1Bytes = File.ReadAllBytes(file1);
  // byte[] file2Bytes = File.ReadAllBytes(file2);
  // bool areEqual = file1Bytes.SequenceEqual(file2Bytes);
  // Console.WriteLine(areEqual);

//7

  // string path = @"C:\Users\Ibrohim\Desktop\io\files";
  // if (File.Exists(path))
  // {
  //   string[] lines = File.ReadAllLines(path);
  //   foreach (var line in lines)
  //   {
  //     Console.WriteLine(line);
  //   }
  // }


//8

//string path = @"C:\Users\Ibrohim\Desktop\io";
 // string file = @"C:\Users\Ibrohim\Desktop\io\files";
 // string newFileName = "renamed_file.txt";
 // if (!File.Exists(newFileName))
 // {
 //  File.Move(file, newFileName);
 //  Console.WriteLine("File renamed successfully");
 // }
 // else
 // {
 //  Console.WriteLine("Error File can not be renamed");
 // }
 

//9

 // string path = @"C:\Users\Ibrohim\Desktop\io";
 // string path2 = @"C:\Users\Ibrohim\Desktop\io2";
 // DirectoryInfo sourcedir2 = new DirectoryInfo(path2);
 // if (!sourcedir2.Exists)
 // {
 //  sourcedir2.Create();
 // }
 // DirectoryInfo sourceDir = new DirectoryInfo(path);
 // if (sourceDir.Exists)
 // {
 //  sourceDir.MoveTo(path2);
 

//11

 // string path = @"C:\Users\Ibrohim\Desktop\io2\files2";
 //
 // if (File.Exists(path))
 // {
 //  Console.WriteLine("File is exist");
 // }
 // else
 // {
 //   Console.WriteLine("File does not found");
 // }

//12

 // string path = @"C:\Users\Ibrohim\Desktop\io2";
 // if (Directory.Exists(path))
 // {
 //   string[] files = Directory.GetFiles(path);
 //   foreach (var file in files)
 //   {
 //     Console.WriteLine(file);
 //   }
 //
 //   string[] dirs = Directory.GetDirectories(path);
 //   foreach (var dir in dirs)
 //   {
 //     Console.WriteLine(dir);
 //   }
 // }

//13
// string path = @"C:\Users\Ibrohim\Desktop\io2";
//  if (Directory.Exists(path))
//  { 
//   string[] dirs = Directory.GetFiles(path,".log");
//   foreach (var VARIABLE in dirs)
//   {
//    Console.WriteLine(VARIABLE);
//   }
//   
//   foreach (var VARIABLE in dirs)
//   {
//     Directory.Delete(VARIABLE);
//   }
//  }

//14

 // string path = @"C:\Users\Ibrohim\Desktop\io\files";
 // FileInfo fileInfo = new FileInfo(path);
 // if (fileInfo.Exists)
 // {
 //    string content = File.ReadAllText(path);
 //    string upperContent = content.ToUpper();
 //    File.WriteAllText(path, upperContent);
 //    Console.WriteLine("File content changed successfully");
 //  
 // }


//15
  //  string path =@"C:\Users\Ibrohim\Desktop\io";
  // string zipPath = @"C:\Users\Ibrohim\Desktop\backup.zip";
  // ZipFile.ExtractToDirectory(zipPath,path);
  
//16

   // string path = @"C:\Users\Ibrohim\Desktop\io\files2";
   // FileInfo fileInfo = new FileInfo(path);
   // if (File.Exists(path))
   // {
   //  Console.WriteLine(fileInfo.Length);
   // }

//17 
   // string path = @"C:\Users\Ibrohim\Desktop\io\files";
   // FileInfo fileInfo = new FileInfo(path);
   // if (fileInfo.Exists)
   // {
   //  DateTime dateTime = fileInfo.LastAccessTime;
   //  Console.WriteLine(dateTime);
   // }

//18

  // string path = @"C:\Users\Ibrohim\Desktop\io";
  // string path2 = @"C:\Users\Ibrohim\Desktop\io2";
  // string file = @"C:\Users\Ibrohim\Desktop\io\files";
  // string newFilePath = Path.Combine(path2, "fileschange.txt");
  // if (File.Exists(file))
  // {
  //  File.Move(file, newFilePath);
  //  Console.WriteLine("File moved successfully");
  // } 
  
  //19

   // string path = @"C:\Users\Ibrohim\Desktop\io";
   // string file = @"C:\Users\Ibrohim\Desktop\io\files.txt";
   // string text = "Hello, World!";
   // File.WriteAllText(file, text);
   // Console.WriteLine("File written successfully");

//20

   // string path = @"C:\Users\Ibrohim\Desktop\io";
   // DirectoryInfo dir = new DirectoryInfo(path);
   // if (dir.Exists)
   // {
   //   FileInfo[] files = dir.GetFiles("*.txt", SearchOption.AllDirectories);
   //   foreach (var file in files)
   //   {
   //     Console.WriteLine(file.Name);
   //   }
   // }

  
  
using System;
using System.IO;
// 1

//string[] strs1 = { "flower", "flow", "flight" };
//string result1 = FindPrefix(strs1);
//Console.WriteLine($"Пример 1: {result1}");

//string[] strs2 = { "dog", "racecar", "car" };
//string result2 = FindPrefix(strs2);
//Console.WriteLine($"Пример 2: {result2}");

//static string FindPrefix(string[] strs)
//{
//    if (strs == null || strs.Length == 0)
//    {
//        return "";
//    }

//    string prefix = strs[0];

//    for (int i = 1; i < strs.Length; i++)
//    {
//        while (strs[i].IndexOf(prefix) != 0)
//        {
//            prefix = prefix.Substring(0, prefix.Length - 1);

//            if (prefix.Length == 0)
//            {
//                return "";
//            }
//        }
//    }

//    return prefix;
//}

// 2

//string directoryPath = @"C:\Name";
//string fileName = "NewFile.txt";

//string filePath = Path.Combine(directoryPath, fileName);

//if (File.Exists(filePath))
//{
//    Console.WriteLine($"Ошибка: Файл с именем {fileName} уже существует в каталоге {directoryPath}.");
//}
//else
//{
//    File.Create(filePath);
//    Console.WriteLine($"Файл {fileName} успешно создан в каталоге {directoryPath}.");
//}

// 3

//string directoryPath = @"C:\Name";

//if (Directory.Exists(directoryPath))
//{
//    Console.WriteLine($"Ошибка: Каталог {directoryPath} уже существует.");
//}
//else
//{
//    Directory.CreateDirectory(directoryPath);
//    Console.WriteLine($"Каталог {directoryPath} успешно создан.");
//}

// 4

//string directoryPath = @"C:\Name";

//ListFiles(directoryPath);
//static void ListFiles(string path)
//{
//    try
//    {
//        string[] files = Directory.GetFiles(path);
//        string[] subDirectories = Directory.GetDirectories(path);

//        Console.WriteLine($"Файлы в каталоге {path}:");

//        foreach (string file in files)
//        {
//            Console.WriteLine(file);
//        }

//        foreach (string subDirectory in subDirectories)
//        {
//            ListFiles(subDirectory);
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Ошибка: {ex.Message}");
//    }
//}
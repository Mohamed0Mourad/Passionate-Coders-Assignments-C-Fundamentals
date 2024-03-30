  static void FileSystemCommandLinePRoject()
  {
      /* File System command Line
       * list files and directories: list [path]
       * Print info of files and directories : info [path]
       * create directory : mkdir [path]
       * remove directory : remove [path]
       * Read file content : read [path]
       */
      Console.Title = "File system command line";
      Console.WriteLine("------------Simple File System Command Line Project----------------");
      while (true)
      {
          Console.Write(">>> ");
          var input = Console.ReadLine();
          var whiteSpace = input.IndexOf(' ');
          var command = input.Substring(0, whiteSpace).Trim().ToLower();
          var path = input.Substring(whiteSpace + 1).Trim();

          if (command == "list")
          {
              Console.ForegroundColor = ConsoleColor.Red;
              // get all directories
              foreach (var entry in Directory.GetDirectories(path))
                  Console.WriteLine("Dir : {0}", entry);
              //you can add a search option 
              // foreach (var entry in Directory.GetDirectories(path,"*.sln*"))
              // Console.WriteLine("Dir : {0}", entry);

              // get all files
              foreach (var entry in Directory.GetFiles(path))
                  Console.WriteLine("File: {0}", entry);

              Console.ForegroundColor = ConsoleColor.White;
          }
          else if (command == "info")
          {
              Console.ForegroundColor = ConsoleColor.Green;
              if (Directory.Exists(path))
              {
                  var dirInfo = new DirectoryInfo(path);
                  Console.WriteLine("\tType : Directory");
                  Console.WriteLine($"\tCreated at: {dirInfo.CreationTime}");
                  Console.WriteLine($"\tLast Modified: {dirInfo.LastWriteTimeUtc}");
                  Console.WriteLine($"\tLast Acces Time: {dirInfo.LastAccessTime}");

              }
              else if (File.Exists(path))
              {
                  var fileInfo = new FileInfo(path);
                  Console.WriteLine("\tType : File");
                  Console.WriteLine("\tCreate At: {0}", fileInfo.CreationTime);
                  Console.WriteLine("\tLast Modified: {0}", fileInfo.LastWriteTime);
                  Console.WriteLine("\tLast Access Time: {0}", fileInfo.LastAccessTime);
                  Console.WriteLine("\tSize of file is: {0} bytes", fileInfo.Length);
                  //Console.WriteLine("\tEncrypted file at: {0}",fileInfo.Encrypt);

              }
              Console.ForegroundColor = ConsoleColor.White;
          }

          else if (command == "mkdir")
              Directory.CreateDirectory(path);
          else if (command == "remove")
          {
              if (Directory.Exists(path))
                  Directory.Delete(path);//remove empty directory Delete(path,true) remove everthing
              else if (File.Exists(path))
                  File.Delete(path);
          }

          else if (command == "read")
          {
              Console.ForegroundColor = ConsoleColor.Blue;
              //write all text , remove old text in file 
              File.WriteAllText(path, "This text written using writealltext\n");

              //append all text ,apend text and doesn't remove the file
              File.AppendAllText(path, "Apeended Text with Appendalltext");

              //read all text
              var fileContent = File.ReadAllText(path);
              Console.WriteLine("File Content: {0}",fileContent);
              Console.ForegroundColor = ConsoleColor.White;
          }
          else if (command == "exit")
              break;
          else
              Console.WriteLine("Invalid Input");


      }
  }

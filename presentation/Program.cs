using System;
using System.Diagnostics;
using System.IO;

namespace Rezare.TogsCop.UI.Angular
{
  class Program
  {
    static void Main(string[] args)
    {
      // set the current working directory to the presentation folder
      Directory.SetCurrentDirectory("../../..");

      var startInfo = new ProcessStartInfo
      {
        FileName = "cmd.exe",
        Arguments = "/C ng serve"
      };

      using (var process = new Process())
      {
        process.StartInfo = startInfo;

        process.Start();
        process.WaitForExit();
      }
    }
  }
}

using System;
using System.CommandLine;
using Windows.Foundation.Collections;

namespace Bumblebee.Hive
{
	static class Program
	{
		public static void Main(string[] args)
		{
			string directory = null;

			ArgumentSyntax.Parse(args, syntax =>
			{
				syntax.DefineOption("d|directory", ref directory, true, "");
			});

			if (directory == null)
			{
				Console.Error.WriteLine("I need a directory!");
				Environment.Exit(1);
			}

			var files = System.IO.Directory.GetFileSystemEntries(directory);
			foreach (var file in files)
				Console.WriteLine(file);

			ValueSet vs = new ValueSet();
		}
	}
}
using System;
using System.Collections.Generic;
using System.IO;
using ViewModel.Interface;

namespace ViewModel
{
	internal sealed class GetAllFiles : IGetFiles
	{
		public string[] GetFullPathFiles(string path)
		{
			try 
			{
				if (string.IsNullOrEmpty(path) || !Directory.Exists(path))
					return null;

				return Directory.GetFiles(path);
			}
			catch (Exception e) 
			{
				return new string[0];
			}
		}

		public List<FileInfo> GetFiles(string[] fullPathFiles)
		{
			try
			{
				if (fullPathFiles == null || fullPathFiles.Length > 0)
					return null;

				var files = new List<FileInfo>();

				foreach (var file in fullPathFiles)
				{
					if (!File.Exists(file))
						continue;
					files.Add(new FileInfo(file));
				}
				return files;
			}
			catch (Exception e) 
			{
				return new List<FileInfo>();
			}
		}
	}
}

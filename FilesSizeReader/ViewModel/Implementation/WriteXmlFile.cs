using FilesSizeReader.Model;
using System;
using System.IO;
using ViewModel.Interface;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ViewModel
{
	internal sealed class WriteXmlFile : IFileWrite<FileData>
	{
		public void WriteFile(string filePath, IEnumerable<FileData> filesData)
		{
			try
			{
				if (string.IsNullOrEmpty(filePath) || !Directory.Exists(filePath))
					return;

				XDocument xdoc = new XDocument();
				XElement xfiles = new XElement("FilesData");
				foreach (var item in filesData) 
				{
					XElement file = new XElement(item.Name);
					XAttribute size = new XAttribute("Size", $"{item.Size} byte");
					file.Add(size);
					xfiles.Add(file);
				}
				xdoc.Add(xfiles);
				xdoc.Save($"{filePath}/FilesSize.xml");
			}
			catch (Exception e) 
			{ }
		}
	}
}

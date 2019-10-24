using FilesSizeReader.Model;
using System.Collections.Generic;
using System.IO;
using ViewModel.Interface;

namespace ViewModel
{
	public class FileViewModel
	{
		FilesOperation _filesOperation;
		public string SetPath { private get; set; }
		public void StartWorkerWithBinaryFiles() 
		{
			_filesOperation = new FilesOperation(new ReadBinaryFiles(), new WriteXmlFile(), new GetAllFiles());
			_filesOperation.StartProcessing(SetPath);
		}
	}
}

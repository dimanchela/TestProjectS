using FilesSizeReader.Model;
using ViewModel.Interface;

namespace ViewModel
{
	public class FilesOperation
	{
		readonly IFileRead<long> _fileRead;
		readonly IFileWrite<FileData> _fileWrite;
		readonly IGetFiles _filesGet;
		public FilesOperation(IFileRead<long> fileRead, IFileWrite<FileData> fileWrite, IGetFiles filesGet) 
		{
			_fileRead = fileRead;
			_fileWrite = fileWrite;
			_filesGet = filesGet;
		}

		public void StartProcessing(string path) 
		{
		}
	}
}

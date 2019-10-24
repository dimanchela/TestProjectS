using System.Collections.Generic;
using System.IO;

namespace ViewModel.Interface
{
	public interface IGetFiles
	{
		string[] GetFullPathFiles(string path);
		List<FileInfo> GetFiles(string[] fullPathFiles);
	}
}

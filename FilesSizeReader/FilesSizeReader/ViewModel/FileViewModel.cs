using FilesSizeReader.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesSizeReader.ViewModel
{
	public class FileViewModel
	{
		private FileData _fileData;
		
		public ObservableCollection<FileData> _files { get; set; }

		public void GetFiles(string path) 
		{ 
			
		}
	}
}

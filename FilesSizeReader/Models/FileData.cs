using System;

namespace FilesSizeReader.Model
{
	[Serializable]
	public class FileData
	{
		public string Name { get; set; }

		public long Size { get; set; }
	}
}

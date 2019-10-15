using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesSizeReader.Model
{
	[Serializable]
	public class FileData
	{
		public string Name { get; set; }


		[NonSerialized]
		public string FullName;

		[NonSerialized]
		public string Extension;

		public long Size { get; set; }
	}
}

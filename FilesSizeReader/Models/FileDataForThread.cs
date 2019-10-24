using FilesSizeReader.Model;

namespace Models
{
	public class FileDataForThread : FileData
	{
		public bool Error { get; set; }
		public string ErrorMessage { get; set; }
	}
}

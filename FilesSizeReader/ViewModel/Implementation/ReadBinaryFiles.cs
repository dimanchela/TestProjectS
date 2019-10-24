using System;
using System.IO;
using ViewModel.Interface;

namespace ViewModel
{
	internal sealed class ReadBinaryFiles : IFileRead<long>
	{
		public long ReadFile(string filePath)
		{
			try
			{
				long sizeByte = default;
				using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
				{
					while (reader.PeekChar() > -1)
					{
						sizeByte += reader.ReadByte();
					}
				}
				return sizeByte;
			}
			catch(Exception e)
			{
				return default;
			}
		}
	}
}

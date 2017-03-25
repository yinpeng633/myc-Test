using System;
using System.IO;
namespace test1.filearray
{
    public class FileArrayTest
    {
         static void Main(string[] args)
         {
             if (args.Length == 0) 
             {
                 Console.WriteLine("indexer <filename>");
                 return;
             }

             SimpleFileByteArray file = new SimpleFileByteArray(args[0]);
             long length = file.Length;
             for (int i = 0; i < length/2; ++i) 
             {
                 byte t;
                 t = file[i];
                 file[i] = file[length - i - 1];
                 file[length - i - 1] = t;
             }
             file.Close();
         }
    }

    public class SimpleFileByteArray
    {
		private FileStream stream;

        public SimpleFileByteArray(String fileName)
        {
            stream = new FileStream(fileName, FileMode.Open);
        }
         
		public void Close()
        {
            //日了 mac上的 .NETCoreApp 1.1 Stream meiyou Close().
            //stream.Close();
			stream = null;
        }


        public byte this[long index]
        {
            get
            {
                byte[] buffer = new byte[1];
                stream.Seek(index, SeekOrigin.Begin);
                stream.Read(buffer, 0, 1);
                return buffer[0];
            }

            set
            {
                byte[] buffer = new byte[1] {value};
                stream.Seek(index, SeekOrigin.Begin);
                stream.Write(buffer, 0, 1);
            }
        }


        public long Length
        {
            get
            {
                return stream.Seek(0, SeekOrigin.End);
            }
        }
    }
}
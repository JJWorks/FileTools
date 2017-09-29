using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RowLookUp
{
    class FileLookUp
    {
        public FileLookUp(string SourceLocation, string DestinationLocation, int RowToStart, int RowtoStop)
        {
            if (!File.Exists(SourceLocation))
                throw new FileNotFoundException(SourceLocation + " cannot be found.");

            if (RowtoStop < RowToStart)
                throw new Exception("Starting Row is after Ending Row");

            StartPoint = RowToStart;
            StopPoint = RowtoStop;
            SourceFile = new FileInfo(SourceLocation);
            DestinationFile = DestinationLocation;
        }

        private FileInfo SourceFile;
        private string DestinationFile;
        private int StartPoint;
        private int StopPoint;

        public void TransferData()
        {
            if (!SourceFile.Exists)
                throw new FileNotFoundException(SourceFile.FullName + " cannot be found.");

            if (File.Exists(DestinationFile))
                File.Delete(DestinationFile);

            using(TextReader TR = new StreamReader(SourceFile.FullName))
            {
                using(TextWriter TW = new StreamWriter(DestinationFile))
                {
                    for (int i = 1; i <= StopPoint || TR.Peek() == -1; i++)
                    {
                        if (i >= StartPoint)
                        {
                            TW.WriteLine(TR.ReadLine());
                        }
                        else
                            TR.ReadLine();
                    }
                    TW.Flush();
                }
            }
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HackerRank
{
    internal class WriteLogToDrive
    {
        internal void initialCall()
        {
            try
            {
                WriteTextToLocalDive($"Test Task Schedule");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public void WriteTextToLocalDive(string writeText)
        {
            try
            {
                string LocalLogFolderUrl = "E:/ConsoleAppILog/";


                if (!Directory.Exists(LocalLogFolderUrl))
                    Directory.CreateDirectory(LocalLogFolderUrl);

                string _path = $"{LocalLogFolderUrl}APILog_{DateTime.Now.ToString("yyyyMMdd")}.txt";

                object locker = new object();

                lock (locker)
                {
                    using (StreamWriter sw = File.AppendText(_path))
                    {
                        sw.WriteLine($"{DateTime.Now} ------: {writeText}");
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}

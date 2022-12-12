﻿using System;
using System.IO;

namespace Scrable.Workers

{
	 class FileReader
	{
        public string[] Read(string filename)
        {

            string[] fileContent; 
            try
            {
                fileContent = File.ReadAllLines(filename);

            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            return fileContent;
        }
    }
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic.Filetypes.ID3V2
{
    /// <summary>
    /// The Id3V2 strategy to read tags of a mp3 file
    /// using TagLib
    /// </summary>
    public class ID3V2Reader : IFileTypeReader
    { 
        /// <summary>
        /// Reads the Id3V2 tags of the given file using TagLib
        /// </summary>
        /// <param name="filepath">The absolute path of the file, which should be read</param>
        /// <returns>A ID3V2 file with the tags</returns>
        public IFile Read(string filepath)
        {
            TagLib.File file = TagLib.File.Create(filepath);
            return new Id3V2(file);
        }
    }
}

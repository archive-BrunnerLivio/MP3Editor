﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace MP3Editor.Businesslogic.Filetypes.ID3V1
{
    /// <summary>
    /// Represents a data file which reprensents one MP3 file.
    /// This class writes to the ID3V1 attributes of this file
    /// </summary>
    public class Id3V1 : File, IID3V1
    {
        private string filePath;
        /// <summary>
        /// Initializes the file
        /// </summary>
        /// <param name="filePath">The path of the file</param>
        /// <param name="tag">The tag provided from TagLib, which should be read or written from</param>
        public Id3V1(string filePath, TagLib.Tag tag)
            :base(tag, filePath)
        {
        }

        /// <summary>
        /// Returns the Album of the mp3 file
        /// and writes it
        /// </summary>
        public string Album
        {
            get { return tag.Album; }
            set { tag.Album = value; }
        }

        /// <summary>
        /// Returns the Album Artists and 
        /// writes it
        /// </summary>
        public string AlbumArtist
        {
            get
            {
                if (tag.AlbumArtists.Length == 0)
                {
                    return String.Empty;
                }
                return tag.AlbumArtists[0];
            }
            set { tag.AlbumArtists = new string[] { value }; }
        }

        /// <summary>
        /// Returns the comment of the file and writes it
        /// </summary>
        public string Comment
        {
            get { return tag.Comment; }
            set { tag.Comment = value; }
        }

        /// <summary>
        /// Returns the track number and sets it
        /// </summary>
        public int Track
        {
            get { return Convert.ToInt32(tag.Track); }

            set { tag.Track = Convert.ToUInt32(value); }
        }

        /// <summary>
        /// Returns the title of the file and sets it.
        /// </summary>
        public string Title
        {
            get { return tag.Title; }

            set { tag.Title = value; }
        }

        /// <summary>
        /// Returns the genre of the file and set it.
        /// </summary>
        public string Genre
        {
            get { return tag.Genres[0]; }

            set { tag.Genres[0] = value; }
        }

        /// <summary>
        /// Returns the release-year and sets it
        /// </summary>
        public int Year
        {
            get { return Convert.ToInt32(tag.Year); }

            set { tag.Year = Convert.ToUInt32(value); }
        }
    }
}

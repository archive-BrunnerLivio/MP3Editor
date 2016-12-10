﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using MP3Editor.Businesslogic.Filetypes.ID3V1;

namespace MP3Editor.UI.Models
{
    /// <summary>
    /// Represents and ID3V1 MP3File
    /// </summary>
    public class Id3V1ViewModel : ViewModel
    {
        private string path;
        private Id3V1Reader reader;
        private Id3V1 file;

        /// <summary>
        /// Initialize and read ID3V1 Tags of the file
        /// </summary>
        /// <param name="path">The path of the file</param>
        public Id3V1ViewModel(string path)
        {
            this.path = path;
            reader = new Id3V1Reader();
            file = (Id3V1)reader.Read(path);
        }

        /// <summary>
        /// Set or get the Albumname of the Song
        /// </summary>
        public string Album
        {
            get { return file.Album; }
            set { file.Album = value; }
        }

        /// <summary>
        /// Set or get the Track Number
        /// </summary>
        public int Track
        {
            get { return file.Track; }
            set { file.Track = value; }
        }

        /// <summary>
        /// Get the name of the file
        /// </summary>
        public string Filename
        {
            get { return file.Filename; }
        }

        /// <summary>
        /// Set or get the Genre of the file
        /// </summary>
        public string Genre
        {
            get { return file.Genre; }
            set { file.Genre = value; }
        }

        /// <summary>
        /// Get or set the creation year of the song
        /// </summary>
        public int Year
        {
            get { return file.Year; }
            set { file.Year = value; }
        }

        /// <summary>
        /// Get or set the comment of the file
        /// </summary>
        public string Comment
        {
            get { return file.Comment; }
            set { file.Comment = value; }
        }

        /// <summary>
        /// Get or set the Album Artist of the file
        /// </summary>
        public string AlbumArtist
        {
            get { return file.AlbumArtist; }
            set { file.AlbumArtist = value; }
        }
        /// <summary>
        /// Saves the file
        /// </summary>
        public void Save()
        {
            file.Save();
        }
    }
}

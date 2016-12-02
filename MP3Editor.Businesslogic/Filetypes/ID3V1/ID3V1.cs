﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace MP3Editor.Businesslogic.Filetypes.ID3V1
{
    public class Id3V1 : File, IID3V1
    {

        public Id3V1(TagLib.File file)
            :base(file)
        {
        }

        public string Filename
        {
            get { return file.Name; }
        }

        public string Album
        {
            get { return file.Tag.Album; }
            set { file.Tag.Album = value; }
        }

        public string[] AlbumArtists
        {
            get { return file.Tag.AlbumArtists; }
            set { file.Tag.AlbumArtists = value; }
        }

        public string Comment
        {
            get { return file.Tag.Comment; }
            set { file.Tag.Comment = value; }
        }

        public int Track
        {
            get { return Convert.ToInt32(file.Tag.Track); }

            set { file.Tag.Track = Convert.ToUInt32(value); }
        }

        public string Title
        {
            get { return file.Tag.Title; }

            set { file.Tag.Title = value; }
        }

        public string Genre
        {
            get { return file.Tag.Genres[0]; }

            set { file.Tag.Genres[0] = value; }
        }

        public int Year
        {
            get { return Convert.ToInt32(file.Tag.Year); }

            set { file.Tag.Year = Convert.ToUInt32(value); }
        }

        public override void Save()
        {
            file.Save();
        }
    }
}

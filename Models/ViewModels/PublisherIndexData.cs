﻿using Betea_Bianca_LAB2.Models;
namespace Betea_Bianca_LAB2.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}

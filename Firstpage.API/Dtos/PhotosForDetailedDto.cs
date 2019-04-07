using System;

namespace Firstpage.API.Dtos
{
    public class PhotosForDetailedDto
    {
        public int Id { get; set; }
        public string  Url { get; set; }

        public string Description { get; set; }

        public DateTime DateAddded { get; set; }
        
        public bool IsMain { get; set; }
    }
}
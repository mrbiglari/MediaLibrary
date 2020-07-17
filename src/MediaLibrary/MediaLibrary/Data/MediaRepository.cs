using MediaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Data
{
    public class MediaRepository
    {
        private readonly MediaContext _context;

        public MediaRepository(MediaContext context)
        {
            _context = context;
        }
        public Media GetMedia(int id)
        {
            return _context.Media.Single(x => x.Id == id);
        }
        public bool SaveMedia(Media media)
        {
            throw new NotImplementedException();
        }

    }
}

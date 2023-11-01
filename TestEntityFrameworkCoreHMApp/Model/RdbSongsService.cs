using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntityFrameworkCoreHMApp.Model
{
    internal class RdbSongsService
    {
        public Song Add(Song song)
        {
            using (var db = new AppConfigContext())
            {
                db.Add(song);
                db.SaveChanges();
                return song;
            }
        }
        public List<Song> GetAll()
        {
            using (var db = new AppConfigContext())
            {
                return db.Songs.ToList();
            }
        }
        public Song? GetById(int id)
        {
            using (var db = new AppConfigContext())
            {
                return db.Songs.FirstOrDefault(s => s.Id == id);
            }
        }
    }
}



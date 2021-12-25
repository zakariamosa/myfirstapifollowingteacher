using Microsoft.EntityFrameworkCore;
using myFirstRESTApi.DTOs;
using myFirstRESTApi.Entities;

namespace myFirstRESTApi.Repo
{
    public class VinylRepo : IVinylRepo
    {
        private ApplicationContext _context;//eller _db
        public VinylRepo(ApplicationContext context)
        {
            _context = context;
        }

        public Vinyl CreateVinyl(CreateVinylDTO createdVinylDTO)
        {
            var vinyl= new Vinyl();
            vinyl.Created = DateTime.Now;
            vinyl.ArtistID = createdVinylDTO.ArtistID;
            vinyl.Title = createdVinylDTO.Title;
            _context.Vinyls.Add(vinyl);
            _context.SaveChanges();
            //_vinyls.Add(vinyl);
            return vinyl;
        }

        public void DeleteVinyl(int id)
        {
            _context.Vinyls.Remove(GetByID(id));
            _context.SaveChanges();
        }

        public List<Vinyl> GetAll()
        {
            return _context.Vinyls.Include(v=>v.Artist).ToList();
        }

        public Vinyl GetByID(int id)
        {
            Vinyl vinyl = _context.Vinyls.Include(v => v.Artist).FirstOrDefault(v=>v.Id==id);
            return vinyl;
        }

        public Vinyl UpdateVinyl(Vinyl vinyl, int id)
        {
            Vinyl existingvinyl = _context.Vinyls.FirstOrDefault(x=>x.Id == id);
            if(existingvinyl != null)
            {
                existingvinyl.Title=vinyl.Title;
                existingvinyl.Artist=vinyl.Artist;
            }
            _context.SaveChanges();
            return existingvinyl;
        }

        
    }
}

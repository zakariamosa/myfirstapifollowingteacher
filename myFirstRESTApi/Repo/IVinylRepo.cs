using myFirstRESTApi.DTOs;
using myFirstRESTApi.Entities;

namespace myFirstRESTApi.Repo
{
    public interface IVinylRepo
    {
        List<Vinyl> GetAll();
        Vinyl GetByID(int id);

        Vinyl CreateVinyl(CreateVinylDTO vinyl);

        Vinyl UpdateVinyl(Vinyl vinyl, int id);

        void DeleteVinyl(int id);
    }
}

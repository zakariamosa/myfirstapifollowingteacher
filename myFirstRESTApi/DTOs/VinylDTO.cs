using myFirstRESTApi.Entities;

namespace myFirstRESTApi.DTOs
{
    public class VinylDTO
    {
        public int Id { get; set; }
        
        public BasicArtistDTO Artist { get; set; }
        public string Title { get; set; }
    }

    public static class VinylDTOExtenstions
    {
        public static VinylDTO MapToVinylDTO(this Vinyl vinyl)
        {
            return new VinylDTO
            {
                Id = vinyl.Id,
                Title = vinyl.Title,
                
                Artist = vinyl.Artist.MapToBasicArtistDTO()
            };
        }
        public static List<VinylDTO> MapToVinylDTOs(this List<Vinyl> vinyls)
        {
            return vinyls.Select(v => v.MapToVinylDTO()).ToList();
        }
    }
}

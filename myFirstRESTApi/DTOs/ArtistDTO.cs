

using myFirstRESTApi.Entities;

namespace myFirstRESTApi.DTOs
{
    public class ArtistDTO
    {
        
        public int Id { get; set; }
       
        public string Name { get; set; }
        
        public DateTime Created { get; set; }
        public string FavoriteCar { get; set; }

        public List<VinylDTO> Vinyls { get; set; }
    }

    public static class ArtistDTOExtensions
    {
        public static ArtistDTO MapToArtistDTO(this Artist artis)
        {
            return new ArtistDTO
            {
                Id = artis.Id,
                Name = artis.Name,
                FavoriteCar = artis.FavoriteCar,
                Vinyls = artis.Vinyls.MapToVinylDTOs(),
            };
        }

        public static List<ArtistDTO> MapToArtistDTOs(this List<Artist> artists)
        {
            return artists.Select(a=>a.MapToArtistDTO()).ToList();
        }
    }
}

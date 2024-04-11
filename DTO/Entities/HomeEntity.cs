using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DTO.Entities
{
    public sealed class HomeEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public List<ReservationEntity> Reservations { get; set; }
    }
}

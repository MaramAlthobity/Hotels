using System.ComponentModel.DataAnnotations;
namespace Hotels.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        public int IdRooms { get; set; }
        public int IdHotel { get; set; }
        public int IdRoomDetails { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public decimal Net { get; set; }
        public decimal Tax { get; set; }
        public DateTime DateInvoice { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DataTo { get; set; }
        public int UserId { get; set; }

    }
}


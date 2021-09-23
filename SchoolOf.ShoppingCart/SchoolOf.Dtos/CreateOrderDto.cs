namespace SchoolOf.Dtos
{
    public class CreateOrderDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public long CartId { get; set; }
    }
}

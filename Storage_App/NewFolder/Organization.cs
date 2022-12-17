namespace Storage_App.NewFolder
{
    public class Organization
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public override string ToString() => $"Id: {Id}\tFull Name:{Name}";
    }
}

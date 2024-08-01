namespace BaseLibrary.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? CivilId { get; set; }
        public string? FileNumber { get; set; }
        public string? FullName { get; set; }
        public string? JobName { get; set; }
        public string? Address { get; set; }
        public string? TelephoneNumber { get; set; }
        public string? Photo { get; set; }
        public string? Other { get; set; }

        #region Связующие
        public GeneralDepartnent? GeneralDepartnent { get; set; }
        public int GeneralDepartmnentId { get; set; }
        public Departmnent? Departmnent { get; set; }
        public int DepartmnentId { get; set; }
        public Branch? Branch { get; set; }
        public int BranchId { get; set; }
        public Town? Town { get; set; }
        public int TownId { get; set; }
        #endregion
    }
}

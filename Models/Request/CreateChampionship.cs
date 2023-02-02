using System;
namespace Championship_Internal_Front.Models.Request
{
	public class CreateChampionship
	{
        public string? Title { get; set; }
        public DateTime StartDate { get; set; }
        public int TotalPhases { get; set; }
    }
}


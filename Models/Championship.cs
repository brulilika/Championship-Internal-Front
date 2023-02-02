﻿using System;
namespace Championship_Internal_Front.Models
{
	public class Championship
	{
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public DateTime StartDate { get; set; }
        public int TotalPhases { get; set; }
        public Guid WinnerTeam { get; set; }
        public Guid SecondTeam { get; set; }
        public Guid ThirdTeam { get; set; }
    }
}


﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace xilopro2.Data.Entities
{
    public class Matchgame
    {
    
        public int Match_ID { get; set; }

        [Display(Name = "Fecha:")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime Date { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime DateLocal => Date.ToLocalTime();

        [Display(Name = "Jornada:")]
        public string Jornada { get; set; }


        [Display(Name = "Goles Local")]
        public int GoalsLocal { get; set; } = 0;

        [Display(Name = "Goles Visitante")]
        public int GoalsVisitor { get; set; } = 0;

        [Display(Name = "Is Closed?")]
        public bool IsClosed { get; set; }

        public int torneoid { get; set; }


        //relations

        public Team? TeamLocal { get; set; }


        public int TeamLocalId { get; set; }



        public Team? TeamVisitor { get; set; }

        public int TeamVisitorId { get; set; }


        [ForeignKey("GroupsrId")]
        public Groups? Groups { get; set; }
        public int GroupsrId { get; set; }


        [Display(Name = "# Estadisticas")]
        public int PlayerStatisticsNumber => PlayerStatistics == null ? 0 : PlayerStatistics.Count;
        public List<PlayerStatistics>? PlayerStatistics { get; set; }


    }
}

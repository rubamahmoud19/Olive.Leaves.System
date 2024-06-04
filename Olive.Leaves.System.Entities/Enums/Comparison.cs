﻿using System.ComponentModel.DataAnnotations;

namespace Olive.Leaves.System.Entities.Enums
{
    public enum Comparison
    {
    [Display(Name = "==")]
        Equal,

    [Display(Name = "<")]
        LessThan,

    [Display(Name = "<=")]
        LessThanOrEqual,

    [Display(Name = ">")]
        GreaterThan,

    [Display(Name = ">=")]
        GreaterThanOrEqual,

    [Display(Name = "!=")]
        NotEqual,

    [Display(Name = "Contains")]
        Contains, //for strings  

    [Display(Name = "StartsWith")]
        StartsWith, //for strings  

    [Display(Name = "EndsWith")]
        EndsWith, //for strings  
    }
}

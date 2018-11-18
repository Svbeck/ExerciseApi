using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace ExerciseApi.Models
{
    public class Exercise
    {
        [Key]
        public long id {get; set;}
        public string name {get; set;}
        public string variation {get; set;}
        public int sets {get; set;}
        public int reps {get; set;}
        public string comment {get; set;}
        public string weakness {get; set;}
        public string strength {get; set;}
    }
        
}

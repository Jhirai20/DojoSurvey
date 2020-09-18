using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models
{
    public class Survey
    {
        [Required(ErrorMessage="Please enter a name.")]
        [MinLength(2,ErrorMessage="Please enter a name with more than 2 characters.")]
        public string Name{get;set;}
        [Required(ErrorMessage="Please select a Location.")]
        public string Location{get;set;}
        [Required(ErrorMessage="Please select a Language.")]
        public string Language{get;set;}
        [MinLength(20,ErrorMessage="Please enter a comment with more than 20 characters.")]
        public string Comment{get;set;}
    }
}
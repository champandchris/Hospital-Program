using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace hospital.Models

{
 public class Symptom

 {
     [Key]
     [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
     public int DiseaseId{get;set;}
     
     [Display (Name ="Disease Name")]
     [Required(ErrorMessage =" Disease Name!!!")]
     public String Disease{get;set;}

     [Display (Name ="Enter First Symptom")]
     [Required(ErrorMessage =" Symptom is Required!!!")]
     public String SymptomOne{get;set;}
     
    [Display (Name ="Enter Second Symptom")]
     [Required(ErrorMessage =" Symptom is Required!!!")]
     public String SymptomTwo{get;set;}
     [Display (Name ="Enter Third Symptom")]
     [Required(ErrorMessage =" Symptom is Required!!!")]
     public String SymptomThree{get;set;}
     [Display (Name ="Enter Fourth Symptom")]
     [Required(ErrorMessage =" Symptom is Required!!!")]
     public String SymptomFour{get;set;}
     [Display (Name ="Enter Fifth Symptom")]
     [Required(ErrorMessage =" Symptom is Required!!!")]
     public String SymptomFive{get;set;}

     
     


     








  


 }
}
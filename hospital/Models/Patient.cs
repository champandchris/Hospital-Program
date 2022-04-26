using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace hospital.Models

{
 public class Patient
 {
     [Key]
     [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
     public int PatientId{get;set;}
     [Display (Name ="Enter First Name")]
     [Required(ErrorMessage ="First Name is Required!!!")]
     public String FirstName{get;set;}
     
     [Display (Name ="Enter Last Name")]
     [Required(ErrorMessage ="Last Name is Required!!!")]
     public String LastName{get;set;}

     

    
     
 }
}
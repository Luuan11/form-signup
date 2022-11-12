using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Pages.Models
{
        public class User
        {
            [Key]
            public int ID { get; set; }

            [Required(ErrorMessage = "Por favor insira seu primeiro nome aqui")]
            [Display(Name = "Primeiro nome*")]
            public string FirstName { get; set; }

            [Required(ErrorMessage = "Por favor insira seu sobrenome aqui")]
            [Display(Name = "Sobrenome*")]
            public string LastName { get; set; }

            [Required(ErrorMessage = "Por favor insira seu email aqui")]
            [Display(Name = "Email*")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Insira seu número de telefone aqui")]
            [Display(Name = "Número de celular*")]
            public string PhoneNumber { get; set; }

            [Required(ErrorMessage = "Por favor insria uma senha aqui")]
            [DataType(DataType.Password)]
            [Display(Name = "Senha*")]
            public string Pwd { get; set; }

            [Required(ErrorMessage = "Por favor confirme sua senha aqui")]
            [DataType(DataType.Password)]
            [Display(Name = "Confirme a senha*")]
            [Compare("Pwd")]
            public string ConfirmPwd { get; set; }
        }
    public class ApplicationUser : DbContext
    {
        public ApplicationUser(DbContextOptions<ApplicationUser> options) : base(options)
        {

        }
        public DbSet<User> UserRegistration { get; set; }
    }
}

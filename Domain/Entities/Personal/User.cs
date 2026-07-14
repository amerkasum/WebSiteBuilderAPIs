using Domain.Entities.IEntities;
using Helpers.Helpers.RegularExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Personal
{
    public class User : IEntity
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(RegEx.AllLetters)]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression(RegEx.AllLetters)]
        public string LastName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}

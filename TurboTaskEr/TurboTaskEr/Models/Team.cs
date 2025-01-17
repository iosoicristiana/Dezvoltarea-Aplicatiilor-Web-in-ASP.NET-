﻿using System.ComponentModel.DataAnnotations.Schema;

namespace TurboTaskEr.Models
{
    public class Team
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? UserId { get; set; }

        public int? ProjectId { get; set; }

        public virtual ApplicationUser? User { get; set; }

        public virtual Project? Project { get; set; }

    }
}

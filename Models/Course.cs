using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementApp.Models;

[Table(nameof(Course))]
public class Course
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string CourseName { get; set; } = null!;

    public int Credits { get; set; }

    [Required]
    [MaxLength(100)]
    public string Department { get; set; } = null!;

    [MaxLength(500)]
    public string Description { get; set; } = null!;

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
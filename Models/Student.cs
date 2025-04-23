using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementApp.Models;

[Table(nameof(Student))]
public class Student
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; } = null!;

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    [Required]
    [MaxLength(100)]
    [EmailAddress]
    public string Email { get; set; } = null!;

    [MaxLength(20)]
    public string PhoneNumber { get; set; } = null!;

    public DateTime EnrollmentDate { get; set; }

    // Navigační vlastnost
    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
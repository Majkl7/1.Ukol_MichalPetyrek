using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentManagementApp.Models;

namespace StudentManagementApp.Models;

[Table(nameof(Enrollment))]
public class Enrollment
{
    public int Id { get; set; }

    public int StudentId { get; set; }
    [ForeignKey(nameof(StudentId))]
    public virtual Student Student { get; set; } = null!;

    public int CourseId { get; set; }
    [ForeignKey(nameof(CourseId))]
    public virtual Course Course { get; set; } = null!;

    public DateTime EnrollmentDate { get; set; }

    public string? Grade { get; set; }
}
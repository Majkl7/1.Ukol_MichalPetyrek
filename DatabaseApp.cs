using System;
using System.Runtime.ConstrainedExecution;
using StudentManagementApp;
using StudentManagementApp.Models;

namespace StudentManagementApp;

internal class DatabaseApp
{
    public void Run()
    {
        ShowCourse(1);
    }

    public void ShowCourse(int id)
    {
        using var dbContext = new AppDbContext();
        var course = dbContext.Courses.FirstOrDefault(x => x.Id == id);
        if (course != null)
        {
            Console.WriteLine($"{course.CourseName} {course.Department} {course.Description}");
        }
    }

    public void CreateCourse()
    {
        var course = new Course
        {
            CourseName = "English",
            Department = "Languages",
            Description = "English language"

        };
        using var dbContext = new AppDbContext();
        dbContext.Add(course);
        dbContext.SaveChanges();
    }
}
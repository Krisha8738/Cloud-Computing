using ISMTCollege.Models;
using Microsoft.EntityFrameworkCore;

namespace ISMTCollege.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Ensure database is created
            context.Database.EnsureCreated();

            // Check if data already exists
            if (context.Courses.Any() || context.Faculty.Any() || context.News.Any())
            {
                return; // Database has already been seeded
            }

            // Seed Courses
            var courses = new Course[]
            {
                new Course
                {
                    Name = "Bachelor of Computer Science",
                    Description = "Comprehensive program covering software development, algorithms, data structures, computer systems, and emerging technologies like artificial intelligence and machine learning.",
                    Duration = "4 Years",
                    Fees = 12000.00m,
                    IsActive = true
                },
                new Course
                {
                    Name = "Bachelor of Business Administration",
                    Description = "Develop leadership skills and business acumen through courses in management, marketing, finance, economics, and strategic planning for the modern corporate world.",
                    Duration = "4 Years",
                    Fees = 10500.00m,
                    IsActive = true
                },
                new Course
                {
                    Name = "Bachelor of Engineering",
                    Description = "Innovative engineering programs in civil, mechanical, and electrical engineering, preparing students for technological challenges and innovation.",
                    Duration = "4 Years",
                    Fees = 13500.00m,
                    IsActive = true
                },
                new Course
                {
                    Name = "Bachelor of Nursing",
                    Description = "Comprehensive nursing program combining theoretical knowledge with practical clinical experience to prepare compassionate healthcare professionals.",
                    Duration = "4 Years",
                    Fees = 11500.00m,
                    IsActive = true
                },
                new Course
                {
                    Name = "Bachelor of Arts in Design",
                    Description = "Creative design program covering graphic design, web design, user experience, and digital media for the modern creative industry.",
                    Duration = "4 Years",
                    Fees = 9500.00m,
                    IsActive = true
                },
                new Course
                {
                    Name = "Master of Education",
                    Description = "Advanced education program for teachers and educational leaders, focusing on curriculum development and educational leadership.",
                    Duration = "2 Years",
                    Fees = 8500.00m,
                    IsActive = true
                }
            };

            context.Courses.AddRange(courses);

            // Seed Faculty
            var faculty = new Faculty[]
            {
                new Faculty
                {
                    Name = "Dr. Sarah Johnson",
                    Designation = "Professor & Department Head",
                    Department = "Computer Science",
                    Email = "sarah.johnson@ismtcollege.edu",
                    Phone = "+1 (555) 123-4567",
                    IsActive = true
                },
                new Faculty
                {
                    Name = "Prof. Michael Chen",
                    Designation = "Associate Professor",
                    Department = "Business Administration",
                    Email = "michael.chen@ismtcollege.edu",
                    Phone = "+1 (555) 123-4568",
                    IsActive = true
                },
                new Faculty
                {
                    Name = "Dr. Emily Rodriguez",
                    Designation = "Assistant Professor",
                    Department = "Engineering",
                    Email = "emily.rodriguez@ismtcollege.edu",
                    Phone = "+1 (555) 123-4569",
                    IsActive = true
                },
                new Faculty
                {
                    Name = "Prof. David Thompson",
                    Designation = "Senior Lecturer",
                    Department = "Health Sciences",
                    Email = "david.thompson@ismtcollege.edu",
                    Phone = "+1 (555) 123-4570",
                    IsActive = true
                },
                new Faculty
                {
                    Name = "Dr. Lisa Park",
                    Designation = "Associate Professor",
                    Department = "Arts & Design",
                    Email = "lisa.park@ismtcollege.edu",
                    Phone = "+1 (555) 123-4571",
                    IsActive = true
                },
                new Faculty
                {
                    Name = "Prof. Robert Wilson",
                    Designation = "Lecturer",
                    Department = "Education",
                    Email = "robert.wilson@ismtcollege.edu",
                    Phone = "+1 (555) 123-4572",
                    IsActive = true
                }
            };

            context.Faculty.AddRange(faculty);

            // Seed News
            var news = new News[]
            {
                new News
                {
                    Title = "Student Achievement Award",
                    Content = "Congratulations to our students who won the regional science competition. The team demonstrated exceptional creativity and problem-solving skills in developing innovative solutions for environmental challenges. This achievement highlights the quality of education and research opportunities available at ISMT College.",
                    PublishedAt = DateTime.Parse("2024-12-15"),
                    IsPublished = true,
                    Category = "Achievements"
                },
                new News
                {
                    Title = "Spring Semester Registration",
                    Content = "Spring semester registration is now open. Early registration deadline is January 15th. Don't miss out on your preferred courses and schedule. Our academic advisors are available to help you plan your academic journey and ensure you meet all graduation requirements.",
                    PublishedAt = DateTime.Parse("2024-12-10"),
                    IsPublished = true,
                    Category = "Announcements"
                },
                new News
                {
                    Title = "New Research Lab Opening",
                    Content = "Our new state-of-the-art research laboratory is now open for students and faculty. The facility includes advanced equipment for cutting-edge research in biotechnology, nanotechnology, and renewable energy. This represents a significant investment in our research capabilities.",
                    PublishedAt = DateTime.Parse("2024-12-05"),
                    IsPublished = true,
                    Category = "Research"
                },
                new News
                {
                    Title = "International Conference",
                    Content = "ISMT College is proud to host the International Conference on Educational Technology. Join us for three days of insightful presentations, workshops, and networking opportunities with leading educators and researchers from around the world.",
                    PublishedAt = DateTime.Parse("2024-11-28"),
                    IsPublished = true,
                    Category = "Events"
                },
                new News
                {
                    Title = "Alumni Success Story",
                    Content = "Meet Sarah Chen, our 2020 Computer Science graduate who recently launched her own tech startup. Her journey from ISMT College to entrepreneurship demonstrates the practical skills and entrepreneurial mindset our programs foster in students.",
                    PublishedAt = DateTime.Parse("2024-11-20"),
                    IsPublished = true,
                    Category = "Alumni"
                },
                new News
                {
                    Title = "Faculty Recognition",
                    Content = "Dr. Michael Johnson from the Engineering Department has been awarded the prestigious National Teaching Excellence Award for his innovative teaching methods and commitment to student success. This recognition reflects the high quality of our faculty.",
                    PublishedAt = DateTime.Parse("2024-11-15"),
                    IsPublished = true,
                    Category = "Faculty"
                }
            };

            context.News.AddRange(news);

            // Save all changes
            context.SaveChanges();
        }
    }
}

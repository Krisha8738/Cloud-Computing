using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ISMTCollege.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubmittedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactForms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fees = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Department = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ProfileImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    FeaturedImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            // Insert sample data
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Name", "Description", "Duration", "Fees", "IsActive" },
                values: new object[,]
                {
                    {
                        "Bachelor of Computer Science",
                        "Comprehensive program covering software development, algorithms, data structures, computer systems, and emerging technologies like artificial intelligence and machine learning.",
                        "4 Years",
                        12000.00m,
                        true
                    },
                    {
                        "Bachelor of Business Administration",
                        "Develop leadership skills and business acumen through courses in management, marketing, finance, economics, and strategic planning for the modern corporate world.",
                        "4 Years",
                        10500.00m,
                        true
                    },
                    {
                        "Bachelor of Engineering",
                        "Innovative engineering programs in civil, mechanical, and electrical engineering, preparing students for technological challenges and innovation.",
                        "4 Years",
                        13500.00m,
                        true
                    },
                    {
                        "Bachelor of Nursing",
                        "Comprehensive nursing program combining theoretical knowledge with practical clinical experience to prepare compassionate healthcare professionals.",
                        "4 Years",
                        11500.00m,
                        true
                    },
                    {
                        "Bachelor of Arts in Design",
                        "Creative design program covering graphic design, web design, user experience, and digital media for the modern creative industry.",
                        "4 Years",
                        9500.00m,
                        true
                    },
                    {
                        "Master of Education",
                        "Advanced education program for teachers and educational leaders, focusing on curriculum development and educational leadership.",
                        "2 Years",
                        8500.00m,
                        true
                    }
                });

            migrationBuilder.InsertData(
                table: "Faculty",
                columns: new[] { "Name", "Designation", "Department", "Email", "Phone", "IsActive" },
                values: new object[,]
                {
                    {
                        "Dr. Sarah Johnson",
                        "Professor & Department Head",
                        "Computer Science",
                        "sarah.johnson@ismtcollege.edu",
                        "+1 (555) 123-4567",
                        true
                    },
                    {
                        "Prof. Michael Chen",
                        "Associate Professor",
                        "Business Administration",
                        "michael.chen@ismtcollege.edu",
                        "+1 (555) 123-4568",
                        true
                    },
                    {
                        "Dr. Emily Rodriguez",
                        "Assistant Professor",
                        "Engineering",
                        "emily.rodriguez@ismtcollege.edu",
                        "+1 (555) 123-4569",
                        true
                    },
                    {
                        "Prof. David Thompson",
                        "Senior Lecturer",
                        "Health Sciences",
                        "david.thompson@ismtcollege.edu",
                        "+1 (555) 123-4570",
                        true
                    },
                    {
                        "Dr. Lisa Park",
                        "Associate Professor",
                        "Arts & Design",
                        "lisa.park@ismtcollege.edu",
                        "+1 (555) 123-4571",
                        true
                    },
                    {
                        "Prof. Robert Wilson",
                        "Lecturer",
                        "Education",
                        "robert.wilson@ismtcollege.edu",
                        "+1 (555) 123-4572",
                        true
                    }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Title", "Content", "PublishedAt", "IsPublished", "Category" },
                values: new object[,]
                {
                    {
                        "Student Achievement Award",
                        "Congratulations to our students who won the regional science competition. The team demonstrated exceptional creativity and problem-solving skills in developing innovative solutions for environmental challenges. This achievement highlights the quality of education and research opportunities available at ISMT College.",
                        DateTime.Parse("2024-12-15"),
                        true,
                        "Achievements"
                    },
                    {
                        "Spring Semester Registration",
                        "Spring semester registration is now open. Early registration deadline is January 15th. Don't miss out on your preferred courses and schedule. Our academic advisors are available to help you plan your academic journey and ensure you meet all graduation requirements.",
                        DateTime.Parse("2024-12-10"),
                        true,
                        "Announcements"
                    },
                    {
                        "New Research Lab Opening",
                        "Our new state-of-the-art research laboratory is now open for students and faculty. The facility includes advanced equipment for cutting-edge research in biotechnology, nanotechnology, and renewable energy. This represents a significant investment in our research capabilities.",
                        DateTime.Parse("2024-12-05"),
                        true,
                        "Research"
                    },
                    {
                        "International Conference",
                        "ISMT College is proud to host the International Conference on Educational Technology. Join us for three days of insightful presentations, workshops, and networking opportunities with leading educators and researchers from around the world.",
                        DateTime.Parse("2024-11-28"),
                        true,
                        "Events"
                    },
                    {
                        "Alumni Success Story",
                        "Meet Sarah Chen, our 2020 Computer Science graduate who recently launched her own tech startup. Her journey from ISMT College to entrepreneurship demonstrates the practical skills and entrepreneurial mindset our programs foster in students.",
                        DateTime.Parse("2024-11-20"),
                        true,
                        "Alumni"
                    },
                    {
                        "Faculty Recognition",
                        "Dr. Michael Johnson from the Engineering Department has been awarded the prestigious National Teaching Excellence Award for his innovative teaching methods and commitment to student success. This recognition reflects the high quality of our faculty.",
                        DateTime.Parse("2024-11-15"),
                        true,
                        "Faculty"
                    }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactForms");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "News");
        }
    }
}

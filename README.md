# ISMT College Website

A modern, user-friendly college website built with ASP.NET Core 9.0, featuring a complete contact form system that stores data in a database.

## Features

- **Modern, Responsive Design**: Built with Bootstrap 5 and custom CSS
- **Complete College Website**: Home, About, Courses, Faculty, News, and Contact pages
- **Functional Contact Form**: Stores submissions in SQL Server database
- **Database Integration**: Entity Framework Core with SQL Server
- **User-Friendly Interface**: Intuitive navigation and modern UI components
- **Mobile Responsive**: Works perfectly on all device sizes
- **Font Awesome Icons**: Beautiful iconography throughout the site

## Technology Stack

- **Backend**: ASP.NET Core 9.0
- **Database**: SQL Server (LocalDB)
- **ORM**: Entity Framework Core 9.0
- **Frontend**: Bootstrap 5, HTML5, CSS3, JavaScript
- **Icons**: Font Awesome 6.0
- **Development**: Visual Studio 2022 / VS Code

## Prerequisites

- .NET 9.0 SDK
- SQL Server (LocalDB recommended for development)
- Visual Studio 2022 or VS Code

## Installation & Setup

### 1. Clone the Repository

```bash
git clone <repository-url>
cd cloudd
```

### 2. Open the Solution

Open `ISMTCollege.sln` in Visual Studio 2022 or your preferred IDE.

### 3. Database Setup

The project uses SQL Server LocalDB by default. If you don't have it installed:

1. Install SQL Server LocalDB from Microsoft
2. Or modify the connection string in `appsettings.json` to use your preferred database

### 4. Install Dependencies

```bash
cd ISMTCollege
dotnet restore
```

### 5. Run Database Migrations

```bash
dotnet ef database update
```

### 6. Run the Application

```bash
dotnet run
```

Or press F5 in Visual Studio.

The application will be available at: `https://localhost:5001` or `http://localhost:5000`

## Project Structure

```
ISMTCollege/
├── Controllers/          # MVC Controllers
├── Data/                # Database context and migrations
├── Models/              # Entity models
├── Views/               # Razor views
├── wwwroot/            # Static files (CSS, JS, images)
├── Program.cs          # Application entry point
├── appsettings.json    # Configuration
└── ISMTCollege.csproj  # Project file
```

## Database Schema

### ContactForms Table
- Stores contact form submissions
- Fields: Id, Name, Email, Subject, Message, SubmittedAt

### Courses Table
- Academic programs offered
- Fields: Id, Name, Description, Duration, Fees, IsActive

### Faculty Table
- Teaching staff information
- Fields: Id, Name, Designation, Department, Email, Phone, ProfileImage, IsActive

### News Table
- College news and announcements
- Fields: Id, Title, Content, PublishedAt, IsPublished, FeaturedImage, Category

## Key Features

### 1. Home Page
- Hero section with call-to-action buttons
- Statistics display (faculty count, courses, etc.)
- Featured courses showcase
- Latest news section
- Responsive design with hover effects

### 2. About Page
- Mission and vision statements
- College history timeline
- Core values
- Facilities overview
- Professional layout with icons

### 3. Courses Page
- Program categories
- Detailed course listings
- Course features and benefits
- Call-to-action for enrollment

### 4. Faculty Page
- Faculty member profiles
- Department information
- Contact details
- Professional headshots (placeholder)

### 5. News Page
- News categories
- Latest updates
- Newsletter subscription
- News submission form

### 6. Contact Page
- **Functional contact form** with database storage
- Department contact information
- Campus location details
- FAQ section
- Form validation and error handling

## Contact Form Functionality

The contact form is fully functional and includes:

- **Form Validation**: Client-side and server-side validation
- **Database Storage**: All submissions are stored in the ContactForms table
- **Success Messages**: User feedback after successful submission
- **Error Handling**: Comprehensive error handling and display
- **Security**: Anti-forgery token protection

### How to Test the Contact Form

1. Navigate to the Contact page
2. Fill out the form with test data
3. Submit the form
4. Check the database to see the stored submission
5. Verify success message display

## Customization

### Adding New Pages

1. Add a new action method in `HomeController.cs`
2. Create a corresponding view in `Views/Home/`
3. Update the navigation in `_Layout.cshtml`

### Modifying the Database

1. Update the model classes in `Models/`
2. Create a new migration: `dotnet ef migrations add MigrationName`
3. Update the database: `dotnet ef database update`

### Styling Changes

- Main styles are in `wwwroot/css/site.css`
- Bootstrap classes are used throughout
- Custom CSS is included in each view for specific styling

## Deployment

### Local Development
```bash
dotnet run
```

### Production Build
```bash
dotnet publish -c Release
```

### Database Connection String
Update the connection string in `appsettings.json` for your production database:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=your-server;Database=ISMTCollege;User Id=your-user;Password=your-password;"
}
```

## Troubleshooting

### Common Issues

1. **Database Connection Error**
   - Verify SQL Server is running
   - Check connection string in `appsettings.json`
   - Ensure LocalDB is installed (for development)

2. **Migration Errors**
   - Delete the `Migrations` folder
   - Run `dotnet ef migrations add InitialCreate`
   - Run `dotnet ef database update`

3. **Build Errors**
   - Run `dotnet restore`
   - Clean and rebuild the solution
   - Verify .NET 9.0 SDK is installed

### Performance Tips

- Use the database for dynamic content
- Optimize images for web
- Enable compression in production
- Use CDN for external libraries

## Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Test thoroughly
5. Submit a pull request

## License

This project is licensed under the MIT License.

## Support

For support and questions:
- Email: info@ismtcollege.edu
- Phone: +1 (555) 123-4567
- Website: www.ismtcollege.edu

## Screenshots

The website features:
- Modern, professional design
- Responsive layout
- Interactive elements
- Beautiful typography
- Consistent branding
- User-friendly navigation

---

**Built with ❤️ for ISMT College**

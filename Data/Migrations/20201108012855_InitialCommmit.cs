using Microsoft.EntityFrameworkCore.Migrations;

namespace COREMVC.Data.Migrations
{
    public partial class InitialCommmit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department_Table$",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department_Table$", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Employees_Table$",
                columns: table => new
                {
                    EmployeeNumber = table.Column<double>(nullable: false),
                    Age = table.Column<double>(nullable: true),
                    Department = table.Column<string>(maxLength: 255, nullable: true),
                    EducationField = table.Column<string>(maxLength: 255, nullable: true),
                    EnvironmentSatisfaction = table.Column<double>(nullable: true),
                    Gender = table.Column<string>(maxLength: 255, nullable: true),
                    HourlyRate = table.Column<double>(nullable: true),
                    JobRole = table.Column<string>(maxLength: 255, nullable: true),
                    JobSatisfaction = table.Column<double>(nullable: true),
                    MaritalStatus = table.Column<string>(maxLength: 255, nullable: true),
                    MonthlyIncome = table.Column<double>(nullable: true),
                    RelationshipSatisfaction = table.Column<double>(nullable: true),
                    StandardHours = table.Column<double>(nullable: true),
                    StockOptionLevel = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees_Table$", x => x.EmployeeNumber);
                });

            migrationBuilder.CreateTable(
                name: "Employees_Table$ExternalData_1",
                columns: table => new
                {
                    EmployeeNumber = table.Column<double>(nullable: false),
                    Age = table.Column<double>(nullable: true),
                    Department = table.Column<string>(maxLength: 255, nullable: true),
                    EducationField = table.Column<string>(maxLength: 255, nullable: true),
                    EnvironmentSatisfaction = table.Column<double>(nullable: true),
                    Gender = table.Column<string>(maxLength: 255, nullable: true),
                    HourlyRate = table.Column<double>(nullable: true),
                    JobRole = table.Column<string>(maxLength: 255, nullable: true),
                    JobSatisfaction = table.Column<double>(nullable: true),
                    MaritalStatus = table.Column<string>(maxLength: 255, nullable: true),
                    MonthlyIncome = table.Column<double>(nullable: true),
                    RelationshipSatisfaction = table.Column<double>(nullable: true),
                    StandardHours = table.Column<double>(nullable: true),
                    StockOptionLevel = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees_Table$ExternalData_1", x => x.EmployeeNumber);
                });

            migrationBuilder.CreateTable(
                name: "Human_Resource_Table$",
                columns: table => new
                {
                    EmployeeNumber = table.Column<double>(nullable: false),
                    Age = table.Column<double>(nullable: true),
                    BusinessTravel = table.Column<string>(maxLength: 255, nullable: true),
                    Department = table.Column<string>(maxLength: 255, nullable: true),
                    DistanceFromHome = table.Column<double>(nullable: true),
                    EducationField = table.Column<string>(maxLength: 255, nullable: true),
                    Gender = table.Column<string>(maxLength: 255, nullable: true),
                    JobRole = table.Column<string>(maxLength: 255, nullable: true),
                    MaritalStatus = table.Column<string>(maxLength: 255, nullable: true),
                    NumCompaniesWorked = table.Column<double>(nullable: true),
                    OverTime = table.Column<string>(maxLength: 255, nullable: true),
                    TotalWorkingYears = table.Column<double>(nullable: true),
                    TrainingTimesLastYear = table.Column<double>(nullable: true),
                    YearsAtCompany = table.Column<double>(nullable: true),
                    YearsInCurrentRole = table.Column<double>(nullable: true),
                    YearsSinceLastPromotion = table.Column<double>(nullable: true),
                    YearsWithCurrManager = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Human_Resource_Table$", x => x.EmployeeNumber);
                });

            migrationBuilder.CreateTable(
                name: "Human_Resource_Table$ExternalData_1",
                columns: table => new
                {
                    Age = table.Column<double>(nullable: true),
                    BusinessTravel = table.Column<string>(maxLength: 255, nullable: true),
                    Department = table.Column<string>(maxLength: 255, nullable: true),
                    DistanceFromHome = table.Column<double>(nullable: true),
                    EducationField = table.Column<string>(maxLength: 255, nullable: true),
                    EmployeeNumber = table.Column<double>(nullable: true),
                    Gender = table.Column<string>(maxLength: 255, nullable: true),
                    JobRole = table.Column<string>(maxLength: 255, nullable: true),
                    MaritalStatus = table.Column<string>(maxLength: 255, nullable: true),
                    NumCompaniesWorked = table.Column<double>(nullable: true),
                    OverTime = table.Column<string>(maxLength: 255, nullable: true),
                    TotalWorkingYears = table.Column<double>(nullable: true),
                    TrainingTimesLastYear = table.Column<double>(nullable: true),
                    YearsAtCompany = table.Column<double>(nullable: true),
                    YearsInCurrentRole = table.Column<double>(nullable: true),
                    YearsSinceLastPromotion = table.Column<double>(nullable: true),
                    YearsWithCurrManager = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Login_Table$",
                columns: table => new
                {
                    EmailAdress = table.Column<string>(maxLength: 255, nullable: true),
                    Password = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Manager_Table$",
                columns: table => new
                {
                    EmployeeNumber = table.Column<double>(nullable: false),
                    Attrition = table.Column<string>(maxLength: 255, nullable: true),
                    DailyRate = table.Column<double>(nullable: true),
                    Department = table.Column<string>(maxLength: 255, nullable: true),
                    EmployeeCount = table.Column<double>(nullable: true),
                    HourlyRate = table.Column<double>(nullable: true),
                    JobInvolvement = table.Column<double>(nullable: true),
                    JobRole = table.Column<string>(maxLength: 255, nullable: true),
                    MonthlyIncome = table.Column<double>(nullable: true),
                    MonthlyRate = table.Column<double>(nullable: true),
                    OverTime = table.Column<string>(maxLength: 255, nullable: true),
                    PercentSalaryHike = table.Column<double>(nullable: true),
                    PerformanceRating = table.Column<double>(nullable: true),
                    StandardHours = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager_Table$", x => x.EmployeeNumber);
                });

            migrationBuilder.CreateTable(
                name: "Registration_Table$",
                columns: table => new
                {
                    EmailAddress = table.Column<string>(maxLength: 255, nullable: true),
                    Password = table.Column<string>(maxLength: 255, nullable: true),
                    JobRole = table.Column<string>(maxLength: 255, nullable: true),
                    Gender = table.Column<string>(maxLength: 255, nullable: true),
                    MaritalStatus = table.Column<string>(maxLength: 255, nullable: true),
                    EducatiionField = table.Column<string>(maxLength: 255, nullable: true),
                    Age = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Roles_Table$",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobRoles = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles_Table$", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Department_Table$");

            migrationBuilder.DropTable(
                name: "Employees_Table$");

            migrationBuilder.DropTable(
                name: "Employees_Table$ExternalData_1");

            migrationBuilder.DropTable(
                name: "Human_Resource_Table$");

            migrationBuilder.DropTable(
                name: "Human_Resource_Table$ExternalData_1");

            migrationBuilder.DropTable(
                name: "Login_Table$");

            migrationBuilder.DropTable(
                name: "Manager_Table$");

            migrationBuilder.DropTable(
                name: "Registration_Table$");

            migrationBuilder.DropTable(
                name: "Roles_Table$");
        }
    }
}

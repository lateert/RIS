using System;
using System.Linq;
using System.Web.UI;

namespace ContosoUniversity
{
    public partial class CoursesPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            using (var db = new SchoolEntities())
            {
                coursesGrid.DataSource = db.Courses
                    .OrderBy(course => course.Title)
                    .Select(course => new
                    {
                        course.CourseID,
                        course.Title,
                        course.Credits,
                        Department = course.Department.Name
                    })
                    .ToList();
                coursesGrid.DataBind();
            }
        }
    }
}

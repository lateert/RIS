using System;
using System.Linq;
using System.Web.UI;

namespace ContosoUniversity
{
    public partial class InstructorsCoursesPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            using (var db = new SchoolEntities())
            {
                assignmentsGrid.DataSource = (
                    from person in db.People
                    from course in person.Courses
                    orderby person.LastName, course.Title
                    select new
                    {
                        person.LastName,
                        person.FirstMidName,
                        course.Title
                    }).ToList();
                assignmentsGrid.DataBind();
            }
        }
    }
}

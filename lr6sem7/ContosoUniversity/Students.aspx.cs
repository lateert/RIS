using System;
using System.Linq;
using System.Web.UI;

namespace ContosoUniversity
{
    public partial class StudentsPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            using (var db = new SchoolEntities())
            {
                peopleGrid.DataSource = db.People
                    .Where(person => person.EnrollmentDate != null)
                    .OrderBy(person => person.LastName)
                    .Select(person => new
                    {
                        person.PersonID,
                        person.LastName,
                        person.FirstMidName,
                        person.EnrollmentDate
                    })
                    .ToList();
                peopleGrid.DataBind();
            }
        }
    }
}

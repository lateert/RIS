using System;
using System.Linq;
using System.Web.UI;

namespace ContosoUniversity
{
    public partial class OfficeAssignmentsPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            using (var db = new SchoolEntities())
            {
                officesGrid.DataSource = db.OfficeAssignments
                    .OrderBy(office => office.Person.LastName)
                    .Select(office => new
                    {
                        office.Person.LastName,
                        office.Person.FirstMidName,
                        office.Location
                    })
                    .ToList();
                officesGrid.DataBind();
            }
        }
    }
}

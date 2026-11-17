using System;
using System.Linq;
using System.Web.UI;

namespace ContosoUniversity
{
    public partial class InstructorsPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            using (var db = new SchoolEntities())
            {
                instructorsGrid.DataSource = db.People
                    .Where(person => person.HireDate != null)
                    .OrderBy(person => person.LastName)
                    .Select(person => new
                    {
                        person.LastName,
                        person.FirstMidName,
                        person.HireDate
                    })
                    .ToList();
                instructorsGrid.DataBind();
            }
        }
    }
}

using System;
using System.Linq;
using System.Web.UI;

namespace ContosoUniversity
{
    public partial class DepartmentsPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            using (var db = new SchoolEntities())
            {
                departmentsGrid.DataSource = db.Departments
                    .OrderBy(department => department.Name)
                    .Select(department => new
                    {
                        department.Name,
                        department.Budget,
                        department.StartDate,
                        Administrator = department.Person.LastName
                    })
                    .ToList();
                departmentsGrid.DataBind();
            }
        }
    }
}

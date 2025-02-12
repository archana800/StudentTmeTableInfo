using System.Web.Mvc;
using TimeTable1.Models;

namespace TimeTable1.Controllers
{
    public class HomeController : Controller
    {
        #region Methods

        public ActionResult Index(StudentSub inputFields)
        {

            if (inputFields.Total_hours_for_week != null && inputFields.Total_hours_for_week > 0)
            {
                if (inputFields.Total_Subjects == 1)
                {
                    inputFields.Sub_Working_Hours = inputFields.Total_hours_for_week;
                }
                else if (inputFields.Total_Subjects == 2)
                {
                    int total = inputFields.Total_hours_for_week / inputFields.Total_Subjects;
                    inputFields.Sub_Working_Hours = total;

                }
                else if (inputFields.Total_Subjects == 3)
                {

                    int total = inputFields.Total_hours_for_week / inputFields.Total_Subjects;
                    inputFields.Sub_Working_Hours = total;
                }
                else
                {

                    int total = inputFields.Total_hours_for_week / inputFields.Total_Subjects;
                    inputFields.Sub_Working_Hours = total;
                }
                return RedirectToAction("GeneratSubject", inputFields);
            }

            return View();
        }

        public ActionResult GeneratSubject(StudentSub inputFields)
        {
            return View(inputFields);
        }

    }

    #endregion
}
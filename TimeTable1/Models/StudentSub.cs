using System.ComponentModel.DataAnnotations;

namespace TimeTable1.Models
{
    public class StudentSub
    {
        #region properties

        public int Sub_Working_Hours { get; set; }

        public int Id { get; set; }

        [Required(ErrorMessage = "No of Working days is required")]
        public int No_of_Working_days { get; set; }

        [Required(ErrorMessage = "No of Subjects per day is required")]
        public int No_of_Subjects_per_day { get; set; }

        [Required(ErrorMessage = "Total Subjects is required")]
        public int Total_Subjects { get; set; }

        public int Total_hours_for_week { get; set; }

        #endregion
    }
}
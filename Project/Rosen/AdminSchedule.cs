using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Project
{
    class AdminSchedule
    {
        private readonly UploadScheduleData uploadScheduleData = new UploadScheduleData();
        public List<Schedule> GetSchedules { get; private set; }
        public AdminSchedule()
        {
            GetSchedules = uploadScheduleData.AllSchedules();
        }
        public void ModifyUsersData(string option, Schedule schedule)
        {
            uploadScheduleData.ModifyScheduleData(option,schedule);
            GetSchedules = uploadScheduleData.AllSchedules();
        }
        public List<String> ScheduleDataInfo(int id)
        {
            return uploadScheduleData.ShowDataInComboBoxesForSchedule(id);
        }
    }
}

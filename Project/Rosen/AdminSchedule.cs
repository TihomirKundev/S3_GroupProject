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
        private UploadScheduleData uploadScheduleData = new UploadScheduleData();
        public AdminSchedule()
        {
            getSchedules = uploadScheduleData.AllSchedules();
        }
        public List<Schedule> getSchedules
        {
            get;
            private set;
        }
        public void ModifyUsersData(string option, Schedule schedule)
        {
            uploadScheduleData.ModifyScheduleData(option,schedule);
            getSchedules = uploadScheduleData.AllSchedules();
        }
        public List<String> scheduleDataInfo(int id)
        {
            return uploadScheduleData.showDataInComboBoxesForSchedule(id);
        }
    }
}

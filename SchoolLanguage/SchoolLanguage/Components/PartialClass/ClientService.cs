using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLanguage.Components
{
    public partial class ClientService
    {
        public string RemaningTime
        {
            get
            {
                int time = (int)(StartTime - DateTime.Now).TotalMinutes;
                return $"Часы: {time/60} минуты: {time%60}";
            }
        }

        public string ColorTime
        {
            get
            {
                int time = (int)(StartTime-DateTime.Now).TotalMinutes;
                if (time < 60)
                {
                    return "Red";
                }
                else
                {
                    return "Black";
                }
            }
        }
    }
}

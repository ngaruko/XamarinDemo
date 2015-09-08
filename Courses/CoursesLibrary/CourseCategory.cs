using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesLibrary
{
    public class CourseCategory
    {
        public string CategoryTitle { get;internal set; }

        public string Description { get; internal set; }

        public override string ToString()
        {
            return CategoryTitle;
        }


        public string Image { get; internal set; }
    }
}

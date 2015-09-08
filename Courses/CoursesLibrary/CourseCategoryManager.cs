using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesLibrary
{
   public class CourseCategoryManager
   {
       private readonly List<CourseCategory> courseCategories;
        private int currentIndex = 0;
        private int lastIndex;
        public CourseCategoryManager()
        {
            courseCategories = InitCourseCategories();
            lastIndex = courseCategories.Count - 1;
        }

        private List<CourseCategory> InitCourseCategories()
        {
            var initCourseCategories = new List<CourseCategory>(){
              new CourseCategory()
                { 
                    CategoryTitle = "Android",
                    Description = "Android Programming Courses",
                    Image = "android_logo"
                },

                new CourseCategory()
                { 
                    CategoryTitle = "IOS",
                    Description = "IOS Programming Courses",
                    Image = "ios-logo"
                },
                new CourseCategory()
                { 
                    CategoryTitle = "Windows Phone",
                    Description = "Windows Phone Programming Courses",
                    Image = "windows"
                },
                new CourseCategory()
                { 
                    CategoryTitle = "Blackberry",
                    Description = "Blackberry Programming Courses",
                    Image = "blackberry"
                }

          };
            return initCourseCategories;
        }

       

        public int Length
        {
            get { return courseCategories.Count(); }
           
        }
        

        public void MoveFirst()
        {
            currentIndex = 0;

        }

        public void MovePrev()
        {
            if (currentIndex > 0)
            {
                --currentIndex;
            }

        }

        public void MoveNext()
        {
            if (currentIndex < lastIndex)
            {
                ++currentIndex;
            }

        }

        public void MoveTo(int position)
        {
            if (currentIndex >= 0 && currentIndex <= lastIndex)

                currentIndex = position;

            else 
                throw new IndexOutOfRangeException(String.Format("{0} must is InvalidCastException. Must be between 0 and {1}",position,lastIndex));
            

        }

        public CourseCategory Current
        {
            get { return courseCategories[currentIndex]; }
        }

        public bool CanMOvePrev
        {
            get
            { return currentIndex >0; }
        }

        public bool CanMOveNext
        {
            get
            { return currentIndex < lastIndex; }
        }
    }
}


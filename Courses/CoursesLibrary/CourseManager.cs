using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesLibrary
{
    public class CourseManager
    {
        private const string DefaultCategory = "Android";

        private  List<Course> courses;
        private int currentIndex = 0;
        private int lastIndex;
        //public CourseManager()
        //{
        //    courses = InitCourses();
        //    lastIndex = courses.Count - 1;
        //}

        //another constructor to manage categories

        public CourseManager()
            : this(DefaultCategory) { }

        public CourseManager(string categoryTitle)
        {
            switch (categoryTitle)
            {
                case "Android":
                    courses = InitCoursesAndroid();
                    break;

                case "IOS":
                    courses = InitCoursesIOS();
                    break;

                case "Windows Phone":
                    courses = InitCoursesWindowsPhone();
                    break;

                case "Blackberry":
                    courses = InitCoursesBlackberry();
                    break;



            }
            if (courses!=null)
            {
                lastIndex = courses.Count() - 1;
                
            }
            
        }

        private List<Course> InitCoursesBlackberry()
        {
            var courses = new List<Course>(){
              new Course()
                { 
                    Title = "Blackberry for .NET Developers",
                    Description = "Provides an overview of the tools used in the Blackberry " + 
                    "development process including the newly released Blackberry Studio.",
                    Image = "ps_top_card_01"
                },

                new Course()
                { 
                    Title = "Blackberry Dreams, Widgets, Notifications",
                    Description = "Provide users with a rich and interactive experience " +
                    "without ever requiring them to open your app.",
                    Image = "ps_top_card_02"
                },
                new Course()
                { 
                    Title = "Blackberry Photo/Video Programming",
                    Description = "Learn how to capitalize on the Blackberry camera " + 
                    "within your apps to capture still photos and video.",
                    Image = "ps_top_card_03"
                },
                new Course()
                { 
                    Title = "Blackberry Location-Based Apps",
                    Description = "Cover the wide range of Blackberry location capabilities " +
                    "including determining user location, power management, and " + 
                    "translating location data to human-readable addresses.",
                    Image = "ps_top_card_04"
                }

          };
            return courses;
        }

        private List<Course> InitCoursesWindowsPhone()
        {
            var initCourses = new List<Course>(){
              new Course()
                { 
                    Title = "Windows Phone for .NET Developers",
                    Description = "Provides an overview of the tools used in the Windows Phone " + 
                    "development process including the newly released Windows Phone Studio.",
                    Image = "ps_top_card_01"
                },

                new Course()
                { 
                    Title = "Windows Phone Dreams, Widgets, Notifications",
                    Description = "Provide users with a rich and interactive experience " +
                    "without ever requiring them to open your app.",
                    Image = "ps_top_card_02"
                },
                new Course()
                { 
                    Title = "Windows Phone Photo/Video Programming",
                    Description = "Learn how to capitalize on the Windows Phone camera " + 
                    "within your apps to capture still photos and video.",
                    Image = "ps_top_card_03"
                },
                new Course()
                { 
                    Title = "Windows Phone Location-Based Apps",
                    Description = "Cover the wide range of Windows Phone location capabilities " +
                    "including determining user location, power management, and " + 
                    "translating location data to human-readable addresses.",
                    Image = "ps_top_card_04"
                }

          };
            return initCourses;
        }

        private List<Course> InitCoursesIOS()
        {
            var initCourses = new List<Course>(){
              new Course()
                { 
                    Title = "IOS for .NET Developers",
                    Description = "Provides an overview of the tools used in the IOS " + 
                    "development process including the newly released IOS Studio.",
                    Image = "ps_top_card_01"
                },

                new Course()
                { 
                    Title = "IOS Dreams, Widgets, Notifications",
                    Description = "Provide users with a rich and interactive experience " +
                    "without ever requiring them to open your app.",
                    Image = "ps_top_card_02"
                },
                new Course()
                { 
                    Title = "IOS Photo/Video Programming",
                    Description = "Learn how to capitalize on the IOS camera " + 
                    "within your apps to capture still photos and video.",
                    Image = "ps_top_card_03"
                },
                new Course()
                { 
                    Title = "IOS Location-Based Apps",
                    Description = "Cover the wide range of IOS location capabilities " +
                    "including determining user location, power management, and " + 
                    "translating location data to human-readable addresses.",
                    Image = "ps_top_card_04"
                }

          };
            return initCourses;
        }

        private List<Course> InitCoursesAndroid()
        {
            var initCourses = new List<Course>(){
              new Course()
                { 
                    Title = "Android for .NET Developers",
                    Description = "Provides an overview of the tools used in the Android " + 
                    "development process including the newly released Android Studio.",
                    Image = "ps_top_card_01"
                },

                new Course()
                { 
                    Title = "Android Dreams, Widgets, Notifications",
                    Description = "Provide users with a rich and interactive experience " +
                    "without ever requiring them to open your app.",
                    Image = "ps_top_card_02"
                },
                new Course()
                { 
                    Title = "Android Photo/Video Programming",
                    Description = "Learn how to capitalize on the Android camera " + 
                    "within your apps to capture still photos and video.",
                    Image = "ps_top_card_03"
                },
                new Course()
                { 
                    Title = "Android Location-Based Apps",
                    Description = "Cover the wide range of Android location capabilities " +
                    "including determining user location, power management, and " + 
                    "translating location data to human-readable addresses.",
                    Image = "ps_top_card_04"
                }

          };
            return initCourses;
        }

        //private List<Course> InitCourses()
        //{
        //    var courses = new List<Course>(){
        //      new Course()
        //        { 
        //            Title = "Android for .NET Developers",
        //            Description = "Provides an overview of the tools used in the Android " + 
        //            "development process including the newly released Android Studio.",
        //            Image = "ps_top_card_01"
        //        },

        //        new Course()
        //        { 
        //            Title = "Android Dreams, Widgets, Notifications",
        //            Description = "Provide users with a rich and interactive experience " +
        //            "without ever requiring them to open your app.",
        //            Image = "ps_top_card_02"
        //        },
        //        new Course()
        //        { 
        //            Title = "Android Photo/Video Programming",
        //            Description = "Learn how to capitalize on the Android camera " + 
        //            "within your apps to capture still photos and video.",
        //            Image = "ps_top_card_03"
        //        },
        //        new Course()
        //        { 
        //            Title = "Android Location-Based Apps",
        //            Description = "Cover the wide range of Android location capabilities " +
        //            "including determining user location, power management, and " + 
        //            "translating location data to human-readable addresses.",
        //            Image = "ps_top_card_04"
        //        }

        //  };
        //    return courses;
        //}

       

        public int Length
        {
            get { return courses.Count(); }
           
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

        public Course Current
        {
            get { return courses[currentIndex]; }
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

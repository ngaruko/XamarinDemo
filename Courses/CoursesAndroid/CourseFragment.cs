using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Support.V4.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using CoursesLibrary;

namespace CoursesAndroid
{
    /// <summary>
    ///Components>> get more components:
    ///1...Android support library v4
    ///2. "              "          v7  AppCompat
    /// </summary>
    public class CourseFragment : Fragment
    {
        TextView textTitle;
        ImageView imageCourse;
        TextView textDescription;

        public Course Course { get; set; }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View rootView = inflater.Inflate(Resource.Layout.CourseFragment,container,false);
            textTitle = rootView.FindViewById<TextView>(Resource.Id.textTitle);

            imageCourse = rootView.FindViewById<ImageView>(Resource.Id.imageCourse);
            textDescription =rootView.FindViewById<TextView>(Resource.Id.textDescription);

            //UI update

            textTitle.Text = Course.Title;
            textDescription.Text = Course.Description;
            imageCourse.SetImageResource(ResourceHelper.TranslateDrawablesWithReflection(Course.Image));
           
            return rootView;
        }
    }
}
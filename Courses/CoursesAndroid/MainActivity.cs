using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using CoursesLibrary;

namespace CoursesAndroid
{
    //[Activity(Label = "Courses", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        Button buttonPrev;
        Button buttonNext;
        TextView textTitle;
        ImageView imageCourse;
        TextView textDescription;
        CourseManager courseManager;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //code

            buttonPrev = FindViewById<Button>(Resource.Id.buttonPrev);
            buttonNext = FindViewById<Button>(Resource.Id.buttonNext);
            textTitle = FindViewById<TextView>(Resource.Id.textTitle);

            imageCourse = FindViewById<ImageView>(Resource.Id.imageCourse);
            textDescription = FindViewById<TextView>(Resource.Id.textDescription);

            buttonPrev.Click += buttonPrev_Click;
            buttonNext.Click += buttonNext_Click;

             courseManager = new CourseManager();
             courseManager.MoveFirst();
             UpdateUI();



        }

        void buttonPrev_Click(object sender, EventArgs e)
        {
            courseManager.MovePrev();
            UpdateUI();
        }

        private void UpdateUI()
        {
            textTitle.Text = courseManager.Current.Title;
            textDescription.Text = courseManager.Current.Description;
            imageCourse.SetImageResource(ResourceHelper.TranslateDrawablesWithReflection(courseManager.Current.Image));
            buttonPrev.Enabled = courseManager.CanMOvePrev;
            buttonNext.Enabled = courseManager.CanMOveNext;
        }

        void buttonNext_Click(object sender, EventArgs e)
        {
            courseManager.MoveNext();


            UpdateUI();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;
using CoursesLibrary;
using Android.Support.V4.View;
using Android.Support.V4.Widget;

namespace CoursesAndroid
{
    [Activity(Label = "Courses", MainLauncher = true, Icon = "@drawable/icon")]

    //[Activity(Label = "CourseActivity")]
    public class CourseActivity : FragmentActivity
    {


        public const String DISPLAY_CATEGORY_TITLE_EXTRA = "DisplaCT";
        private const String DEFAULT_CATEGORY_TITLE = "Android";
        CourseCategoryManager courseCategoryManager;

        CourseManager courseManager;
        CoursePagerAdapter coursePagerAdapter;

        ViewPager viewPager;


        DrawerLayout drawerLayout;
        ListView categoryDrawerListView;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.CourseActivity); 
            
            //code with drawer
            courseCategoryManager = new CourseCategoryManager();
            courseCategoryManager.MoveFirst();

           String displayCategoryTitle = courseCategoryManager.Current.CategoryTitle;

          // String displayCategoryTitle = DEFAULT_CATEGORY_TITLE;

            //Intent startupIntent = this.Intent;
            //if (startupIntent != null)
            //{
            //    String displayCategoryTitleExtra = startupIntent.GetStringExtra(DISPLAY_CATEGORY_TITLE_EXTRA);
            //    if (displayCategoryTitleExtra != null)
            //        displayCategoryTitle = displayCategoryTitleExtra;
            //}

          
            courseManager = new CourseManager(displayCategoryTitle);
            courseManager.MoveFirst();

            
            coursePagerAdapter = new CoursePagerAdapter(SupportFragmentManager, courseManager);
            viewPager = FindViewById<ViewPager>(Resource.Id.coursePager);
            viewPager.Adapter = coursePagerAdapter;

            //drawer

            drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawerLayout);
            categoryDrawerListView = FindViewById<ListView>(Resource.Id.categoryDrawerListView);

            //categoryDrawerListView.Adapter =
            //    new CourseCategoryManagerAdapter(this, Android.Resource.Layout.SimpleListItem1, courseCategoryManager);

            categoryDrawerListView.Adapter =
                    new CourseCategoryManagerAdapter(this,Resource.Layout.CourseCategoryItem, courseCategoryManager);
        
        //android selected as default
            categoryDrawerListView.SetItemChecked(0, true);

            //click event for categories
            categoryDrawerListView.ItemClick += categoryDrawerListView_ItemClick;
        
        }

        /// <summary>
        /// Event handler for click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        void categoryDrawerListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            drawerLayout.CloseDrawer(categoryDrawerListView);

            courseCategoryManager.MoveTo(e.Position);
            courseManager = new CourseManager(courseCategoryManager.Current.CategoryTitle);
            coursePagerAdapter.CourseManager = courseManager;
        }
    }
}
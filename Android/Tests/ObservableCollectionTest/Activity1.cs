﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ObservableCollectionTest
{
    [Activity(Label = "ObservableCollectionTest", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
		private LinearLayout layout;
        private Button buttonAdd;
		private TextView textLastText;
		private TextView textLastCheck;
		private Spinner spinner;
		private EditableTextTable listView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

			this.RequestedOrientation = Android.Content.PM.ScreenOrientation.Portrait;

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

			this.layout = FindViewById<LinearLayout> (Resource.Id.layout);
			this.buttonAdd = FindViewById<Button>(Resource.Id.buttonAdd);
			this.textLastText = FindViewById<TextView> (Resource.Id.textLastText);
			this.textLastCheck = FindViewById<TextView> (Resource.Id.textLastCheck);
			this.spinner = FindViewById<Spinner> (Resource.Id.spinnerView);
			this.listView = FindViewById<EditableTextTable> (Resource.Id.listView1);

//			this.listView = new EditableTextTable (this);
//			this.layout.AddView (this.listView);

			this.buttonAdd.Click += (sender, e) => 
			{
				EditableTextViewModel.Instance.AddItem(new EditableText());
			};
        }

		void HandlePropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			var model = sender as EditableTextViewModel;
			if (model == null)
			{
				return;
			}

			if (e.PropertyName == "LatestTextChange")
			{
				this.textLastText.Text = model.LatestTextChange.Text;
			}
			else
			{
				this.textLastCheck.Text = model.LatestCheckChange.Text;
			}
		}

		protected override void OnResume ()
		{
			base.OnResume ();
			EditableTextViewModel.Instance.Items.Bind (this.spinner);
			EditableTextViewModel.Instance.Items.Bind (this.listView);

			this.textLastText.Text = EditableTextViewModel.Instance.LatestTextChange.Text;
			this.textLastCheck.Text = EditableTextViewModel.Instance.LatestCheckChange.Text;

			EditableTextViewModel.Instance.PropertyChanged += HandlePropertyChanged;
		}

		protected override void OnPause ()
		{
			base.OnPause ();
			EditableTextViewModel.Instance.Items.Unbind (this.spinner);
			EditableTextViewModel.Instance.Items.Unbind (this.listView);

			EditableTextViewModel.Instance.PropertyChanged -= HandlePropertyChanged;
		}
    }
}


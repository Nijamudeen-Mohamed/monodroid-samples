﻿using System;
using Android.App;

namespace BatchStepSensor.CardStream
{
	public class StreamRetentionFragment : Fragment
	{
		CardStreamState mState;
		public override void OnActivityCreated (Android.OS.Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);
			RetainInstance = true;
		}

		public CardStreamState CardStream{
			get { return mState; }
			set { mState = value; }
		}
	}
}


using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using EniDemo.Droid;
using EniDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


[assembly: Xamarin.Forms.Dependency (typeof (DeviceOrientationImplementation))]
namespace EniDemo.Droid
{
    public class DeviceOrientationImplementation : IDeviceOrientation
    {
        public DeviceOrientations GetOrientation()
        {
            IWindowManager windowManager =
                Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

            var rotation = windowManager.DefaultDisplay.Rotation;
            DeviceOrientations Orientation = DeviceOrientations.Unknow;

            if (rotation == SurfaceOrientation.Rotation0 || rotation == SurfaceOrientation.Rotation180)
            {
                Orientation = DeviceOrientations.Portrait;
            }
            else
            {
                Orientation = DeviceOrientations.Landscape;
            }

            return Orientation;
        }
    }
}
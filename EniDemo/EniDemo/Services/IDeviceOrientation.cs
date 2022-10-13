using System;
using System.Collections.Generic;
using System.Text;

namespace EniDemo.Services
{
    public enum DeviceOrientations
    {
        Unknow,
        Portrait,
        Landscape
    }

    public interface IDeviceOrientation
    {
        DeviceOrientations GetOrientation();
    }
}

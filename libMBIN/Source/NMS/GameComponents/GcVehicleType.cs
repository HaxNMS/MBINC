﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB05429E14A6EE274, SubGUID = 0x46812D05ED43A48D)]
    public class GcVehicleType : NMSTemplate
    {
		public enum VehicleTypeEnum { Buggy, Bike, Truck, WheeledBike, Hovercraft, Submarine }
		public VehicleTypeEnum VehicleType;
    }
}

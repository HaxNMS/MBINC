﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x48, GUID = 0x2E4918574094CC16, SubGUID = 0xCF538100E4D1C218)]
    public class GcRewardTableCategory : NMSTemplate
    {
        [NMS(Size = 0x3, EnumValue = new[] { "Small", "Medium", "Large"})]
        public GcRewardTableItemList[] Sizes;
    }
}

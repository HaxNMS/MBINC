﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x28A5F0DD7B123C68, SubGUID = 0xD3E29E0D0AAA3B2B)]
    public class GcPlayerCharacterIKOverrideData : NMSTemplate
    {
        public bool Enabled;
        public float Strength;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding8;
        public Vector3f RotStrengths;
    }
}

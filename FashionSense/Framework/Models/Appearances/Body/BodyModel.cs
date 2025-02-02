﻿using FashionSense.Framework.Interfaces.API;
using FashionSense.Framework.Models.Appearances.Generic;

namespace FashionSense.Framework.Models.Appearances.Body
{
    public class BodyModel : AppearanceModel
    {
        public int EyeBackgroundPosition { get; set; }
        public int EyePosition { get; set; }
        public bool HideEyes { get; set; }

        public int HeightOffset { get; set; }
        public int? AccessoryOffset { get; set; }
        public int? HeadOffset { get; set; }
        public int? LegOffset { get; set; }
        public int? BodyOffset { get; set; }
        public int? ArmsOffset { get; set; }
        public Size BodySize { get; set; }

        internal int GetFeatureOffset(IApi.Type type, int defaultValue = 0)
        {
            switch (type)
            {
                case IApi.Type.Accessory:
                    return AccessoryOffset is not null ? AccessoryOffset.Value : defaultValue;
                case IApi.Type.Hat:
                case IApi.Type.Hair:
                    return HeadOffset is not null ? HeadOffset.Value : defaultValue;
                case IApi.Type.Pants:
                case IApi.Type.Shoes:
                    return LegOffset is not null ? LegOffset.Value : defaultValue;
                case IApi.Type.Shirt:
                    return BodyOffset is not null ? BodyOffset.Value : defaultValue;
                case IApi.Type.Sleeves:
                    return ArmsOffset is not null ? ArmsOffset.Value : defaultValue;
                default:
                    return defaultValue;
            }
        }
    }
}

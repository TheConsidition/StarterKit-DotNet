﻿using Newtonsoft.Json;

namespace Considition.RestApi.Models.Objective
{
    public class NearbyLandObjective : GameObjective
    {
        [JsonProperty("x")]
        public int X
        {
            get { return (int)V1; }
            set { V1 = value; }
        }

        [JsonProperty("y")]
        public int Y
        {
            get { return (int)V2; }
            set { V2 = value; }
        }
    }
}

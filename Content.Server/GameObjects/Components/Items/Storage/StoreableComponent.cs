﻿using SS14.Shared.GameObjects;
using SS14.Shared.GameObjects.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.Server.GameObjects
{
    public class StoreableComponent : Component
    {
        public override string Name => "Storeable";

        public int ObjectSize = 0;

        public override void ExposeData(EntitySerializer serializer)
        {
            base.ExposeData(serializer);

            serializer.DataField(ref ObjectSize, "Size", 1);
        }
    }

    /// <summary>
    /// Enum for the storage capacity of various containers
    /// </summary>
    public enum ReferenceSizes
    {
        Wallet = 4,
        Pocket = 12,
        Box = 24,
        Belt = 30,
        Toolbox = 60,
        Backpack = 100,
        NoStoring = 9999
    }
}

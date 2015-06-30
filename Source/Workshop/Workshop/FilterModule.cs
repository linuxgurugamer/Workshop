﻿namespace Workshop
{
    using System.Collections.Generic;
    using System.Linq;

    public class FilterModule : FilterBase
    {
        public string Module;

        public FilterModule(string texturePath, string module) : base(texturePath)
        {
            this.Module = module;
        }

        public override WorkshopItem[] Filter(IEnumerable<WorkshopItem> items)
        {
            return items.Where(i => i.Part.partPrefab.GetComponent(Module) != null).ToArray();
        }
    }
}
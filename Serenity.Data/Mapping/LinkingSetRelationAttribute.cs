﻿using System;

namespace Serenity.Data.Mapping
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class LinkingSetRelationAttribute : Attribute
    {
        /// <summary>
        /// Declares a linking set relation
        /// </summary>
        /// <param name="rowType">Linking row type</param>
        /// <param name="thisKey">Name of the field in linking row that corresponds to ID in this table</param>
        /// <param name="itemKey">Name of the field in linking row that will hold item values in list</param>
        public LinkingSetRelationAttribute(Type rowType, string thisKey, string itemKey)
        {
            Check.NotNull(rowType, "LinkingSetRelationAttribute.RowType");
            Check.NotNullOrEmpty(thisKey, "LinkingSetRelationAttribute.ThisKey");
            Check.NotNullOrEmpty(itemKey, "LinkingSetRelationAttribute.ItemKey");

            this.RowType = rowType;
            this.ThisKey = thisKey;
            this.ItemKey = itemKey;
        }

        public Type RowType { get; private set; }
        public string ThisKey { get; private set; }
        public string ItemKey { get; private set; }
        public bool PreserveOrder { get; set; }
    }
}
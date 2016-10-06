using System;

namespace DynamicData
{
    /// <summary>
    /// The policy which will be applied when a mutable filter changes
    /// </summary>
    [Obsolete("This was included in an earlier version of ObservableList to account for performance issues. These have been resolved now so this option will be removed. From v5, CalcDiffSet will always be used")]
    public enum FilterPolicy
    {
        /// <summary>
        /// A full diff-set of adds, updates and removes will be calculated. Use this when objects are mutable.
        /// </summary>
        CalculateDiffSet,

        /// <summary>
        /// Clears the list and inserts batch of items matching the filter. Use this for much better performance
        /// </summary>
        ClearAndReplace
    }
}

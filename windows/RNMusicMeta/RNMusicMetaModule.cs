using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Music.Meta.RNMusicMeta
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNMusicMetaModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNMusicMetaModule"/>.
        /// </summary>
        internal RNMusicMetaModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNMusicMeta";
            }
        }
    }
}

using System;
using UnityEngine.UI;

namespace Texts
{
    [Serializable]
    public struct TextCollection
    {
        public string NameObject;
        public string NameScene;
        public Text PoleTxt;
        public ModeTxt ModeTxt;
        public string RusText;
        public string EngText;
    }
}
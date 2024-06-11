using System;
using UnityEngine;

namespace UI
{
    public class MenuExecutor : IMenuExecutor
    {
        public Action OnAudioClickl { get { return onAudioClickl; } set { onAudioClickl = value; } }
        private Action onAudioClickl;
        public Action OnButtonPanel { get { return onButtonPanel; } set { onButtonPanel = value; } }
        private Action onButtonPanel;
        public Action OnSettingsPanel { get { return onSettingsPanel; } set { onSettingsPanel = value; } }
        private Action onSettingsPanel;
        public Action OnInfoPanel { get { return onInfoPanel; } set { onInfoPanel = value; } }
        private Action onInfoPanel;
        public Action OnRezultPanel { get { return onRezultPanel; } set { onRezultPanel = value; } }
        private Action onRezultPanel;
        public Action OnButtonLvlPanel { get { return onButtonLvlPanel; } set { onButtonLvlPanel = value; } }
        private Action onButtonLvlPanel;
        public Action OnGndPanel { get { return onGndPanel; } set { onGndPanel = value; } }
        private Action onGndPanel;

        #region Panels
        public void ButtonPanel()
        {
            onButtonPanel?.Invoke();
        }
        public void SettingsPanel()
        {
            onSettingsPanel?.Invoke();
        }
        public void InfoPanel()
        {
            onInfoPanel?.Invoke();
        }
        public void RezultPanel()
        {
            onRezultPanel?.Invoke();
        }
        //
        public void ButtonLvlPanel()
        {
            onButtonLvlPanel?.Invoke();
        }
        public void GndPanel()
        {
            onGndPanel?.Invoke();
        }
        #endregion
        #region Sett
        public void AudioClick()
        {
            onAudioClickl?.Invoke();
        }
        #endregion

    }
}
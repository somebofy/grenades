using System;

namespace grenades
{
    public class grenades : Qurre.Plugin
    {
        public EventHandlers EventHandlers;
        #region override
        public override string Developer { get; } = "nekto";
        public override string Name { get; } = "grenades";
        public override System.Version Version { get; } = new System.Version(0, 0, 1);
        public override System.Version NeededQurreVersion { get; } = new System.Version(1, 3, 0);
        public override void Reload() => base.Reload();
        public override void Enable() => RegisterEvents();
        public override void Disable() => UnregisterEvents();
        #endregion


        #region RegEvents
        private void RegisterEvents()
        {

        }
        #endregion

        #region UnregEvents
        private void UnregisterEvents()
        {

        }
        #endregion
    }
}

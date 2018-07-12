using MSCLoader;
using UnityEngine;

namespace JonnezES
{
    public class JonnezES : Mod
    {
        public override string ID => "JonnezESPowerUp";
        public override string Name => "JonnezES";
        public override string Author => "Vikanen";
        public override string Version => "1.0";

        private GameObject MOPED;

        public override void OnLoad()
        {
            {
                this.MOPED = GameObject.Find("JONNEZ ES(Clone)");
                Drivetrain[] component = this.MOPED.GetComponents<Drivetrain>();
                for (int i = 0; i < component.Length; i++)
                {
                    Drivetrain playMakerFSM = component[i];
                    {
                        playMakerFSM.revLimiter = false;
                        playMakerFSM.maxPowerRPM = (13000);
                        playMakerFSM.maxTorque = (14);
                        playMakerFSM.powerMultiplier = (1.3f);
                        playMakerFSM.externalMultiplier = (0.7f);
                        playMakerFSM.clutchMaxTorque = (100);
                    }
                }
            }
        }
    }
}



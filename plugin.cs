using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Timeline;
using UnityEngine;
using BepInEx;
using UnityEngine.XR;
using Sirenix.OdinInspector;
using GorillaLocomotion;

namespace Joystick_Fly
{
    [BepInPlugin("Azora", "JoystickFly", "1.0.0")]
    public class JoystickFly : BaseUnityPlugin
    {

        void Start()
        {
            Vector3 zero = Vector3.zero;
            float yAxis = 0.5f; // wouldnt recommend messing with unless you know what your doing
            float xAxis = 0.5f; // wouldnt recommend messing with unless you know what your doing
            float speed = 10f;  // adjust to your liking
            deps.execute(speed, xAxis, yAxis, zero);
        }

    }
}

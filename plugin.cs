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
        Vector3 zero = Vector3.zero;
        void Start()
        {
            float yAxis = 0.5f; // wouldnt recommend messing with unless you know what your doing
            float xAxis = 0.5f; // wouldnt recommend messing with unless you know what your doing
            float speed = 10f;  // adjust to your liking
            if (GetPoller().rightControllerPrimary2DAxis.y > yAxis)
            {
                Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * speed;
                Player.Instance.GetComponent<Rigidbody>().velocity = zero;
            }
            if (GetPoller().rightControllerPrimary2DAxis.y < -yAxis)
            {
                Player.Instance.transform.position -= GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * speed;
                Player.Instance.GetComponent<Rigidbody>().velocity = zero;
            }
            if (GetPoller().rightControllerPrimary2DAxis.x > xAxis)
            {
                Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.right * Time.deltaTime * speed;
                Player.Instance.GetComponent<Rigidbody>().velocity = zero;
            }
            if (GetPoller().rightControllerPrimary2DAxis.x < -xAxis)
            {
                Player.Instance.transform.position -= GorillaLocomotion.Player.Instance.headCollider.transform.right * Time.deltaTime * speed;
                Player.Instance.GetComponent<Rigidbody>().velocity = zero;
            }
            Player.Instance.GetComponent<Rigidbody>().velocity = zero;
        }
        public static ControllerInputPoller GetPoller()
        {
            return ControllerInputPoller.instance;
        }

    }
}

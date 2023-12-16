using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using GorillaLocomotion;

namespace Joystick_Fly
{
    internal class deps : MonoBehaviour
    {
        public static void execute(float speed, float x, float y, Vector3 zero)
        {
            if (ControllerInputPoller.instance.rightControllerPrimary2DAxis.y > y)
            {
                Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * speed;
                Player.Instance.GetComponent<Rigidbody>().velocity = zero;
            }
            if (ControllerInputPoller.instance.rightControllerPrimary2DAxis.y < -y)
            {
                Player.Instance.transform.position -= GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * speed;
                Player.Instance.GetComponent<Rigidbody>().velocity = zero;
            }
            if (ControllerInputPoller.instance.rightControllerPrimary2DAxis.x > x)
            {
                Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.right * Time.deltaTime * speed;
                Player.Instance.GetComponent<Rigidbody>().velocity = zero;
            }
            if (ControllerInputPoller.instance.rightControllerPrimary2DAxis.x < -x)
            {
                Player.Instance.transform.position -= GorillaLocomotion.Player.Instance.headCollider.transform.right * Time.deltaTime * speed;
                Player.Instance.GetComponent<Rigidbody>().velocity = zero;
            }
            Player.Instance.GetComponent<Rigidbody>().velocity = zero;
        }

    }
}

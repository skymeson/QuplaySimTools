using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollPitchYaw : MonoBehaviour
{

        public float roll = 0.0f;
        public float pitch = 0.0f;
        public float yaw = 0.0f;

        public bool commit = false;

        protected void Update()
        {
            if (commit == true)
            {
                // roll
                transform.Rotate(0f, 0f, roll, Space.Self);

                // pitch
                transform.Rotate(pitch, 0f, 0f, Space.Self);

                // yaw
                transform.Rotate(0f, yaw, 0f, Space.Self);

                commit = false;
                roll = 0f;
                pitch = 0f;
                yaw = 0f;
            }
        }

        protected void OnGUI()
        {
            GUI.Label(new Rect(5, 5, 100, 25), "Roll  : " + roll);
            GUI.Label(new Rect(5, 25, 100, 25), "Pitch : " + pitch);
            GUI.Label(new Rect(5, 50, 100, 25), "Yaw  : " + yaw);
        }
    
}

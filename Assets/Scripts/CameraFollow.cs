using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   public Transform target;

   public float smoothSpeed = 0.125f; 
   public Vector3 offset;

   void LateUpdate()
   {
   		//transform.position = target.position + offset;
   		Vector3 desiredPosition = target.position + offset;
   		transform.position = desiredPosition;

   		//transform.LookAt(target);
   }
}

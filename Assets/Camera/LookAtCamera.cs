using UnityEngine;
using System.Collections;

public class LookAtCamera : MonoBehaviour {

    public GameObject target;

    //we need to tell our camera's transform to look at the target object. Thankfully, transform objects have a convenient LookAt()

    void LateUpdate()
    {
        transform.LookAt(target.transform);
    }
}

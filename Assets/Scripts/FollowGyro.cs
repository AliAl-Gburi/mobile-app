using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGyro : MonoBehaviour
{
    [Header("Tweaks")]
    [SerializeField] private Quaternion baseRotation = new Quaternion(0, 0, 1, 0);
    private float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        GyroManager.Instance.EnableGyro();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localRotation = GyroManager.Instance.GetGyroRotation() * baseRotation;
        Debug.Log(GyroManager.Instance.GetGyroRotation());
        transform.Translate(Vector3.left * speed * Time.deltaTime * -(GyroManager.Instance.GetGyroRotation().x));
    }
}

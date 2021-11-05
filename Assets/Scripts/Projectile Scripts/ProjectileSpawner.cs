using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ProjectileSpawner : MonoBehaviour
{

    // Properties
    public GameObject projectile;
    public Transform[] positions;
    private InputDevice leftController;
    private InputDevice rightController;

    // Start is called before the first frame update
    void Start()
    {
      // List<InputDevice> devices = new List<InputDevice>();
      // InputDevices.GetDevices(devices);
    }

    // Update is called once per frame
    void Update()
    {
        leftController.TryGetFeatureValue(CommonUsages.trigger, out float leftTriggerValue);
        rightController.TryGetFeatureValue(CommonUsages.trigger, out float rightTriggerValue);

        if(leftTriggerValue > .25f)
        {
          GameObject leftProjectile = Instantiate(projectile, positions[0]);
          leftProjectile.transform.localPosition = Vector3.zero;
          leftProjectile.transform.Translate(transform.forward);
        }
        else if(rightTriggerValue > .25f)
        {
          GameObject rightProjectile = Instantiate(projectile, positions[1]);
          rightProjectile.transform.localPosition = Vector3.zero;
          rightProjectile.transform.Translate(transform.forward);
        }
    }
}
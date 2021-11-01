using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
  public GameObject[] myObjects;
  public Transform[] positions; // array of available spawn points (empty gameObjects)
  public float beat = (60/105);
  private float timer; // in between spawn of new GameObject

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

      int randomObjectIndex = Random.Range(0,myObjects.Length); // picking a random index from the array of gameObjects
      int randomPosition = Random.Range(0, positions.Length); // picking a random position to spawn the object

      if(timer>beat)
      {
        GameObject randomObject = Instantiate(myObjects[randomObjectIndex], positions[randomPosition]); // instantiating the random object at one of the 3 positions
        randomObject.transform.localPosition = Vector3.zero;
        randomObject.transform.Translate(transform.forward);
        timer -= beat;
      }

      timer += Time.deltaTime;
  }
}

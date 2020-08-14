using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject _ball;

    private float spawnSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnBall(spawnSpeed));
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private IEnumerator spawnBall(float spawnSpeed) {
        while (true) {
            
            GameObject newBall = Instantiate(_ball, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
            yield return new WaitForSeconds(spawnSpeed);    
        }
    }
}

using System.Collections;
using UnityEngine;

//Posibly make the player the thing that enemys spawn around
public class Spawner : MonoBehaviour
{

    public GameObject[] ennemies;
    //holding the value of the area that the enerys can be spawned in
    public Vector3 spawnValues;
    public float spawnWait;
    //holding the value of the spawn longest and least amount of tame that can happen between spawns
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;

    int randEnemy;

    void Start()
    {
        StartCoroutine(waitSpawner());
    }

    void Update()
    {
        //haveing the wait be randomly chosen from the range of values added in the inspector
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }
    //starting a Coroutine to be able to use "wait for seconds"
    IEnumerator waitSpawner()
    {
        //waiting a amount of time before starting the code that is below it.
        yield return new WaitForSeconds(startWait);

        //while stopt is tot true the Coroutine will run
        while (!stop)
        {
            //the range of enemys is 2 (with 0 and 1 )
            randEnemy = Random.Range(0, 2);

            //picking ta random value from the x and z axis to spwn the enemy
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));
           
            //spawning a instatn  object of a random enemy at a transfompoint
            Instantiate(ennemies[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            //haveing the spawn wait be a random time
            yield return new WaitForSeconds(spawnWait);
        }
    }
}

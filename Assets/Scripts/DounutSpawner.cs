using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DounutSpawner : MonoBehaviour {
	public GameObject[] dounutPrefab;
	public float timeInterval = 1f;
	float minX, maxX;
	private Transform SpawnPos;


	// Use this for initialization
	void Start () {
		SpawnPos=GetComponent<Transform>();
	}

	public void PrepDount(bool status)
	{

		if(status)
		{
			StartCoroutine(Generate());
		}
		else
		{
			StopAllCoroutines();
		}
	}
    IEnumerator Generate()
    {
        while (true)
        {
            minX = SpawnPos.position.x - 15;
            maxX = SpawnPos.position.x + 15;
            var cipars = Random.Range(minX, maxX);
            var pos = new Vector2(cipars, transform.position.y);
            GameObject dounut = Instantiate(dounutPrefab[Random.Range(0, dounutPrefab.Length)], pos, Quaternion.identity, SpawnPos);
            yield return new WaitForSeconds(timeInterval);
        }
    }

}

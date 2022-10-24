using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    private float _interval = 2f;

    private void Start()
    {
        StartCoroutine(SpawnEnemy(_interval, _template));
    }

    private IEnumerator SpawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-8f, 8f), Random.Range(-4f, 4f),0), Quaternion.identity);
        StartCoroutine(SpawnEnemy(interval, enemy));
    }
}

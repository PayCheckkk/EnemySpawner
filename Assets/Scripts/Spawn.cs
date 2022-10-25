using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject _template;

    private float _cameraLeftBorder = -8;
    private float _cameraRightBorder = 8;
    private float _cameraTopBorder = 4;
    private float _cameraBottomBorder = -4;
    private float _interval = 2f;

    private void Start()
    {
        StartCoroutine(SpawnEnemy(_interval, _template));
    }

    private IEnumerator SpawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(_cameraLeftBorder, _cameraRightBorder), Random.Range(_cameraBottomBorder, _cameraTopBorder),0), Quaternion.identity);
        StartCoroutine(SpawnEnemy(interval, enemy));
    }
}

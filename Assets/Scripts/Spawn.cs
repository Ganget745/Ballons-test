using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject spawnObj;
    public Vector3 spawnValues;
    public int spawnCount;
    public float spawnWhait;
    public float waweWhait;
    public int counter;
    public SetScore ScoreText;

  
    private void Start()
    {
        StartCoroutine (spawnBallons());

    }

    IEnumerator spawnBallons()
    {
        while (true)
        {
            for (int k = 0; k < spawnCount; k++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                GameObject spawnBallon = Instantiate(spawnObj, spawnPosition, spawnRotation);
                spawnBallon.GetComponent<DestroyByClick>().Spawner = this;
                yield return new WaitForSeconds(Random.Range(0.5f, spawnWhait));
            }
            yield return new WaitForSeconds(waweWhait);

        }
    }

    public void UpdateScore(int score)
    {
        counter += score;
        ScoreText.SetScoreText(counter);
    }

}

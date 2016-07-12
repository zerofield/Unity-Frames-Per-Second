using UnityEngine;
using System.Collections;

public class StuffSpawnerRing : MonoBehaviour
{
    public int numberOfSpawners;

    public float radius, tiltAngle;

    public StuffSpawner spawnerPrefab;
    public Material[] stuffMaterials;

    void Awake()
    {
        for (int i = 0; i < numberOfSpawners; ++i)
        {
            CreateSpawner(i);
        }
    }

    void CreateSpawner(int i)
    {
        Transform rotater = new GameObject("Rotater").transform;
        rotater.SetParent(transform, false);

        rotater.localRotation = Quaternion.Euler(0, i * 360f / numberOfSpawners, 0);

        StuffSpawner spawner = Instantiate<StuffSpawner>(spawnerPrefab);
        spawner.transform.SetParent(rotater, false);
        spawner.transform.localPosition = new Vector3(0, 0, radius);
        spawner.transform.localRotation = Quaternion.Euler(tiltAngle, 0, 0);
        spawner.stuffMaterial = stuffMaterials[i % stuffMaterials.Length];
    }

}

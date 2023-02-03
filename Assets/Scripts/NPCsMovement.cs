using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCsMovement : MonoBehaviour
{
    [SerializeField] List<GameObject> monsters;
    List<float> positions = new List<float> { -1f, -4f, -7f };
    float posY = 3f;
    float posZ = 0f;

    public void MoveMonsters()
    {
        List<int> tmpMonsters = new List<int> { };

        for (int posIndex = 0; posIndex < positions.Count; posIndex++)
        {
            int index = Random.Range(0, monsters.Count);
            while (tmpMonsters.Contains(index))
            {
                index = Random.Range(0, monsters.Count);
            }

            tmpMonsters.Add(index);
            var monster = monsters[index];
            monster.transform.position = new Vector3(positions[posIndex], posY, posZ);
        }
    }
}

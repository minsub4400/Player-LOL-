using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    // ###############################################
    //             NAME : Simstealer                      
    //             MAIL : minsub4400@gmail.com         
    // ###############################################

    public NavMeshAgent navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ������ ���콺�� Ŭ�� �Ǿ��� ��,
        if (Input.GetMouseButtonDown(0))
        {
            // ī�޶��� ���콺 ��ġ���� Ray�� ���
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                navMeshAgent.SetDestination(new Vector3(hit.point.x, transform.position.y, hit.point.z));
            }
        }
    }
}

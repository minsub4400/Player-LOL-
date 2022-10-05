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
        // 오른쪽 마우스가 클릭 되었을 떄,
        if (Input.GetMouseButtonDown(0))
        {
            // 카메라의 마우스 위치부터 Ray를 사용
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                navMeshAgent.SetDestination(new Vector3(hit.point.x, transform.position.y, hit.point.z));
            }
        }
    }
}

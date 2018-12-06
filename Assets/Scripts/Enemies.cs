using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rig;
    [SerializeField] private float speed;
    [SerializeField] private float posMax = 3.5f;
    [SerializeField] private float posMin = -1f;

    private bool call1=true;
    enum Enemy
    {
        GO_UP,
        GO_DOWN,
        DIE,
    }
    private Enemy enemy;

    void Start()
    {
        enemy = Enemy.GO_UP;
    }


    void Update()
    {
        switch (enemy)
        {
            case Enemy.GO_UP:
                GoUp();
                break;
            case Enemy.GO_DOWN:
                GoDown();
                break;
            case Enemy.DIE:

                break;
        }
    }

    public void GoUp()
    {       
        if (gameObject.transform.position.y>=posMax)
        {
            enemy = Enemy.GO_DOWN;
        }
            rig.velocity=new Vector2(0,speed);

    }

    public void GoDown()
    {
        if (gameObject.transform.position.y <= posMin)
        {
            enemy = Enemy.GO_UP;
        }
        rig.velocity = new Vector2(0, -speed);
    }






    /*
        [SerializeField] private Transform[] waypoints;

        [SerializeField] private float moveSpeed = 2f;

        private int waypointIndex = 0;

        void Start()
        {
            transform.position = waypoints[waypointIndex].transform.position;
        }

        void Update()
        {
            Move();
        }

        void Move()
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position,
                moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }

            if (waypointIndex == waypoints.Length)
            {
                waypointIndex = 0;
            }
        }*/
    /*
        private Transform target;
        private int wavepointIndex = 0;
        public float speed = 10f;



        // Use this for initialization
        void Start ()
        {
            target = WayPoint.wayPoints[0];
        }

        // Update is called once per frame
        void Update ()
        {
            Vector3 direction = target.position - transform.position;
            transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

            if (Vector2.Distance(transform.position, target.position) <= 0.1f) //la distance des waypoints pour envoyer l'ennemie au prochain waypoints
            {
                GoNextWayPoint();
            }
        }

        void GoNextWayPoint()
        {
            if (wavepointIndex >= WayPoint.wayPoints.Length - 1) //si il arrive au dernier, il se détruit
            {
                wavepointIndex = 0;
                return;
            }
            wavepointIndex++;
            transform.position = target.position;               //remet l'ennemie sur waypoint pour pas qu'il parte en diagonale
            target = WayPoint.wayPoints[wavepointIndex];
        }*/

}

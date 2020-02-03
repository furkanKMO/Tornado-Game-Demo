using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firtina : MonoBehaviour
{
    [Header("Defining Ball Qualifications")]
    [SerializeField]
    private float _speed = 5f;
    public static bool carturn = false;
    //[Header("Ball Boundaries")]
    //[SerializeField]
    //private float wallDistance = 8.4f;
    //[SerializeField]
    //private float turnedwallDistancenear = 120f;
    //[SerializeField]
    //private float turnedwallDistancefar = 156f;
    //[SerializeField]
    //private float minCamDistance = 3f;

    private Rigidbody _rb;

    private Vector3 _lastTouchPos;
    private Vector3 _deltaPos;
    // Start is called before the first frame update
    void Start()
    {
        Input.multiTouchEnabled = false;
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (start.MoveAllowed)
        {
            _rb.WakeUp();
            BallMovement();
        }
        else
        {
            _rb.Sleep();
        }
    }


   

    private void BallMovement()
    {
        if (Input.GetMouseButton(0))
        {
            if (!carturn)
            {
                Vector3 currentPos = Input.mousePosition;
                if (_lastTouchPos == Vector3.zero)
                    _lastTouchPos = currentPos;
                _deltaPos = currentPos - _lastTouchPos;
                _lastTouchPos = currentPos;
                Vector3 force = new Vector3(_deltaPos.x, 0, _deltaPos.y) * _speed;
                _rb.AddForce(force);
                
            }
            if (carturn)
            {
                Vector3 currentPos = Input.mousePosition;
                if (_lastTouchPos == Vector3.zero)
                    _lastTouchPos = currentPos;
                _deltaPos = currentPos - _lastTouchPos;
                _lastTouchPos = currentPos;
                Vector3 force = new Vector3(-_deltaPos.y, 0, _deltaPos.x) * _speed;
                _rb.AddForce(force);

            }
        }
        else
            _lastTouchPos = Vector2.zero;
    }



}



//Another control mechanic for testing

//{
//    public static bool carturn = false;
//    private Touch touch1;
//    private Vector2 begintouch, endtouch;
//    private bool isMoveAllowed = true;
//    private Vector2 lastMousePosition;
//    private Vector3 startPosition, lastloc;
//    public int speed = 20;
//    public float maxSpeed = 1f;
////    public GameObject car;

//    private void Start()
//    {
//        Input.multiTouchEnabled = false;
//        startPosition = transform.position;
//    }




//    private void FixedUpdate()
//    {
//        if (start.MoveAllowed)
//        {


//            //float dist = Vector3.Distance(car.transform.position, transform.position);
//            //if (dist > 40 && dist < 41)
//            //{
//            //    lastloc = this.transform.position;
//            //}

//            //if (dist > 45)
//            //{
//            //    this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

//            //    this.transform.position = lastloc;

//            //    Debug.Log(lastloc);
//            //}

//            if (Input.GetMouseButton(0))
//            {
//                Vector2 currentMousePosition = Input.mousePosition;

//                if (lastMousePosition == Vector2.zero)
//                    lastMousePosition = currentMousePosition;

//                Vector2 deltaPosition = currentMousePosition - lastMousePosition;
//                lastMousePosition = currentMousePosition;
//                if (deltaPosition.x > 10f)
//                {
//                    deltaPosition.x = 9f;
//                }
//                if (deltaPosition.y > 10f)
//                {
//                    deltaPosition.y = 9f;
//                }
//                if (deltaPosition.x < -10f)
//                {
//                    deltaPosition.x = -9f;
//                }
//                if (deltaPosition.y < -10f)
//                {
//                    deltaPosition.y = -9f;
//                }
//                if (carturn)
//                {
//                    Vector3 force = new Vector3(-deltaPosition.y, 0, deltaPosition.x) * speed;
//                    this.gameObject.GetComponent<Rigidbody>().AddForce(force);
//                }
//                if (!carturn)
//                {

//                    Vector3 force = new Vector3(deltaPosition.x, 0, deltaPosition.y) * speed;
//                    this.gameObject.GetComponent<Rigidbody>().AddForce(force);
//                }





//            }
//            else
//                lastMousePosition = Vector2.zero;
//        }








//    }
//}

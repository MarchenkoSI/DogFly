using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playermove : MonoBehaviour
{
    private float deltaX, deltaY;
    public GameObject apple;
    private Rigidbody2D rb;
    public string objname;
    private int score = 0;
    public Text scoretxt;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {        
        Move();        
    }
    
    private void Move()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            deltaY = transform.position.y;
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    deltaX = touchPos.x - transform.position.x;
                    break;

                case TouchPhase.Moved:
                    rb.MovePosition(new Vector2(touchPos.x - deltaX, deltaY));
                    break;

                case TouchPhase.Ended:
                    rb.velocity = Vector2.zero;
                    break;
            }            
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        objname = col.gameObject.name;
        objname = objname.Substring(0, 5);
        if (objname == "tunde")
        {
            SceneManager.LoadScene(2);
        }
        if (objname == "apple")
        {
            score = score + 1;
            PlayerStats.finalscore = scoretxt.text = score.ToString();
            float x = Random.Range(-2.0f, 2.0f);
            Instantiate(apple, new Vector3(x, 6, -0.5f), Quaternion.identity);
            Destroy(col.gameObject);
        }
    }
}

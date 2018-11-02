using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glowingBookLockScr : MonoBehaviour {
    public GameObject book;
    public GameObject door;

    private Vector3 book_pos;
    private bool locked;

    // Use this for initialization
    void Start () {
        book_pos = book.transform.position;
        locked = true;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Vector3.Distance(book_pos, book.transform.position));
		if(locked && Vector3.Distance(book_pos, book.transform.position) >= 1)
        {
            unlock();
        }
	}
    
    void unlock()
    {
        Destroy(door);
        Destroy(gameObject);
    }
}
using UnityEngine;
using System.Collections;

public class Collectibles : MonoBehaviour {
    public float speed = 10f;
    public AudioClip suaranya;
    //public PengaturGame pg;
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider target)
    { 
        if (target.gameObject.tag == "Player")
        { 
            //pg.Bunyikan(suaranya);
            GameObject.Find("ObjPG").GetComponent<PengaturGame>().Bunyikan(suaranya);
            GameObject.Find("ObjPG").GetComponent<PengaturGame>().TambahSkor(10);
            Destroy(gameObject); //hancurkan diri sendiri tsb
        }
    }
}

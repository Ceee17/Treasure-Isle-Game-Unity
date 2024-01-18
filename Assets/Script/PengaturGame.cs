using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PengaturGame : MonoBehaviour
{
    public TextMeshProUGUI teks_skor;
    public static int skorSkrg = 0;

    void Start()
    {
        ResetScore();
    }

    public void TambahSkor(int skornya)
    {
        skorSkrg += skornya;
        teks_skor.text = skorSkrg.ToString();
    }

    public int CalculateScore()
    {
        return skorSkrg;
    }

    public void ResetScore()
    {
        skorSkrg = 0;
        teks_skor.text = skorSkrg.ToString();
    }

    public void Bunyikan(AudioClip suara)
    {
        GetComponent<AudioSource>().PlayOneShot(suara, 1F);
    }
}

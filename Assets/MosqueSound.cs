using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MosqueSound : MonoBehaviour
{
    public Transform player; // ãÊÛíÑ áÊÍÏíÏ ãæŞÚ ÇááÇÚÈ
    public Transform mosque; // ãÊÛíÑ áÊÍÏíÏ ãæŞÚ ÇáãÓÌÏ
    public AudioSource audioSource; // ãÊÛíÑ áãÕÏÑ ÇáÕæÊ

    public float maxDistance = 10f; // ÇáãÓÇİÉ ÇáŞÕæì ááÕæÊ
    public float minDistance = 1f; // ÇáãÓÇİÉ ÇáÏäíÇ ááÕæÊ

    private void Update()
    {
        // ÍÓÇÈ ÇáãÓÇİÉ Èíä ÇááÇÚÈ æÇáãÓÌÏ
        float distance = Vector3.Distance(player.position, mosque.position);

        // ÊÍÏíÏ ŞæÉ ÇáÕæÊ ÈäÇÁğ Úáì ÇáãÓÇİÉ
        float volume = Mathf.Lerp(0f, 1f, (maxDistance - distance) / (maxDistance - minDistance));

        // ÊÍÏíË ŞæÉ ÇáÕæÊ İí ãÕÏÑ ÇáÕæÊ
        audioSource.volume = volume;
    }
}

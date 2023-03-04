using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.VR;
using Photon.VR.Cosmetics;
public class ChangeCosmetic : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TopHat"))
        {
            PhotonVRManager.SetCosmetic(CosmeticType.Head, "VRTopHat");
        }
        if (other.gameObject.CompareTag("NoHat"))
        {
            PhotonVRManager.SetCosmetic(CosmeticType.Head, "");
        }
                if (other.gameObject.CompareTag("Hammer"))
        {
            PhotonVRManager.SetCosmetic(CosmeticType.RightHand, "Hammer");
        }
        if (other.gameObject.CompareTag("NoRightHand"))
        {
            PhotonVRManager.SetCosmetic(CosmeticType.RightHand, "");
        }
    }
}
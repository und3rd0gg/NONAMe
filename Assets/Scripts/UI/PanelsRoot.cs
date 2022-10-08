using Dythervin.AutoAttach;
using UnityEngine;

namespace NONAMe.UI
{
    public class PanelsRoot : MonoBehaviour
    {
        [SerializeField] [Attach(Attach.Child)]
        private Panel[] _panels;
    }
}

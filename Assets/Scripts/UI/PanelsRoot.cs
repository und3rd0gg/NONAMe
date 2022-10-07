using Dythervin.AutoAttach;
using UnityEngine;

namespace UI
{
    public class PanelsRoot : MonoBehaviour
    {
        [SerializeField] [Attach(Attach.Child)]
        private Panel[] _panels;
    }
}

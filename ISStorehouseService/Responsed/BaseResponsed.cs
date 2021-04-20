using System.Runtime.Serialization;

namespace ISStorehouseService.Responsed
{
    [DataContract()]
    public class BaseResponsed
    {
        private string _ErrorMessage;

        [DataMember()]
        public string ErrorMessage
        {
            get
            {
                return _ErrorMessage;
            }

            set
            {
                _ErrorMessage = value;
            }
        }
    }
}

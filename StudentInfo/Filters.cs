using System.Runtime.Serialization;

namespace StudentInfo
{
    [DataContract]
    public class Filters
    {
        [DataMember]
        public string StudentCity
        {
            get;
            set;
        }

        [DataMember]
        public string StudentSurname
        {
            get;
            set;
        }
    }
}
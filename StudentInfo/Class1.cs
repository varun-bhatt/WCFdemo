using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace StudentInfo
{
    [DataContract]
    public class Student1
    {
       
        [DataMember]
        public int StudentId
        {
            get;
            set;
        }

        [DataMember]
        public string StudentName
        {
            get;
            set;
        }

        [DataMember]
        public string Number
        {
            get;
            set;
        }

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
